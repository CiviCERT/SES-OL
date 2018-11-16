using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.IO;
using System.Web.Script.Serialization;
using System.Net;

namespace SES_OL
{
    public partial class ThisAddIn
    {
        private static Regex mailtoRx = new Regex("^mailto:", 
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see https://go.microsoft.com/fwlink/?LinkId=506785
        }

        public Dictionary<string, string> ConfigureSES()
        {
            var vals = new Dictionary<string, string>();
            using (var dlg = new ConfigWindow())
            {
                var filename = GetConfigFilename();
                if (!File.Exists(filename))
                {
                    vals["name"] = "Unknown";
                    vals["serverUrl"] = "mailto:someone@example.com";
                    vals["authToken"] = "";
                }
                else
                {
                    vals = LoadConfig();
                }

                dlg.SiteName = vals["name"];
                if (mailtoRx.IsMatch(vals["serverUrl"]))
                {
                    dlg.Method = 0;
                    dlg.Destination = vals["serverUrl"].Substring(7);
                } else
                {
                    dlg.Method = 1;
                    dlg.Destination = vals["serverUrl"].Substring(8);
                }
                dlg.AuthToken = vals["authToken"];

                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return null;
                var via = dlg.Method == 0 ? "mailto:" : "https://";
                vals["name"] = dlg.SiteName;
                vals["serverUrl"] = via + dlg.Destination;
                vals["authToken"] = dlg.AuthToken;
            }
            using (var handle = File.CreateText(GetConfigFilename()))
            {
                handle.WriteLine(string.Format(@"{{
    ""name"": ""{0}"",
    ""serverUrl"": ""{1}"",
    ""authToken"": ""{2}""
}}", vals["name"], vals["serverUrl"], vals["authToken"]));
            }
            return vals;
        }

        public string GetConfigFilename()
        {
            var appdirid = Environment.SpecialFolder.ApplicationData;
            var appdir = Environment.GetFolderPath(appdirid);
            string dirname = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Suspicious Email Submitter");
            if (!Directory.Exists(dirname))
            {
                Directory.CreateDirectory(dirname);
            }
            return Path.Combine(dirname, "config.json");
        }

        public Dictionary<string, string> LoadConfig()
        {
            var rv = new Dictionary<string, string>();
            var filename = GetConfigFilename();
            if (!File.Exists(filename))
            {
                if (null == ConfigureSES())
                    return null;
            }
            using (var handle = File.OpenText(GetConfigFilename()))
            {
                var contents = handle.ReadToEnd();
                var jsonReader = new JavaScriptSerializer();
                dynamic obj = jsonReader.DeserializeObject(contents);
                rv["name"] = obj["name"];
                rv["serverUrl"] = obj["serverUrl"];
                rv["authToken"] = obj["authToken"];
                return rv;
            }
        }

        public void ForwardMails()
        {
            Dictionary<string, string> config = null;
            var mailItems = new List<Outlook.MailItem>();
            config = LoadConfig();
            System.Windows.Forms.MessageBox.Show("Selected: " + Globals.ThisAddIn.Application.ActiveExplorer().Selection.Count.ToString());
            foreach (var obj in Globals.ThisAddIn.Application.ActiveExplorer().Selection)
            {
                var mail = obj as Outlook.MailItem;
                if (null != mail)
                {
                    mailItems.Add(mail);
                }
            }
            System.Windows.Forms.MessageBox.Show("Count: " + mailItems.Count.ToString());

            if (config == null && mailItems.Count > 0)
            {
                System.Windows.Forms.MessageBox.Show("SES needs to be configured.");
                return;
            }

            var shouldMail = mailtoRx.IsMatch(config["serverUrl"]);
            var dest = config["serverUrl"].Substring(shouldMail ? 7 : 8); 
            foreach (var email in mailItems)
            {
                if (shouldMail)
                {
                    SendViaEmail(dest, email);
                }
                else
                {
                    SendViaWeb(dest, email, config["authToken"]);
                }
            }
            System.Windows.Forms.MessageBox.Show("Forwarded " + mailItems.Count.ToString() + " items.");
        }

        private void SendViaEmail(string dest, Outlook.MailItem email)
        {
            Outlook.MailItem newMail = Application.CreateItem(Outlook.OlItemType.olMailItem) as Outlook.MailItem;
            newMail = email.Forward();
            newMail.Recipients.Add(dest);
            newMail.Send();
        }

        private void SendViaWeb(string dest, Outlook.MailItem email, string token)
        {
            var tmpfilename = Path.GetTempFileName();
            var finfo = new FileInfo(tmpfilename);
            finfo.Attributes = FileAttributes.Temporary;
            var sb = new StringBuilder();

            sb.Append(@"{
    'Event': {
        'info': 'Suspicious Email Submitter',
		'distribution': 0,
		'threat_level_id': 3,
		'analysis': 1,
		'Object': [
            {
			    'name': 'email',
                'meta-category': 'network',
                'description': 'Email object describing an email with meta-information',
                'template_uuid': 'a0c666e0-fc65-4be8-b48f-3423d788b552',
                'template_version': 10,
                'Attribute': [
                    {
                        'category': 'Payload delivery',
                        'type': 'attachment',
                        'object_relation': 'eml',
                        'value': 'Raw Email',
                        'data': '");
            
            email.SaveAs(tmpfilename, Outlook.OlSaveAsType.olMSGUnicode);
            finfo = new FileInfo(tmpfilename);

            var bytes = new byte[Convert.ToInt32(finfo.Length & 0x7fffffff)];
            using (var handle = File.Open(tmpfilename, FileMode.Open))
            {
                handle.Read(bytes, 0, Convert.ToInt32(finfo.Length & 0x7FFFFFFF));
            }
            File.Delete(tmpfilename);

            sb.Append(Convert.ToBase64String(bytes));
            sb.Append(@"'
                    }
                ]
           }
       ]
    }
}");
            HttpWebRequest rq = (HttpWebRequest)WebRequest.Create(dest);
            rq.Headers.Add("Accept:application/json");
            rq.Headers.Add("Content-Type:application/json");
            rq.Headers.Add("Authorization:" + token);
            using (var s = new StreamWriter(rq.GetRequestStream()))
            {
                s.WriteLine(sb.ToString());
            }
        }


        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}

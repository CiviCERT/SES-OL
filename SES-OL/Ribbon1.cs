using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace SES_OL
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.ForwardMails();
        }

        private void configSES_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.ConfigureSES();
        }
    }
}

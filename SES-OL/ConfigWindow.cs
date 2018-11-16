using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace SES_OL
{
    public partial class ConfigWindow : Form
    {
        private static Regex mailtoRx = new Regex("^mailto:",
            RegexOptions.Compiled | RegexOptions.IgnoreCase);
        private static Regex httpsRx = new Regex("^http(s)?://");

        public ConfigWindow()
        {
            InitializeComponent();
            Validate();
        }

        private void validate()
        {
            if (SiteName.Length > 0 &&
                Destination.Length > 0 &&
                (! mailtoRx.IsMatch(Destination)) &&
                (! httpsRx.IsMatch(Destination)))
            {
                okButton.Enabled = true;
            }
            else
            {
                okButton.Enabled = false;
            }
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            validate();
        }

        private void toBox_TextChanged(object sender, EventArgs e)
        {
            validate();
        }

        private void authTokenBox_TextChanged(object sender, EventArgs e)
        {
            validate();
        }
    }
}

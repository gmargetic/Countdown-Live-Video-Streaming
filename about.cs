using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Countdown
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://paypal.me/margetic");
        }

        private void linkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.goranmargetic.com");
        }

        private void about_Load(object sender, EventArgs e)
        {
            var versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);
            lblVersion.Text = "Version " + versionInfo.ProductVersion;
            lblTitle.Text = versionInfo.InternalName;
            lblCopy.Text = versionInfo.LegalCopyright;
            lblCompany.Text = versionInfo.CompanyName;

            this.Text = "About " + versionInfo.InternalName;
        }
    }
}

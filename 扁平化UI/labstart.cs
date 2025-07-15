using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSTSCLib;

namespace 扁平化UI
{
    public partial class labstart : Form
    {
        public labstart()
        {
            InitializeComponent();
        }

        private void labstart_Load(object sender, EventArgs e)
        {
            this.remotescreen.UserName = "ASUS";
            this.remotescreen.Server = "10.37.65.236";
            this.remotescreen.AdvancedSettings2.RDPPort = 3389;
            this.remotescreen.AdvancedSettings2.SmartSizing = true;
            this.remotescreen.AdvancedSettings9.NegotiateSecurityLayer = true;
            this.remotescreen.AdvancedSettings7.EnableCredSspSupport = true;
            IMsTscNonScriptable securd = (IMsTscNonScriptable)this.remotescreen.GetOcx();
            securd.ClearTextPassword = "hwj";
            this.remotescreen.AdvancedSettings5.ClearTextPassword = "hwj";
            this.remotescreen.ColorDepth = 32;
            this.remotescreen.Connect();
        }

        private void remotescreen_OnConnecting(object sender, EventArgs e)
        {

        }
    }
}

using CefSharp;
using CefSharp.WinForms;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Win32;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 扁平化UI
{
    
    public partial class camera : Form
    {
        public camera()
        {
            InitializeComponent();
            SetBrowserEmulationMode();
        }
        // 静态类用于存储全局变量
       
        private void camera_Load(object sender, EventArgs e)
        {
           
        }
        private void SetBrowserEmulationMode()
        {
            string appName = System.IO.Path.GetFileName(Application.ExecutablePath);
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION"))
            {
                key.SetValue(appName, 11001, RegistryValueKind.DWord); // 设置为 IE11 模式
            }
        }

        private void btn_cameraconnect_Click(object sender, EventArgs e)
        {
            string ipAddress = ip_textbox.Text.Trim();

            if (string.IsNullOrEmpty(ipAddress))
            {
                MessageBox.Show("请输入有效的 IP 地址！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ipAddress.StartsWith("http://") && !ipAddress.StartsWith("https://"))
            {
                ipAddress = "http://" + ipAddress; // 默认添加 http://
            }


            Form popupForm = new Form
            {
                Text = "实验摄像头",
                Width = 1000,
                Height = 800,
                StartPosition = FormStartPosition.CenterScreen // 窗体居中显示
            };

            // 创建 WebView2 控件
            var webView = new Microsoft.Web.WebView2.WinForms.WebView2
            {
                Dock = DockStyle.Fill // 填

                // 充整个窗体
            };

            // 初始化 WebView2 控件
            webView.Source = new Uri(ipAddress);

            // 将 WebView2 添加到新窗体
            popupForm.Controls.Add(webView);

            // 显示新窗体
            popupForm.Show(); // 模态弹窗（阻塞当前窗体）
        }
    }
    public static class GlobalData
    {
        // 定义静态变量（可被所有窗体访问）
        public static string ipaddress { get; set; } = "";
    }
}

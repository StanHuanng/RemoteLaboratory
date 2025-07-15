using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Sockets;

namespace 扁平化UI
{
    public partial class 实验主页 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
       int nLeftRect,     // 左上角x坐标
       int nTopRect,      // 左上角y坐标
       int nRightRect,    // 右下角x坐标
       int nBottomRect,   // 右下角y坐标
       int nWidthEllipse, // 圆角椭圆宽度
       int nHeightEllipse // 圆角椭圆高度
   );

        public 实验主页()
        {
            InitializeComponent();
            
            pnlNav.Height = btnclient.Height;
            pnlNav.Top = btnclient.Top;
            pnlNav.Left = btnclient.Left;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!screen.Controls.Contains(client))
            {
                client.TopLevel = false;
                screen.Controls.Add(client);
                client.Show();
                client.BringToFront();

            }
            else
                client.BringToFront();
        
        }

        private void btnlabsource_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnlabstart.Height;
            pnlNav.Top = btnlabstart.Top;
            pnlNav.Left = btnlabstart.Left;
            btnlabstart.BackColor = Color.FromArgb(46, 51, 73);
            if(!screen.Controls.Contains(labstart))
            {
                labstart.TopLevel = false;
                screen.Controls.Add(labstart);
                labstart.Show();
                labstart.BringToFront();

            }
            else
                labstart.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btncamera.Height;
            pnlNav.Top = btncamera.Top;
            pnlNav.Left = btncamera.Left;
            btncamera.BackColor = Color.FromArgb(46, 51, 73);
            if (!screen.Controls.Contains(camera))
            {
                camera.TopLevel = false;
                screen.Controls.Add(camera);
                camera.Show();
                camera.BringToFront();

            }
            else
                camera.BringToFront();
        }

        private void btnlabsource_Click_1(object sender, EventArgs e)
        {
            pnlNav.Height = btnlabsource.Height;
            pnlNav.Top = btnlabsource.Top;
            pnlNav.Left = btnlabsource.Left;
            btnlabsource.BackColor = Color.FromArgb(46, 51, 73);
            if (!screen.Controls.Contains(labsource))
            {
                labsource.TopLevel = false;
                screen.Controls.Add(labsource);
                labsource.Show();
                labsource.BringToFront();

            }
            else
                labsource.BringToFront();
        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnclient.Height;
            pnlNav.Top = btnclient.Top;
            pnlNav.Left = btnclient.Left;
            btnclient.BackColor = Color.FromArgb(46, 51, 73);
            if (!screen.Controls.Contains(client))
            {
                client.TopLevel = false;
                screen.Controls.Add(client);
                client.Show();
                client.BringToFront();

            }
            else
                client.BringToFront();
        }

        private void btnlabstart_Leave(object sender, EventArgs e)
        {
            btnlabstart.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btncamera_Leave(object sender, EventArgs e)
        {
            btncamera.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnlabsource_Leave(object sender, EventArgs e)
        {
            btnlabsource.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnclient_Leave(object sender, EventArgs e)
        {
            btnclient.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnsetting.Height;
            pnlNav.Top = btnsetting.Top;
            pnlNav.Left = btnsetting.Left;
            btnsetting.BackColor = Color.FromArgb(46, 51, 73);
            if (!screen.Controls.Contains(setting))
            {
                setting.TopLevel = false;
                screen.Controls.Add(setting);
                setting.Show();
                setting.BringToFront();

            }
            else
                setting.BringToFront();
        }

        private void btnsetting_Leave(object sender, EventArgs e)
        {
            btnsetting.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "确定要关闭程序吗？",
                "确认关闭",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        client client = new client();
        labstart labstart = new labstart();
        labsource labsource = new labsource();  
        camera camera = new camera();   
        setting setting = new setting();

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

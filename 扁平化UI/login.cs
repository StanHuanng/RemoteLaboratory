using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace 扁平化UI
{
    
    public partial class 登录界面 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,     // 左上角x坐标
            int nTopRect,      // 左上角y坐标
            int nRightRect,    // 右下角x坐标
            int nBottomRect,   // 右下角y坐标
            int nWidthEllipse, // 圆角椭圆宽度
            int nHeightEllipse  // 圆角椭圆高度
        );
        public static string identity { get; set; } = "";

        public 登录界面()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            identity = Account.Text;

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = this.Account.Text;
            string passwrd = this.Password.Text;

  

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(passwrd))
                {
                    MessageBox.Show("账号或密码不能为空！");
                    return;
                }

                string connStr = "server=localhost;port=3306;user=root;password=123456;database=labuser;";
                string sql = "SELECT COUNT(*) FROM login WHERE account=@account AND password=@password";

                try
                {
                    using (var conn = new MySqlConnection(connStr))
                    {
                        conn.Open();
                        using (var cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@account", username);
                            cmd.Parameters.AddWithValue("@password", passwrd);
                            int count = Convert.ToInt32(cmd.ExecuteScalar());
                            if (count > 0)
                            {
                                MessageBox.Show("登录成功！");
                                实验主页 mainForm = new 实验主页();
                                mainForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("账号或密码错误！");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("连接数据库失败：" + ex.Message);
                }
           

        }

       
    }
}

using Aliyun.OSS;
using Aliyun.OSS.Common;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 扁平化UI
{
    public partial class client : Form
    {

        public client()
        {
            InitializeComponent();
            label3.Text = 登录界面.identity;
            time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
        
        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
           


        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        string upload_filename;
        string upload_path;
        private void upload_file_select_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    string path =openFileDialog1.FileName;
                    upload_path = path.Replace(@"\", @"\\");
                    upload_filename = Path.GetFileName(upload_path);

                    // 1. 显示文件路径
                    textBox1.Text = upload_path;

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"处理文件时出错: {ex.Message}",
                                   "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        OssClient oss = new OssClient(Config.Endpoint, Config.AccessKeyId, Config.AccessKeySecret);

        public class Config
        {
            public const string AccessKeyId = "LTAI5tG56VxFysmmAUMYptdD";
            public const string AccessKeySecret = "aI4CKX2LOBmZqQb4Ht6dCNKHe8K0lv";
            public const string Endpoint = "oss-cn-guangzhou.aliyuncs.com";  //存储桶所在的区域对应的访问域名
            public const string BucketName = "shilostan";  //存储桶名称
        }
        private void upload_btn_Click(object sender, EventArgs e)
        {
            
            try
            {
                oss = new OssClient(Config.Endpoint, Config.AccessKeyId, Config.AccessKeySecret);
                
                oss.PutObject(Config.BucketName, upload_filename, upload_path);
                
                MessageBox.Show("实验数据上传成功:" + upload_filename);
            }
            catch ( OssException err)
            {
                MessageBox.Show("本地上传报错:" + err.Message);
            }
            catch (System.Exception err)
            {
                MessageBox.Show("本地上传报错:" + err.Message);
            }
        }
        string download_filename;
        string download_path;
        private void download_file_select_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog2.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    string path = openFileDialog2.FileName;
                    download_path = path.Replace(@"\", @"\\");
                    download_filename = Path.GetFileName(download_path);

                    // 1. 显示文件路径
                    textBox2.Text = download_path;


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"处理文件时出错: {ex.Message}",
                                   "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void download_btn_Click(object sender, EventArgs e)
        {
            try
            {

                // 下载文件。
                var result = oss.GetObject(Config.BucketName, download_filename);
                using (var requestStream = result.Content)
                {
                    using (var fs = File.Open(download_path, FileMode.OpenOrCreate))
                    {
                        int length = 4 * 1024;
                        var buf = new byte[length];
                        do
                        {
                            length = requestStream.Read(buf, 0, length);
                            fs.Write(buf, 0, length);
                        } while (length != 0);
                    }
                }
                MessageBox.Show("实验数据同步成功");
            }
            catch (OssException ex)
            {
                Console.WriteLine("Failed with error code: {0}; Error info: {1}. \nRequestID:{2}\tHostID:{3}",
                    ex.ErrorCode, ex.Message, ex.RequestId, ex.HostId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed with error info: {0}", ex.Message);
            }
        }
    }
}

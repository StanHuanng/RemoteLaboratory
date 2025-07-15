using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using CefSharp;
using PdfiumViewer;
using System.Diagnostics;


namespace 扁平化UI
{
    public partial class labsource : Form
    {
        private const string Path = "C:\\Project\\RemoteDP\\扁平化UI\\扁平化UI\\技术文档.pdf";

        public labsource()
        {
            InitializeComponent();
         
           

        }

        private void labsource_Load(object sender, EventArgs e)
        {
            pdfViewer1.Document = opendocument(Path);

        }

        private void pdfViewer1_Load(object sender, EventArgs e)
        {
            pdfViewer1.Document = opendocument(Path);
        }
        private PdfDocument opendocument(string path)
        {
            try
            {
                return PdfDocument.Load(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading PDF document: " + ex.Message);
                return null;
            }
        }

        private void labsource_Leave(object sender, EventArgs e)
        {
            pdfViewer1.Document = null;
            pdfViewer1.Dispose();

        }

        private void pdfViewer1_Leave(object sender, EventArgs e)
        {
          
        }
    }
}

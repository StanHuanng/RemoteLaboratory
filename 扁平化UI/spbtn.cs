using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace remotelab
{
    public partial class spbtn : PictureBox
    {
        public spbtn()
        {
            InitializeComponent();
        }

        private void spbtn_Load(object sender, EventArgs e)
        {

        }
        private Image normalimage;
        private Image hoverimage;

        public Image imagenormal
        {
            get { return normalimage; }
            set { normalimage = value; }
        }

        public Image imagehover
        {
            get { return hoverimage; }
            set { hoverimage = value; }

        }

        private void spbtn_MouseEnter(object sender, EventArgs e)
        {
            this.Width += 5;
            this.Height += 5;
            this.Image = hoverimage;
        }

        private void spbtn_MouseLeave(object sender, EventArgs e)
        {
            this.Width -= 5;
            this.Height -= 5;
            this.Image = normalimage;
        }
    }
}

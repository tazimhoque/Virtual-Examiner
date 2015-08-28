using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildHaven
{
    public partial class testing : Form
    {
        public testing()
        {
            InitializeComponent();
            this.BackColor = Color.Magenta;
            this.TransparencyKey = Color.Magenta;
            
          //  pictureBox1.Image = image;



            pictureBoxPic.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = Image.FromFile("FormBackground\\3.jpg");
            pictureBoxPic.Image = Image.FromFile("Picture\\1.png");
        }

        private void testing_Load(object sender, EventArgs e)
        {

        }
    }
}

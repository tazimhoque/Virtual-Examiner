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
    public partial class OnlyFun : Form
    {
        public OnlyFun()
        {
            InitializeComponent();
            this.BackColor = Color.Magenta;
            this.TransparencyKey = Color.Magenta;
            //Image image = Image.FromFile("hulagirl.gif");
            //pictureBox1.Image = image;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Image image = Image.FromFile("Picture\\8.png");
            

            // Construct an image object from a file in the local directory.
            // ... This file must exist in the solution.
            //Image image = Image.FromFile("hulagirl.gif");
            // Set the PictureBox image property to this image.
            // ... Then, adjust its height and width properties.
           // pictureBox1.Image = image;
          //  pictureBox1.Height = image.Height;
           // pictureBox1.Width = image.Width;
        }

        private void OnlyFun_Load(object sender, EventArgs e)
        {
            labelName.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = Image.FromFile("Picture\\8.png");

        }

    }
}

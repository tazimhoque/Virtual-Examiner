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
    public partial class SplashScreen : Form
    {
        int color_i=2;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            labelWelcome.Text = "Welcome\n  to  the\nKidzone!";
           
            labelWelcome.BackColor = System.Drawing.Color.Transparent;
            labelWelcome.Font = new Font(labelWelcome.Font.FontFamily, color_i);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);

            
                color_i = color_i + 1;
           
            labelWelcome.Font = new Font(labelWelcome.Font.FontFamily,color_i);



            if (progressBar1.Value == 60)
            {
                labelWelcome.ForeColor = System.Drawing.Color.Navy;
                timer1.Stop();
               
            }
        }
    }
}

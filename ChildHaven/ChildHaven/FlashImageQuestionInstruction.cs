using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildHaven
{
    public partial class FlashImageQuestionInstruction : Form
    {
        public FlashImageQuestionInstruction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5000);
            t.Abort();


            FlashImageQuestion fiq = new FlashImageQuestion();
            fiq.ShowDialog();
        }

        public void SplashStart()
        {
            Application.Run(new FlashImage());

        }
    }
}

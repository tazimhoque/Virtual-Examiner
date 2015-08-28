using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace ChildHaven
{
    public partial class OnlineQuestionImagePattern : Form
    {

        string[] kidAnswer = new string[20];
        string[] rightAnswer = new string[20];
        string information;


        public OnlineQuestionImagePattern()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("C:\\Image folder\\Q1.jpg");
            pictureBox2.Image = Image.FromFile("C:\\Image folder\\Q2.jpg");
            pictureBox3.Image = Image.FromFile("C:\\Image folder\\Q3.jpg");
            pictureBox4.Image = Image.FromFile("C:\\Image folder\\Q4.jpg");
            pictureBox5.Image = Image.FromFile("C:\\Image folder\\Q5.jpg");
            pictureBox6.Image = Image.FromFile("C:\\Image folder\\Q6.jpg");
            

            int i = 0;
            string[] lines = System.IO.File.ReadAllLines(@"C:\Image Folder\information.txt");
            foreach (string line in lines)
            {
                if (i == 0)
                {
                    information = line;
                    
                }
                else
                    rightAnswer[i-1] = line;
                i++;
            }

            labelQuestion.Text =information;
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void OnlineQuestionImagePattern_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxA1_TextChanged(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
          //  this.Hide();
           // InformationAnalysis inform = new InformationAnalysis();
            //inform.TextAnalysis();

            processResult();


            MessageBox.Show("It's a Demo Version\nThankyou for using!");

        }


        public void processResult()
        {


            kidAnswer[0] = textBoxA1.Text.ToLower().Replace(" ","");
            kidAnswer[1] = textBoxA2.Text.ToLower().Replace(" ","");
            kidAnswer[2] = textBoxA3.Text.ToLower().Replace(" ","");
            kidAnswer[3] = textBoxA4.Text.ToLower().Replace(" ","");
            kidAnswer[4] = textBoxA5.Text.ToLower().Replace(" ","");
            kidAnswer[5] = textBoxA6.Text.ToLower().Replace(" ","");

           


            
            int i = 0;

            Label[] myLabel = new Label[7];
            myLabel[0] = label2;
            myLabel[1] = label3;
            myLabel[2] = label4;
            myLabel[3] = label5;
            myLabel[4] = label6;
            myLabel[5] = label7;

            for (i = 0; i < 6; i++)
            {
                if (kidAnswer[i] == rightAnswer[i])
                {
                   
                     myLabel[i].Text = "Correct\nAnswer";
                     myLabel[i].ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    myLabel[i].Text = "Wrong\nAnswer";
                    myLabel[i].ForeColor = System.Drawing.Color.Red;
                }
            }

          

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



    }
}

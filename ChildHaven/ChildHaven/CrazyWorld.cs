using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;


namespace ChildHaven
{
    public partial class CrazyWorld : Form
    {
        int fun_i = 1;
        int movePic = 3;

        public CrazyWorld()
        {
           


           // Thread t = new Thread(new ThreadStart(SplashStart));
           // t.Start();
            //Thread.Sleep(5000);

            InitializeComponent();
            this.BackgroundImage = Image.FromFile("FormBackground\\1.jpg");
            pictureBoxMovingImage.Image = Image.FromFile("KnowledgeQuote\\1.jpg");
            makeButtonColor();
            makeLableBackground();
            makePictureStop();

           // t.Abort();
        }


        public void makePictureStop()
        {

            pictureBoxMovingImage.MouseEnter += (s, e) =>
            {
                timerPicture.Stop();
            };
            pictureBoxMovingImage.MouseLeave += (s, e) =>
            {
                timerPicture.Start();
            };

        }

        public void makeLableBackground()
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            labelKnowledge.BackColor = System.Drawing.Color.Transparent;
        }


        public void makeButtonColor()
        {
            buttonAccount.MouseEnter += (s, e) =>
            {
                buttonAccount.BackColor = System.Drawing.Color.Transparent;
            };
            buttonAccount.MouseLeave += (s, e) =>
            {
                buttonAccount.BackColor = Color.GreenYellow;
            };



            buttonUpdate.MouseEnter += (s, e) =>
            {
                timerKnowledge.Stop();
                buttonUpdate.BackColor = System.Drawing.Color.Transparent;
            };
            buttonUpdate.MouseLeave += (s, e) =>
            {
                timerKnowledge.Start();
                buttonUpdate.BackColor = Color.SteelBlue;
            };


            button2.MouseEnter += (s, e) =>
            {
                button2.BackColor = System.Drawing.Color.Transparent;
            };
            button2.MouseLeave += (s, e) =>
            {
                button2.BackColor = Color.Pink;
            };
            

             button1.MouseEnter += (s, e) =>
            {
                button1.BackColor = System.Drawing.Color.Transparent;
            };
            button1.MouseLeave += (s, e) =>
            {
                button1.BackColor = Color.Thistle;
            };

            

        }




        public void SplashStart()
        {
          //  Application.Run(new SplashScreen());

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerKnowledge.Stop();
            timerPicture.Stop();
        }

        private void CrazyWorld_Load(object sender, EventArgs e)
        {
            
            timerKnowledge.Enabled = true;
            timerPicture.Enabled = true;
        }

      



        private void button2_Click(object sender, EventArgs e)
        {
            timerKnowledge.Stop();
            timerPicture.Stop();
            this.Hide();
           Question Q = new Question();
          //  OnlineQuestionImagePattern Q = new OnlineQuestionImagePattern();
            Q.ShowDialog();
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            timerKnowledge.Stop();
            timerPicture.Stop();
            this.Hide();
            UpdateInformation ui = new UpdateInformation();
            ui.ShowDialog();
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            timerKnowledge.Stop();
            timerPicture.Stop();
            this.Hide();
            UserLogin ul = new UserLogin();
            ul.ShowDialog();
        }

        private void timerKnowledge_Tick_1(object sender, EventArgs e)
        {
            if (fun_i == 1)
            {
                buttonUpdate.BackColor = Color.SteelBlue;
               // buttonUpdate.Text = "";
               // timerKnowledge.Interval = 80;
                fun_i = 2;
            }
            else if (fun_i == 2)
            {
                buttonUpdate.BackColor = System.Drawing.Color.Transparent;
               // buttonUpdate.Text = "Update Now";
               // timerKnowledge.Interval = 1090;
                fun_i = 1;
            }

            //label.Left = label.Left + 10;
            //if (labelKnowledge.Location.X > this.Width)
            //{
            //    labelKnowledge.Location = new Point(0 - labelKnowledge.Width, labelKnowledge.Location.Y);
            //}
            //labelKnowledge.Left = labelKnowledge.Left+10;
        }

        

        private void timerPicture_Tick(object sender, EventArgs e)
        {
            if (movePic == 1)
            {
                pictureBoxMovingImage.Image = Image.FromFile("KnowledgeQuote\\1.jpg");
                movePic = 2;
            }
            else if (movePic == 2)
            {
                pictureBoxMovingImage.Image = Image.FromFile("KnowledgeQuote\\2.jpg");
                movePic = 3;
            }
            else if (movePic == 3)
            {
                pictureBoxMovingImage.Image = Image.FromFile("KnowledgeQuote\\3.jpg");
                movePic = 4;
            }
            else if (movePic == 4)
            {
                pictureBoxMovingImage.Image = Image.FromFile("KnowledgeQuote\\4.jpg");
                movePic = 5;
            }
            else if (movePic == 5)
            {
                pictureBoxMovingImage.Image = Image.FromFile("KnowledgeQuote\\5.jpg");
                movePic = 6;
            }
            else if (movePic == 6)
            {
                pictureBoxMovingImage.Image = Image.FromFile("KnowledgeQuote\\6.jpg");
                movePic = 7;
            }
            else if (movePic == 7)
            {
                pictureBoxMovingImage.Image = Image.FromFile("KnowledgeQuote\\7.jpg");
                movePic = 1;
            }

        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonClassic_Click(object sender, EventArgs e)
        {
            timerKnowledge.Stop();
            timerPicture.Stop();
            this.Hide();
            UserAccount ua = new UserAccount();
            ua.ShowDialog();
        }


        


    }
}

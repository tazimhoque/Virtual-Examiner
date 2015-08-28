using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildHaven
{
    public partial class UserLogin : Form
    {

        bool passwordchecker;
        bool blankChecker;
        bool closeChecker = false;

        int btnON = 1;
       

        public UserLogin()
        {
            InitializeComponent();

            label8.Visible = false; //Have an Account?
            label9.Visible = false;//- Here is someone in the dark! She wants to tell you something...Help her...She will let you login
           

          
        }

        public void initializeIeam()
        {
            this.BackgroundImage = Image.FromFile("FormBackground\\2.jpg");


            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
           // label4.BackColor = System.Drawing.Color.Transparent;
            //label5.BackColor = System.Drawing.Color.Transparent;
            label6.BackColor = System.Drawing.Color.Transparent;
            label7.BackColor = System.Drawing.Color.Transparent;
           // label8.BackColor = System.Drawing.Color.Transparent;
            //label9.BackColor = System.Drawing.Color.Transparent;

            pictureBoxPic.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBoxDialogue.BackColor = System.Drawing.Color.Transparent;

           

            pictureBoxPic.Image = Image.FromFile("FormBackground\\gif2.gif");
            pictureBox1.Image = Image.FromFile("Picture\\2.png");
            pictureBox2.Image = Image.FromFile("Picture\\5.jpg");
            pictureBoxDialogue.Image = Image.FromFile("Picture\\3.png");



           

            buttonSignup.MouseEnter += (s, e) =>
            {
                buttonSignup.BackColor = System.Drawing.Color.Transparent;
            };
            buttonSignup.MouseLeave += (s, e) =>
            {
                buttonSignup.BackColor = Color.LightPink;
            };


            buttonON.MouseEnter += (s, e) =>
            {
                buttonON.BackColor = System.Drawing.Color.Transparent;
            };
            buttonON.MouseLeave += (s, e) =>
            {
                buttonON.BackColor = Color.PaleGreen;
            };



            buttonOFF.MouseEnter += (s, e) =>
            {
                buttonOFF.BackColor = System.Drawing.Color.Transparent;
            };
            buttonOFF.MouseLeave += (s, e) =>
            {
                buttonOFF.BackColor = Color.Plum;
            };


            buttonLogin.MouseEnter += (s, e) =>
            {
                buttonLogin.BackColor = System.Drawing.Color.Transparent;
            };
            buttonLogin.MouseLeave += (s, e) =>
            {
                buttonLogin.BackColor = Color.SkyBlue;
            };


            

        }

        public void makeON()
        {
            pictureBox2.Visible = false;

           // label8.Visible = false;
           // label9.Visible = false;
            label3.Visible = false;
            buttonSignup.Visible = false;
           // label4.Visible = false;
            pictureBoxPic.Visible = false;
          
            buttonON.Visible = false;
          //  label5.Visible = false;
            

            Application.DoEvents();

            this.BackgroundImage = Image.FromFile("FormBackground\\3.jpg");
            Application.DoEvents();


            pictureBox1.Visible = true;
            pictureBoxDialogue.Visible = true;

           

            label1.Visible = true;
            label2.Visible = true;
            label6.Visible = true;


            textBoxUserName.Visible = true;
            textBoxPassword.Visible = true;
            buttonLogin.Visible = true;



            label7.Visible = true;
            buttonOFF.Visible = true;

            
            


          //  label4.Text = "Create an Account";
          //  label4.Visible = true;
           // label5.Visible = true;

        



        }




        public void makeOFF()
        {
            
            textBoxUserName.Visible = false;
            textBoxPassword.Visible = false;
            buttonLogin.Visible = false;

            label7.Visible = false;

            buttonON.Visible = false;
         
           // label5.Visible = false;
           // label4.Visible = false;
            


            //loginFalse
            

            label1.Visible = false;
            label2.Visible = false;
            label6.Visible = false;
            

         
            pictureBoxDialogue.Visible = false;
            pictureBox1.Visible = false;
            buttonOFF.Visible = false;

            Application.DoEvents();

            pictureBoxPic.Image = Image.FromFile("FormBackground\\gif2.gif");
            this.BackgroundImage = Image.FromFile("FormBackground\\2.jpg");
            Application.DoEvents();




          //  label8.Visible = true;
           // label9.Visible = true;
            label3.Visible = true;
            
            buttonSignup.Visible = true;
           
  
            
         
            pictureBoxPic.Visible = true;
            pictureBox2.Visible = true;
            buttonON.Visible = true;
            //pictureBoxBulb.Visible = false;
        
          //  label4.Text = "";
           // label4.Visible = true;
            



        }


       



       



        private void buttonSignup_Click(object sender, EventArgs e)
        {
            timerON.Stop();
            this.Hide();
            Signup su = new Signup();
            su.ShowDialog();
        }





        public void nullChecker()
        {
            blankChecker = true;
            if (textBoxUserName.Text == "")
            {
                MessageBox.Show("You have to enter an user name.");
                blankChecker = false;
            }
            
            else if (textBoxPassword.Text == "")
            {
                MessageBox.Show("You have to enter a password.");
                blankChecker = false;
            }
           

        }



        public void makeLogin()
        {


            passwordchecker = true;
            // step 1: Create a connection
            var result = Path.GetFullPath("InformationDatabase.mdf");
            string strConnection = "Data Source=.\\sqlexpress;AttachDbFilename=" + result + ";User Instance=true; Integrated Security=True;Pooling=False";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();

            // step 2: fire a command

            string userInputID = textBoxUserName.Text;
            string strCommand = "select userID, userPassword from [User] where userID = @useInputID";
            SqlCommand objCommand = new SqlCommand(strCommand, objConnection);

            objCommand.Parameters.Add(new SqlParameter("@useInputID", userInputID));
            // step 3: bind the result data with user interface

            SqlDataReader reader = objCommand.ExecuteReader();

            if (reader.Read())
            {

               
               if (reader[1].ToString() != textBoxPassword.Text)
                {
                    MessageBox.Show("Wrong Password!");
                    passwordchecker = false;
                }

               reader.Close();
               objConnection.Close();
            }
            else
            {
                
                    MessageBox.Show("Invalid User Name!");
                    passwordchecker = false;
                    reader.Close();
                    objConnection.Close();
            }


           



        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            timerON.Stop();
            nullChecker();

            if ((textBoxUserName.Text.ToLower().Replace(" ","") == "admin") && textBoxPassword.Text.ToLower().Replace(" ","") == "kid13")
            {
                this.Hide();
                QuestionMaker qm = new QuestionMaker();
                qm.ShowDialog();
            }


            

            if (blankChecker == true)
            {
                makeLogin();


                if (passwordchecker == true)
                {

                    this.Hide();

                    UserInformation.setUserName(textBoxUserName.Text.ToString());

                    CrazyWorld cw = new CrazyWorld();
                    cw.ShowDialog();

                  
                }


            }


            
           
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

        private void buttonHola_Click(object sender, EventArgs e)
        {
            this.Hide();
            OnlyFun of = new OnlyFun();
            of.ShowDialog();
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }



        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxDialogue_Click(object sender, EventArgs e)
        {

        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            
            initializeIeam();
            makeOFF();
            timerON.Enabled = true;
           
        }

        private void timerON_Tick(object sender, EventArgs e)
        {
            
             
                if (btnON == 1)
                {
                    buttonON.BackColor = Color.LimeGreen;
                    btnON = 2;
                }
                else if (btnON == 2)
                {
                    buttonON.BackColor = System.Drawing.Color.Transparent;
                    btnON = 1;
                }
            
        }

       
        private void buttonQuit_Click(object sender, EventArgs e)
        {
            timerON.Stop();
            this.Close();
        }

        private void pictureBoxDialogue_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonON_Click(object sender, EventArgs e)
        {
            makeON();
        }

        private void buttonOFF_Click_1(object sender, EventArgs e)
        {
            makeOFF();
        }








    }
}

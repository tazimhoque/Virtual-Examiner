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
    public partial class UserAccount : Form
    {
        public UserAccount()
        {
            InitializeComponent();
            this.BackColor = Color.PaleGoldenrod;
            this.TransparencyKey = Color.PaleGoldenrod;


        }

        private void UserAccount_Load(object sender, EventArgs e)
        {
            timerMovingImage.Enabled = true;



            pictureBoxLeft.BackColor = System.Drawing.Color.Transparent;
            pictureBoxRight.BackColor = System.Drawing.Color.Transparent;

            initialHideItem();

    



        }



        public void collectUserInformation()
        {

            // step 1: Create a connection
            var result = Path.GetFullPath("InformationDatabase.mdf");
            string strConnection = "Data Source=.\\sqlexpress;AttachDbFilename=" + result + ";User Instance=true; Integrated Security=True;Pooling=False";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();
            // step 2: fire a command

            string userName = UserInformation.getUserName();
            string strCommand = "select userID, userPassword, FullName, userCountry, Birthday, MailAddress, userGender, userPicture from [User] where userID = @username";
            SqlCommand objCommand = new SqlCommand(strCommand, objConnection);

            objCommand.Parameters.Add(new SqlParameter("@username",userName));
            // step 3: bind the result data with user interface

            SqlDataReader reader = objCommand.ExecuteReader();

           
            if (reader.Read())
            {
               // string givenDate = DateTimePicker.Value.ToString("yyyy/MM/dd");
               // DateTimePicker myDT = new DateTimePicker();
                
                  labelName.Text= reader[2].ToString();
                  labelUserName.Text = reader[1].ToString();
                  labelGender.Text = reader[6].ToString();



                  labelBirthday.Text = reader.GetDateTime(reader.GetOrdinal("Birthday")).ToString("MMMM dd, yyyy");

                
                
                 


                  labelCountry.Text = reader[3].ToString();
                  labelEmail.Text = reader[5].ToString();



                   byte[] img = (byte[])(reader[7]);
                   MemoryStream ms = new MemoryStream(img);
                   pictureBoxPic.Image = Image.FromStream(ms);

                

            }
            
          
            reader.Close();
            objConnection.Close();
        }



        public void initialHideItem()
        {
            pictureBoxAntique.Visible = false;
            pictureBoxPic.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            labelName.Visible = false;
            labelUserName.Visible = false;
            labelGender.Visible = false;
            labelBirthday.Visible = false;
            labelCountry.Visible = false;
            labelEmail.Visible = false;


            buttonBack.Visible = false;
            buttonQuit.Visible = false;
            buttonSignOut.Visible = false;
            buttonUpdate.Visible = false;
           

        }







        public void showItem()
        {
            pictureBoxAntique.Visible = true;
            pictureBoxPic.Visible = true;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

            labelName.Visible = true;
            labelUserName.Visible = true;
            labelGender.Visible = true;
            labelBirthday.Visible = true;
            labelCountry.Visible = true;
            labelEmail.Visible = true;


            buttonBack.Visible = true;
            buttonQuit.Visible = true;
            buttonSignOut.Visible = true;
            buttonUpdate.Visible = true;


        }






        private void timerMovingImage_Tick(object sender, EventArgs e)
        {



            if (pictureBoxLeft.Location.X != 0)
            {
                pictureBoxLeft.Location = new Point(pictureBoxLeft.Location.X - 5, pictureBoxLeft.Location.Y);
                pictureBoxLeftHide.Location = new Point(pictureBoxLeftHide.Location.X - 5, pictureBoxLeftHide.Location.Y);
            }

            else if (pictureBoxLeft.Location.X == 0)
            {


                pictureBoxRightHide.Visible = false;

                pictureBoxLeftHide.Visible = false;

                timerMovingImage.Stop();

                collectUserInformation();
                Application.DoEvents();

                showItem();
                
            }


            if(pictureBoxRight.Location.X<=950)
            {
                pictureBoxRight.Location = new Point(pictureBoxRight.Location.X + 5, pictureBoxRight.Location.Y);
                 pictureBoxRightHide.Location = new Point(pictureBoxRightHide.Location.X + 5, pictureBoxRightHide.Location.Y);
            }



         
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
          
            this.Hide();
            UserLogin ul = new UserLogin();
            ul.ShowDialog();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
          
            this.Hide();
            CrazyWorld cw = new CrazyWorld();
            cw.ShowDialog();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}

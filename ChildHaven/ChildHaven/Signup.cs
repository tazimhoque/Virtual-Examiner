using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;



namespace ChildHaven
{
     


    public partial class Signup : Form
    {

       
        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;



        bool checker = false;
        
        bool camTrack = false;

        Image myImage = Image.FromFile(@"UserImage\Default.png");
        bool userImage = false;


        string userAdminChecker;
        string pictureURL = null;

        int yearGiven;
        int yearToday;
        int yearCalculation;
        

        public Signup()
        {
            InitializeComponent();
            this.BackColor = Color.PaleGoldenrod;
            this.TransparencyKey = Color.PaleGoldenrod;
        }


        private void Signup_Load(object sender, EventArgs e)
        {
            Point myPoint = new Point(765, -351);
            pictureBoxCam.Location = myPoint;

            pictureBoxHide.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;

          // pictureBoxUser.BackColor = System.Drawing.Color.Transparent;
          // pictureBoxCam.BackColor = System.Drawing.Color.Transparent;
           //pictureBoxUserInfo.BackColor = System.Drawing.Color.Transparent;
           //pictureBoxNew.BackColor = System.Drawing.Color.Transparent;
           //pictureBoxPic.BackColor = System.Drawing.Color.Transparent;

           // pictureBoxUser.BackgroundImage = Image.FromFile("Picture\\8.png");
            timerCam.Enabled = true;
            
            pictureBoxUser.Image = Image.FromFile("Picture\\8.png");
            pictureBoxCam.Image = Image.FromFile("Picture\\9.png");

            //this.BackgroundImage = Image.FromFile("FormBackground\\4.png");
           
            pictureBoxPic.Image = myImage;



            //makeInvisible();
            makeHideItemInitial();
            hideCamProperty();
            

            CamDelayStart();
           
       }


        public void CamDelayStart()
        {
         
            label9.Visible = false;

            pictureBoxPic.Visible = false;
            comboBoxPic.Visible = false;

            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            buttonStart.Visible = false;
            buttonTakePicture.Visible = false;
            buttonSave.Visible = false;
        }
        public void CamDelayStop()
        {
            
            label9.Visible = true;

            pictureBoxPic.Visible = true;
           // comboBoxPic.Visible = true;

            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            //buttonStart.Visible = true;
            //buttonTakePicture.Visible = true;
            //buttonSave.Visible = true;
        }



        //public void makeInvisible()
        //{
        //    label1.BackColor = System.Drawing.Color.Transparent;

        //    label1.BackColor = System.Drawing.Color.Transparent;
        //    label2.BackColor = System.Drawing.Color.Transparent;
        //    label3.BackColor = System.Drawing.Color.Transparent;
        //    label4.BackColor = System.Drawing.Color.Transparent;
        //    label5.BackColor = System.Drawing.Color.Transparent;
        //    label6.BackColor = System.Drawing.Color.Transparent;
        //    label7.BackColor = System.Drawing.Color.Transparent;
        //    label8.BackColor = System.Drawing.Color.Transparent;
        //    label9.BackColor = System.Drawing.Color.Transparent;

        //    label10.BackColor = System.Drawing.Color.Transparent;
        //    labelName.BackColor = System.Drawing.Color.Transparent;
        //    labelUserName.BackColor = System.Drawing.Color.Transparent;
        //    labelPassword.BackColor = System.Drawing.Color.Transparent;
        //    labelRePassword.BackColor = System.Drawing.Color.Transparent;
        //    labelBirthday.BackColor = System.Drawing.Color.Transparent;
        //    labelGender.BackColor = System.Drawing.Color.Transparent;
        //    labelEmail.BackColor = System.Drawing.Color.Transparent;
        //    labelCountry.BackColor = System.Drawing.Color.Transparent;


        //    groupBoxGender.BackColor = System.Drawing.Color.Transparent;
        //    radioButtonMale.BackColor = System.Drawing.Color.Transparent;
        //    radioButtonFemale.BackColor = System.Drawing.Color.Transparent;

           
        //    //dateTimePicker1.Invalidate();

        //}

        //const int WM_ERASEBKGND = 0x14;
        //protected override void WndProc(ref System.Windows.Forms.Message m)
        //{
        //    if (m.Msg == WM_ERASEBKGND)
        //    {
        //        Graphics g = Graphics.FromHdc(m.WParam);
        //        g.FillRectangle(new SolidBrush(Color.Red), ClientRectangle);
        //        g.Dispose();
        //        return;
        //    }

        //    base.WndProc(ref m);
        //}

        //private SolidBrush _BackColorBrush = new SolidBrush(SystemColors.Window);

        //public override System.Drawing.Color BackColor
        //{
        //    get
        //    {
        //        return base.BackColor;
        //    }
        //    set
        //    {
        //        if (null != _BackColorBrush)
        //        {
        //            _BackColorBrush.Dispose();
        //        }
        //        base.BackColor = value;
        //        _BackColorBrush = new SolidBrush(value);
        //        this.Invalidate();
        //    }
        //}

        //protected override void WndProc(ref Message m)
        //{
        //    const int WM_ERASEBKGND = 20;

        //    if (WM_ERASEBKGND == m.Msg)
        //    {
        //        Graphics g = Graphics.FromHdc(m.WParam);
        //        g.FillRectangle(_BackColorBrush, this.ClientRectangle);
        //        g.Dispose();
        //    }
        //    else
        //    {
        //        base.WndProc(ref m);
        //    }
        //}




        public void initialWebcame()
        {
            try
            {
                webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);


                foreach (FilterInfo VideoCaptureDevice in webcam)
                {
                    comboBoxPic.Items.Add(VideoCaptureDevice.Name);
                }
                comboBoxPic.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                hideCamProperty();

                if (cam.IsRunning)
                {
                    cam.Stop();
                }   
                    camTrack = false;
                
                userImage = false;
                myImage = null;
                Application.DoEvents();

                if (radioButtonMale.Checked == true)
                {
                    myImage = Image.FromFile(@"UserImage\Male.png");
                    pictureBoxPic.Image = myImage;
                }
                else if (radioButtonFemale.Checked == true)
                {
                    myImage = Image.FromFile(@"UserImage\Female.png");
                    pictureBoxPic.Image = myImage;
                }
                else
                {
                    myImage = Image.FromFile(@"UserImage\Default.png");
                    pictureBoxPic.Image = myImage;
                }
                
            }
        }



        public void camStart()
        {
            try
            {
                cam = new VideoCaptureDevice(webcam[comboBoxPic.SelectedIndex].MonikerString);
                cam.NewFrame += new NewFrameEventHandler(cam_NewFram);
                cam.Start();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                hideCamProperty();


                if (cam.IsRunning)
                {
                    cam.Stop();
                }

                camTrack = false;

                userImage = false;
                myImage = null;
                Application.DoEvents();

                if (radioButtonMale.Checked == true)
                {
                    myImage = Image.FromFile(@"UserImage\Male.png");
                    pictureBoxPic.Image = myImage;
                }
                else if (radioButtonFemale.Checked == true)
                {
                    myImage = Image.FromFile(@"UserImage\Female.png");
                    pictureBoxPic.Image = myImage;
                }
                else
                {
                    myImage = Image.FromFile(@"UserImage\Default.png");
                    pictureBoxPic.Image = myImage;
                } 
                
            }
        }


        private void cam_NewFram(object sender, NewFrameEventArgs eventArgs)
        {

            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            pictureBoxPic.Image = bit;

        }




        public void makeHideItemInitial()
        {
            

            labelName.Visible = false;
            labelUserName.Visible = false;
            labelPassword.Visible = false;
            labelRePassword.Visible = false;
            labelBirthday.Visible = false;
            labelGender.Visible = false;
            labelEmail.Visible = false;
            labelCountry.Visible = false;
       

        }

        public void makeCamProperty()
        {
            button2.Visible = false;
            button3.Visible = false;
            label9.Visible = false;

            buttonTakePicture.Visible = true;
           // buttonStart.Visible = true;
           // buttonSave.Visible = true;
            comboBoxPic.Visible = true;


        }

        public void hideCamProperty()
        {

            buttonTakePicture.Visible = false;
            comboBoxPic.Visible = false;
            buttonStart.Visible = false;
            buttonSave.Visible = false;
            
            Application.DoEvents();

            button2.Visible = true;
            button3.Visible = true;
            label9.Visible = true;

            

        }



        public void makeRefresh()
        {
           
          
         
            labelName.Visible = false;
            labelUserName.Visible = false;
            labelPassword.Visible = false;
            labelRePassword.Visible = false;
            labelBirthday.Visible = false;
            labelGender.Visible = false;
            labelEmail.Visible = false;
            labelCountry.Visible = false;

            textBoxFullName.Text = "";
            textBoxUserName.Text = "";
            textBoxRePassword.Text = "";
            textBoxPassword.Text = "";
            
            dateTimePicker1.Text = DateTime.Now.ToString();
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            textBoxEmail.Text = "";
            comboBoxCountry.Text = "";

            myImage = Image.FromFile(@"UserImage\Default.png");
            pictureBoxPic.Image = myImage;
            

        }











        public void perfectInputChecker()
        {
            checker = false;


            userAdminChecker = textBoxUserName.Text;
            RegexUtilities util = new RegexUtilities();

            //Name
            if (textBoxFullName.Text == "")
            {
                labelName.ForeColor = Color.Red;
                labelName.Text = "You can't leave this empty.";
                labelName.Visible = true;

                checker = true;
            }
            else if (textBoxFullName.Text.Length > 30)
            {
                labelName.ForeColor = Color.Red;
                labelName.Text = "Name should be within 30 characters.";
                labelName.Visible = true;
                            
                checker = true;
            }





            if (textBoxUserName.Text == "")
            {
                labelUserName.ForeColor = Color.Red;
                labelUserName.Text = "You can't leave this empty.";
                labelUserName.Visible = true;
             
                checker = true;
            }
            else if (textBoxUserName.Text.ToLower().Replace(" ", "") == "admin")
            {
                labelUserName.ForeColor = Color.Red;
                labelUserName.Text = "You can't open an account with User Name: " + userAdminChecker;
                labelUserName.Visible = true;

                checker = true;
            }
            else if (textBoxUserName.Text.Contains(" "))
            {
                labelUserName.ForeColor = Color.Red;
                labelUserName.Text = "User Name can't contain any space.";
                labelUserName.Visible = true;
               
                checker = true;
            }   
            else if (textBoxUserName.Text.Length > 15 || textBoxUserName.Text.Length < 5)
            {
                labelUserName.ForeColor = Color.Red;
                labelUserName.Text = "User Name should between 5 to 15 characters.";
                labelUserName.Visible = true;
             
                checker = true;
            }
            else if (textBoxUserName.Text.Length >= 5 && textBoxUserName.Text.Length <= 15 )
            {

                validUserName();
               
            }




                string todaysDate = DateTime.Now.ToString("yyyy/MM/dd");
                string givenDate = dateTimePicker1.Value.ToString("yyyy/MM/dd");

                yearToday = int.Parse(DateTime.Now.ToString("yyyy"));
                yearGiven = int.Parse(dateTimePicker1.Value.ToString("yyyy"));
                yearCalculation = yearToday - yearGiven;



                //DateTime.Now.ToString("M/d/yyyy");
                //  string theDate = dateTimePicker1.Value.ToShortDateString();
                //string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");




                if (textBoxPassword.Text == "")
                {
                    labelPassword.ForeColor = Color.Red;
                    labelPassword.Text = "You can't leave this empty.";
                    labelPassword.Visible = true;
               
                    checker = true;
                }
                else if (textBoxPassword.Text.Length > 30 || textBoxPassword.Text.Length < 5)
                {
                    labelPassword.ForeColor = Color.Red;
                    labelPassword.Text = "Password should between 5 to 30 characters.";
                    labelPassword.Visible = true;
            
                    checker = true;
                }




                if (textBoxRePassword.Text == "")
                {
                    labelRePassword.ForeColor = Color.Red;
                    labelRePassword.Text = "You can't leave this empty.";
                    labelRePassword.Visible = true;
                    checker = true;
                }



               if (todaysDate == givenDate)
                {

                    labelBirthday.ForeColor = Color.Red;
                    labelBirthday.Text = "Enter your birthday.";
                    labelBirthday.Visible = true;

                    checker = true;
                }

                else if (yearCalculation < 0 || (yearCalculation > 0 && yearCalculation <= 4))
                {
                    labelBirthday.ForeColor = Color.Red;
                    if (yearCalculation == 1)
                    {
                        labelBirthday.Text = "You are not " + yearCalculation + " year old!";
                    }
                    else
                    {
                        labelBirthday.Text = "You are not " + yearCalculation + " year old!";
                    }
                    labelBirthday.Visible = true;

                    checker = true;
                }


                if (radioButtonMale.Checked == false && radioButtonFemale.Checked == false)
                {
                    labelGender.ForeColor = Color.Red;
                    labelGender.Text = "Select the gender.";
                    labelGender.Visible = true;
                    checker = true;
                }



                if (textBoxEmail.Text == "")
                {
                    labelEmail.ForeColor = Color.Red;
                    labelEmail.Text = "You can't leave this empty.";
                    labelEmail.Visible = true;
                    checker = true;
                }
                   
                 else if(!util.IsValidEmail(textBoxEmail.Text.ToString()))
                {
                   
                    labelEmail.ForeColor = Color.Red;
                    labelEmail.Text = "Give a valid Email Address";
                    labelEmail.Visible = true;
                    checker = true;
                }


               if (comboBoxCountry.Text == "")
                {
                    labelCountry.ForeColor = Color.Red;
                    labelCountry.Text = "Select your country.";
                    labelCountry.Visible = true;

                    checker = true;
                }


               validEmailAddress();   


        }




        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress mail = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }




        public void validUserName()
        {

            // step 1: Create a connection
            var result = Path.GetFullPath("InformationDatabase.mdf");
            string strConnection = "Data Source=.\\sqlexpress;AttachDbFilename=" + result + ";User Instance=true; Integrated Security=True;Pooling=False";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();
            // step 2: fire a command

            string i = textBoxUserName.Text.ToLower();
            string strCommand = "select userID from [User] where userID = @i";
            SqlCommand objCommand = new SqlCommand(strCommand, objConnection);

            objCommand.Parameters.Add(new SqlParameter("@i", i));
            // step 3: bind the result data with user interface

            SqlDataReader reader = objCommand.ExecuteReader();

           
            if (reader.Read())
            {
                string j = " ";
                if (reader[0].ToString() != "")
                    j = reader[0].ToString().ToLower();

                if (j == i)
                {
                    checker = true;

                    labelUserName.ForeColor = Color.Red;

                    labelUserName.Text = "User Name Already Exist!";
                    labelUserName.Visible = true;

                  
                }
                


            }
            else
            {
                labelUserName.ForeColor = Color.Green;

                labelUserName.Text = "Unique Username";
                labelUserName.Visible = true;
            }

          
            reader.Close();
            objConnection.Close();
        }








        public void validEmailAddress()
        {

            // step 1: Create a connection
            var result = Path.GetFullPath("InformationDatabase.mdf");
            string strConnection = "Data Source=.\\sqlexpress;AttachDbFilename=" + result + ";User Instance=true; Integrated Security=True;Pooling=False";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();
            // step 2: fire a command

            string i = textBoxEmail.Text;
            string strCommand = "select MailAddress from [User] where MailAddress = @i";
            SqlCommand objCommand = new SqlCommand(strCommand, objConnection);

            objCommand.Parameters.Add(new SqlParameter("@i", i));
            // step 3: bind the result data with user interface

            SqlDataReader reader = objCommand.ExecuteReader();


            if (reader.Read())
            {
                string j = " ";
                if (reader[0].ToString() != "")
                    j = reader[0].ToString();

                if (j == i)
                {
                    checker = true;


                    labelEmail.ForeColor = Color.Red;

                    labelEmail.Text = "This Email Address is already in use!";
                    labelEmail.Visible = true;


                }



            }
            else
            {
                //labelEmail.ForeColor = Color.Green;

                //labelEmail.Text = "";
                //labelEmail.Visible = true;
            }


            reader.Close();
            objConnection.Close();
        }













        public void databaseMaker()
        {


            try
            {
                // step 1: Create a connection
                var result = Path.GetFullPath("InformationDatabase.mdf");
                string strConnection = "Data Source=.\\sqlexpress;AttachDbFilename=" + result + ";User Instance=true; Integrated Security=True;Pooling=False";
                //  string strConnection = "Data Source=.\\sqlexpress;Initial Catalog=CustomerDatabase;Integrated Security=True;Pooling=False";
                SqlConnection objConnection = new SqlConnection(strConnection);
                objConnection.Open();
                // step 2: fire a command

                string strCommand = "insert into [User] values( @id, @password, @name, @country, @birthday, @email, @gender, @img )";
                SqlCommand objCommand = new SqlCommand(strCommand, objConnection);
                objCommand.Parameters.Add(new SqlParameter("@id", textBoxUserName.Text));
                objCommand.Parameters.Add(new SqlParameter("@password", textBoxPassword.Text));
                objCommand.Parameters.Add(new SqlParameter("@name", textBoxFullName.Text));
                objCommand.Parameters.Add(new SqlParameter("@country", comboBoxCountry.Text));
                objCommand.Parameters.Add(new SqlParameter("@birthday", dateTimePicker1.Value.ToString("yyyy/MM/dd")));
                objCommand.Parameters.Add(new SqlParameter("@email", textBoxEmail.Text));

                if (radioButtonMale.Checked == true)
                {
                    objCommand.Parameters.Add(new SqlParameter("@gender", "Male"));
                }
                else if (radioButtonFemale.Checked == true)
                {
                    objCommand.Parameters.Add(new SqlParameter("@gender", "Female"));
                }

                //var dir = @"TempPicStore";  // folder location

                //if (!Directory.Exists(dir))  // if it doesn't exist, create
                //    Directory.CreateDirectory(dir);



                ImageConverter _imageConverter = new ImageConverter();
                byte[] img = (byte[])_imageConverter.ConvertTo(myImage, typeof(byte[]));
                

           

                 //byte[] img = null;
                 //myImage.Save("UserImage\\UserWebcam.jpg");
                 //FileStream fs = new FileStream("UserImage\\UserWebcam.jpg", FileMode.Open, FileAccess.Read);
                 // BinaryReader br = new BinaryReader(fs);
                 // img = br.ReadBytes((int)fs.Length);

               
                objCommand.Parameters.Add(new SqlParameter("@img",img));


              
                



                objCommand.ExecuteNonQuery();



                //DirectoryInfo di = new DirectoryInfo("TempPicStore\\UserWebcam.jpg");
                //if (Directory.Exists("TempPicStore\\UserWebcam.jpg"))
                //{
                //    di.Delete(true);
                //}


                // step 4: close the connection
                objConnection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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

        private void textBoxFullName_TextChanged(object sender, EventArgs e)
        {
            labelName.Visible = false;
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

            labelUserName.Visible = false;

            if (textBoxUserName.Text.ToString().Length >= 5 && textBoxUserName.Text.ToString().Length <= 30)
            {
                validUserName();
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            labelPassword.Visible = false;
            if ( textBoxPassword.Text == textBoxRePassword.Text && textBoxRePassword.Text != "")
            {
                labelRePassword.ForeColor = Color.Green;
                labelRePassword.Text = "Password Matched!";
                labelRePassword.Visible = true;
            }
            else if (textBoxRePassword.Text != "")
            {
                labelRePassword.ForeColor = Color.DeepPink;
                labelRePassword.Text = "Password Does Not Match!";
                labelRePassword.Visible = true;
                checker = true;
            }


        }

        private void textBoxRePassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRePassword.Text == textBoxPassword.Text && textBoxPassword.Text != "")
            {
                labelRePassword.ForeColor = Color.Green;
                labelRePassword.Text = "Password Matched!";
                labelRePassword.Visible = true;
            }
            else if (textBoxRePassword.Text != "")
            {
                labelRePassword.ForeColor = Color.DeepPink;
                labelRePassword.Text = "Password Does Not Match!";
                labelRePassword.Visible = true;
                checker = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            labelBirthday.Visible = false;
        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            labelGender.Visible = false;

            if (userImage == false)
            {
                myImage = Image.FromFile(@"UserImage\Male.png");
                pictureBoxPic.Image = myImage;
            }
        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            labelGender.Visible = false;

            if (userImage == false)
            {
                myImage = Image.FromFile(@"UserImage\Female.png");
                pictureBoxPic.Image = myImage;
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            labelEmail.Visible = false;
            validEmailAddress();
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelCountry.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogin ul = new UserLogin();
            ul.ShowDialog();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

           
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

            userImage = false;
            myImage = null;
            Application.DoEvents();
            makeRefresh();
            
        }

        private void buttonCreatAccount_Click(object sender, EventArgs e)
        {
            makeHideItemInitial();

            perfectInputChecker();
            if (checker == false)
            {

                databaseMaker();
                //solveStatusNull();
                MessageBox.Show("Your account is created successfully!!");

                this.Hide();
                UserLogin ul = new UserLogin();
                ul.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    userImage = true;

                    pictureURL = openFileDialog1.FileName;

                    myImage = Image.FromFile(pictureURL);

                    pictureBoxPic.Image = myImage;

                    // pictureBox1.Image = Image.FromFile("C:\\Image folder\\Q1.jpg");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            myImage = Image.FromFile(@"Loading\Loading.gif");

            pictureBoxPic.Image = myImage;
            Application.DoEvents();
            initialWebcame();
            buttonTakePicture.Text = "Capture";
            camTrack = true;
            camStart();
            makeCamProperty();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideCamProperty();

            if (camTrack == true)
            {
                if (cam.IsRunning)
                {
                    cam.Stop();
                }
                camTrack = false;
            }
            userImage = false;
           // myImage = null;
            Application.DoEvents();

            if (radioButtonMale.Checked == true)
            {
                myImage = Image.FromFile(@"UserImage\Male.png");
                pictureBoxPic.Image = myImage;
            }
            else if (radioButtonFemale.Checked == true)
            {
                myImage = Image.FromFile(@"UserImage\Female.png");
                pictureBoxPic.Image = myImage;
            }
            else
            {
                myImage = Image.FromFile(@"UserImage\Default.png");
                pictureBoxPic.Image = myImage;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            myImage = Image.FromFile(@"Loading\Loading.gif");
            pictureBoxPic.Image = myImage;
            Application.DoEvents();
            buttonTakePicture.Text = "Capture";
            buttonTakePicture.Visible = true;
            buttonStart.Visible = false;
            buttonSave.Visible = false;
            camStart();
        }

        private void buttonTakePicture_Click(object sender, EventArgs e)
        {
           // buttonTakePicture.Text = "Okay, use it!";

            userImage = true;
            buttonTakePicture.Visible = false;


            if (cam.IsRunning)
            {
                cam.Stop();
            }

            myImage = pictureBoxPic.Image;

            buttonStart.Visible = true;
            buttonSave.Visible = true;
        }

        private void pictureBoxUser_Click(object sender, EventArgs e)
        {

        }

        private void timerCam_Tick(object sender, EventArgs e)
        {

            pictureBoxCam.Location = new Point(pictureBoxCam.Location.X, pictureBoxCam.Location.Y + 3);

            if (pictureBoxCam.Location.Y ==75)
            {
                pictureBox2.Visible = false;
                pictureBoxHide.Visible = false;
               // pictureBoxCam.Location = new Point(pictureBoxCam.Location.X, 75);
                timerCam.Stop();
                CamDelayStop();
            }
            //label.Left = label.Left + 10;
            //if (labelKnowledge.Location.X > this.Width)
            //{
            //    labelKnowledge.Location = new Point(0 - labelKnowledge.Width, labelKnowledge.Location.Y);
            //}
            //labelKnowledge.Left = labelKnowledge.Left+10;
        }

        private void pictureBoxPic_Click(object sender, EventArgs e)
        {

        }

        

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //saveFileDialogPic.InitialDirectory = @"UserImage";

            

           // saveFileDialogPic.InitializeLifetimeService();
           // string str = saveFileDialogPic.InitializeLifetimeService().ToString();
           // MessageBox.Show(str);

            if (saveFileDialogPic.ShowDialog() == DialogResult.OK)
            {


                    pictureBoxPic.Image.Save(saveFileDialogPic.FileName);
                

            }
        }

       
        
        
      
        
          




        //public void solveStatusNull()
        //{
        //    // step 1: Create a connection
        //    var result = Path.GetFullPath("InformationDatabase.mdf");
        //    string strConnection = "Data Source=.\\sqlexpress;AttachDbFilename=" + result + ";User Instance=true; Integrated Security=True;Pooling=False;MultipleActiveResultSets=true";
        //    SqlConnection objConnection = new SqlConnection(strConnection);
        //    objConnection.Open();

        //    // step 2: fire a command

        //    string userInputID = textBoxUserName.Text;
        //    string strCommand = "select * from Question";
        //    SqlCommand objCommand = new SqlCommand(strCommand, objConnection);

        //    // objCommand.Parameters.Add(new SqlParameter("@useInputID", userInputID));
        //    // step 3: bind the result data with user interface

        //    SqlDataReader reader = objCommand.ExecuteReader();




        //    try
        //    {
        //        while (reader.Read())
        //        {

        //            int sName = reader.GetInt32(0);

        //            // MessageBox.Show(sName.ToString());
        //            string userID = textBoxUserName.Text;
        //            string statusNull = "Unsolved";

        //            string strCommand1 = "insert into Solve values( @userID , @QSN, @Status)";
        //            SqlCommand objCommand1 = new SqlCommand(strCommand1, objConnection);
        //            objCommand1.Parameters.Add(new SqlParameter("@userID", userID));
        //            objCommand1.Parameters.Add(new SqlParameter("@QSN", sName));
        //            objCommand1.Parameters.Add(new SqlParameter("@Status", statusNull));
        //            objCommand1.ExecuteNonQuery();
        //        }
        //        reader.Close();
        //        objConnection.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);

        //        objConnection.Close();

        //    }





        //}

       
    }
}

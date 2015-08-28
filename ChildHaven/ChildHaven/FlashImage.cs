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
    public partial class FlashImage : Form
    {
        int color_i = 2;
        string selectQuestionNoSystem = UserInformation.getOnlineOrOffline();

        public FlashImage()
        {
            InitializeComponent();

            this.BackColor = Color.Magenta;
            this.TransparencyKey = Color.Magenta;

            searchQuestionFromDatabase();

        }




        public void searchQuestionFromDatabase()
        {
            int QuestionSNo = 1;
            if (selectQuestionNoSystem == "Online")
            {
                QuestionSNo = InformationAnalysis.getQuestionNo();

            }
            else if (selectQuestionNoSystem == "Offline")
            {
                QuestionSNo = offlineInformationAnalysis.getQuestionNo();

            }

            


            // step 1: Create a connection
            var result = Path.GetFullPath("InformationDatabase.mdf");
            string strConnection = "Data Source=.\\sqlexpress;AttachDbFilename=" + result + ";User Instance=true;Integrated Security=True;Pooling=False";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();


            try
            {
                // step 2: fire a command

                string strCommand = "select PicURL from Question where QSN=" + QuestionSNo + "";
                SqlCommand objCommand = new SqlCommand(strCommand, objConnection);

                // step 3: bind the result data with user interface

                SqlDataReader reader = objCommand.ExecuteReader();

                reader.Read();

               

                byte[] img = (byte[])(reader[0]);
                MemoryStream ms = new MemoryStream(img);
                pictureBoxPic.Image = Image.FromStream(ms);

                


                objConnection.Close();
            }
            catch (Exception ex)
            {
                if (objConnection.State == ConnectionState.Open)
                    objConnection.Close();

               


            }

        }






        private void SplashScreen_Load(object sender, EventArgs e)
        {
          //  labelWelcome.Text = "Welcome\n  to  the\nKidzone!";

     //       labelWelcome.BackColor = System.Drawing.Color.Transparent;
       //     labelWelcome.Font = new Font(labelWelcome.Font.FontFamily, color_i);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         //   progressBar1.Increment(1);


            color_i = color_i + 1;

         //   labelWelcome.Font = new Font(labelWelcome.Font.FontFamily, color_i);



       /*    if (progressBar1.Value == 60)
            {
                labelWelcome.ForeColor = System.Drawing.Color.Navy;
                timer1.Stop();

            }
        */
        }

        private void FlashImage_Load(object sender, EventArgs e)
        {
            
        }



        
    }

   
}

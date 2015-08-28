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
    public partial class ObjectiveImageQuestion : Form
    {
        string user_Answer;
        string right_Answer;
        int point = 0;
        int QSN = 0;

        string OptionA;
        string OptionB;
        string OptionC;
        string OptionD;


        string selectQuestionNoSystem = UserInformation.getOnlineOrOffline();

       

        public ObjectiveImageQuestion()
        {
            InitializeComponent();

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

            QSN = QuestionSNo;


            // step 1: Create a connection
            var result = Path.GetFullPath("InformationDatabase.mdf");
            string strConnection = "Data Source=.\\sqlexpress;AttachDbFilename=" + result + ";User Instance=true;Integrated Security=True;Pooling=False";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();


            try
            {
                // step 2: fire a command

                string strCommand = "select * from Question where QSN=" + QuestionSNo + "";
                SqlCommand objCommand = new SqlCommand(strCommand, objConnection);

                // step 3: bind the result data with user interface

                SqlDataReader reader = objCommand.ExecuteReader();

                reader.Read();

                labelQSN.Text = reader[0].ToString();

                if (reader[2].ToString() == "NA")
                    label3.Text = "";
                else
                    label3.Text = reader[2].ToString();



                byte[] img = (byte[])(reader[3]);
                MemoryStream ms = new MemoryStream(img);
                pictureBoxPic.Image = Image.FromStream(ms);


                if (reader[6].ToString() == "NA")
                    richTextBoxDescription.Text = "";
                else
                    richTextBoxDescription.Text = reader[6].ToString();

                label2.Text = reader[7].ToString();

                labelOptionA.Text = reader[8].ToString();
                OptionA =  reader[8].ToString();
                labelOptionB.Text = reader[9].ToString();
                OptionB =  reader[9].ToString();
                labelOptionC.Text = reader[10].ToString();
                OptionC =  reader[10].ToString();
                labelOptionD.Text = reader[11].ToString();
                OptionD =  reader[11].ToString();

                right_Answer = reader[12].ToString();

                objConnection.Close();
            }
            catch (Exception ex)
            {
                if (objConnection.State == ConnectionState.Open)
                    objConnection.Close();

               // MessageBox.Show(ex.Message);


            }

        }









        private void ObjectiveImageQuestion_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (selectQuestionNoSystem == "Online")
            {
                this.Hide();

                InformationAnalysis ia = new InformationAnalysis();

                ia.nextForm();
            }
            else if (selectQuestionNoSystem == "Offline")
            {
                this.Hide();

                offlineInformationAnalysis oia = new offlineInformationAnalysis();

                oia.nextForm();
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (selectQuestionNoSystem == "Online")
            {
                this.Hide();

                InformationAnalysis ia = new InformationAnalysis();

                ia.previousForm();
            }
            else if (selectQuestionNoSystem == "Offline")
            {
                this.Hide();

                offlineInformationAnalysis oia = new offlineInformationAnalysis();

                oia.previousForm();
            }



        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

            if (selectQuestionNoSystem == "Online")
            {
                if (radioButtonOptionA.Checked)
                {
                    user_Answer = OptionA.ToLower().Replace(" ", "");
                }
                else if (radioButtonOptionB.Checked)
                {
                    user_Answer = OptionB.ToLower().Replace(" ", "");
                }
                else if (radioButtonOptionC.Checked)
                {
                    user_Answer = OptionC.ToLower().Replace(" ", "");
                }
                else if (radioButtonOptionD.Checked)
                {
                    user_Answer = OptionD.ToLower().Replace(" ", "");
                }
                else
                {
                    user_Answer = "";
                }

                //user_Answer = textBoxAnswer.Text.ToLower().Replace(" ", "");
                right_Answer = right_Answer.ToLower().Replace(" ", "");


                if (user_Answer == right_Answer)
                {
                    point = 5;
                    UserInformation.setQuestionNO(QSN);
                    makeSolve.makeSolveStatus();
                }
                else if (user_Answer == "")
                {
                    point = 0;
                }
                else if (user_Answer != right_Answer)
                {
                    point = -2;
                }

                this.Hide();

                InformationAnalysis ia = new InformationAnalysis();

                ia.removeForm(point);
            }

            else if (selectQuestionNoSystem == "Offline")
            {
                if (radioButtonOptionA.Checked)
                {
                    user_Answer = OptionA.ToLower().Replace(" ", "");
                }
                else if (radioButtonOptionB.Checked)
                {
                    user_Answer = OptionB.ToLower().Replace(" ", "");
                }
                else if (radioButtonOptionC.Checked)
                {
                    user_Answer = OptionC.ToLower().Replace(" ", "");
                }
                else if (radioButtonOptionD.Checked)
                {
                    user_Answer = OptionD.ToLower().Replace(" ", "");
                }
                else
                {
                    user_Answer = "";
                }

                //user_Answer = textBoxAnswer.Text.ToLower().Replace(" ", "");
                right_Answer = right_Answer.ToLower().Replace(" ", "");


                if (user_Answer == right_Answer)
                {
                    UserInformation.setQuestionNO(QSN);
                    makeSolve.makeSolveStatus();

                    MessageBox.Show("Right Answer!");

                    this.Hide();

                    offlineInformationAnalysis oia = new offlineInformationAnalysis();

                    oia.removeForm();
                }
                else if (user_Answer == "")
                {
                    MessageBox.Show("Answer is blank!");
                }
                else if (user_Answer != right_Answer)
                {
                    MessageBox.Show("Wrong Answer!!");
                }

               
            }

        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Question q = new Question();
            q.ShowDialog();

        }
    }
}

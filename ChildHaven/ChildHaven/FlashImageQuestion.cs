using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildHaven
{
    public partial class FlashImageQuestion : Form
    {
        string user_Answer1;
        string user_Answer2;
        string right_Answer1;
        string right_Answer2;
        int point = 0;
        int QSN = 0;
                

        string OptionA;
        string OptionB;
        string OptionC;
        string OptionD;
        string selectQuestionNoSystem = UserInformation.getOnlineOrOffline();

      


        public FlashImageQuestion()
        {

            InitializeComponent();

            searchQuestionFromDatabase();
            
        }




      




        public void searchQuestionFromDatabase()
        {
           

            int QuestionSNo=1;
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
                    labelUpperText.Text = "";
                else
                    labelUpperText.Text = reader[2].ToString();



                if (reader[6].ToString() == "NA")
                    richTextBoxDescription.Text = "";
                else
                    richTextBoxDescription.Text = reader[6].ToString();

                labelQuestion1.Text = reader[13].ToString();

               labelQuestion2.Text = reader[15].ToString();

                labelOptionA.Text = reader[16].ToString();
                labelOptionB.Text = reader[17].ToString();
                labelOptionC.Text = reader[18].ToString();
                labelOptionD.Text = reader[19].ToString();

                OptionA = reader[16].ToString();

                OptionB = reader[17].ToString();

                OptionC = reader[18].ToString();

                OptionD = reader[19].ToString();

                right_Answer1 = reader[14].ToString();
                right_Answer2 = reader[20].ToString();


                objConnection.Close();
            }
            catch (Exception ex)
            {
                if (objConnection.State == ConnectionState.Open)
                    objConnection.Close();

                // MessageBox.Show(ex.Message);


            }

        }






     

        



        

        private void FlashImageQuestion_Load(object sender, EventArgs e)
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

        private void buttonBack_Click(object sender, EventArgs e)
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
                user_Answer1 = textBoxAnswer.Text.ToLower().Replace(" ", "");
                right_Answer1 = right_Answer1.ToLower().Replace(" ", "");


                if (user_Answer1 == right_Answer1)
                {
                    point = 3;
                }
                else if (user_Answer1 == "")
                {
                    point = 0;
                }
                else if (user_Answer1 != right_Answer1)
                {
                    point = -1;
                }





                if (radioButtonOptionA.Checked)
                {
                    user_Answer2 = OptionA.ToLower().Replace(" ", "");
                }
                else if (radioButtonOptionB.Checked)
                {
                    user_Answer2 = OptionB.ToLower().Replace(" ", "");
                }
                else if (radioButtonOptionC.Checked)
                {
                    user_Answer2 = OptionC.ToLower().Replace(" ", "");
                }
                else if (radioButtonOptionD.Checked)
                {
                    user_Answer2 = OptionD.ToLower().Replace(" ", "");
                }
                else
                {
                    user_Answer2 = "";
                }

                //user_Answer = textBoxAnswer.Text.ToLower().Replace(" ", "");
                right_Answer2 = right_Answer2.ToLower().Replace(" ", "");


                if (user_Answer2 == right_Answer2)
                {
                    point = point + 2;
                }
                else if (user_Answer2 == "")
                {
                    point = point + 0;
                }
                else if (user_Answer2 != right_Answer2)
                {
                    point = point - 1;
                }

                if (user_Answer1 == right_Answer1 && user_Answer2 == right_Answer2)
                {

                    UserInformation.setQuestionNO(QSN);
                    makeSolve.makeSolveStatus();
                }

                this.Hide();

                InformationAnalysis ia = new InformationAnalysis();

                ia.removeForm(point);
            }



            else if (selectQuestionNoSystem == "Offline")
            {

                user_Answer1 = textBoxAnswer.Text.ToLower().Replace(" ", "");
                right_Answer1 = right_Answer1.ToLower().Replace(" ", "");


                if (radioButtonOptionA.Checked)
                {
                    user_Answer2 = OptionA.ToLower().Replace(" ", "");
                }
                else if (radioButtonOptionB.Checked)
                {
                    user_Answer2 = OptionB.ToLower().Replace(" ", "");
                }
                else if (radioButtonOptionC.Checked)
                {
                    user_Answer2 = OptionC.ToLower().Replace(" ", "");
                }
                else if (radioButtonOptionD.Checked)
                {
                    user_Answer2 = OptionD.ToLower().Replace(" ", "");
                }
                else
                {
                    user_Answer2 = "";
                }

                //user_Answer = textBoxAnswer.Text.ToLower().Replace(" ", "");
                right_Answer2 = right_Answer2.ToLower().Replace(" ", "");



                if (user_Answer1 == right_Answer1 && user_Answer2 == right_Answer2)
                {

                    UserInformation.setQuestionNO(QSN);
                    makeSolve.makeSolveStatus();

                    MessageBox.Show("Right Answer!");

                    this.Hide();

                    offlineInformationAnalysis oia = new offlineInformationAnalysis();

                    oia.removeForm();
                }
                else if (user_Answer1 != right_Answer1 && user_Answer2 != right_Answer2)
                {
                    MessageBox.Show("Both Wrong Answer!!");
                }
                else if (user_Answer1 != right_Answer1)
                {
                    MessageBox.Show("Question One's Answer is Wrong!");
                }
                else if (user_Answer2 != right_Answer2)
                {
                    MessageBox.Show("Question Twos's Answer is Wrong!");
                }





            }



        }

        private void groupBoxObjective_Enter(object sender, EventArgs e)
        {

        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Question q = new Question();
            q.ShowDialog();

        }
    
    



    
    }
}

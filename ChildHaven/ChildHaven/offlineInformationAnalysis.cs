using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildHaven
{
    class offlineInformationAnalysis
    {


        public static List<string> myForm = new List<string>();

        public static List<string> myQuestion = new List<string>();

        public static List<int> myQuestionNo = new List<int>();

        public static List<int> myQuestionNoTemp = new List<int>();


        public static List<string> unsolvedQuestion = new List<string>();
        public static List<string> str = new List<string>();

        public static int total_score = 0;

        bool Unsolved = false;
        bool All = false;

        public static int Form_track = 0;

        string userName = null;
        string QuizNo = null;

        string AllorUnsolved="";


        public static void makeMyQuestionNoTempNull()
        {

            
            myForm.Clear();
            myQuestion.Clear();
            myQuestionNo.Clear();
            myQuestionNoTemp.Clear();
            unsolvedQuestion.Clear();
            str.Clear();


        }





         public void selectQuestionNo()
        {

            try
            {

                // step 1: Create a connection

                var result = Path.GetFullPath("InformationDatabase.mdf");
                string strConnection = "Data Source=.\\sqlexpress;AttachDbFilename=" + result + ";User Instance=true;Integrated Security=True;Pooling=False;MultipleActiveResultSets=true";
                SqlConnection objConnection = new SqlConnection(strConnection);
                objConnection.Open();

                // step 2: fire a command
                string username = UserInformation.getUserName();
               // string quizno = onlineQuizSerialNo;


                AllorUnsolved = UserInformation.getAllorSolved();
               
                string strCommand = "";
                if (AllorUnsolved == "Unsolved")
                {

                    Unsolved = true;

                    strCommand = "SELECT QSN FROM Question EXCEPT SELECT QSN FROM Solve WHERE userID=@UN";

                   
                }
                else if (AllorUnsolved == "All")
                {
                    All = true;
                    strCommand = "SELECT QSN FROM Question";
                }
                SqlCommand objCommand = new SqlCommand(strCommand, objConnection);

               
                objCommand.Parameters.Add(new SqlParameter("@UN", username));

               
                // step 3: bind the result data with user interface

                SqlDataReader reader = objCommand.ExecuteReader();
                


                while(reader.Read())
                {
                   
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                      
                       unsolvedQuestion.Add( reader[i].ToString());
                    }
                }

               

                    reader.Close();
                objConnection.Close();


                if (unsolvedQuestion.Count == 0 &&   Unsolved == true)
                {
                    MessageBox.Show("You have no unsolved Questions!");
                    Unsolved = false;

                    Question q = new Question();
                    q.ShowDialog();
                }
                else if (unsolvedQuestion.Count == 0 && All == true)
                {
                    MessageBox.Show("Please Update Questions!\nDatabase is empty.");
                    All = false;
                    Question q = new Question();
                    q.ShowDialog();
               }


               makeValue(unsolvedQuestion);

            }
            catch (Exception ex)
            {

               
               
                
                    MessageBox.Show(ex.Message);
                

                Question q = new Question();
                q.ShowDialog();

                //MessageBox.Show(ex.Message);
            }

        }







         public void makeValue(List<string> QNo)
        {

            myQuestionNoTemp.Add(-5);
            try
            {

                for (int i = 0; i < QNo.Count; i++)
                {

                    myQuestion.Add(QNo[i]);

                }


                // step 1:
                var result = Path.GetFullPath("InformationDatabase.mdf");
                string strConnection = "Data Source=.\\sqlexpress;AttachDbFilename=" + result + ";User Instance=true;Integrated Security=True;Pooling=False";
                SqlConnection objConnection = new SqlConnection(strConnection);
                objConnection.Open();


                for (int i = 0; i < QNo.Count; i++)
                {

                    int j = int.Parse(QNo[i]);
                    string strCommand = "select QuestionType from Question where QSN=" + j + "";
                    SqlCommand objCommand = new SqlCommand(strCommand, objConnection);




                    SqlDataReader reader = objCommand.ExecuteReader();


                    // myFormTemp.Enqueue(reader[0].ToString());

                    reader.Read();

                    var nextItem = reader[0].ToString();

                    reader.Close();
                    // MessageBox.Show(nextItem.ToString());

                    if (nextItem == "Picture Question")
                    {
                        // PictureQuestion pq = new PictureQuestion();
                        // myForm.Add(pq);
                        myForm.Add(nextItem);
                        myQuestionNo.Add(j);

                    }
                    else if (nextItem == "Picture Question Objective Type")
                    {
                        // ObjectiveImageQuestion oiq = new ObjectiveImageQuestion();
                        // myForm.Add(oiq);
                        myForm.Add(nextItem);
                        myQuestionNo.Add(j);
                    }
                    else if (nextItem == "Normal Question")
                    {
                        // NormalQuestion nq = new NormalQuestion();
                        //myForm.Add(nq);
                        myForm.Add(nextItem);
                        myQuestionNo.Add(j);
                    }
                    else if (nextItem == "Normal Question Objective Type")
                    {
                        // NormalObjectiveQuestion noq = new NormalObjectiveQuestion();
                        // myForm.Add(noq);
                        myForm.Add(nextItem);
                        myQuestionNo.Add(j);
                    }
                    else if (nextItem == "Descriptive Question (No Image)")
                    {
                        //  MathNormalQuestion mnq = new MathNormalQuestion();
                        //myForm.Add(mnq);
                        myForm.Add(nextItem);
                        myQuestionNo.Add(j);
                    }
                    else if (nextItem == "Descriptive Question Objective Type (No Image)")
                    {
                        //  MathObjectiveQuestion moq = new MathObjectiveQuestion();
                        // myForm.Add(moq);
                        myForm.Add(nextItem);
                        myQuestionNo.Add(j);
                    }

                    else if (nextItem == "Flash Question")
                    {

                        // FlashImageQuestion fiq = new FlashImageQuestion();
                        //myForm.Add(fiq);
                        myForm.Add(nextItem);
                        myQuestionNo.Add(j);



                    }



                }
                objConnection.Close();



                /*  for (int i = 0; i < QNo.Length; i++)
                  {
                      Form newForm = myForm[i];
                      newForm.Show();

                  }*/


                Form_track = -1;
                total_score = 0;
                nextForm();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);



                Question q = new Question();
                q.ShowDialog();
            }



        }






       public void nextForm()
        {

            Form_track = Form_track + 1;


            if (Form_track >= myForm.Count)
            {
                // MessageBox.Show("if: " + (Form_track+1).ToString());
                Form_track = 0;
                callForm();
            }
            else
            {
                // MessageBox.Show("else: " + (Form_track + 1).ToString());
                callForm();
            }


        }





        public void previousForm()
        {

            Form_track = Form_track - 1;

            if (Form_track < 0)
            {
                Form_track = myForm.Count - 1;
                callForm();
            }
            else
            {
                callForm();
            }


        }


        public void removeForm()
        {

            ///total_score = total_score + point;

            myForm.RemoveAt(Form_track);

            myQuestionNo.RemoveAt(Form_track);

            if (myForm.Count == 0)
            {

                Question q = new Question();
                q.ShowDialog();
            }
            else if (Form_track >= myForm.Count)
            {
                Form_track = 0;
                callForm();
            }
            else
            {
                callForm();
            }



        }


  /*      public static int getResult()
        {
            return total_score;
        }
   */

        public static int getQuestionNo()
        {
            return myQuestionNo[Form_track];
        }



         public void callForm()
        {

            // MessageBox.Show(myQuestionNo[Form_track].ToString());


            if (myForm[Form_track] == "Picture Question")
            {
                
                PictureQuestion pq = new PictureQuestion();
                pq.ShowDialog();

            }
            else if (myForm[Form_track] == "Picture Question Objective Type")
            {
                
                ObjectiveImageQuestion oiq = new ObjectiveImageQuestion();
                oiq.ShowDialog();
            }
            else if (myForm[Form_track] == "Normal Question")
            {
                
                NormalQuestion nq = new NormalQuestion();
                nq.ShowDialog();
            }
            else if (myForm[Form_track] == "Normal Question Objective Type")
            {
                
                NormalObjectiveQuestion noq = new NormalObjectiveQuestion();
                noq.ShowDialog();
            }
            else if (myForm[Form_track] == "Descriptive Question (No Image)")
            {
                
                MathNormalQuestion mnq = new MathNormalQuestion();
                mnq.ShowDialog();
            }
            else if (myForm[Form_track] == "Descriptive Question Objective Type (No Image)")
            {
                
                MathObjectiveQuestion moq = new MathObjectiveQuestion();
                moq.ShowDialog();
            }

            else if (myForm[Form_track] == "Flash Question")
            {
                try
                {
                    int result = myQuestionNoTemp.Find(item => item == myQuestionNo[Form_track]);

                    //  MessageBox.Show(result.ToString()+" Qn: "+myQuestionNo[Form_track].ToString());

                    if (result == myQuestionNo[Form_track])
                    {
                       
                        FlashImageQuestion fiq = new FlashImageQuestion();
                        fiq.ShowDialog();
                    }
                    else
                    {
                        
                        myQuestionNoTemp.Add(myQuestionNo[Form_track]);
                        FlashImageQuestionInstruction fiqi = new FlashImageQuestionInstruction();
                        fiqi.ShowDialog();

                    }

                }

                catch (Exception)
                {
                    myQuestionNoTemp.Add(myQuestionNo[Form_track]);

                    FlashImageQuestionInstruction fiqi = new FlashImageQuestionInstruction();
                    fiqi.ShowDialog();


                }
            }


        }




    }
}

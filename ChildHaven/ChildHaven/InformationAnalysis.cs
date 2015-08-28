using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ChildHaven
{
    class InformationAnalysis
    {

    //  public static List<Form> myForm = new List<Form>();

      public static List<string> myForm = new List<string>();

      public static List<string> myQuestion = new List<string>();

      public static List<int> myQuestionNo = new List<int>();

      public static List<int> myQuestionNoTemp = new List<int>();

      public static int total_score = 0;


      public static int Form_track=0;

      string userName = null;
      string QuizNo = null;



      public static void makeMyQuestionNoTempNull()
      {

          myForm.Clear();
          myQuestion.Clear();
          myQuestionNo.Clear();
          myQuestionNoTemp.Clear();
         
              
          
      }

        
        public void makeValue(string[] QNo)
       {

           myQuestionNoTemp.Add(-5);
           try
           {
           
               for (int i = 0; i < QNo.Length; i++)
               {
               
                   myQuestion.Add(QNo[i]);

               }


               // step 1:
               var result = Path.GetFullPath("InformationDatabase.mdf");
               string strConnection = "Data Source=.\\sqlexpress;AttachDbFilename=" + result + ";User Instance=true;Integrated Security=True;Pooling=False";
               SqlConnection objConnection = new SqlConnection(strConnection);
               objConnection.Open();


               for (int i = 0; i < QNo.Length; i++)
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


         public void removeForm(int point)
         {

             total_score = total_score + point;

             myForm.RemoveAt(Form_track);

             myQuestionNo.RemoveAt(Form_track);

             if (myForm.Count == 0)
             {
                
                 makeIndividualOnlineQuizTracker();
                 TestForm tf = new TestForm();
                 tf.ShowDialog();
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


         public static int getResult()
         {
             return total_score;
         }

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




         


         public void makeIndividualOnlineQuizTracker()
         {
            

             try
             {
                 userName = UserInformation.getUserName();
                 QuizNo = UserInformation.getQuizNo();

                
                     
                     // step 1: Create a connection
                     var result = Path.GetFullPath("InformationDatabase.mdf");
                     string strConnection = "Data Source=.\\sqlexpress;AttachDbFilename=" + result + ";User Instance=true; Integrated Security=True;Pooling=False;MultipleActiveResultSets=true";
                     SqlConnection objConnection = new SqlConnection(strConnection);
                     objConnection.Open();



                     string strCommand = "insert into IndividualOnlineQuizTracker values( @QN , @UN )";



                     SqlCommand objCommand = new SqlCommand(strCommand, objConnection);


                    

                     objCommand.Parameters.Add(new SqlParameter("@QN", QuizNo));

                     objCommand.Parameters.Add(new SqlParameter("@UN", userName));


                     objCommand.ExecuteNonQuery();
                     objConnection.Close();

                    
             }
             catch (Exception ex)
             {

                 MessageBox.Show(ex.Message);
             }
         }



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildHaven
{
    public partial class RulesAndRegulations : Form
    {
        WebClient info = new WebClient();
        WebClient text = new WebClient();
        WebClient img = new WebClient();

        

        string onlineQuizSerialNo;
        string TotalQuestionNo;
         Queue<string> QuestionText = new Queue<string>();
         Queue<string> QuestionImage = new Queue<string>();

         Queue<string> QuestionTextTemp = new Queue<string>();
         Queue<string> QuestionImageTemp = new Queue<string>();



        string[] datalines = new string[100];
        int unique_i = 0;
        bool unique_QSN = false;
        bool unique_QuizNo = false;
        bool fileDownloadChecker = false;
        bool[] unique_QSN_databse = Enumerable.Repeat(false, 20).ToArray();

         int QuestionSerialNo;
         string QuestionType;
         string UpperText;
         string pic;
         string audio;
         string video;
         string Description;
         string MainQuestion;
         string MQOptionA;
         string MQOptionB;
         string MQOptionC;
         string MQOptionD;
         string MQAnswer;
         string Question1;
         string Q1Answer;
         string Question2;
         string Q2OptionA;
         string Q2OptionB;
         string Q2OptionC;
         string Q2OptionD;
         string Q2Answer;



        public RulesAndRegulations()
        {
            
            InitializeComponent();
            buttonGetReady.Visible = false;
           
        }

        











        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGetReady_Click(object sender, EventArgs e)
        {
            UserInformation.setOnlineOrOffline("Online");
            InformationAnalysis.makeMyQuestionNoTempNull();
           
            string[] myQuestion = new string[int.Parse(TotalQuestionNo)];

            int j = 0;
            for (int i = 2; i <= int.Parse(TotalQuestionNo) + 1; i++, j++)
            {
                myQuestion[j] = datalines[i];
            }


            directoryDelete();

            this.Hide();

            UserInformation.setQuizNo(onlineQuizSerialNo);

            InformationAnalysis ia = new InformationAnalysis();
           
            ia.makeValue(myQuestion);


        }


      private void RulesAndRegulations_Load(object sender, EventArgs e)
        {

            this.Visible = true;
            label1.Visible = true;
            Application.DoEvents();

            downloadQuestion();
            

        }


      



      public void downloadQuestion()
      {
          
          directoryChecker();  // To make a temporary folder named "Online Question" for the downloaded iteams


          informationDownload(); // To download information.txt
        

          
            informationFileAnalysis();

            OnetimeQuizChecker();

            if (fileDownloadChecker == false)
            {
                QuestionTextDownload();


                QuestionImageDownload();

                insertDataBase();
                insertDBOnlineQuizTrack();
            }

          //  label1.Text = "          Download Completed!";

            buttonGetReady.Visible = true;

            Application.DoEvents();
           

      }



      public void directoryDelete()
      {


          DirectoryInfo di = new DirectoryInfo("Online Question");
          if (Directory.Exists("Online Question"))
          {
              di.Delete(true);
          }

      }

        public void OnetimeQuizChecker()
        {


            try
            {

                // step 1: Create a connection

                var result = Path.GetFullPath("InformationDatabase.mdf");
                string strConnection = "Data Source=.\\sqlexpress;AttachDbFilename=" + result + ";User Instance=true;Integrated Security=True;Pooling=False";
                SqlConnection objConnection = new SqlConnection(strConnection);
                objConnection.Open();

                // step 2: fire a command
                string username = UserInformation.getUserName();
                string quizno = onlineQuizSerialNo;
                string strCommand = "select QuizNo, userID from IndividualOnlineQuizTracker where QuizNo=@QN and userID=@UI";
                SqlCommand objCommand = new SqlCommand(strCommand, objConnection);

                objCommand.Parameters.Add(new SqlParameter("@QN", quizno));
                objCommand.Parameters.Add(new SqlParameter("@UI", username));


                // step 3: bind the result data with user interface

                SqlDataReader reader = objCommand.ExecuteReader();


                if (reader.Read())
                {
                    MessageBox.Show("You participated this quiz once! \n Please wait for the next round..");

                    this.Hide();
                    Question q = new Question();
                    q.ShowDialog();

                }
                else
                { 
                
                }



                reader.Close();
                objConnection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }





        }



      public void insertDBOnlineQuizTrack()
      {

          // step 1: Create a connection
          var result = Path.GetFullPath("InformationDatabase.mdf");
          string strConnection = "Data Source=.\\sqlexpress;AttachDbFilename=" + result + ";User Instance=true; Integrated Security=True;Pooling=False;MultipleActiveResultSets=true";
           SqlConnection objConnection = new SqlConnection(strConnection);
          objConnection.Open();


          string strCommand = "insert into OnlineQuizTrack values( @QN , @TQN, @Q )";



          SqlCommand objCommand = new SqlCommand(strCommand, objConnection);

         string totalQuestionSet=null;

           for (int i = 2; i <= int.Parse(TotalQuestionNo) + 1; i++)
                   {
                      if(i!=int.Parse(TotalQuestionNo)+1)
                      totalQuestionSet = totalQuestionSet+datalines[i] +",";

                      else
                          totalQuestionSet = totalQuestionSet+datalines[i];
                    }
         // MessageBox.Show(totalQuestionSet);


          objCommand.Parameters.Add(new SqlParameter("@QN",onlineQuizSerialNo ));
          objCommand.Parameters.Add(new SqlParameter("@TQN", int.Parse(TotalQuestionNo) ));
          objCommand.Parameters.Add(new SqlParameter("@Q", totalQuestionSet));
          

          objCommand.ExecuteNonQuery();
          objConnection.Close();

      }



      public void insertDataBase()
      {

          // step 1: Create a connection
          //   var result = Path.GetFullPath("InformationDatabase.mdf");
          //   string strConnection = "Data Source=(LocalDB)\v11.0;AttachDbFilename="+result+";Integrated Security=True";

          var result = Path.GetFullPath("InformationDatabase.mdf");
          string strConnection = "Data Source=.\\sqlexpress;AttachDbFilename=" + result + ";User Instance=true; Integrated Security=True;Pooling=False;MultipleActiveResultSets=true";

          //  string strConnection = "Data Source=.\\sqlexpress;Initial Catalog=CustomerDatabase;Integrated Security=True;Pooling=False";
          SqlConnection objConnection = new SqlConnection(strConnection);
          objConnection.Open();


          for (int i = 2; i <= int.Parse(TotalQuestionNo) + 1; i++)
          {
              
              if (unique_QSN_databse[i] == true)
              {
                  try
                  {
                      string stri = datalines[i];

                     

                      string[] QuestionDataPro = new string[100];


                      string[] lines = System.IO.File.ReadAllLines(@"Online Question\" + stri + ".txt");

                      for (int idx = 0; idx < lines.Count(); idx++)
                      {
                          

                          if (lines[idx] == "QSNo:")
                          {
                              idx = idx + 1;
                              QuestionSerialNo = int.Parse(lines[idx]);
                              // MessageBox.Show(QuestionSerialNo.ToString());
                              continue;
                          }

                          else if (lines[idx] == "QuestionType:")
                          {
                              idx = idx + 1;
                              QuestionType = lines[idx];
                              //       MessageBox.Show(QuestionType);
                              continue;
                          }

                          else if (lines[idx] == "UpperText:")
                          {
                              idx = idx + 1;
                              UpperText = lines[idx];
                              //  MessageBox.Show(UpperText);
                              continue;
                          }

                          else if (lines[idx] == "PicURL:")
                          {
                              idx = idx + 1;
                              pic = lines[idx];
                              //  MessageBox.Show(pic);
                              continue;
                          }

                          else if (lines[idx] == "AudioURL:")
                          {
                              idx = idx + 1;
                              audio = lines[idx];
                              //   MessageBox.Show(audio);
                              continue;
                          }
                          else if (lines[idx] == "VideoURL:")
                          {
                              idx = idx + 1;
                              video = lines[idx];
                              //   MessageBox.Show(video);
                              continue;
                          }
                          else if (lines[idx] == "Description:")
                          {
                              idx = idx + 1;
                              Description = lines[idx];
                              //    MessageBox.Show(Description);
                              continue;
                          }
                          else if (lines[idx] == "MainQuestion:")
                          {
                              idx = idx + 1;
                              MainQuestion = lines[idx];
                              //    MessageBox.Show(MainQuestion);
                              continue;
                          }
                          else if (lines[idx] == "MainQuestionOption:")
                          {
                              idx = idx + 1;
                              MQOptionA = lines[idx];
                              //    MessageBox.Show(MQOptionA);
                              idx = idx + 1;
                              MQOptionB = lines[idx];
                              //    MessageBox.Show(MQOptionB);
                              idx = idx + 1;
                              MQOptionC = lines[idx];
                              //     MessageBox.Show(MQOptionC);
                              idx = idx + 1;
                              MQOptionD = lines[idx];
                              //     MessageBox.Show(MQOptionD);
                              continue;
                          }
                          else if (lines[idx] == "MainQuestionAnswer:")
                          {
                              idx = idx + 1;
                              MQAnswer = lines[idx];
                              //      MessageBox.Show(MQAnswer);
                              continue;
                          }
                          else if (lines[idx] == "Question1:")
                          {
                              idx = idx + 1;
                              Question1 = lines[idx];
                              //    MessageBox.Show(Question1);
                              continue;
                          }
                          else if (lines[idx] == "Question1Answer:")
                          {
                              idx = idx + 1;
                              Q1Answer = lines[idx];
                              //     MessageBox.Show(Q1Answer);
                              continue;
                          }
                          else if (lines[idx] == "Question2:")
                          {
                              idx = idx + 1;
                              Question2 = lines[idx];
                              //     MessageBox.Show(Question2);
                              continue;
                          }
                          else if (lines[idx] == "Question2Option:")
                          {
                              idx = idx + 1;
                              Q2OptionA = lines[idx];
                              //      MessageBox.Show(Q2OptionA);
                              idx = idx + 1;
                              Q2OptionB = lines[idx];
                              //       MessageBox.Show(Q2OptionB);
                              idx = idx + 1;
                              Q2OptionC = lines[idx];
                              //       MessageBox.Show(Q2OptionC);
                              idx = idx + 1;
                              Q2OptionD = lines[idx];
                              //      MessageBox.Show(Q2OptionD);
                              continue;
                          }
                          else if (lines[idx] == "Question2Answer:")
                          {
                              idx = idx + 1;
                              Q2Answer = lines[idx];
                              //       MessageBox.Show(Q2Answer);
                              continue;
                          }
                          idx++;

                      }





                     



                      // step 2: fire a command
                      //string str2Command = "insert into CustomerTable values('" + QuestionSerialNo + "', '" + audio + "', '" + audio + "', '" + audio + "', '" + audio + "')";

                      byte[] img = null;
                      if (pic != "NA")
                      {
                          
                          FileStream fs = new FileStream("Online Question//" + pic + ".jpg", FileMode.Open, FileAccess.Read);
                        
                          BinaryReader br = new BinaryReader(fs);
                          img = br.ReadBytes((int)fs.Length);
                          fs.Close();
                      }
                      else
                      {

                          FileStream fs = new FileStream("blanktt.bmp", FileMode.Open, FileAccess.Read);
                          BinaryReader br = new BinaryReader(fs);
                          img = br.ReadBytes((int)fs.Length);
                          fs.Close();
                      }


                   

                      string strCommand = "insert into Question values('" + QuestionSerialNo + "' , @QuestionType , @UpperText, @img , @audio , @video , @Description , @MainQuestion , @MQOptionA , @MQOptionB , @MQOptionC , @MQOptionD , @MQAnswer , @Question1 , @Q1Answer , @Question2 , @Q2OptionA , @Q2OptionB , @Q2OptionC , @Q2OptionD , @Q2Answer )";
                      
                  
                      
                      SqlCommand objCommand = new SqlCommand(strCommand, objConnection);
                      
                  
                      
                      objCommand.Parameters.Add(new SqlParameter("@QuestionType", QuestionType));
                      objCommand.Parameters.Add(new SqlParameter("@UpperText", UpperText));

                    

                      objCommand.Parameters.Add(new SqlParameter("@img", img));
                      objCommand.Parameters.Add(new SqlParameter("@audio", audio));
                      objCommand.Parameters.Add(new SqlParameter("@video", video));
                      objCommand.Parameters.Add(new SqlParameter("@Description", Description));


                      objCommand.Parameters.Add(new SqlParameter("@MainQuestion", MainQuestion));
                      objCommand.Parameters.Add(new SqlParameter("@MQOptionA", MQOptionA));
                      objCommand.Parameters.Add(new SqlParameter("@MQOptionB", MQOptionB));
                      objCommand.Parameters.Add(new SqlParameter("@MQOptionC", MQOptionC));
                      objCommand.Parameters.Add(new SqlParameter("@MQOptionD", MQOptionD));
                      objCommand.Parameters.Add(new SqlParameter("@MQAnswer", MQAnswer));

                      objCommand.Parameters.Add(new SqlParameter("@Question1", Question1));
                      objCommand.Parameters.Add(new SqlParameter("@Q1Answer", Q1Answer));


                      objCommand.Parameters.Add(new SqlParameter("@Question2", Question2));
                      objCommand.Parameters.Add(new SqlParameter("@Q2OptionA", Q2OptionA));
                      objCommand.Parameters.Add(new SqlParameter("@Q2OptionB", Q2OptionB));
                      objCommand.Parameters.Add(new SqlParameter("@Q2OptionC", Q2OptionC));
                      objCommand.Parameters.Add(new SqlParameter("@Q2OptionD", Q2OptionD));
                      objCommand.Parameters.Add(new SqlParameter("@Q2Answer", Q2Answer));

                  

                      objCommand.ExecuteNonQuery();

                     
                  }
                  catch (Exception ex)
                  {
                      MessageBox.Show(ex.Message);
                      break;
                   //   i = i - 1;
                  }
              }

              

          }


          // step 4: close the connection
          objConnection.Close();

      }





      public void QuestionImageDownload()
      {
          

          while (QuestionImage.Any())
          {
              
                  var nextItem = QuestionImage.Dequeue();
                  var nextItemtemp = QuestionImageTemp.Dequeue();


                  //   var webClient = new WebClient();
                  //  webClient.DownloadStringCompleted += OnGetDownloadedStringCompleted;
                  //  webClient.DownloadStringAsync(new Uri(nextItem));


                  img.DownloadFileCompleted += new AsyncCompletedEventHandler(imgFileDownloadComplete);
                  Uri imgurl = new Uri(nextItem);

                  img.DownloadFileAsync(imgurl, nextItemtemp);

                  while (img.IsBusy)
                  {
                      System.Threading.Thread.Sleep(200);
                  }

                 

                //  return;

                 
              
          }


      }




     





      private void imgFileDownloadComplete(object sender, AsyncCompletedEventArgs e)
      {



          if (e.Error != null)
          {
              MessageBox.Show("Problem while Downloading!\nOr no internet connection..");



              this.Hide();
              Question q = new Question();
              q.ShowDialog();

          }
       
          QuestionImageDownload();

      }















      public void QuestionTextDownload()
      {
         
          while(QuestionText.Any())
          {
              var nextItem = QuestionText.Dequeue();
              var nextItemtemp = QuestionTextTemp.Dequeue();
              //   var webClient = new WebClient();
              //  webClient.DownloadStringCompleted += OnGetDownloadedStringCompleted;
              //  webClient.DownloadStringAsync(new Uri(nextItem));

              text.DownloadFileCompleted += new AsyncCompletedEventHandler(textFileDownloadComplete);
              Uri texturl = new Uri(nextItem);

              //myWebClient.DownloadFile(myStringWebResource,fileName);	
              text.DownloadFileAsync(texturl, nextItemtemp);

              while (text.IsBusy)
              {
                  System.Threading.Thread.Sleep(300);
              }

              //return;
          }
      }

  




      private void textFileDownloadComplete(object sender, AsyncCompletedEventArgs e)
      {
          
          

          if (e.Error != null)
          {
              MessageBox.Show("Problem while Downloading!\nOr no internet connection..");

             

              this.Hide();
              Question q = new Question();
              q.ShowDialog();

          }
        
          QuestionTextDownload();

      }











        public void informationFileAnalysis()
        {

            try
            {
                 datalines = System.IO.File.ReadAllLines(@"Online Question\information.txt");

                onlineQuizSerialNo = datalines[0];
                TotalQuestionNo = datalines[1];

                unique_QuizNo = false;
               QuestionSetExistance();

               if (unique_QuizNo == true)
               {

                   for (int i = 2; i <= int.Parse(TotalQuestionNo) + 1; i++)
                   {
                       fileDownloadChecker = false;
                       unique_i = i;
                       uniqueQSNChecker();
                       if (unique_QSN == true)
                       {
                           unique_QSN_databse[i] = true;
                           QuestionText.Enqueue("file:///E:/kidzone/OnlineExamQuestion/TextFile/" + datalines[i] + ".txt");
                           QuestionTextTemp.Enqueue("Online Question\\" + datalines[i] + ".txt");


                           QuestionImage.Enqueue("file:///E:/kidzone/OnlineExamQuestion/ImageFile/" + datalines[i] + ".jpg");

                           QuestionImageTemp.Enqueue("Online Question\\" + datalines[i] + ".jpg");

                       }

                   }
               }
               else
               {
                   fileDownloadChecker = true; 
               }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        /*    
           MessageBox.Show(onlineQuizSerialNo);
            MessageBox.Show(TotalQuestionNo);

            for (int i = 2; i <= int.Parse(TotalQuestionNo)+1; i++)
            {
                var t = QuestionText.Dequeue();
                MessageBox.Show(t.ToString());
                var tt = QuestionTextTemp.Dequeue();
                MessageBox.Show(tt.ToString());
                
            } */

        }



        public void QuestionSetExistance()
        {

            // step 1: Create a connection

            var result = Path.GetFullPath("InformationDatabase.mdf");
            string strConnection = "Data Source=.\\sqlexpress;AttachDbFilename=" + result + ";User Instance=true;Integrated Security=True;Pooling=False";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();

            // step 2: fire a command
            string i = onlineQuizSerialNo;
            string strCommand = "select QuizNo from OnlineQuizTrack where QuizNo=" + i + "";
            SqlCommand objCommand = new SqlCommand(strCommand, objConnection);

            // step 3: bind the result data with user interface

            SqlDataReader reader = objCommand.ExecuteReader();


            if (reader.Read())
            {

                string j = reader[0].ToString();

                if (j == i)
                {
                    unique_QuizNo = false;
                }
                else
                    unique_QuizNo = true;
            }
            else
                unique_QuizNo = true;

            reader.Close();
            objConnection.Close();



        }




        public void uniqueQSNChecker()
        {

            // step 1: Create a connection

            //var result = Path.GetFullPath("InformationDatabase.mdf");
            //string strConnection = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\\Users\\Tazim\\Desktop\\MyWork\\Project\\WorkForChild\\ChildHaven\\ChildHaven\\bin\\Debug\\InformationDatabase.mdf;Integrated Security=True;Connect Timeout=30";

            var result = Path.GetFullPath("InformationDatabase.mdf");
           // MessageBox.Show(result);

            string strConnection = "Data Source=.\\sqlexpress;AttachDbFilename=" + result + ";User Instance=true;Integrated Security=True;Pooling=False";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();
            // step 2: fire a command
            int i = int.Parse(datalines[unique_i]);
            string strCommand = "select QSN from Question where QSN=" + i + "";
            SqlCommand objCommand = new SqlCommand(strCommand, objConnection);

            // step 3: bind the result data with user interface

            SqlDataReader reader = objCommand.ExecuteReader();


            if (reader.Read())
            {

                int j = int.Parse(reader[0].ToString());

                if (j == i)
                {
                    unique_QSN = false;
                }
                else
                    unique_QSN = true;
            }
            else
                unique_QSN = true;

            reader.Close();
            objConnection.Close();

        }





        
        public void informationDownload()
        {


            info.DownloadFileCompleted += new AsyncCompletedEventHandler(infoFileDownloadComplete);
            Uri infoURL = new Uri("file:///E:/kidzone/OnlineExamQuestion/information.txt");

            info.DownloadFileAsync(infoURL, "Online Question\\information.txt");

            while (info.IsBusy)
            {
                System.Threading.Thread.Sleep(400);
            }
           
        }

      
        
        
        private void infoFileDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {



            if (e.Error != null)
            {
                MessageBox.Show("Problem while Downloading!\nOr no internet connection..");

                
                this.Hide();
                Question q = new Question();
                q.ShowDialog();
            }

            
        }

   
        
        
        
        
        
        public void directoryChecker()
        {
           

            DirectoryInfo di = new DirectoryInfo("Online Question");
            if (Directory.Exists("Online Question"))
            {
                          di.Delete(true);
            }


            //tring[] fileNames = Directory.GetFiles(@"your directory path");
            //foreach (string fileName in fileNames)
            //  File.Delete(fileName);


          
            var dir = @"Online Question";  // folder location

            if (!Directory.Exists(dir))  // if it doesn't exist, create
                Directory.CreateDirectory(dir);

        }

        private void buttonDownload_Click(object sender, EventArgs e)
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

       
        



    }
}

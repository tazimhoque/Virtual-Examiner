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
    public partial class UpdateInformation : Form
    {

        WebClient info = new WebClient();
        WebClient text = new WebClient();
        WebClient img = new WebClient();


        string[] datalines = new string[500];

        string TotalQuestionNo;

        int unique_i = 0;
        int questionCounter = 0;
        int questionQuantity = 0;


        bool unique_QSN = false;
        bool unique_QuizNo = false;
        bool fileDownloadChecker = false;

        bool[] unique_QSN_databse = Enumerable.Repeat(false, 500).ToArray();




        Queue<string> QuestionText = new Queue<string>();
        Queue<string> QuestionImage = new Queue<string>();

        Queue<string> QuestionTextTemp = new Queue<string>();
        Queue<string> QuestionImageTemp = new Queue<string>();










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







        public UpdateInformation()
        {
            InitializeComponent();


        }




        private void UpdateInformation_Load(object sender, EventArgs e)
        {

            startWorking();

        }


        public void startWorking()
        {

            labelTotalUpdate.Text = "Checking for Updates.....";
            makeFalse();

            Application.DoEvents();

            directoryChecker();
            informationDownload();
            informationFileAnalysis();
            showInformation();
            Application.DoEvents();

        }


        public void showInformation()
        {
            if (questionCounter == 0)
            {
                labelTotalUpdate.Text = "No new updates are available!";

                buttonLimitedDownload.Visible = false;
                buttonDownloadAll.Visible = false;

                Application.DoEvents();
            }
            else if (questionCounter == 1)
            {
                labelTotalUpdate.Text = "1 new update is available";
                buttonDownloadAll.Visible = true;
                buttonLimitedDownload.Visible = true;
            }
            else if (questionCounter > 1)
            {
                labelTotalUpdate.Text = questionCounter.ToString() + " new updates are available!";
                buttonDownloadAll.Visible = true;
                buttonLimitedDownload.Visible = true;
            }



            



        }


        public void informationFileAnalysis()
        {

            try
            {
                datalines = System.IO.File.ReadAllLines(@"Online Question\updateinfo.txt");


                TotalQuestionNo = datalines[0];



                questionCounter = 0;

                for (int i = 1; i <= int.Parse(TotalQuestionNo); i++)
                {

                    fileDownloadChecker = false;
                    unique_i = i;
                    uniqueQSNChecker();
                    if (unique_QSN == true)
                    {
                        questionCounter = questionCounter + 1;
                        unique_QSN_databse[i] = true;
                        QuestionText.Enqueue("file:///E:/kidzone/OnlineExamQuestion/TextFile/" + datalines[i] + ".txt");
                        QuestionTextTemp.Enqueue("Online Question\\" + datalines[i] + ".txt");


                        QuestionImage.Enqueue("file:///E:/kidzone/OnlineExamQuestion/ImageFile/" + datalines[i] + ".jpg");

                        QuestionImageTemp.Enqueue("Online Question\\" + datalines[i] + ".jpg");

                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }








        public void uniqueQSNChecker()
        {

            // step 1: Create a connection


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
            Uri infoURL = new Uri("file:///E:/kidzone/UpdateInfo/updateinfo.txt");

            info.DownloadFileAsync(infoURL, "Online Question\\updateinfo.txt");

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
                CrazyWorld cw = new CrazyWorld();
                cw.ShowDialog();
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





        public void makeFalse()
        {



            buttonRefresh.Visible = false;
            buttonDownload.Visible = false;
            buttonDownloadAll.Visible = false;
            buttonLimitedDownload.Visible = false;

            labelUpdateNumber.Visible = false;
            comboBoxUpdateNumber.Visible = false;
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








        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            CrazyWorld cw = new CrazyWorld();

            cw.ShowDialog();
        }





        private void buttonLimitedDownload_Click(object sender, EventArgs e)
        {
            buttonLimitedDownload.Visible = false;


            for (int i = 1; i <= questionCounter; i++)
            {

                comboBoxUpdateNumber.Items.Add(i.ToString());

            }

            buttonDownloadAll.Visible = false;

            labelUpdateNumber.Visible = true;
            comboBoxUpdateNumber.Visible = true;
            buttonRefresh.Visible = true;
            
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

            startWorking();

        }

        private void buttonDownloadAll_Click(object sender, EventArgs e)
        {
            labelTotalUpdate.Visible = false;
            labelDownloadStart.Text = "Download Started, Please wait...";
            buttonDownloadAll.Visible = false;
            buttonLimitedDownload.Visible = false;


            Application.DoEvents();

            questionQuantity = questionCounter;

  
            QuestionTextDownload();

            questionQuantity = questionCounter;


            QuestionImageDownload();

            questionQuantity = questionCounter;

            insertDataBase();
            Application.DoEvents();

            directoryDelete();
            MessageBox.Show("Download Completed!");
            Application.DoEvents();
            this.Hide();
            CrazyWorld cw = new CrazyWorld();
            cw.ShowDialog();

        }






        private void buttonDownload_Click(object sender, EventArgs e)
        {
            labelTotalUpdate.Visible = false;
            labelDownloadStart.Text = "Download Started, Please wait...";

            buttonDownload.Visible = false;
            buttonRefresh.Visible = false;

            Application.DoEvents();

            if (comboBoxUpdateNumber.Text.ToString() != "")
                questionQuantity = int.Parse(comboBoxUpdateNumber.Text.ToString());
            else
                questionQuantity = 0;



            QuestionTextDownload();



            questionQuantity = int.Parse(comboBoxUpdateNumber.Text.ToString());

            QuestionImageDownload();

            questionQuantity = int.Parse(comboBoxUpdateNumber.Text.ToString());

            insertDataBase();

            Application.DoEvents();

            MessageBox.Show("Download Completed!");
            Application.DoEvents();
            directoryDelete();
            this.Hide();
            CrazyWorld cw = new CrazyWorld();
            cw.ShowDialog();

        }



        public void directoryDelete()
        {


            DirectoryInfo di = new DirectoryInfo("Online Question");
            if (Directory.Exists("Online Question"))
            {
              
                di.Delete(true);
            }

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


            for (int i = 1; i <= int.Parse(TotalQuestionNo); i++)
            {

                if (unique_QSN_databse[i] == true)
                {
                    questionQuantity = questionQuantity -1;
                   if (questionQuantity>-1)
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



            }


            // step 4: close the connection
            objConnection.Close();

        }





        public void QuestionImageDownload()
        {

            questionQuantity = questionQuantity - 1;

            while (QuestionImage.Any() && questionQuantity>-1)
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
                    System.Threading.Thread.Sleep(400);
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
                CrazyWorld cw = new CrazyWorld();
                cw.ShowDialog();
            }

            QuestionImageDownload();

        }















        public void QuestionTextDownload()
        {
            questionQuantity = questionQuantity - 1;

            while (QuestionText.Any() && questionQuantity>-1)
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
                    System.Threading.Thread.Sleep(400);
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
                CrazyWorld cw = new CrazyWorld();
                cw.ShowDialog();

            }

            QuestionTextDownload();

        }

        private void comboBoxUpdateNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDownload.Visible = true;
        }

       










    }
}
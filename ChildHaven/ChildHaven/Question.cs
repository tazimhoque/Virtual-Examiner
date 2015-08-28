using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.IO;

namespace ChildHaven
{
    public partial class Question : Form
    {

        private Queue<string> _items = new Queue<string>();
        private List<string> _results = new List<string>();
        int count_file = 1;

        public Question()
        {
            
            InitializeComponent();
           
        }




       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            this.Hide();

            CrazyWorld cw = new CrazyWorld();
            cw.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          

            this.Hide();

            UserLogin ul = new UserLogin();
            ul.ShowDialog();
        }

        private void buttonUnsolved_Click(object sender, EventArgs e)
        {
            this.Refresh();
            this.Hide();


            UserInformation.setOnlineOrOffline("Offline");
            UserInformation.setAllorSolved("Unsolved");
            offlineInformationAnalysis.makeMyQuestionNoTempNull();
            Application.DoEvents();
            offlineInformationAnalysis oia = new offlineInformationAnalysis();
            oia.selectQuestionNo();

        }

        private void buttonAllProblem_Click(object sender, EventArgs e)
        {
           

            this.Hide();

            UserInformation.setOnlineOrOffline("Offline");
            UserInformation.setAllorSolved("All");
            offlineInformationAnalysis.makeMyQuestionNoTempNull();
            Application.DoEvents();
            offlineInformationAnalysis oia = new offlineInformationAnalysis();
            oia.selectQuestionNo();

        }
        
   /*     private void OnGetDownloadedStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Error == null && !string.IsNullOrEmpty(e.Result))
            {
                // do something with e.Result string.
                _results.Add(e.Result);
            }
            DownloadItem();
        }
*/
        private void button1_Click(object sender, EventArgs e)
        {
           

            this.Hide();
           
            
            RulesAndRegulations rar = new RulesAndRegulations();

            rar.ShowDialog();

            // Only This one   GenerateFolder();



            //button1.Text = "Question Paper is downloading.....\nPlease Wait...";
            //button1.ForeColor = System.Drawing.Color.Green;
            //button1.Font = new Font(button1.Font.FontFamily, 18);
           // label1.Visible = true;
            //button2.Visible = false;
            
           
          //  label1.ForeColor = System.Drawing.Color.Green;
            //label1.Font = new Font(button1.Font.FontFamily, 18);

      
           
      /*       use Path.Combine to combine 2 strings to a path
            File.WriteAllText(Path.Combine(dir, "log.txt"), "blah blah, text");



         

           WebClient Client = new WebClient();
            wc.DownloadFile("http://i.stackoverflow.com/Content/Img/stackoverflow-logo-250.png", @"C:\\newfolder\\stackoverflowlogo.png");
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete);

            Uri imageurl1 = new Uri("http://childzone.webege.com/Image/Q1.jpg");
             wc.DownloadFileAsync(imageurl1, "C:\\Image folder\\01.jpg");  */
            
           
        }


        //private void GenerateFolder()
        //{

           
        //    PopulateItemsQueue();

        //}

        //private void PopulateItemsQueue()
        //{
        //    //label1.Visible = true;
        //    _items.Enqueue("http://childzone.webege.com/Image/Q1.jpg");
        //    _items.Enqueue("http://childzone.webege.com/Image/Q2.jpg");
        //    _items.Enqueue("http://childzone.webege.com/Image/Q3.jpg");
        //    _items.Enqueue("http://childzone.webege.com/Image/Q4.jpg");
        //    _items.Enqueue("http://childzone.webege.com/Image/Q5.jpg");
        //    _items.Enqueue("http://childzone.webege.com/Image/Q6.jpg");
        //    _items.Enqueue("http://childzone.webege.com/Image/information.jpg");
          

        //    DownloadItem();
        //}


        //private void DownloadItem()
        //{
        //    if (_items.Any())
        //    {
        //       var  nextItem = _items.Dequeue();

        //     //   var webClient = new WebClient();
        //      //  webClient.DownloadStringCompleted += OnGetDownloadedStringCompleted;
        //      //  webClient.DownloadStringAsync(new Uri(nextItem));

        //        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete);
        //        Uri imageurl = new Uri(nextItem);

        //        if (count_file == 1)
        //        {
                   
        //            wc.DownloadFileAsync(imageurl, "C:\\Image folder\\Q1.jpg");
        //        }
        //        if (count_file == 2)
        //        {
                    
        //            wc.DownloadFileAsync(imageurl, "C:\\Image folder\\Q2.jpg");
        //        }
        //        if (count_file == 3)
        //        {
                    
                    

        //            wc.DownloadFileAsync(imageurl, "C:\\Image folder\\Q3.jpg");
        //        }
        //        if (count_file == 4)
        //        {
                  
        //            wc.DownloadFileAsync(imageurl, "C:\\Image folder\\Q4.jpg");
        //        }
        //        if (count_file == 5)
        //        {
                   
        //            wc.DownloadFileAsync(imageurl, "C:\\Image folder\\Q5.jpg");
        //        }
        //        if (count_file == 6)
        //        {
                    
        //            wc.DownloadFileAsync(imageurl, "C:\\Image folder\\Q6.jpg");
        //        }

        //        if (count_file == 7)
        //        {

        //            wc.DownloadFileAsync(imageurl, "C:\\Image folder\\information.txt");
        //        }


                

               

               


        //        return;
        //    }


        //}



        //private void FileDownloadComplete(object sender, AsyncCompletedEventArgs e)
        //{

        //    count_file++;
        //    while (wc.IsBusy)
        //    {
        //        System.Threading.Thread.Sleep(200);
        //    }

        //    if (e.Error != null)
        //    {
        //        MessageBox.Show("Problem while Downloading!\nOr no internet connection..");

        //        this.Hide();

        //        Question qn = new Question();


        //        qn.ShowDialog();


                             
        //    }



        //    if (count_file == 8)
        //    {
        //        MessageBox.Show("Download Completed!");
        //        this.Hide();
        //        OnlineQuestionImagePattern OQ = new OnlineQuestionImagePattern();
        //        OQ.ShowDialog();
        //    }
        //    DownloadItem();
        //}



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

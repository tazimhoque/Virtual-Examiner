using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.IO;
using System.Data.SqlClient;

namespace ChildHaven
{
    public partial class QuestionMaker : Form
    {
        bool unique_QSN=false;

        string pictureURL = null;
        string audioURL = null;
        string videoURL = null;
        bool nullChecker_var;




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


        public QuestionMaker()
        {
            InitializeComponent();
            makeFalse();
           
        }

        public void makeFalse()
        {
            textBoxQuestionSerialNo.Text = null;
            textBoxUpperText.Text = null;

            pictureURL = null;
            audioURL = null;
            videoURL = null;

            richTextBoxDescription.Text = null;

            textBoxMainQuestion.Text = null;
            textBoxMQA.Text = null;
            textBoxMQB.Text = null;
            textBoxMQC.Text = null;
            textBoxMQD.Text = null;
            textBoxMQAnswer.Text = null;

            textBoxQuestion1.Text = null;
            textBoxQ1Answer.Text = null;

            textBoxQuestion2.Text = null;
            textBoxQ2A.Text = null;
            textBoxQ2B.Text = null;
            textBoxQ2C.Text = null;
            textBoxQ2D.Text = null;
            textBoxQ2Answer.Text = null;
            

           


            //Making Button Check False
            labelQuestionSerialNoCheck.Visible = false;

            labelUpperTextCheck.Visible = false;

            labelPictureLinkCheck.Visible = false;

            labelDescriptionCheck.Visible = false;

            labelMainQuestionCheck.Visible = false;
            labelMainQuestionOptionCheck.Visible = false;
            labelMainQuestionAnswerCheck.Visible = false;

            labelQuestion1Check.Visible = false;
            labelQuestion1AnswerCheck.Visible = false;

            labelQuestion2Check.Visible = false;
            labelQuestion2OptionCheck.Visible = false;
            labelQuestion2AnswerCheck.Visible = false;

            //Question Serial No
            labelQuestionSerialNo.Visible = false;
            textBoxQuestionSerialNo.Visible = false;

            //Upper Text
            labelUpperText.Visible = false;
            textBoxUpperText.Visible = false;

            //Picture
            labelPictureLink.Visible = false;
            buttonPictureChoose.Visible = false;
            pictureBoxPic.Visible = false;


            //Audio
            labelAudioLink.Visible = false;
            buttonAudioChoose.Visible = false;

            //Video
            labelVideoLink.Visible = false;
            buttonVideoChoose.Visible = false;

            //Description
            labelDescription.Visible = false;
            richTextBoxDescription.Visible = false;

            //Main Question
            labelMainQuestion.Visible = false;
            textBoxMainQuestion.Visible = false;

            labelOptionMQ.Visible = false;

            labelMQA.Visible = false;
            textBoxMQA.Visible = false;
            labelMQB.Visible = false;
            textBoxMQB.Visible = false;
            labelMQC.Visible = false;
            textBoxMQC.Visible = false;
            labelMQD.Visible = false;
            textBoxMQD.Visible = false;

            labelMQAnswer.Visible = false;
            textBoxMQAnswer.Visible = false;

            //Question 1
            labelQuestion1.Visible = false;
            textBoxQuestion1.Visible = false;

            labelQ1Answer.Visible = false;
            textBoxQ1Answer.Visible = false;

            //Question 2
            labelQuestion2.Visible = false;
            textBoxQuestion2.Visible = false;

            labelOptionQ2.Visible = false;

            labelQ2A.Visible = false;
            textBoxQ2A.Visible = false;
            labelQ2B.Visible = false;
            textBoxQ2B.Visible = false;
            labelQ2C.Visible = false;
            textBoxQ2C.Visible = false;
            labelQ2D.Visible = false;
            textBoxQ2D.Visible = false;

            labelQ2Answer.Visible = false;
            textBoxQ2Answer.Visible = false;

            //Submit Button
            buttonSubmit.Visible = false;
            //button database insert and refresh
            button1.Visible = false;
            button2.Visible = false;
        }




        public void formMaker()
        {
            buttonSubmit.Visible = true;
            button2.Visible = true;
            if (comboBoxQuestionType.Text == "Picture Question")
            {

                labelQuestionSerialNoCheck.Visible = true;

                

                labelPictureLinkCheck.Visible = true;

               

                labelMainQuestionCheck.Visible = true;
                
                labelMainQuestionAnswerCheck.Visible = true;


                //QS No

                labelQuestionSerialNo.Visible = true;
                textBoxQuestionSerialNo.Visible = true;

                //Upper Text
                labelUpperText.Visible = true;
                textBoxUpperText.Visible = true;

                //Picture
                labelPictureLink.Visible = true;
                buttonPictureChoose.Visible = true;
                pictureBoxPic.Visible = true;



                //Description
                labelDescription.Visible = true;
                richTextBoxDescription.Visible = true;

                //Main Question
                labelMainQuestion.Visible = true;
                textBoxMainQuestion.Visible = true;


                labelMQAnswer.Visible = true;
                textBoxMQAnswer.Visible = true;

            }
            else if (comboBoxQuestionType.Text == "Picture Question Objective Type")
            {

                labelQuestionSerialNoCheck.Visible = true;

            

                labelPictureLinkCheck.Visible = true;



                labelMainQuestionCheck.Visible = true;
                labelMainQuestionOptionCheck.Visible = true;
                labelMainQuestionAnswerCheck.Visible = true;


                //QS No
                labelQuestionSerialNo.Visible = true;
                textBoxQuestionSerialNo.Visible = true;

                //Upper Text
                labelUpperText.Visible = true;
                textBoxUpperText.Visible = true;

                //Picture
                labelPictureLink.Visible = true;
                buttonPictureChoose.Visible = true;
                pictureBoxPic.Visible = true;


                //Description
                labelDescription.Visible = true;
                richTextBoxDescription.Visible = true;

                //Main Question
                labelMainQuestion.Visible = true;
                textBoxMainQuestion.Visible = true;

                labelOptionMQ.Visible = true;

                labelMQA.Visible = true;
                textBoxMQA.Visible = true;
                labelMQB.Visible = true;
                textBoxMQB.Visible = true;
                labelMQC.Visible = true;
                textBoxMQC.Visible = true;
                labelMQD.Visible = true;
                textBoxMQD.Visible = true;

                labelMQAnswer.Visible = true;
                textBoxMQAnswer.Visible = true;

            }
            else if (comboBoxQuestionType.Text == "Normal Question")
            {
                labelQuestionSerialNoCheck.Visible = true;



                



                labelMainQuestionCheck.Visible = true;
             
                labelMainQuestionAnswerCheck.Visible = true;


                //QS No

                labelQuestionSerialNo.Visible = true;
                textBoxQuestionSerialNo.Visible = true;

                //Upper Text
                labelUpperText.Visible = true;
                textBoxUpperText.Visible = true;

               

                //Main Question
                labelMainQuestion.Visible = true;
                textBoxMainQuestion.Visible = true;



                labelMQAnswer.Visible = true;
                textBoxMQAnswer.Visible = true;

                
            }
            else if (comboBoxQuestionType.Text == "Normal Question Objective Type")
            {
                labelQuestionSerialNoCheck.Visible = true;



         



                labelMainQuestionCheck.Visible = true;
                labelMainQuestionOptionCheck.Visible = true;
                labelMainQuestionAnswerCheck.Visible = true;


                //QS No
                labelQuestionSerialNo.Visible = true;
                textBoxQuestionSerialNo.Visible = true;

                //Upper Text
                labelUpperText.Visible = true;
                textBoxUpperText.Visible = true;

                

                //Main Question
                labelMainQuestion.Visible = true;
                textBoxMainQuestion.Visible = true;

                labelOptionMQ.Visible = true;

                labelMQA.Visible = true;
                textBoxMQA.Visible = true;
                labelMQB.Visible = true;
                textBoxMQB.Visible = true;
                labelMQC.Visible = true;
                textBoxMQC.Visible = true;
                labelMQD.Visible = true;
                textBoxMQD.Visible = true;

                labelMQAnswer.Visible = true;
                textBoxMQAnswer.Visible = true;

            }
            else if (comboBoxQuestionType.Text == "Descriptive Question (No Image)")
            {
                labelQuestionSerialNoCheck.Visible = true;

             

                labelDescriptionCheck.Visible = true;

                labelMainQuestionCheck.Visible = true;
             
                labelMainQuestionAnswerCheck.Visible = true;

            

                //QS No
                labelQuestionSerialNo.Visible = true;
                textBoxQuestionSerialNo.Visible = true;

                //Upper Text
                labelUpperText.Visible = true;
                textBoxUpperText.Visible = true;



                //Description
                labelDescription.Visible = true;
                richTextBoxDescription.Visible = true;

                //Main Question
                labelMainQuestion.Visible = true;
                textBoxMainQuestion.Visible = true;


                labelMQAnswer.Visible = true;
                textBoxMQAnswer.Visible = true;

            }
            else if (comboBoxQuestionType.Text == "Descriptive Question Objective Type (No Image)")
            {
                labelQuestionSerialNoCheck.Visible = true;



                labelDescriptionCheck.Visible = true;

                labelMainQuestionCheck.Visible = true;
                labelMainQuestionOptionCheck.Visible = true;
                labelMainQuestionAnswerCheck.Visible = true;



                //QS No
                labelQuestionSerialNo.Visible = true;
                textBoxQuestionSerialNo.Visible = true;

                //Upper Text
                labelUpperText.Visible = true;
                textBoxUpperText.Visible = true;

            

                //Description
                labelDescription.Visible = true;
                richTextBoxDescription.Visible = true;

                //Main Question
                labelMainQuestion.Visible = true;
                textBoxMainQuestion.Visible = true;

                labelOptionMQ.Visible = true;

                labelMQA.Visible = true;
                textBoxMQA.Visible = true;
                labelMQB.Visible = true;
                textBoxMQB.Visible = true;
                labelMQC.Visible = true;
                textBoxMQC.Visible = true;
                labelMQD.Visible = true;
                textBoxMQD.Visible = true;

                labelMQAnswer.Visible = true;
                textBoxMQAnswer.Visible = true;

            }
            else if (comboBoxQuestionType.Text == "Flash Question")
            {
                labelQuestionSerialNoCheck.Visible = true;



                labelPictureLinkCheck.Visible = true;


                labelQuestion1Check.Visible = true;
                labelQuestion1AnswerCheck.Visible = true;

                labelQuestion2Check.Visible = true;
                labelQuestion2OptionCheck.Visible = true;
                labelQuestion2AnswerCheck.Visible = true;



                //QS No
                labelQuestionSerialNo.Visible = true;
                textBoxQuestionSerialNo.Visible = true;

                //Upper Text
                labelUpperText.Visible = true;
                textBoxUpperText.Visible = true;

                //Picture
                labelPictureLink.Visible = true;
                buttonPictureChoose.Visible = true;
                pictureBoxPic.Visible = true;



                //Description
                labelDescription.Visible = true;
                richTextBoxDescription.Visible = true;

                

                //Question 1
                labelQuestion1.Visible = true;
                textBoxQuestion1.Visible = true;

                labelQ1Answer.Visible = true;
                textBoxQ1Answer.Visible = true;

                //Question 2
                labelQuestion2.Visible = true;
                textBoxQuestion2.Visible = true;

                labelOptionQ2.Visible = true;

                labelQ2A.Visible = true;
                textBoxQ2A.Visible = true;
                labelQ2B.Visible = true;
                textBoxQ2B.Visible = true;
                labelQ2C.Visible = true;
                textBoxQ2C.Visible = true;
                labelQ2D.Visible = true;
                textBoxQ2D.Visible = true;

                labelQ2Answer.Visible = true;
                textBoxQ2Answer.Visible = true;
            }
            else if (comboBoxQuestionType.Text == "Audio Question")
            {
                MessageBox.Show("Still Not Available");
            }
            else if (comboBoxQuestionType.Text == "Video Question")
            {
                MessageBox.Show("Still Not Available");
            }

        }

        public void nullChecker()
        {
            nullChecker_var = true;


           
           if (comboBoxQuestionType.Text == "Picture Question")
            {


                if (textBoxQuestionSerialNo.Text == "")
                {
                   
                    MessageBox.Show("You must have to give question serial no");
                    nullChecker_var = false;
                }
                else if (pictureURL == "")
                {
                    MessageBox.Show("You must have to choose a picture");
                    nullChecker_var = false;
                }
                else if (textBoxMainQuestion.Text == "")
                {
                    MessageBox.Show("You must have to make a question");
                    nullChecker_var = false;
                }
                else if (textBoxMQAnswer.Text == "")
                {
                    MessageBox.Show("You must have to give an answer");
                    nullChecker_var = false;
                }
            }




            else if (comboBoxQuestionType.Text == "Picture Question Objective Type")
            {
                if (textBoxQuestionSerialNo.Text == "")
                {
                    MessageBox.Show("You must have to give question serial no");
                    nullChecker_var = false;
                }
                else if (pictureURL == "")
                {
                    MessageBox.Show("You must have to choose a picture");
                    nullChecker_var = false;
                }
                else if (textBoxMainQuestion.Text == "")
                {
                    MessageBox.Show("You must have to make a question");
                    nullChecker_var = false;
                }
                else if (textBoxMQA.Text == "" || textBoxMQB.Text == "" || textBoxMQC.Text == "" || textBoxMQD.Text == "")
                {
                    MessageBox.Show("You must have to create four options");
                    nullChecker_var = false;
                }
                else if (textBoxMQAnswer.Text == "")
                {
                    MessageBox.Show("You must have to give an answer");
                    nullChecker_var = false;
                }
            }


            else if (comboBoxQuestionType.Text == "Normal Question")
            {
                if (textBoxQuestionSerialNo.Text == "")
                {
                    MessageBox.Show("You must have to give question serial no");
                    nullChecker_var = false;
                }
                else if (textBoxMainQuestion.Text == "")
                {
                    MessageBox.Show("You must have to make a question");
                    nullChecker_var = false;
                }
                else if (textBoxMQAnswer.Text == "")
                {
                    MessageBox.Show("You must have to give an answer");
                    nullChecker_var = false;
                }
            }

           else if (comboBoxQuestionType.Text == "Normal Question Objective Type")
           {
               if (textBoxQuestionSerialNo.Text == "")
               {
                   MessageBox.Show("You must have to give question serial no");
                   nullChecker_var = false;
               }

               else if (textBoxMainQuestion.Text == "")
               {
                   MessageBox.Show("You must have to make a question");
                   nullChecker_var = false;
               }
               else if (textBoxMQA.Text == "" || textBoxMQB.Text == "" || textBoxMQC.Text == "" || textBoxMQD.Text == "")
               {
                   MessageBox.Show("You must have to create four options");
                   nullChecker_var = false;
               }
               else if (textBoxMQAnswer.Text == "")
               {
                   MessageBox.Show("You must have to give an answer");
                   nullChecker_var = false;
               }
           }


           else if (comboBoxQuestionType.Text == "Descriptive Question (No Image)")
           {
               if (textBoxQuestionSerialNo.Text == "")
               {
                   MessageBox.Show("You must have to give question serial no");
                   nullChecker_var = false;
               }
               else if (richTextBoxDescription.Text == "")
               {
                   MessageBox.Show("You must have to give a description");
                   nullChecker_var = false;
               }
               else if (textBoxMainQuestion.Text == "")
               {
                   MessageBox.Show("You must have to make a question");
                   nullChecker_var = false;
               }

               else if (textBoxMQAnswer.Text == "")
               {
                   MessageBox.Show("You must have to give an answer");
                   nullChecker_var = false;
               }
           }

           else if (comboBoxQuestionType.Text == "Descriptive Question Objective Type (No Image)")
           {
               if (textBoxQuestionSerialNo.Text == "")
               {
                   MessageBox.Show("You must have to give question serial no");
                   nullChecker_var = false;
               }
               else if (richTextBoxDescription.Text == "")
               {
                   MessageBox.Show("You must have to give a description");
                   nullChecker_var = false;
               }
               else if (textBoxMainQuestion.Text == "")
               {
                   MessageBox.Show("You must have to make a question");
                   nullChecker_var = false;
               }
               else if (textBoxMQA.Text == "" || textBoxMQB.Text == "" || textBoxMQC.Text == "" || textBoxMQD.Text == "")
               {
                   MessageBox.Show("You must have to create four options");
                   nullChecker_var = false;
               }
               else if (textBoxMQAnswer.Text == "")
               {
                   MessageBox.Show("You must have to give an answer");
                   nullChecker_var = false;
               }
           }


           else if (comboBoxQuestionType.Text == "Flash Question")
           {
               if (textBoxQuestionSerialNo.Text == "")
               {
                   MessageBox.Show("You must have to give question serial no");
                   nullChecker_var = false;
               }
               else if (pictureURL == "")
               {
                   MessageBox.Show("You must have to choose a picture link");
                   nullChecker_var = false;
               }
               else if (textBoxQuestion1.Text == "")
               {
                   MessageBox.Show("Question1 is blank. You Have to make a question");
                   nullChecker_var = false;
               }
               else if (textBoxQ1Answer.Text == "")
               {
                   MessageBox.Show("Question1's answer is blank. You Have to give an answer");
                   nullChecker_var = false;
               }
               else if (textBoxQuestion2.Text == "")
               {
                   MessageBox.Show("Question2 is blank. You Have to make a question");
                   nullChecker_var = false;
               }
               else if (textBoxQ2A.Text == "" || textBoxQ2B.Text == "" || textBoxQ2C.Text == "" || textBoxQ2D.Text == "")
               {
                   MessageBox.Show("Question2's Options are blank. You must have to create four options");
                   nullChecker_var = false;
               }
               else if (textBoxQ2Answer.Text == "")
               {
                   MessageBox.Show("Question2's answer is blank. You must have to give an answer");
                   nullChecker_var = false;
               }
           }




        }



        public void makeTextFile()
        {
            if (comboBoxQuestionType.Text == "Picture Question")
            {

                StreamWriter File1 = new StreamWriter("Question//" + textBoxQuestionSerialNo.Text + ".txt");
             
                //Question Serial No
                File1.Write("QSNo:\r\n" + textBoxQuestionSerialNo.Text + "\r\n");
                //Question Type
                File1.Write("QuestionType:\r\n" + comboBoxQuestionType.Text + "\r\n");

                //Upper Text
                if (textBoxUpperText.Text=="")
                    File1.Write("UpperText:\r\n" + "NA\r\n");  
                else
                    File1.Write("UpperText:\r\n" + textBoxUpperText.Text + "\r\n");


                //Picture

               
                File.Copy(pictureURL, "Question//" + textBoxQuestionSerialNo.Text + ".jpg",false);
                
                File1.Write("PicURL:\r\n" + textBoxQuestionSerialNo.Text + "\r\n");

                //Audio URL
                File1.Write("AudioURL:\r\n" + "NA\r\n");
                //Viseo URL
                File1.Write("VideoURL:\r\n" + "NA\r\n");

                //Description
                if (richTextBoxDescription.Text == "")
                    File1.Write("Description:\r\n" + "NA\r\n");
                else
                    File1.Write("Description:\r\n" + richTextBoxDescription.Text.Replace("\n"," ") + "\r\n");

                //Main Question
                File1.Write("MainQuestion:\r\n" + textBoxMainQuestion.Text + "\r\n");

                //Main Question Option
                File1.Write("MainQuestionOption:\r\n" + "NA\r\nNA\r\nNA\r\nNA\r\n");
               /* textBoxMQA.Text = null;
                textBoxMQB.Text = null;
                textBoxMQC.Text = null;
                textBoxMQD.Text = null; */

                //Main Question Answer
                File1.Write("MainQuestionAnswer:\r\n" + textBoxMQAnswer.Text + "\r\n");
                
                //Question1
                File1.Write("Question1:\r\n" + "NA\r\n");
                File1.Write("Question1Answer:\r\n" + "NA\r\n");

                //Question2
                File1.Write("Question2:\r\n" + "NA\r\n");
                File1.Write("Question2Option:\r\n" + "NA\r\nNA\r\nNA\r\nNA\r\n");
                File1.Write("Question2Answer:\r\n" + "NA");

                File1.Close();
               
            }




            else if (comboBoxQuestionType.Text == "Picture Question Objective Type")
            {

                StreamWriter File2 = new StreamWriter("Question//" + textBoxQuestionSerialNo.Text + ".txt");

                //Question Serial No
                File2.Write("QSNo:\r\n" + textBoxQuestionSerialNo.Text + "\r\n");
                //Question Type
                File2.Write("QuestionType:\r\n" + comboBoxQuestionType.Text + "\r\n");

                //Upper Text
                if (textBoxUpperText.Text == "")
                    File2.Write("UpperText:\r\n" + "NA\r\n");
                else
                    File2.Write("UpperText:\r\n" + textBoxUpperText.Text + "\r\n");


                //Picture
                File.Copy(pictureURL, "Question//" + textBoxQuestionSerialNo.Text + ".jpg", true);
                File2.Write("PicURL:\r\n" + textBoxQuestionSerialNo.Text + "\r\n");

                //Audio URL
                File2.Write("AudioURL:\r\n" + "NA\r\n");
                //Viseo URL
                File2.Write("VideoURL:\r\n" + "NA\r\n");

                //Description
                if (richTextBoxDescription.Text == "")
                    File2.Write("Description:\r\n" + "NA\r\n");
                else
                    File2.Write("Description:\r\n" + richTextBoxDescription.Text.Replace("\n", " ") + "\r\n");

                //Main Question
                File2.Write("MainQuestion:\r\n" + textBoxMainQuestion.Text + "\r\n");

                //Main Question Option
                File2.Write("MainQuestionOption:\r\n" + textBoxMQA.Text + "\r\n" + textBoxMQB.Text + "\r\n" + textBoxMQC.Text + "\r\n" + textBoxMQD.Text + "\r\n");
               

                //Main Question Answer
                File2.Write("MainQuestionAnswer:\r\n" + textBoxMQAnswer.Text + "\r\n");

                //Question1
                File2.Write("Question1:\r\n" + "NA\r\n");
                File2.Write("Question1Answer:\r\n" + "NA\r\n");

                //Question2
                File2.Write("Question2:\r\n" + "NA\r\n");
                File2.Write("Question2Option:\r\n" + "NA\r\nNA\r\nNA\r\nNA\r\n");
                File2.Write("Question2Answer:\r\n" + "NA");

                File2.Close();
                
            }


            else if (comboBoxQuestionType.Text == "Normal Question")
            {

                StreamWriter File3 = new StreamWriter("Question//" + textBoxQuestionSerialNo.Text + ".txt");

                //Question Serial No
                File3.Write("QSNo:\r\n" + textBoxQuestionSerialNo.Text + "\r\n");
                //Question Type
                File3.Write("QuestionType:\r\n" + comboBoxQuestionType.Text + "\r\n");

                //Upper Text
                if (textBoxUpperText.Text == "")
                    File3.Write("UpperText:\r\n" + "NA\r\n");
                else
                    File3.Write("UpperText:\r\n" + textBoxUpperText.Text + "\r\n");


                //Picture
                File.Copy("blanktt.bmp", "Question//" + textBoxQuestionSerialNo.Text + ".jpg", false);
                File3.Write("PicURL:\r\n" + "NA\r\n");

                //Audio URL
                File3.Write("AudioURL:\r\n" + "NA\r\n");
                //Viseo URL
                File3.Write("VideoURL:\r\n" + "NA\r\n");

                //Description
                File3.Write("Description:\r\n" + "NA\r\n");
                

                //Main Question
                File3.Write("MainQuestion:\r\n" + textBoxMainQuestion.Text + "\r\n");

                //Main Question Option
                File3.Write("MainQuestionOption:\r\n" + "NA\r\nNA\r\nNA\r\nNA\r\n");
               // File3.Write("MainQuestionOption:\n" + textBoxMQA.Text + "\n" + textBoxMQB.Text + "\n" + textBoxMQC.Text + "\n" + textBoxMQD.Text + "\n");


                //Main Question Answer
                File3.Write("MainQuestionAnswer:\r\n" + textBoxMQAnswer.Text + "\r\n");

                //Question1
                File3.Write("Question1:\r\n" + "NA\r\n");
                File3.Write("Question1Answer:\r\n" + "NA\r\n");

                //Question2
                File3.Write("Question2:\r\n" + "NA\r\n");
                File3.Write("Question2Option:\r\n" + "NA\r\nNA\r\nNA\r\nNA\r\n");
                File3.Write("Question2Answer:\r\n" + "NA");

                File3.Close();

                
            }

            else if (comboBoxQuestionType.Text == "Normal Question Objective Type")
            {

                StreamWriter File4 = new StreamWriter("Question//" + textBoxQuestionSerialNo.Text + ".txt");

                //Question Serial No
                File4.Write("QSNo:\r\n" + textBoxQuestionSerialNo.Text + "\r\n");
                //Question Type
                File4.Write("QuestionType:\r\n" + comboBoxQuestionType.Text + "\r\n");

                //Upper Text
                if (textBoxUpperText.Text == "")
                    File4.Write("UpperText:\r\n" + "NA\r\n");
                else
                    File4.Write("UpperText:\r\n" + textBoxUpperText.Text + "\r\n");


                //Picture
                File.Copy("blanktt.bmp", "Question//" + textBoxQuestionSerialNo.Text + ".jpg", false);
                File4.Write("PicURL:\r\n" + "NA\r\n");

                //Audio URL
                File4.Write("AudioURL:\r\n" + "NA\r\n");
                //Viseo URL
                File4.Write("VideoURL:\r\n" + "NA\r\n");

                //Description
                File4.Write("Description:\r\n" + "NA\r\n");


                //Main Question
                File4.Write("MainQuestion:\r\n" + textBoxMainQuestion.Text + "\r\n");

                //Main Question Option
              //  File4.Write("MainQuestionOption:\n" + "NA\nNA\nNA\nNA\n");
                File4.Write("MainQuestionOption:\r\n" + textBoxMQA.Text + "\r\n" + textBoxMQB.Text + "\r\n" + textBoxMQC.Text + "\r\n" + textBoxMQD.Text + "\r\n");


                //Main Question Answer
                File4.Write("MainQuestionAnswer:\r\n" + textBoxMQAnswer.Text + "\r\n");

                //Question1
                File4.Write("Question1:\r\n" + "NA\r\n");
                File4.Write("Question1Answer:\r\n" + "NA\r\n");

                //Question2
                File4.Write("Question2:\r\n" + "NA\r\n");
                File4.Write("Question2Option:\r\n" + "NA\r\nNA\r\nNA\r\nNA\r\n");
                File4.Write("Question2Answer:\r\n" + "NA");

                File4.Close();
               
            }


            else if (comboBoxQuestionType.Text == "Descriptive Question (No Image)")
            {

                StreamWriter File5 = new StreamWriter("Question//" + textBoxQuestionSerialNo.Text + ".txt");

                //Question Serial No
                File5.Write("QSNo:\r\n" + textBoxQuestionSerialNo.Text + "\r\n");
                //Question Type
                File5.Write("QuestionType:\r\n" + comboBoxQuestionType.Text + "\r\n");

                //Upper Text
                if (textBoxUpperText.Text == "")
                    File5.Write("UpperText:\r\n" + "NA\r\n");
                else
                    File5.Write("UpperText:\r\n" + textBoxUpperText.Text + "\r\n");


                //Picture
                File.Copy("blanktt.bmp", "Question//" + textBoxQuestionSerialNo.Text + ".jpg", false);
                File5.Write("PicURL:\r\n" + "NA\r\n");

                //Audio URL
                File5.Write("AudioURL:\r\n" + "NA\r\n");
                //Viseo URL
                File5.Write("VideoURL:\r\n" + "NA\r\n");

                //Description
                File5.Write("Description:\r\n" + richTextBoxDescription.Text.Replace("\n", " ") + "\r\n");

                //Main Question
                File5.Write("MainQuestion:\r\n" + textBoxMainQuestion.Text + "\r\n");

                //Main Question Option
                File5.Write("MainQuestionOption:\r\n" + "NA\r\nNA\r\nNA\r\nNA\r\n");
                /* textBoxMQA.Text = null;
                 textBoxMQB.Text = null;
                 textBoxMQC.Text = null;
                 textBoxMQD.Text = null; */

                //Main Question Answer
                File5.Write("MainQuestionAnswer:\r\n" + textBoxMQAnswer.Text + "\r\n");

                //Question1
                File5.Write("Question1:\r\n" + "NA\r\n");
                File5.Write("Question1Answer:\r\n" + "NA\r\n");

                //Question2
                File5.Write("Question2:\r\n" + "NA\r\n");
                File5.Write("Question2Option:\r\n" + "NA\r\nNA\r\nNA\r\nNA\r\n");
                File5.Write("Question2Answer:\r\n" + "NA");

                File5.Close();
            }

            else if (comboBoxQuestionType.Text == "Descriptive Question Objective Type (No Image)")
            {

                StreamWriter File6 = new StreamWriter("Question//" + textBoxQuestionSerialNo.Text + ".txt");

                //Question Serial No
                File6.Write("QSNo:\r\n" + textBoxQuestionSerialNo.Text + "\r\n");
                //Question Type
                File6.Write("QuestionType:\r\n" + comboBoxQuestionType.Text + "\r\n");

                //Upper Text
                if (textBoxUpperText.Text == "")
                    File6.Write("UpperText:\r\n" + "NA\r\n");
                else
                    File6.Write("UpperText:\r\n" + textBoxUpperText.Text + "\r\n");


                //Picture
                File.Copy("blanktt.bmp", "Question//" + textBoxQuestionSerialNo.Text + ".jpg", false);
                File6.Write("PicURL:\r\n" + "NA\r\n");

                //Audio URL
                File6.Write("AudioURL:\r\n" + "NA\r\n");
                //Viseo URL
                File6.Write("VideoURL:\r\n" + "NA\r\n");

                //Description
                File6.Write("Description:\r\n" + richTextBoxDescription.Text.Replace("\n", " ") + "\r\n");

                //Main Question
                File6.Write("MainQuestion:\r\n" + textBoxMainQuestion.Text + "\r\n");

                //Main Question Option
                File6.Write("MainQuestionOption:\r\n" + textBoxMQA.Text + "\r\n" + textBoxMQB.Text + "\r\n" + textBoxMQC.Text + "\r\n" + textBoxMQD.Text + "\r\n");
               
                /* textBoxMQA.Text = null;
                 textBoxMQB.Text = null;
                 textBoxMQC.Text = null;
                 textBoxMQD.Text = null; */

                //Main Question Answer
                File6.Write("MainQuestionAnswer:\r\n" + textBoxMQAnswer.Text + "\r\n");

                //Question1
                File6.Write("Question1:\r\n" + "NA\r\n");
                File6.Write("Question1Answer:\n" + "NA\r\n");

                //Question2
                File6.Write("Question2:\r\n" + "NA\r\n");
                File6.Write("Question2Option:\r\n" + "NA\r\nNA\r\nNA\r\nNA\r\n");
                File6.Write("Question2Answer:\r\n" + "NA");

                File6.Close();
            }


            else if (comboBoxQuestionType.Text == "Flash Question")
            {


                StreamWriter File7 = new StreamWriter("Question//" + textBoxQuestionSerialNo.Text + ".txt");

                //Question Serial No
                File7.Write("QSNo:\r\n" + textBoxQuestionSerialNo.Text + "\r\n");
                //Question Type
                File7.Write("QuestionType:\r\n" + comboBoxQuestionType.Text + "\r\n");

                //Upper Text
                if (textBoxUpperText.Text == "")
                    File7.Write("UpperText:\r\n" + "NA\r\n");
                else
                    File7.Write("UpperText:\r\n" + textBoxUpperText.Text + "\r\n");


                //Picture
                File.Copy(pictureURL, "Question//" + textBoxQuestionSerialNo.Text + ".jpg", true);
                File7.Write("PicURL:\r\n" + textBoxQuestionSerialNo.Text + "\r\n");

                //Audio URL
                File7.Write("AudioURL:\r\n" + "NA\r\n");
                //Viseo URL
                File7.Write("VideoURL:\r\n" + "NA\r\n");

                //Description
                if (richTextBoxDescription.Text == "")
                    File7.Write("Description:\r\n" + "NA\r\n");
                else
                    File7.Write("Description:\r\n" + richTextBoxDescription.Text.Replace("\n", " ") + "\r\n");

                //Main Question
                File7.Write("MainQuestion:\r\n" + "NA\r\n");

                //Main Question Option
                File7.Write("MainQuestionOption:\r\n" + "NA\r\nNA\r\nNA\r\nNA\r\n");

                //Main Question Answer
                File7.Write("MainQuestionAnswer:\r\n" + "NA\r\n");

                //Question1
                File7.Write("Question1:\r\n" + textBoxQuestion1.Text + "\r\n");
                File7.Write("Question1Answer:\r\n" + textBoxQ1Answer.Text + "\r\n");

                //Question2
                File7.Write("Question2:\r\n" + textBoxQuestion2.Text + "\r\n");
                File7.Write("Question2Option:\r\n" + textBoxQ2A.Text + "\r\n" + textBoxQ2B.Text + "\r\n" + textBoxQ2C.Text + "\r\n" + textBoxQ2D.Text + "\r\n");
                File7.Write("Question2Answer:\r\n" + textBoxQ2Answer.Text);

                File7.Close();
            }
        }


        private void QuestionMaker_Load(object sender, EventArgs e)
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

        private void buttonMakeForm_Click(object sender, EventArgs e)
        {
           // makeFalse();
           // formMaker();
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
            int i = int.Parse(textBoxQuestionSerialNo.Text.Replace(" ", ""));
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

            objConnection.Close();

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            nullChecker();
            
            uniqueQSNChecker();

            if (nullChecker_var == true && unique_QSN == true)
            {
                button1.Visible = true;
                makeTextFile();
                // MessageBox.Show(comboBoxQuestionType.Text + " Successful!!");

               

            }
            else
            {
                if (unique_QSN == false)
                    MessageBox.Show("The Question serial No " + textBoxQuestionSerialNo.Text + " already exists!");

            }
        }

        private void buttonPictureChoose_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    pictureURL = openFileDialog1.FileName;

                    pictureBoxPic.Image = Image.FromFile(pictureURL);
                   // pictureBox1.Image = Image.FromFile("C:\\Image folder\\Q1.jpg");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuestionMaker q2 = new QuestionMaker();
            q2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;

            string stri=textBoxQuestionSerialNo.Text;
            string[] QuestionDataPro = new string[100];
             
            
            string[] lines = System.IO.File.ReadAllLines(@"Question\"+stri+".txt");
            for(int idx = 0; idx < lines.Count(); idx ++)

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
                    MQAnswer= lines[idx];
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

        
            
        

       



            // step 1: Create a connection
         //   var result = Path.GetFullPath("InformationDatabase.mdf");
         //   string strConnection = "Data Source=(LocalDB)\v11.0;AttachDbFilename="+result+";Integrated Security=True";

            var result = Path.GetFullPath("InformationDatabase.mdf");
            string strConnection = "Data Source=.\\sqlexpress;AttachDbFilename=" + result + ";User Instance=true; Integrated Security=True;Pooling=False";

            //  string strConnection = "Data Source=.\\sqlexpress;Initial Catalog=CustomerDatabase;Integrated Security=True;Pooling=False";
              SqlConnection objConnection = new SqlConnection(strConnection);
              objConnection.Open();
            // step 2: fire a command
              //string str2Command = "insert into CustomerTable values('" + QuestionSerialNo + "', '" + audio + "', '" + audio + "', '" + audio + "', '" + audio + "')";

              byte[] img = null;
              if (pic != "NA")
              {
                  
                  FileStream fs = new FileStream("Question//" + pic + ".jpg", FileMode.Open, FileAccess.Read);
                  BinaryReader br = new BinaryReader(fs);
                  img = br.ReadBytes((int)fs.Length);
              }
              else 
              {

                  FileStream fs = new FileStream("blanktt.bmp", FileMode.Open, FileAccess.Read);
                  BinaryReader br = new BinaryReader(fs);
                  img = br.ReadBytes((int)fs.Length);
              }
              string strCommand = "insert into Question values('" + QuestionSerialNo + "' , @QuestionType , @UpperText, @img , @audio , @video , @Description , @MainQuestion , @MQOptionA , @MQOptionB , @MQOptionC , @MQOptionD , @MQAnswer , @Question1 , @Q1Answer , @Question2 , @Q2OptionA , @Q2OptionB , @Q2OptionC , @Q2OptionD , @Q2Answer )";
            SqlCommand objCommand = new SqlCommand(strCommand, objConnection);
            objCommand.Parameters.Add(new SqlParameter("@QuestionType", QuestionType));  
            objCommand.Parameters.Add(new SqlParameter("@UpperText", UpperText));
               
            objCommand.Parameters.Add(new SqlParameter ("@img",img));
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

            // step 4: close the connection
            objConnection.Close();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            // step 1: Create a connection
           // var result = Path.GetFullPath("InformationDatabase.mdf");
           // string strConnection = "Data Source=(LocalDB)\v11.0;AttachDbFilename=" + result + ";Integrated Security=True";
            var result = Path.GetFullPath("InformationDatabase.mdf");
            string strConnection = "Data Source=.\\sqlexpress;AttachDbFilename=" + result + ";User Instance=true; Integrated Security=True;Pooling=False";

          //  string strConnection = "Data Source=.\\sqlexpress;Initial Catalog=InformationDatabase;Integrated Security=True;Pooling=False";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();
            // step 2: fire a command
            string strCommand = "select UpperText, PicURL from Question where QSN=1";
            SqlCommand objCommand = new SqlCommand(strCommand, objConnection);

            // step 3: bind the result data with user interface

            SqlDataReader reader = objCommand.ExecuteReader();
            reader.Read();

            //textBox1.Text = reader[0].ToString();
            byte[] img = (byte[])(reader[1]);

            if (img == null)
            {
               // pictureBox1.Image = null;
            }
            else
            {
                MemoryStream ms = new MemoryStream(img);
               // pictureBox1.Image = Image.FromStream(ms);
            }
            // step 4: close the connection
            objConnection.Close();
        }

        private void comboBoxQuestionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxQuestionType.SelectedIndex > -1)
            {
                makeFalse();
                formMaker();
            }
            
        }

        private void buttonAudioChoose_Click(object sender, EventArgs e)
        {

        }

        
    }
}

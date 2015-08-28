using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;
using System.Speech;
using System.Threading;
using System.Speech.Recognition;


namespace ChildHaven
{
    public partial class SpeechRecognitionAndTextToSpeech : Form
    {

        SpeechSynthesizer sSynth = new SpeechSynthesizer();
        SpeechRecognitionEngine sRecognize = new SpeechRecognitionEngine();
        PromptBuilder pBuilder = new PromptBuilder();
        


        public SpeechRecognitionAndTextToSpeech()
        {
            InitializeComponent();

           
        }

        

        private void SpeechRecognitionAndTextToSpeech_Load(object sender, EventArgs e)
        {
            buttonStop.Visible = false;
            sSynth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            sSynth.Rate = -4;

        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText(richTextBox1.Text);
            sSynth.Speak(pBuilder);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {


            //SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine();
            //_recognizer.RequestRecognizerUpdate();
            //_recognizer.LoadGrammar(new Grammar(new GrammarBuilder("exit")));
            //_recognizer.RequestRecognizerUpdate();
            //_recognizer.LoadGrammar(new DictationGrammar());
            //_recognizer.SpeechRecognized += _recognizer_SpeechRecognized;
            //_recognizer.SetInputToDefaultAudioDevice(); // set input to default audio device
            //_recognizer.RecognizeAsync(RecognizeMode.Multiple); // recognize speech 


         


            buttonStart.Visible = false;
            buttonStop.Visible = true;

           // Choices myChoice = new Choices();
          //  myChoice.Add("hellow","exit","dear","like","dislike");

          //  Grammar myGrammar = new Grammar(new GrammarBuilder(myChoice));

        

            try
            {
                
                sRecognize.RequestRecognizerUpdate();
                //sRecognize.LoadGrammar(myGrammar);
                sRecognize.LoadGrammar(new Grammar(new GrammarBuilder("exit"))); //new
                sRecognize.RequestRecognizerUpdate();
                sRecognize.LoadGrammar(new DictationGrammar());




                sRecognize.SpeechRecognized += sRecognize_SpeechRecognized;
                sRecognize.SetInputToDefaultAudioDevice();
                sRecognize.RecognizeAsync(RecognizeMode.Multiple);

                
            }

            catch
            {
                
                return;
            }


        }

        private void sRecognize_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text.ToString() == "exit")
            {
                Application.Exit();
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + " " + e.Result.Text.ToString(); 
            }

           // throw new NotImplementedException();
        }

       

        private void buttonStop_Click(object sender, EventArgs e)
        {

            sRecognize.RecognizeAsyncStop();

            buttonStop.Visible = false;
            buttonStart.Visible = true;
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
    }
}

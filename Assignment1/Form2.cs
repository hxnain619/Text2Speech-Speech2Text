using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace Assignment1
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        SpeechRecognitionEngine engine = new SpeechRecognitionEngine();
        private void Speak_Click(object sender, EventArgs e)
        {



            // ****** To Make ChatBot ***************

            // Choices commands = new Choices();
            // commands.Add(new string[] { "say Hello.." });
            // GrammarBuilder gBuilder = new GrammarBuilder();
            // gBuilder.Append(commands);
            // Grammar grammer = new Grammar();

            // engine.LoadGrammarAsync(grammer);

            // ********** Speech To Text ***********

            engine = new SpeechRecognitionEngine();
            Grammar g = new DictationGrammar();
            engine.LoadGrammar(g);
           

            if(Speak.Text == "Speak"){

                engine.SetInputToDefaultAudioDevice();
                engine.SpeechRecognized += engine_SpeechRecognized;
                Speak.Text = "Listening...";
                engine.RecognizeAsync(RecognizeMode.Multiple);
            
            }else
            {
                Speak.Text = "Speak";
                engine.RecognizeAsyncStop();

            }
        }

        private void engine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            ListenBox.Text += e.Result.Text + " ";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void ListenBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 Main_Page = new Form1();

            Main_Page.Show();
            this.Hide();
        }
    }
}
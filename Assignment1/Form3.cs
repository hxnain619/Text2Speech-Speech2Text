using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace Assignment1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            if (speechSynthesizerObj != null)
            {
                if (speechSynthesizerObj.State == SynthesizerState.Speaking)
                {
                    speechSynthesizerObj.Pause();
                    Resume.Enabled = true;
                    Speak.Enabled = false;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
        SpeechSynthesizer speechSynthesizerObj;
        private void Form3_Load(object sender, EventArgs e)
        {
            speechSynthesizerObj = new SpeechSynthesizer();
            this.Speak.Enabled = false;
            this.Resume.Enabled = false;
            this.Pause.Enabled = false;
        }

        private void Speak_Click(object sender, EventArgs e)
        {
            speechSynthesizerObj.Dispose();
            if (richTextBox1.Text != "")
            {
                speechSynthesizerObj = new SpeechSynthesizer();
                speechSynthesizerObj.SpeakAsync(richTextBox1.Text);
                Pause.Enabled = true;
                Stop.Enabled = true;
            }
        }

        private void Resume_Click(object sender, EventArgs e)
        {
            if (speechSynthesizerObj != null)
            {
                if (speechSynthesizerObj.State == SynthesizerState.Paused)
                {
                    speechSynthesizerObj.Resume();
                    Resume.Enabled = false;
                    Speak.Enabled = true;
                }
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (speechSynthesizerObj != null)
            {
                speechSynthesizerObj.Dispose();
                Speak.Enabled = true;
                Resume.Enabled = false;
                Pause.Enabled = false;
                Stop.Enabled = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 Main_Page = new Form1();
            Main_Page.Show();
            this.Hide();
        }
    }
}

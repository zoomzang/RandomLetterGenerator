using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace RandomLetterGenerator
{
    
    public partial class Form1 : Form
    {
        static Random rand = new Random();
        SoundPlayer player = new SoundPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rollResult = rand.Next(1, 27);
            char letterGrab = ((char)(rollResult + 64));

            textBox1.Text = ""  + rollResult + letterGrab;
            string soundFile = "C:\\Users\\zoomz\\source\\repos\\RandomLetterGenerator\\RandomLetterGenerator\\MorseCodeAudio\\" +letterGrab+ "_morse_code.ogg.mp3";
            //SystemSounds.Hand.Play();
            //MessageBox.Show(soundFile);
            axWindowsMediaPlayer1.URL = soundFile; //remember to be absolutely sure of file type. This matters more when file types are to be exact.
            //axWindowsMediaPlayer1.launchURL(soundFile);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}

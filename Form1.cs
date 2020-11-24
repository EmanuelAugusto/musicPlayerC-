using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;

namespace musicPlayer
{
    public partial class Form1 : Form
    {
        bool playing = false;
        IWavePlayer waveOutDevice = new WaveOut();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

            if (playing == false)
            {
                AudioFileReader audioFileReader = new AudioFileReader("C:/Users/Emanuel Augusto/Desktop/C#/musicPlayer/bandaResgate.mp3");
                waveOutDevice.Init(audioFileReader);
                pictureBox2.Visible = true;
                playing = true;
                waveOutDevice.Play();
            }
            else if(playing == true)
            {
                pictureBox2.Visible = false;
                playing = false;
                waveOutDevice.Pause();
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

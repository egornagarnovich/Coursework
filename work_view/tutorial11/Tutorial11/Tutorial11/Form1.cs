using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tutorial11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NAudio.Wave.BlockAlignReductionStream stream = null;
        private NAudio.Wave.DirectSoundOut output = null;

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Audio file (*.mp3;*.wav)|*.mp3; *.wav;";
            if (open.ShowDialog() != DialogResult.OK) return;
            DisposeWave();
            if (open.FileName.EndsWith(".mp3"))
            {
                customWaveViewer1.WaveStream = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(open.FileName));
                customWaveViewer1.FitToScreen();
                NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(open.FileName));
                stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
            }
            else if (open.FileName.EndsWith(".wav"))
            {
                customWaveViewer1.WaveStream = new NAudio.Wave.WaveFileReader(open.FileName);
                customWaveViewer1.FitToScreen();
                NAudio.Wave.WaveStream pcm = new NAudio.Wave.WaveChannel32(new NAudio.Wave.WaveFileReader(open.FileName));
                stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
            }
            else throw new InvalidOperationException("Not a correct audio file type.");
            output = new NAudio.Wave.DirectSoundOut();
            output.Init(stream);
            output.Play();

            pauseButton1.Enabled = true;
        }

        private void pauseButton1_Click(object sender, EventArgs e)
        {
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing) output.Pause();
                else if (output.PlaybackState == NAudio.Wave.PlaybackState.Paused) output.Play();
            }
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Audio file (*.mp3;*.wav)|*.mp3; *.wav;";
            if (open.ShowDialog() != DialogResult.OK) return;
            DisposeWave();
            if (open.FileName.EndsWith(".mp3"))
            {
                customWaveViewer2.WaveStream = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(open.FileName));
                customWaveViewer2.FitToScreen();
                NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(open.FileName));
                stream = new NAudio.Wave.BlockAlignReductionStream(pcm);

            }
            else if (open.FileName.EndsWith(".wav"))
            {
                customWaveViewer2.WaveStream = new NAudio.Wave.WaveFileReader(open.FileName);
                customWaveViewer2.FitToScreen();
                NAudio.Wave.WaveStream pcm = new NAudio.Wave.WaveChannel32(new NAudio.Wave.WaveFileReader(open.FileName));
                stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
            }
            else throw new InvalidOperationException("Not a correct audio file type.");
            output = new NAudio.Wave.DirectSoundOut();
            output.Init(stream);
            output.Play();
        }

        private void DisposeWave()
        {
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                {
                    output.Stop();
                }
                output.Dispose();
                output = null;
            }
            if (stream != null)
            {
                stream.Dispose();
                stream = null;
            }
        }
        private void Tutorial11_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeWave();
        }
    }
}

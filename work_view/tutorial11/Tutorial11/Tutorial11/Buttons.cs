using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial11
{
    class Buttons
    {
        private void openf(object sender, EventArgs e)
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

        private void pauseb(object sender, EventArgs e)
        {
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing) output.Pause();
                else if (output.PlaybackState == NAudio.Wave.PlaybackState.Paused) output.Play();
            }
        }
    }
}

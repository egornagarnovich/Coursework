using System;
using System.Numerics;

namespace work
{
    public class WavInformation
    {
        public Complex[] GetInformation(string pathToWavFile)
        {
            Complex[] data;
            byte[] wave;
            System.IO.FileStream WaveFile = System.IO.File.OpenRead(pathToWavFile);
            wave = new byte[WaveFile.Length];
            data = new Complex[(wave.Length - 44) / 4]; //shifting the headers out of the PCM data;
            WaveFile.Read(wave, 0, Convert.ToInt32(WaveFile.Length)); //read the wave file into the wave variable
            /***********Converting and PCM accounting***************/
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = (BitConverter.ToInt32(wave, 44 + i * 4)); // 4 294 967 296.0
            }
            return data;
        }
    }
}

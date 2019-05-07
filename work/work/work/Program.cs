using System;
using System.IO;
using System.Text;

namespace work
{
class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                AudioConverter converter = new AudioConverter();
                WavInformation wav = new WavInformation();
                //converter.Convert(ref args);
                var a = wav.GetInformation("/home/egor_kin/git/Coursework/work/work/work/bin/Debug/Sample_BeeMoved_96kHz24bit_converted.flac");
                FFT fft = new FFT();
                var b = fft.fft(a);
                string path = "/home/egor_kin/git/Coursework/work/work/work/out.csv";
                var csv = new StringBuilder();
                foreach (var i in b)
                {
                    var newLine = string.Format("{0},{1}", i.Real, i.Imaginary);
                    csv.AppendLine(newLine);
                }
                File.WriteAllText(path, csv.ToString());

                var csv1 = new StringBuilder();
                foreach (var j in a)
                {
                    var newLine = string.Format("{0},{1}", j.Real, j.Imaginary);
                    csv1.AppendLine(newLine);
                }
                File.WriteAllText("/home/egor_kin/git/Coursework/work/work/work/out1.csv", csv1.ToString());
            }
            catch(Exception error)
            {
                Console.WriteLine("Error:" + error.Message);
            }
        }
    }
}

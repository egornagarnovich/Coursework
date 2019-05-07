using System.IO;

namespace work
{
  public class AudioConverter
  {
    enum Arguments
    {
      pathToFlacFile,
      bitrate,
    }

    public void Convert(ref string[] args)
    {
      ConvertFlacToMp3(ref args);
      ConvertMp3ToFlac(ref args);
      File.Delete("/home/egor_kin/git/Coursework/audio_files/out.mp3");
      ConvertFlacToWav(ref args);
    }

    public void ConvertFlacToMp3(ref string[] args)
    {
      string bashCommandFlacToMp3 = GetCommandFlacToMp3Convert(ref args);
      ShellHelper.Bash(bashCommandFlacToMp3);
    }

    public void ConvertMp3ToFlac(ref string[] args)
    {
      string bashCommandMp3ToFlac = GetCommandMp3ToFlacConvert(ref args);
      ShellHelper.Bash(bashCommandMp3ToFlac);
    }

    public void ConvertFlacToWav(ref string[] args)
    {
      string bashCommandFlacToWav = GetCommandFlacToWavConvert(ref args);
      ShellHelper.Bash(bashCommandFlacToWav);
    }

    public string GetCommandFlacToWavConvert(ref string[] args)
    {
      string outNameFile = Path.GetFileNameWithoutExtension(args[(int)Arguments.pathToFlacFile]);
      string bashCommand = string.Concat("ffmpeg -i ", args[(int)Arguments.pathToFlacFile], " ", outNameFile, ".wav");
      return bashCommand;
    }

    public string GetCommandFlacToMp3Convert(ref string[] args)
    {
      string bashCommand = string.Concat("ffmpeg -i ", args[(int)Arguments.pathToFlacFile], " -b:a ",
                                         args[(int)Arguments.bitrate], " /home/egor_kin/git/Coursework/audio_files/out.mp3");
      return bashCommand;
    }

    public string GetCommandMp3ToFlacConvert(ref string[] args)
    {
      string outNameFile = string.Concat(Path.GetFileNameWithoutExtension(args[(int)Arguments.pathToFlacFile]), "_converted");
      string bashCommand = string.Concat("ffmpeg -i /home/egor_kin/git/Coursework/audio_files/out.mp3 -b:a ", args[(int)Arguments.bitrate],
                                         " ", outNameFile, ".flac");
      return bashCommand;
    }
  }
}
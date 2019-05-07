using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using Microsoft.Win32;
using NAudio.Wave;
using System.Windows;

namespace AudioModule
{
    class ApplicationViewModel : INotifyPropertyChanged
    {
        private Audio selectedPhone;

        public ObservableCollection<Audio> Audios { get; set; }
        public Audio SelectedAudio
        {
            get { return selectedPhone; }
            set
            {
                selectedPhone = value;
                OnPropertyChanged("SelectedAudio");
            }
        }

        public void MenuItemOpenClick()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Audio file (*.mp3;*.wav)|*.mp3; *.wav; *.flac;";
            if (openFileDialog.ShowDialog() != true)
                return;
            Audios = new ObservableCollection<Audio> {};
            AddAudio(openFileDialog);
            OnPropertyChanged("Audios");
        }

        public void AddAudio(OpenFileDialog audioInfo)
        {
            Audios.Add(new Audio { FileName = audioInfo.FileName, Format = audioInfo.Title, Size = 15 });
        }

        public ApplicationViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}

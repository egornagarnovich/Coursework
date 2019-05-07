using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AudioModule
{
    public delegate void ClickButton();

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationViewModel _viewModel = new ApplicationViewModel();
        public static event ClickButton OpenFile;
        public static event ClickButton SaveFile;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = _viewModel;
            OpenFile = _viewModel.MenuItemOpenClick;

        }

        private void MenuItemOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFile?.Invoke();
        }

        private void MenuItemSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonFlacToMp3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonMp3ToFlac_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonFlacToWav_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

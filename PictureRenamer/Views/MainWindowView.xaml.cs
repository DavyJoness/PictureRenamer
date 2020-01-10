using System;
using System.Windows;
using System.Windows.Controls;


namespace PictureRenamer.Views
{
    /// <summary>
    /// Interaction logic for MainWindowView.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            InitializeComponent();
        }

        private void Log_TextChanged(object sender, TextChangedEventArgs e)
        {
            (sender as TextBox).ScrollToEnd();
        }

        private void Run_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Content.ToString() == "Rozpocznij")
                (sender as Button).Content = "Stop";
            else
                (sender as Button).Content = "Rozpocznij";
        }

        private void Complete_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if((sender as ProgressBar).Value == 100)
                Run.Content = "Rozpocznij";
        }
    }
}

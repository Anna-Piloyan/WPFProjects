using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<string> styles = new List<string> { "Default", "Blue", "Green" };
            combobox.SelectionChanged += Skin_Selection;
            combobox.ItemsSource = styles;
            combobox.SelectedItem = "Default";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mediaScreen.Stop();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mediaScreen.Play();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            mediaScreen.Pause();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.AddExtension = true;
            openFile.DefaultExt = "*.*";
            openFile.Filter = "Media Files (*.*)|*.*";
            openFile.ShowDialog();
            try { mediaScreen.Source = new Uri(openFile.FileName); }
            catch { new NullReferenceException("Error"); }

            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
            mediaScreen.Play();

        }

        void timer_Tick(object sender, EventArgs e)
        {
            slider.Value = mediaScreen.Position.TotalSeconds;
        }

        private void slider_ValueChange(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TimeSpan ts = TimeSpan.FromSeconds(e.NewValue);
            mediaScreen.Position = ts;
        }

        private void volume_ValueChange(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaScreen.Volume = volume.Value;
        }

        private void screen_MediaOpened(object sender, RoutedEventArgs e)
        {
            if(mediaScreen.NaturalDuration.HasTimeSpan)
            {
                TimeSpan ts = TimeSpan.FromMilliseconds(mediaScreen.NaturalDuration.TimeSpan.TotalMilliseconds);
                slider.Maximum = ts.TotalSeconds;
            }
        }

        private void Skin_Selection(object sender, SelectionChangedEventArgs e)
        {
            string style = combobox.SelectedItem as string;
            var uri = new Uri(@"Skins\" + style + ".xaml", UriKind.Relative);
            ResourceDictionary resourceDict = System.Windows.Application.LoadComponent(uri) as ResourceDictionary;
            System.Windows.Application.Current.Resources.Clear();
            System.Windows.Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }
    }
}

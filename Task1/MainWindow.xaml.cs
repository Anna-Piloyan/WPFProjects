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

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        class AnswerGenerator
        {

            string[] Answers = new string[]{
           "Ask Again later","Can Not Predict Now","Without a Doubt",
           "Is Decidely So","Concentrate and Ask Again","My Sources Say No",
           "Yes, Definitely","Don't Count On It","Signs Point to Yes",
           "Better Not Tell You Now","Outlook Not So Good","Most Likely",
           "Very Doubtful","As I See It, Yes","My Reply is No","It Is Certain",
           "Yes","You May Rely On It","Outlook Good","Reply Hazy Try Again"
        };

            public string GetRandomAnswer(string question)
            {
                Random rnd = new Random();
                return Answers[rnd.Next(0, Answers.Length)];
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
            AnswerGenerator generator = new AnswerGenerator();
            answer.Text = generator.GetRandomAnswer(question.Text);
            this.Cursor = null;
        }
    }
}

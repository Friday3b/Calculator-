using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator_new_one
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double first;
        double second;

        char op; // first work is this in code 



        public MainWindow()
        {
            InitializeComponent();
        }


        private void Clear_Button (object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            board.Clear();



        }

       
     

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button  = sender as Button;
            board.Text += button.Content.ToString();
            Double.TryParse(board.Text , out second);
            
            
        }


        private void Percent_Button (object sender ,RoutedEventArgs eventArgs)
        {

            Double.TryParse(board.Text, out first);
            op = '%';
            board.Clear(); 


        }


      

        private void DivideButton_Click (object sender, RoutedEventArgs e)
        {
            Double.TryParse(board.Text , out first);
            op = '/';
            board.Clear();
        }

        private void MultipleButton_Click(object sender, RoutedEventArgs e)
        {
            Double.TryParse(board.Text, out first);
            op = '*';
            board.Clear();
        }
        private void SubButton_Click(object sender, RoutedEventArgs e)
        {
            Double.TryParse(board.Text, out first);
            op = '-';
            board.Clear();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Double.TryParse(board.Text, out first);
            op = '+';
            board.Clear();
        }

        private void Double_Button(object sender, RoutedEventArgs e)
        {
            Double.TryParse(board.Text , out first);
            op = '^';
            board.Clear();


        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            Double.TryParse(board.Text, out second);
            double result = 0;

            if (op =='+')
            {
                result = first + second; 
                

            }
            else if (op == '-')
            {
                result = first - second;
            }
            else if (op ==  '*')
            {
                result = first * second;
            }
            else if(op == '/')
            {
                result = first / second;
            }
            else if (op == '%')
            {
                result = first * (second/100); 
            }            
            else if(op == '^')
            {

                result = first * first;
            }
            
            if (board.Text == "0")
            {
                board.Clear();
            }

            board.Text = result .ToString(); 


        }




    }
}
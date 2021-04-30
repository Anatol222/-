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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Image myImage3 = new Image();
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri(@"C:\Users\User\Desktop\f1.png");
            bi3.EndInit();
            myImage3.Stretch = Stretch.Fill;
            myImage3.Source = bi3;
            But.Content = myImage3;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            string result = ReversePN.ToRPN(TextBox.Text);
            label1.Content = "RPN Expression: " + result;
            label2.Content = "Answer: " + ReversePN.CalculateRPN(result,10);
        }
    }
}

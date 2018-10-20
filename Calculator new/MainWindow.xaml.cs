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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int ip1 = Convert.ToInt32(textbox1.Text);
            int ip2 = Convert.ToInt32(textbox2.Text);

            Arithmetic obj = new Arithmetic(ip1, ip2);
            textbox3.Text = obj.Add().ToString();
        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textbox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int ip1 = Convert.ToInt32(textbox1.Text);
            int ip2 = Convert.ToInt32(textbox2.Text);

            Arithmetic obj = new Arithmetic(ip1, ip2);
            textbox3.Text = obj.Sub().ToString();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int ip1 = Convert.ToInt32(textbox1.Text);
            int ip2 = Convert.ToInt32(textbox2.Text);

            Arithmetic obj = new Arithmetic(ip1, ip2);
            textbox3.Text = obj.mul().ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int ip1 = Convert.ToInt32(textbox1.Text);
            int ip2 = Convert.ToInt32(textbox2.Text);

            Arithmetic obj = new Arithmetic(ip1, ip2);
            textbox3.Text = obj.div().ToString();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            int ip1 = Convert.ToInt32(textbox4.Text);

            Arithmetic obj = new Arithmetic(ip1);
            textbox5.Text = obj.ConvertBin();
            textbox6.Text = obj.ConvertOct();
            textbox7.Text = obj.ConvertHex();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "";
            textbox2.Text = "";
            textbox3.Text = "";
            textbox4.Text = "";
            textbox5.Text = "";
            textbox6.Text = "";
            textbox7.Text = "";
        }
    }
    public class Arithmetic
    {
        public int no1, no2, no3;

        public Arithmetic()
        {
            no1 = 0;
            no2 = 0;
            no3 = 0;
        }
        public Arithmetic(int val1, int val2)
        {
            no1 = val1;
            no2 = val2;
        }
        public Arithmetic(int val1)
        {
            no3 = val1;
        }
        public int Add()
        {
            return no1 + no2;

        }
        public int Sub()
        {
            return no1 - no2;

        }
        public int mul()
        {
            return no1 * no2;

        }
        public int div()
        {
            return no1 / no2;
        }
        public string ConvertBin()
        {
            String Bin = Convert.ToString(no3, 2);
            return Bin;
        }
        public string ConvertOct()
        {
            String Bin = Convert.ToString(no3, 8);
            return Bin;
        }
        public string ConvertHex()
        {
            String Bin = Convert.ToString(no3, 16);
            return Bin;
        }
    }
}

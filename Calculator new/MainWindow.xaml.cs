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
        int ip1, ip2;
        char operation;
        Arithmetic aobj;
        public MainWindow()
        {

            aobj = new Arithmetic();
            InitializeComponent();
        }
        

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "";
            textbox2.Text = "";
            textbox3.Text = "";
            textbox4.Text = "";
       }
       
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textbox1.Text.Length != 0)
            {
                int no = Convert.ToInt32(textbox1.Text);
                textbox2.Text = Convert.ToString(no, 2);
                textbox3.Text = Convert.ToString(no, 8);
                textbox4.Text = Convert.ToString(no, 16);
            }
            else
            {
                textbox2.Text = "";
                textbox3.Text = "";
                textbox4.Text = "";

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button obj = sender as Button;
            string strip = obj.Content.ToString();
          
            if (strip[0] >= '0' && strip[0] <= '9')
            {
                textbox1.Text = textbox1.Text + strip;
               
            }
            else if(strip[0]=='-' || strip[0] == '+' || strip[0] == '*' || strip[0] == '/')
            {
                operation = strip[0];
                ip1 = Convert.ToInt32(textbox1.Text);
                textbox1.Text = "";
            }
            else if(strip[0] == '=')
            {
                ip2 = Convert.ToInt32(textbox1.Text);
                textbox1.Text = "";
               

                if (operation== '+')
                {
                    aobj.no1 = ip1;
                    aobj.no2 = ip2;
                    textbox1.Text = aobj.Add().ToString();

                }
                else if (operation == '-')
                {
                    aobj.no1 = ip1;
                    aobj.no2 = ip2;
                    textbox1.Text = aobj.Sub().ToString();

                }
                else if (operation == '*')
                {
                    aobj.no1 = ip1;
                    aobj.no2 = ip2;
                    textbox1.Text = aobj.mul().ToString();

                }
                else if (operation == '/')
                {
                    aobj.no1 = ip1;
                    aobj.no2 = ip2;
                    textbox1.Text = aobj.div().ToString();

                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(textbox1.Text.Length!=0)
            {
                
                textbox1.Text = textbox1.Text.Remove(textbox1.Text.Length - 1);
            }
        }

       
    }
 
}

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


namespace WpfAppПр1
{
    public partial class MainWindow : Window
    {


        
        int[] arryi = new int[9];
        Button[] but = new Button[9];

        public MainWindow()
        {
            InitializeComponent();        
            but[0] = button1;
            but[1] = button2;
            but[2] = button3;
            but[3] = button4;
            but[4] = button5;
            but[5] = button6;
            but[6] = button7;
            but[7] = button8;
            but[8] = button9;

            Lable1.Content = " ";
        }
        private void Bot()
        {
            Random random = new Random();
            var button = (but[random.Next(0,8)]);
            
                for (int i = 0;i < but.Length; i++)
                {                   
                    if (button == but[i] && button.IsEnabled    ) 
                    {
                        but[i].Content = "O";
                        but[i].IsEnabled = false;
                        arryi[i] = 2;

                    }                                 
                }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            for (int i = 0; i < but.Length; i++) 
            {                               
                if (sender == but[i])
                {
                    but[i].Content= "X";
                    but[i].IsEnabled=false;
                    arryi[i] = 1;
                }
                else 
                { 
                    Bot();
                }
                                      
                
            }
            

            if (arryi[0] == 1 && arryi[1] == 1 && arryi[2] == 1)
            {
                Lable1.Content = "Вы победили";
            }
            else if (arryi[3] == 1 && arryi[4] == 1 && arryi[5] == 1)
            {
                Lable1.Content = "Вы победили";
            }
            else if (arryi[6] == 1 && arryi[7] == 1 && arryi[8] == 1)
            {
                Lable1.Content = "Вы победили";
            }
            else if (arryi[0] == 1 && arryi[3] == 1 && arryi[6] == 1)
            {
                Lable1.Content = "Вы победили";
            }
            else if (arryi[1] == 1 && arryi[4] == 1 && arryi[7] == 1)
            {
                Lable1.Content = "Вы победили";
            }
            else if (arryi[2] == 1 && arryi[5] == 1 && arryi[8] == 1)
            {
                Lable1.Content = "Вы победили";
            }
            else if (arryi[0] == 1 && arryi[4] == 1 && arryi[8] == 1)
            {
                Lable1.Content = "Вы победили";
            }
            else if (arryi[2] == 1 && arryi[4] == 1 && arryi[6] == 1)
            {
                Lable1.Content = "Вы победили";
            }
            /////////////////////////////////////////////////////
            else if (arryi[0] == 2 && arryi[1] == 2 && arryi[2] == 2)
            {
                Lable1.Content = "Вы проиграли";
            }
            else if (arryi[3] == 2 && arryi[4] == 2 && arryi[5] == 2)
            {
                Lable1.Content = "Вы проиграли";
            }
            else if (arryi[6] == 2 && arryi[7] == 2 && arryi[8] == 2)
            {
                Lable1.Content = "Вы проиграли";
            }
            else if (arryi[0] == 2 && arryi[3] == 2 && arryi[6] == 2)
            {
                Lable1.Content = "Вы проиграли";
            }
            else if (arryi[1] == 2 && arryi[4] == 1 && arryi[7] == 2)
            {
                Lable1.Content = "Вы проиграли";
            }
            else if (arryi[2] == 2 && arryi[5] == 2 && arryi[8] == 2)
            {
                Lable1.Content = "Вы проиграли";
            }
            else if (arryi[0] == 2 && arryi[4] == 2 && arryi[8] == 2)
            {
                Lable1.Content = "Вы проиграли";
            }
            else if (arryi[2] == 2 && arryi[4] == 2 && arryi[6] == 2)
            {
                Lable1.Content = "Вы проиграли";
            }

        }

        private void Sbros_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < but.Length; i++)
            {
                arryi[i] = 0;
                but[i].Content = " ";
                but[i].IsEnabled = true;
                Lable1.Content = " ";

            }
            


        }
    }

}

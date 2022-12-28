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
using static System.Net.Mime.MediaTypeNames;

namespace amimation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int click;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            click++;
            if (click % 2 != 0)
            {
                fireOne.Visibility = Visibility.Visible;
                fireTwo.Visibility = Visibility.Visible;
                fireThree.Visibility = Visibility.Visible;
                fireFour.Visibility = Visibility.Visible;
                fireFive.Visibility = Visibility.Visible;
                fireSix.Visibility = Visibility.Visible;
                fireSeven.Visibility = Visibility.Visible;
                fireEight.Visibility = Visibility.Visible;
                fireNine.Visibility = Visibility.Visible;
            }
            else
            {
                fireOne.Visibility = Visibility.Hidden;
                fireTwo.Visibility = Visibility.Hidden;
                fireThree.Visibility = Visibility.Hidden;
                fireFour.Visibility = Visibility.Hidden;
                fireFive.Visibility = Visibility.Hidden;
                fireSix.Visibility = Visibility.Hidden;
                fireSeven.Visibility = Visibility.Hidden;
                fireEight.Visibility = Visibility.Hidden;
                fireNine.Visibility = Visibility.Hidden;
            }
            


        }
    }
}
    

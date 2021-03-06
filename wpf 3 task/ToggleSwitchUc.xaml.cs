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

namespace wpf_3_task
{
    /// <summary>
    /// Логика взаимодействия для ToggleSwitchUc.xaml
    /// </summary>
    public partial class ToggleSwitchUc : UserControl
    {


        Thickness Left = new Thickness(-39, 0, 0, 0);
        Thickness Right = new Thickness(0, 0, -39, 0);
        SolidColorBrush Off = new SolidColorBrush(Color.FromRgb(160, 160, 160));
        SolidColorBrush On = new SolidColorBrush(Color.FromRgb(130, 190, 125));
        private bool Toggled = false;
        public ToggleSwitchUc()
        {
            InitializeComponent();
            Back.Fill = Off;
            Toggled = false;
            Dot.Margin = Left;
        }
        public bool Toggled1 { get => Toggled; set => Toggled = value; }


        private void Dot_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!Toggled)
            {
                Back.Fill = On;
                Toggled = true;
                Dot.Margin = Right;
            }
            else
            {
                Back.Fill = Off;
                Toggled = false;
                Dot.Margin = Left;
            }
        }

        private void Back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!Toggled)
            {
                Back.Fill = On;
                Toggled = true;
                Dot.Margin = Right;
            }
            else
            {
                Back.Fill = Off;
                Toggled = false;
                Dot.Margin = Left;
            }
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}

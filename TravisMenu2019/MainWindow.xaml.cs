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


namespace TravisMenu2019
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

       /* private void doubleAnimationDemo(object sender, RoutedEventArgs e)
        {
            FrameworkElement alpha = sender as FrameworkElement;
            //if (alpha.Height == 1.0 && alpha.Width == 1.0)
            //{
                DoubleAnimation beta = new DoubleAnimation(0.0, new Duration(TimeSpan.FromSeconds(3)));
                alpha.BeginAnimation(UserControl., beta);
            //}
        }*/

        private void QuitButton_Click(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
        private void QuitButton_Click(object sender, TouchEventArgs e)
        {
            Close();
        }

        private void Button_Enter(object sender, MouseEventArgs e)
        {
            Rectangle r = sender as Rectangle;
            r.SetValue(Rectangle.MarginProperty, new Thickness(r.Margin.Left-2.5, r.Margin.Top-2.5, r.Margin.Right, r.Margin.Bottom) );
            r.Width += 5.0;
            r.Height += 5.0;
        }

        private void Button_Leave(object sender, MouseEventArgs e)
        {
            Rectangle r = sender as Rectangle;
            r.SetValue(Rectangle.MarginProperty, new Thickness(r.Margin.Left + 2.5, r.Margin.Top + 2.5, r.Margin.Right, r.Margin.Bottom));
            r.Width -= 5.0;
            r.Height -= 5.0;
        }

        private void Button_Enter(object sender, TouchEventArgs e)
        {
            Rectangle r = sender as Rectangle;
            r.SetValue(Rectangle.MarginProperty, new Thickness(r.Margin.Left - 2.5, r.Margin.Top - 2.5, r.Margin.Right, r.Margin.Bottom));
            r.Width += 5.0;
            r.Height += 5.0;
        }

        private void Button_Leave(object sender, TouchEventArgs e)
        {
            Rectangle r = sender as Rectangle;
            r.SetValue(Rectangle.MarginProperty, new Thickness(r.Margin.Left + 2.5, r.Margin.Top + 2.5, r.Margin.Right, r.Margin.Bottom));
            r.Width -= 5.0;
            r.Height -= 5.0;
        }
    }
}

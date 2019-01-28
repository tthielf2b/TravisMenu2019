using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
using TravisMenu2019.Model;
using System.Windows.Forms;


namespace TravisMenu2019
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
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

        private void Button_Enter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            //    if (B1.IsMouseDirectlyOver || B1.AreAnyTouchesDirectlyOver)
            //    {
            //        I1.Source = new BitmapImage(new Uri("C:\\Users\\hp-800_G2-011\\Desktop\\TJ Projects\\TravisMenu2019\\TravisMenu2019\\Util\\Cats\\cat1.jpg"));
            //    }
            //    else if (B2.IsMouseDirectlyOver || B2.AreAnyTouchesDirectlyOver)
            //    {
            //        I1.Source = new BitmapImage(new Uri("C:\\Users\\hp-800_G2-011\\Desktop\\TJ Projects\\TravisMenu2019\\TravisMenu2019\\Util\\Dogs\\dog1.jpg"));
            //    }
            Rectangle r = sender as Rectangle;
            r.SetValue(Rectangle.MarginProperty, new Thickness(r.Margin.Left - 2.5, r.Margin.Top - 2.5, r.Margin.Right, r.Margin.Bottom));
            r.Width += 5.0;
            r.Height += 5.0;
        }

        private void Button_Leave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Rectangle r = sender as Rectangle;
            r.SetValue(Rectangle.MarginProperty, new Thickness(r.Margin.Left + 2.5, r.Margin.Top + 2.5, r.Margin.Right, r.Margin.Bottom));
            r.Width -= 5.0;
            r.Height -= 5.0;
        }

        private void Button_Enter(object sender, TouchEventArgs e)
        {
            //    if (B1.IsMouseDirectlyOver||B1.AreAnyTouchesDirectlyOver)
            //    {
            //        I1.Source = new BitmapImage(new Uri("C:\\Users\\hp-800_G2-011\\Desktop\\TJ Projects\\TravisMenu2019\\TravisMenu2019\\Util\\Cats\\cat1.jpg"));
            //    }else if(B2.IsMouseDirectlyOver || B2.AreAnyTouchesDirectlyOver)
            //    {
            //        I1.Source = new BitmapImage(new Uri("C:\\Users\\hp-800_G2-011\\Desktop\\TJ Projects\\TravisMenu2019\\TravisMenu2019\\Util\\Dogs\\dog1.jpg"));
            //    }
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

        private void Image_Click(object sender, MouseButtonEventArgs e)
        {
            Image i = sender as Image;
            I1.Source = i.Source;
        }

        private void Image_Click(object sender, TouchEventArgs e)
        {
            Image i = sender as Image;
            I1.Source = i.Source;
        }

        private void Add_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.Categorys.Add(new CategoryControl());
        }

        private void AddSub_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (CategoryPanel.SelectedItem != null)
            {
                CategoryControl temp = (CategoryControl)CategoryPanel.SelectedItem;
                temp.SubCats.Add(new SubCat());
            }
        }

  

        private void CategoryPanel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (CategoryPanel.SelectedItem != null)
            {
                SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.SelectedCat = (CategoryControl)CategoryPanel.SelectedItem;
                RaisePropertyChanged("SelectedCat");
                RaisePropertyChanged("Dir");
                //if (SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.SelectedCat.Dir != null)
                //{
                //    SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.Thumbs.Clear();
                //    //Thumbnails.Items.Clear();
                //    DirectoryInfo catFolder = new DirectoryInfo(SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.SelectedCat.Dir);
                //    FileInfo[] cats = catFolder.GetFiles("*", SearchOption.AllDirectories);
                //    foreach (FileInfo c in cats)
                //    {

                //        SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.Thumbs.Add(c.FullName);
                //        //Thumbnails.Items.Add(c.FullName);
                //    }
                //}
                //else
                //{
                //    SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.Thumbs.Clear();
                //    //Thumbnails.Items.Clear();
                //}
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        private void DirButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (CategoryPanel.SelectedItem != null)
            {

                FolderBrowserDialog f = new FolderBrowserDialog();
                f.ShowDialog();
                SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.SelectedCat.Dir = f.SelectedPath;
                CategoryDir.Text = f.SelectedPath;
                RaisePropertyChanged("Dir");

            }
        }

        private void SubDirButton_Click(object sender, RoutedEventArgs e)
        {
            if (CategoryPanel.SelectedItem != null)
            {

                FolderBrowserDialog f = new FolderBrowserDialog();
                f.ShowDialog();
                SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.SelectedCat.SelectedSubCat.SubDir = f.SelectedPath;
                SubCategoryDir.Text = f.SelectedPath;
                RaisePropertyChanged("SubDir");

            }
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                if(SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.IsEdit == Visibility.Hidden)
                {
                    editgrid.Visibility = Visibility.Visible;
                    editgrid.Width = 200;
                }
                else
                {
                    editgrid.Visibility = Visibility.Hidden;
                    editgrid.Width = 0;
                }
               
            }
        }

        private void Delete_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if(SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.SelectedCat!= null)
            {
                if (SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.SelectedCat.SelectedSubCat != null)
                {
                    SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.SelectedCat.SubCats.Remove(SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.SelectedCat.SelectedSubCat);
                    SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.SelectedCat.SelectedSubCat = null;
                }
                else
                {
                    SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.Categorys.Remove(SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.SelectedCat);
                    SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.SelectedCat = null;
                }
            }
        }

        private void BGChange_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            //dlg.Filter = "*.jpg|*.png|*.JPG|*.PNG";
            if( dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.BackGround = new BitmapImage(new Uri(dlg.FileName));
            }

            
        }
    }
}

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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TravisMenu2019.Model;

namespace TravisMenu2019.View
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class CatagoryControl : UserControl, INotifyPropertyChanged
    {
        public CatagoryControl()
        {
            InitializeComponent();
        }

        private void Button_Enter(object sender, MouseEventArgs e)
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

        private void Button_Leave(object sender, MouseEventArgs e)
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


        private void SubCategoryPanel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SubCategoryPanel.SelectedItem != null)
            {
                SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.SelectedCat.SelectedSubCat = (SubCat)SubCategoryPanel.SelectedItem;
                RaisePropertyChanged("SelectedSubCat");
                RaisePropertyChanged("SubDir");



                //    if (SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.SelectedCat.SelectedSubCat.SubDir != null)
                //    {
                //        SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.Thumbs.Clear();
                //        DirectoryInfo catFolder = new DirectoryInfo(SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.SelectedCat.SelectedSubCat.SubDir);
                //        FileInfo[] cats = catFolder.GetFiles("*", SearchOption.AllDirectories);
                //        foreach (FileInfo c in cats)
                //        {
                //            SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.Thumbs.Add(c.FullName);
                //        }
                //    }
                //    else
                //    {
                //        SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.Thumbs.Clear();
                ////    }








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

        private void CatagoryButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            CategoryControl temp = SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.SelectedCat;

            if (temp != null)
            {
                //SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.SelectedCat = temp;
               // RaisePropertyChanged("SelectedCat");
                //RaisePropertyChanged("Dir");
                if (SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.SelectedCat.Dir != null)
                {
                    SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.Thumbs.Clear();
                    //Thumbnails.Items.Clear();
                    DirectoryInfo catFolder = new DirectoryInfo(SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.SelectedCat.Dir);
                    FileInfo[] cats = catFolder.GetFiles("*", SearchOption.AllDirectories);
                    foreach (FileInfo c in cats)
                    {

                        SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.Thumbs.Add(c.FullName);
                        //Thumbnails.Items.Add(c.FullName);
                    }
                }
                else
                {
                    SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.Thumbs.Clear();
                    //Thumbnails.Items.Clear();
                }
            }
        }
    }
}

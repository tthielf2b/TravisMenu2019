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
    /// Interaction logic for SubCatControl.xaml
    /// </summary>
    public partial class SubCatControl : UserControl, INotifyPropertyChanged
    {
        public SubCatControl()
        {
            InitializeComponent();
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

        }

        private void SubCatagoryButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SubCat temp = SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.SelectedCat.SelectedSubCat;

            if (temp != null)
            {
                //SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.SelectedCat.SelectedSubCat = temp;
                //RaisePropertyChanged("SelectedSubCat");
                //RaisePropertyChanged("SubDir");



                if (SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.SelectedCat.SelectedSubCat.SubDir != null)
                {
                    SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.Thumbs.Clear();
                    DirectoryInfo catFolder = new DirectoryInfo(SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.SelectedCat.SelectedSubCat.SubDir);
                    FileInfo[] cats = catFolder.GetFiles("*", SearchOption.AllDirectories);
                    foreach (FileInfo c in cats)
                    {
                        SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.Thumbs.Add(c.FullName);
                    }
                }
                else
                {
                    SimpleIoc.Default.GetInstance<ViewModel.MainViewModel>().Mw.Thumbs.Clear();
                }
            }
        }



        private void Button_Enter(object sender, MouseEventArgs e)
        {
           
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

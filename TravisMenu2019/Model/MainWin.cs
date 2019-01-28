using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TravisMenu2019.Model
{
    public class MainWin:INotifyPropertyChanged
    {
        public MainWin()
        {
            
        }



        public ObservableCollection<CategoryControl> Categorys { get; set; } = new ObservableCollection<CategoryControl>();
        public ObservableCollection<string> Thumbs { get; set; } = new ObservableCollection<string>();


        private string _BG = @"C:\Users\hp-800_G2-011\Desktop\TJ Projects\TravisMenu2019\TravisMenu2019\Content\Pres1\LookandFeel\MenuBackground00.jpg";

        public ImageSource BackGround
        {
            get { return new BitmapImage(new Uri(_BG)); }
            set
            {
                _BG = value.ToString();
                RaisePropertyChanged("BackGround");
            }
        }

        private CategoryControl _SelectedCat;
        public CategoryControl SelectedCat {
            get
            {
                return _SelectedCat;
            }
            set
            {
                _SelectedCat = value;
                RaisePropertyChanged("SelectedCat");
            }
        }
 

        private Visibility _IsEdit = Visibility.Visible;
        public Visibility IsEdit {
            get
            {
                return _IsEdit;
            }
            set
            {
                _IsEdit = value;
                RaisePropertyChanged("IsEdit");
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
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravisMenu2019.Model
{
    public class CategoryControl:INotifyPropertyChanged
    {

        // add constructors for default,name only, name + dir, Name + dir+ subcat list
        public CategoryControl()
        {
            CatName = "Default Category Name";
            
        }



        public ObservableCollection<SubCat> SubCats { get; set; } = new ObservableCollection<SubCat>();


        private SubCat _SelectedSubCat;
        public SubCat SelectedSubCat {
            get
            {
                return _SelectedSubCat;
            }
            set
            {
                _SelectedSubCat = value;
                RaisePropertyChanged("SelectedSubCat");
            }
        } 
        
            

        private string _Dir;
        public string Dir
        {
            get
            {
                return _Dir;
            }
            set
            {
                _Dir = value;
                RaisePropertyChanged("Dir");
            }
        }

        private string _CatName = "Cats";

        public string CatName
        {
            get
            {
                return _CatName;
            }
            set
            {
                _CatName = value;
                RaisePropertyChanged("CatName");
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravisMenu2019.Model
{
    public class SubCat:INotifyPropertyChanged
    {

        public SubCat()
        {
            SubCatName = "Default Sub Name";

        }
        private string _SubCatName;
        public string SubCatName
        {
            get
            {
                return _SubCatName;
            }
            set
            {
                _SubCatName = value;
                RaisePropertyChanged("SubCatName");
                
            }
        }

        private string _SubDir;
        public string SubDir
        {
            get
            {
                return _SubDir;
            }
            set
            {
                _SubDir = value;
                RaisePropertyChanged("SubDir");
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

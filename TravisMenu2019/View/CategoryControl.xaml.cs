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

namespace TravisMenu2019.View
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class CatagoryControl : UserControl
    {
        public CatagoryControl()
        {
            InitializeComponent();
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
            }
        }
    }
}

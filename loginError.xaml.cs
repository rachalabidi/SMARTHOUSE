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
using System.Windows.Shapes;

namespace SHINS
{
    /// <summary>
    /// Interaction logic for loginError.xaml
    /// </summary>
    public partial class loginError : Window
    {
        public loginError()
        {
            InitializeComponent();
        }

        private void Cls_btn_error_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}

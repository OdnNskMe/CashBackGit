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

namespace CashBackBaseLibrary
{
    /// <summary>
    /// Логика взаимодействия для fLogin.xaml
    /// </summary>
    public partial class fLogin : Window
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void bConnectSet_Click(object sender, RoutedEventArgs e)
        {
            fSettingConnect FRM = new fSettingConnect();
            FRM.ShowDialog();
        }
    }
}

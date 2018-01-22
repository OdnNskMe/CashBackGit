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

namespace CashBack
{
    /// <summary>
    /// Логика взаимодействия для fOperator.xaml
    /// </summary>
    public partial class fOperators : Window
    {
        public fOperators()
        {
            InitializeComponent();
        }

        private void bOperatorAdd_Click(object sender, RoutedEventArgs e)
        {
            fOperatorSet FRM = new fOperatorSet();
            FRM.ShowDialog();
        }

        private void bOperatorEdit_Click(object sender, RoutedEventArgs e)
        {
            fOperatorSet FRM = new fOperatorSet();
            FRM.ShowDialog();
        }


    }
}

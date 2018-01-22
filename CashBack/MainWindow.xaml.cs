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

namespace CashBack
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bOperator_Click(object sender, RoutedEventArgs e)
        {
            fOperators FRM = new fOperators();
            FRM.ShowDialog();
        }

        private void bClients_Click(object sender, RoutedEventArgs e)
        {
            fClients FRM = new fClients();
            FRM.ShowDialog();
        }

        private void bTemplatesDoc_Click(object sender, RoutedEventArgs e)
        {
            fTemplateDoc FRM = new fTemplateDoc();
            FRM.ShowDialog();
        }

        private void bOrgan_Click(object sender, RoutedEventArgs e)
        {
            fOrgan FRM = new fOrgan();
            FRM.ShowDialog();
        }
    }
}

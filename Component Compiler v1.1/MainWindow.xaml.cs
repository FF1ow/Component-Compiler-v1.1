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

namespace Component_Compiler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {

            InitializeComponent();
        }



        private void cboUse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cboUse.Items.Add("Gaming");
            cboUse.Items.Add("Office");
        }

        private void cboCPU_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cboCPU.Items.Add("Ryzen 5 3600");
        }

        private void cboMobo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cboMobo.Items.Add("MSI B450M-A PRO MAX mATX");
        }

        private void cboRAM_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cboRAM.Items.Add("Corsair Vengeance LPX 16GB");
        }

        private void cboGPU_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cboGPU.Items.Add("EVGA XC GAMING RTX 3060");
        }

        private void btnGenPartslist_Click(object sender, RoutedEventArgs e)
        {
            bool isNull = false;

            if (string.IsNullOrEmpty(cboUse.Text))
            {
                isNull = true;
            }
            if (int.TryParse(txtBudget.Text, out int budget) && (isNull = false))
            {
                MessageBox.Show("here's your gucci list");
            }
            else MessageBox.Show("Try Again");
        }

        private void cboPSU_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cboPSU.Items.Add("EVGA 600 W 80+ Certified ATX Power Supply");
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLDA_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

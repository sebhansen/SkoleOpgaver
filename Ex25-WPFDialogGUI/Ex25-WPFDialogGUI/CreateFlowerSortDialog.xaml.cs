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

namespace Ex25_WPFDialogGUI
{
    /// <summary>
    /// Interaction logic for CreateFlowerSortDialog.xaml
    /// </summary>
    public partial class CreateFlowerSortDialog : Window
    {
        string empty = "";
        public FlowerSort CurrentFlowerSort;
        public CreateFlowerSortDialog()
        {
            InitializeComponent();
        }
        public string SortName
        {
            get { return tbSortName.Text; }
        }
        public string PicturePath
        {
            get { return tbSortImage.Text; }
        }
        public int ProductionTime
        {
            get { return int.Parse(tbSortProduction.Text); }
        }
        public int HalfLife
        {
            get { return int.Parse(tbSortHalfLife.Text); }
        }
        public int SortSize
        {
            get { return int.Parse(tbSortSize.Text); }
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            CurrentFlowerSort = new FlowerSort();

            CurrentFlowerSort.Name = SortName;
            CurrentFlowerSort.PicturePath = PicturePath;
            CurrentFlowerSort.ProductionTime = ProductionTime;
            CurrentFlowerSort.HalfLifeTime = HalfLife;
            CurrentFlowerSort.Size = SortSize;
            DialogResult = true;
            this.Close();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            App.Current.MainWindow.Show();
        }

        private void tbSortProduction_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                int.Parse(tbSortProduction.Text);
            }
            catch
            {
                MessageBox.Show("Produktionstid skal være et heltal");
                tbSortProduction.Text = "";
            }
            if (tbSortName.Text != empty && tbSortImage.Text != empty && tbSortProduction.Text != empty && tbSortHalfLife.Text != empty && tbSortSize.Text != empty)
            {
                btnOk.IsEnabled = true;
            }
        }

        private void tbSortHalfLife_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                int.Parse(tbSortHalfLife.Text);
            }
            catch
            {
                MessageBox.Show("Halveringstid skal være et heltal");
                tbSortHalfLife.Text = "";
            }
            if (tbSortName.Text != empty && tbSortImage.Text != empty && tbSortProduction.Text != empty && tbSortHalfLife.Text != empty && tbSortSize.Text != empty)
            {
                btnOk.IsEnabled = true;
            }
        }

        private void tbSortSize_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                int.Parse(tbSortSize.Text);
            }
            catch
            {
                MessageBox.Show("Størrelse skal være et heltal");
                tbSortSize.Text = "";
            }
        }

        private void tbSortSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbSortName.Text != empty && tbSortImage.Text != empty && tbSortProduction.Text != empty && tbSortHalfLife.Text != empty && tbSortSize.Text != empty)
            {
                btnOk.IsEnabled = true;
            }
        }
    }
}

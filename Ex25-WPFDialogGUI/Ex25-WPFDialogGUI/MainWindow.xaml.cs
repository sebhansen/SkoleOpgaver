﻿using System;
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

namespace Ex25_WPFDialogGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<FlowerSort> flowerSorts;
        public MainWindow()
        {
            InitializeComponent();
            flowerSorts = new List<FlowerSort>();
           
        }
         
        private void ShowFlowerSort()
        {
            string tbText = "";
            foreach (var flowerSort in flowerSorts)
            {
                tbText += $"{flowerSort.Name}\n";
            }
            TbList.Text = tbText;
        }

        private void btnCreateSort_Click(object sender, RoutedEventArgs e)
        {
            CreateFlowerSortDialog createFlowerSortDialog = new CreateFlowerSortDialog();
            if (createFlowerSortDialog.ShowDialog() == true)
            {
                flowerSorts.Add(createFlowerSortDialog.CurrentFlowerSort);
                ShowFlowerSort();
            }
        }
    }
}

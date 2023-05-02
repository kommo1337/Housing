using Housing.WindowFolder;
using HousingColledge.DataFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace HousingColledge.WindowFolder
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

        private void nameFilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            housingComplexDataGrid.ItemsSource = DBEntities.GetContext()
                .Housing.Where(u => u.Name_Housing_Complex
                .StartsWith(nameFilterTextBox.Text))
                .ToList().OrderBy(u => u.Name_Housing_Complex);
            if (housingComplexDataGrid.Items.Count <= 0)
            {
                MessageBox.Show("Данные не найдены");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new AddNewRecordWindow().ShowDialog();
        }
    }
}

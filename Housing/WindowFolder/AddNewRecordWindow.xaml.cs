using HousingColledge.DataFolder;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Housing.WindowFolder
{
    /// <summary>
    /// Логика взаимодействия для AddNewRecordWindow.xaml
    /// </summary>
    public partial class AddNewRecordWindow : Window
    {
        public AddNewRecordWindow()
        {
            InitializeComponent();
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtId.Text);
            int apartmentNumber = int.Parse(txtApartmentNumber.Text);
            decimal square = decimal.Parse(txtSquare.Text);
            int rooms = int.Parse(txtRooms.Text);
            int entrance = int.Parse(txtEntrance.Text);
            int storey = int.Parse(txtStorey.Text);
            string statusSale = txtStatusSale.Text;
            decimal additionalCost = decimal.Parse(txtAdditionalCost.Text);
            decimal costConstruction = decimal.Parse(txtCostConstruction.Text);

            // create a new instance of the context
            using (var context = new DBEntities())
            {
                // create a new instance of the Housing_Complex class
                var housingComplex = new Housing_Complex
                {
                    Id_Housing_Complex = id,
                    Apartment_Number = apartmentNumber,
                    Square = square,
                    Rooms = rooms,
                    Entrance = entrance,
                    Storey = storey,
                    Status_Sale = statusSale,
                    Additional_Cost_Of_Finishing = additionalCost,
                    Cost_Apartment_Construction = costConstruction
                };

                // add the new instance to the context
                context.Housing_Complex.Add(housingComplex);

                try
                {
                    // save changes to the database
                    context.SaveChanges();
                    MessageBox.Show("New record has been added successfully!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding new record: {ex.Message}");
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

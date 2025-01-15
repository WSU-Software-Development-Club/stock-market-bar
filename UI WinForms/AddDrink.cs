using Drink_Class_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_WinForms
{
    public partial class AddDrink : Form
    {
        AdminController admin_controller_instance;

        public AddDrink(AdminController adminController)
        {
            InitializeComponent();

            admin_controller_instance = adminController;
        }

        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            // Price must be a valid double to continue
            if (double.TryParse(drinkPriceBox.Text, out double price)) {

                // Initialize drink with name and price
                string drink_name = drinkNameBox.Text;
                Drink new_drink = new Drink(drink_name, price);
                admin_controller_instance.drinkController.drinkRepository.AddDrink(new_drink);

                // Clear out textboxes
                drinkNameBox.Clear();
                drinkPriceBox.Clear();
                // Go back to admin page
                this.Hide();
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

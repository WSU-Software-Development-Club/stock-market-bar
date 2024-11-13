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
            admin_controller_instance.drinksDemo.Add(new Tuple<string, double>(drinkNameBox.Text, Convert.ToDouble(drinkPriceBox.Text)));

            drinkNameBox.Clear();
            drinkPriceBox.Clear();

            this.Hide();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

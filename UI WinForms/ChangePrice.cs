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
    public partial class ChangePrice : Form
    {
        public AdminController adminController;
        private int drink_index;
        public ChangePrice(AdminController AdminController)
        {
            InitializeComponent();
            adminController = AdminController;
            drink_index = -1;

        }

        public void load_form(int drink_index)
        {
            this.Show();
            this.drink_index = drink_index;
            drink_info.Text = "Drink: " + adminController.drinkController.drink_list[drink_index].getNameAndPrice();
        }

        private void ChangePrice_Load(object sender, EventArgs e)
        {

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (double.TryParse(change_price_box.Text, out double new_price))
            {
                adminController.change_price(this.drink_index, new_price);
            }
            this.Hide();
        }
    }
}

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
    public partial class PriceVariation : Form
    {
        AdminController adminController;
        public PriceVariation(AdminController adminController)
        {
            InitializeComponent();
            this.adminController = adminController;
        }

        private void price_change_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // This function will translate a price variation into # of levels
        private void save_button_Click(object sender, EventArgs e)
        {
            // Get input from user
            string user_price = price_input.Text;
            if (double.TryParse(user_price, out var price))
            {
                // Calulcate "levels"
                int new_levels = 0;
                double price_to_levels = Math.Round(price / .25);
                // Levels will include negative and positive ints - why the need for * 2
                new_levels = (int)price_to_levels * 2 + 1;

                // Must be odd
                if (new_levels % 2 == 0)
                {
                    new_levels++;
                }
                // Silent maximum
                if (new_levels > 25)
                {
                    new_levels = 25;
                }

                Console.WriteLine(new_levels);
                adminController.levels = new_levels;
                adminController.change_price_variation();
                this.Hide();
            }
            else
            {
                Console.WriteLine("Input a valid number");
            }


        }

        private void PriceVariation_Load(object sender, EventArgs e)
        {

        }
    }
}

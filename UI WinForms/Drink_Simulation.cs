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
    public partial class Drink_Simulation : Form
    {
        AdminController adminController;
        DrinkController drinkController;
        // List of 50 random names and associated price
        List<(string, double)> drinksWithPrices = new List<(string, double)>
        {
            ("Mojito", 8.50),
            ("Cosmopolitan", 10.00),
            ("Margarita", 9.25),
            ("Old Fashioned", 11.00),
            ("Pina Colada", 8.75),
            ("Martini", 12.00),
            ("Daiquiri", 9.00),
            ("Mai Tai", 10.50),
            ("Manhattan", 11.50),
            ("Whiskey Sour", 9.75),
            ("Bloody Mary", 8.00),
            ("Negroni", 10.75),
            ("Gin and Tonic", 7.50),
            ("Rum Punch", 9.50),
            ("Tequila Sunrise", 8.25),
            ("Long Island Iced Tea", 11.25),
            ("Moscow Mule", 9.00),
            ("Sangria", 8.50),
            ("Blue Lagoon", 10.00),
            ("Irish Coffee", 8.75),
            ("Amaretto Sour", 9.25),
            ("Caipirinha", 10.00),
            ("Bellini", 8.00),
            ("Aperol Spritz", 9.75),
            ("French 75", 10.50),
            ("Paloma", 8.50),
            ("Tom Collins", 9.25),
            ("White Russian", 10.25),
            ("Black Russian", 9.00),
            ("Sidecar", 10.75),
            ("Hurricane", 11.00),
            ("Mint Julep", 8.75),
            ("Pisco Sour", 9.50),
            ("Zombie", 11.50),
            ("Gin Fizz", 9.25),
            ("Cuba Libre", 8.00),
            ("Sazerac", 12.00),
            ("Espresso Martini", 10.75),
            ("Vesper", 11.25),
            ("Bee's Knees", 9.50),
            ("Bourbon Smash", 10.00),
            ("Clover Club", 8.75),
            ("Dark and Stormy", 9.75),
            ("Gin Rickey", 7.75),
            ("Vodka Collins", 8.25),
            ("Planter's Punch", 9.50),
            ("Bramble", 10.00),
            ("Highball", 8.50),
            ("Rum Swizzle", 9.00),
            ("Southside", 10.25),
            ("Shirley Temple", 6.50)
        };


        public Drink_Simulation(AdminController adminController)
        {
            InitializeComponent();
            this.adminController = adminController;
            this.drinkController = adminController.drinkController;

            tabControl1.SelectedIndexChanged += tab_index_changed;
        }

        private void hide_buttons()
        {
            admin_start_button.Hide();
        }

        private void tab_index_changed(object sender, EventArgs e)
        {
            hide_buttons();
            if (tabControl1.SelectedTab == admin_tab)
            {
                admin_start_button.Show();
                admin_textbox.Lines = new string[]
                {
                    "Admin Simulation: Uses the current drink list from the admin panel.",
                    "Every Drink will have an even chance of being chosen.",
                    "This simulation ensures the admin features are working properly.",
                    "Click on the button to begin."
                };
            }
            
        }

        // This button begins the admin simulation
        private void admin_start_button_Click(object sender, EventArgs e)
        {

        }
    }
}

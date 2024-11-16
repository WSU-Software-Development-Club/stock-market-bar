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
        private int runs;
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

        List<Drink> admin_drink_list = new List<Drink>();

        public Drink_Simulation(AdminController adminController)
        {
            InitializeComponent();
            runs = 0;
            this.adminController = adminController;
            admin_drink_list = adminController.drinkController.drink_list;
            admin_textbox.Lines = new string[]
                {
                    "Admin Simulation: Uses the current drink ",
                    "list from the admin panel.",
                    "Every Drink will have an even chance of ",
                    "being chosen.",
                    "This simulation ensures the admin features are working properly.",
                    "Click on the button to begin."
                };
            tabControl1.SelectedIndexChanged += tab_index_changed;
        }

        private void hide_buttons()
        {
            admin_start_button.Hide();
        }

        private void tab_index_changed(object sender, EventArgs e)
        {
            // Reset total sales each time
            adminController.drinkController.total_sales = 0;
            if (tabControl1.SelectedTab == admin_tab)
            {
                admin_start_button.Show();
                admin_textbox.Lines = new string[]
                {
                    "Admin Simulation: Uses the current drink ",
                    "list from the admin panel.",
                    "Every Drink will have an even chance of ",
                    "being chosen.",
                    "This simulation ensures the admin features are working properly.",
                    "Click on the button to begin."
                };
                // Set the drink_list to be the saved drink list admin_dirnk_list
                adminController.drinkController.drink_list = admin_drink_list;
            }
            else if (tabControl1.SelectedTab == normal_tab)
            {
                normal_start_button.Show();
                normal_textbox.Lines = new string[]
                {
                    "Normal Simulation: Uses a random generated",
                    "drink list with 10 drinks.",
                    "Every Drink will have an even chance of ",
                    "being chosen.",
                    "This simulation demonstrates how the prices fluctuate under normal circumstances.",
                    "Click on the button to begin."
                };
                // Set the drink_list to be a randomized drink list ten drinks long
                adminController.drinkController.drink_list = adminController.drinkController.InitializeTenDrinkList(drinksWithPrices);
            }
            else if (tabControl1.SelectedTab == lock_tab)
            {
                locked_start_button.Show();
                locked_textbox.Lines = new string[]
                {
                    "Normal Simulation: Uses a random generated",
                    "drink list with 10 drinks. However, three",
                    "drinks will be \"locked\" and cannot ",
                    "fluctuate in price.",
                    "Every Drink will have an even chance of being chosen.",
                    "This simulation demonstrates how the prices fluctuate with some drinks being locked.",
                    "Click on the button to begin."
                };
                // Set the drink_list to be a randomized drink list ten drinks long
                adminController.drinkController.drink_list = adminController.drinkController.InitializeTenDrinkList(drinksWithPrices);
                // Lock three drinks (for the test)
                adminController.drinkController.drink_list[0].varies = false;
                adminController.drinkController.drink_list[1].varies = false;
                adminController.drinkController.drink_list[2].varies = false;

            }
            else if (tabControl1.SelectedTab == unbalanced_tab)
            {
                unbalanced_start_button.Show();
                unbalanced_textbox.Lines = new string[]
                {
                    "Normal Simulation: Uses a random generated",
                    "drink list with 10 drinks.",
                    "The first 4 drinks will have a higher chance",
                    "of being chosen, leading to more skew in the price fluctuations.",
                    "This simulation demonstrates how the prices fluctuate with some drinks being more popular than others.",
                    "Click on the button to begin."
                };
                // Set the drink_list to be a randomized drink list ten drinks long
                adminController.drinkController.drink_list = adminController.drinkController.InitializeTenDrinkList(drinksWithPrices);
            }
            else if (tabControl1.SelectedTab == large_tab)
            {
                large_start_button.Show();
                large_textbox.Lines = new string[]
                {
                    "Normal Simulation: Uses a random generated",
                    "drink list with 30 drinks.",
                    "Each drink has an equal probability of being",
                    "chosen.",
                    "This simulation demonstrates how the prices will change when the dataset is large.",
                    "Click on the button to begin."
                };
                // Set the drink_list to be a randomized drink list ten drinks long
                adminController.drinkController.drink_list = adminController.drinkController.InitializeThirtyDrinkList(drinksWithPrices);
            }
        }

        // This button begins and continues the admin simulation
        private void admin_start_button_Click(object sender, EventArgs e)
        {

            admin_textbox.Clear();

            // Run the simulate_25_drinks function
            simulate_25_drinks();

            // Update the displayed data after each simulation
            UpdateDrinkInfo(admin_textbox);

            // Update the button text to indicate progress
            admin_start_button.Text = "Simulate 25 drink sales";

        }

        // This button starts and continues the normal simulation
        private void normal_start_button_Click(object sender, EventArgs e)
        {

            normal_textbox.Clear();


            // Run the simulate_25_drinks function
            simulate_25_drinks();

            // Update the displayed data after each simulation
            UpdateDrinkInfo(normal_textbox);

            // Update the button text to indicate progress
            normal_start_button.Text = "Simulate 25 drink sales";
        }

        // This button starts and continues the locked simulation
        private void locked_start_button_Click(object sender, EventArgs e)
        {
            locked_textbox.Clear();


            // Run the simulate_25_drinks function
            simulate_25_drinks();

            // Update the displayed data after each simulation
            UpdateDrinkInfo(locked_textbox);

            // Update the button text to indicate progress
            locked_start_button.Text = "Simulate 25 drink sales";
        }

        // This button starts and continues the unbalanced simulation
        private void unbalanced_start_button_Click(object sender, EventArgs e)
        {
            unbalanced_textbox.Clear();

            // Run the simulate_25_drinks function
            simulate_25_drinks_unbalanced();

            // Update the displayed data after each simulation
            UpdateDrinkInfo(unbalanced_textbox);

            // Update the button text to indicate progress
            unbalanced_start_button.Text = "Simulate 25 drink sales";
        }

        // This button starts and continues thhe large data simulation
        private void large_start_button_Click(object sender, EventArgs e)
        {
            large_textbox.Clear();

            // Run the simulate_25_drinks function
            simulate_25_drinks();

            // Update the displayed data after each simulation
            UpdateDrinkInfo(large_textbox);

            // Update the button text to indicate progress
            large_start_button.Text = "Simulate 25 drink sales";
        }

        // Function to update the drink information in the textbox
        private void UpdateDrinkInfo(TextBox textBox)
        {
            int drink_list_size = adminController.drinkController.drink_list.Count();
            string[] printed_drinks = new string[drink_list_size * 4];

            for (int i = 0; i < drink_list_size; i++)
            {
                Drink drink = adminController.drinkController.drink_list[i];
                printed_drinks[i * 4] = (i + 1) + ") " + drink.name;
                printed_drinks[i * 4 + 1] = "Sales: " + drink.sales_count;
                printed_drinks[i * 4 + 2] = "Original Price: $" + drink.initial_price.ToString("F2");
                printed_drinks[i * 4 + 3] = "Current Price: $" + drink.price.ToString("F2");
            }

            textBox.Lines = printed_drinks;
        }

        // Simulates 25 drinks being bought at an even rate
        private void simulate_25_drinks()
        {
            Random rand = new Random();
            int total_drinks = adminController.drinkController.drink_list.Count();

            for (int i = 0; i < 25; i++)
            {
                int randomNumber = rand.Next(0, total_drinks);

                Drink drink = adminController.drinkController.drink_list[randomNumber];
                adminController.drinkController.drink_bought(drink);

            }
        }

        // Simulates 25 drinks being bought at an even rate
        private void simulate_25_drinks_unbalanced()
        {
            Random rand = new Random();
            int total_drinks = adminController.drinkController.drink_list.Count();

            for (int i = 0; i < 25; i++)
            {
                int randomNumber = rand.Next(0, total_drinks * 2);
                Drink drink = new Drink("", 0);
                if (randomNumber < 5)
                {
                    drink = adminController.drinkController.drink_list[0];
                }
                else if (randomNumber < 9)
                {
                    drink = adminController.drinkController.drink_list[1];
                }
                else if (randomNumber < 12)
                {
                    drink = adminController.drinkController.drink_list[2];
                }
                else if (randomNumber < 14)
                {
                    drink = adminController.drinkController.drink_list[3];
                }
                else if (randomNumber == 15)
                {
                    drink = adminController.drinkController.drink_list[4];
                }
                else if (randomNumber == 16)
                {
                    drink = adminController.drinkController.drink_list[5];
                }
                else if (randomNumber == 17)
                {
                    drink = adminController.drinkController.drink_list[6];
                }
                else if (randomNumber == 18)
                {
                    drink = adminController.drinkController.drink_list[7];
                }
                else if (randomNumber == 19)
                {
                    drink = adminController.drinkController.drink_list[8];
                }
                else
                {
                    drink = adminController.drinkController.drink_list[9];
                }
                adminController.drinkController.drink_bought(drink);

            }
        }

        
    }
}

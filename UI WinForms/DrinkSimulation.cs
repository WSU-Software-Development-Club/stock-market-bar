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
using static System.Windows.Forms.LinkLabel;

namespace UI_WinForms
{
    public partial class DrinkSimulation : Form
    {

        // Instance of admin controller
        AdminController adminController;

        private int runs;

        List<Drink> drink_list = new List<Drink>();

        public DrinkSimulation(AdminController adminController)
        {

            InitializeComponent();
            runs = 0;
            this.adminController = adminController;
            drink_list = adminController.drinkController.drinkRepository.GetAllDrinks();

            // Visual changes
            reset_all_buttons();
            admin_textbox.Lines = new string[]
            {
                "Admin Simulation: Uses the current drink list from the admin panel.",
                "Every Drink will have an even chance of being chosen.",
                "This simulation ensures the admin features are working properly.",
                "Click on the button to begin."
            };
            //End visual changes

            simulation_tabs.SelectedIndexChanged += tab_index_changed;
        }

        private void tab_index_changed(object? sender, EventArgs e)
        {
            // Reset total sales each time
            adminController.drinkController.total_sales = 0;
            if (simulation_tabs.SelectedTab == admin_tab)
            {
                reset_all_buttons();
                admin_textbox.Lines = new string[]
                {
                    "Admin Simulation: Uses the current drink list from the admin panel.",
                    "Every Drink will have an even chance of being chosen.",
                    "This simulation ensures the admin features are working properly."
                };
            }
            else if (simulation_tabs.SelectedTab == dynamic_tab)
            {
                reset_all_buttons();
                dynamic_textbox.Lines = new string[]
                {
                    "Normal Simulation: Uses a random generated drink list with 10 drinks.",
                    "Every Drink will have an even chance of being chosen.",
                    "This simulation demonstrates how the prices fluctuate under normal circumstances."
                };
            }
        }

        private void reset_all_buttons()
        {
            admin_one_drink_button.Visible = true;
            admin_one_drink_button.Text = "Start";
            admin_ten_drink_button.Visible = false;
            dynamic_one_drink_button.Visible = true;
            dynamic_one_drink_button.Text = "Start";
            dynamic_ten_drinks_button.Visible = false;
        }

        private void admin_one_drink_button_Click(object sender, EventArgs e)
        {
            // Change the text if it is the first time simulating drinks
            if (admin_one_drink_button.Text == "Start")
            {
                admin_one_drink_button.Text = "Buy 1 drink";
                admin_textbox.Clear();
                admin_ten_drink_button.Visible = true;
            }

            // Buy a random drink
            buy_drinks(1);
            // Update text information on all drinks
            UpdateDrinkInfo(admin_textbox);
        }

        private void admin_ten_drink_button_Click(object sender, EventArgs e)
        {
            // Buy 10 random drinks
            buy_drinks(10);
            // Update text information on all drinks
            UpdateDrinkInfo(admin_textbox);
        }

        private void dynamic_one_drink_button_Click(object sender, EventArgs e)
        {
            // Change the text if it is the first time simulating drinks
            if (dynamic_one_drink_button.Text == "Start")
            {
                dynamic_one_drink_button.Text = "Buy 1 drink";
                admin_textbox.Clear();
                dynamic_ten_drinks_button.Visible = true;
            }

            buy_cheap_drinks(1);
            UpdateDrinkInfo(dynamic_textbox);
        }

        private void dynamic_ten_drinks_button_Click(object sender, EventArgs e)
        {
            buy_cheap_drinks(10);
            UpdateDrinkInfo(dynamic_textbox);
        }

        // Function to update the drink information in the textbox
        private void UpdateDrinkInfo(TextBox textBox)
        {
            int drink_list_size = drink_list.Count;
            string[] printed_drinks = new string[drink_list_size + 3];
            double total_deviation = 0;

            for (int i = 0; i < drink_list_size; i++)
            {
                Drink drink = drink_list[i];
                printed_drinks[i] += (i + 1) + ") ";
                printed_drinks[i] += "Sales: " + drink.sales_count + "; ";
                printed_drinks[i] += "Original Price: $" + drink.initial_price.ToString("F2") + "; ";
                printed_drinks[i] += "Current Price: $" + drink.price.ToString("F2") + "; ";
                total_deviation += drink.price - drink.initial_price;
            }
            printed_drinks[drink_list_size] = "Total deviation between all drinks: " + total_deviation.ToString("F2");
            printed_drinks[drink_list_size + 1] = "Total sales: " + adminController.drinkController.GetTotalSales().ToString("F2");
            printed_drinks[drink_list_size + 2] = "Total differentiation: " + adminController.drinkController.GetSalesDifferentiation().ToString("F2");
            textBox.Lines = printed_drinks;
        }

        // Simulates n number of drinks being bought at an even rate
        private void buy_drinks(int drinks)
        {
            Random rand = new Random();
            // total_drinks = Count of all drinks in the list
            int total_drinks = drink_list.Count;

            for (int i = 0; i < drinks; i++)
            {
                int randomIndex = rand.Next(0, total_drinks);

                Drink drink = drink_list[randomIndex];
                adminController.drinkController.drink_bought(drink.name);
            }

        }

        // Simluates n number of drinks being bought with bias toward cheaper drinks
        private void buy_cheap_drinks(int drinks)
        {
            // Sort drinks from best deal -> worst deal
            List<Drink> drink_list_sorted_by_deal = new List<Drink>();
            drink_list_sorted_by_deal = SortDrinksByPrice(drink_list);

            Random rand = new Random();

            // total_drinks = Count of all drinks in the list
            int total_drinks = drink_list.Count;
            // Chance of current drink index being bought
            double buy_chance = (1 / (double)total_drinks) * 2;
            // Bool to trigger funciton to stop once a drink index has been chosen
            bool drink_bought = false;
            // Current drink index
            int drink_index = 0;

            // Buy number of drinks specified in parameter
            for (int i = 0; i < drinks; i++)
            {
                drink_index = 0;
                while (drink_bought == false)
                {
                    double randomNum = rand.NextDouble();
                    if (randomNum < buy_chance)     // Current drink index chosen
                    {
                        // Buy current drink index
                        drink_bought = true;
                        adminController.drinkController.drink_bought(drink_list_sorted_by_deal[drink_index].name);
                    }
                    else if (drink_index == total_drinks - 1)       // Reached end of drink list
                    {
                        // Buy current drink index
                        drink_bought = true;
                        adminController.drinkController.drink_bought(drink_list_sorted_by_deal[drink_index].name);
                    }
                    else
                    {
                        drink_index++;
                    }
                }
                drink_bought = false;

            }

        }

        // Sorts drinks in order by best deal -> worst deal
        private List<Drink> SortDrinksByPrice(List<Drink> drinks)
        {
            return drinks
                .OrderByDescending(d => d.initial_price - d.price)  // Sort by deal value in descending order
                .ToList();  // Convert the result to a new list
        }

        private void DrinkSimulation_Load(object sender, EventArgs e)
        {

        }
    }
}

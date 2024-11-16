using Drink_Class_Library;
using System.Diagnostics;
using static System.Windows.Forms.LinkLabel;

namespace UI_WinForms
{
    public partial class AdminController : Form
    {

        // Create DrinkClass
        public DrinkController drinkController;

        // Create Form Instances
        public AddDrink add_drink_instance;
        public PriceVariation price_variation_instance;
        public ChangePrice change_price_instance;
        public Drink_Simulation drink_simulation_instance;

        public int levels = 9;

        // Constructor
        public AdminController()
        {
            // Form Load
            InitializeComponent();

            // Initialize screen instances
            add_drink_instance = new AddDrink(this);
            price_variation_instance = new PriceVariation(this);
            change_price_instance = new ChangePrice(this);
            

            // Initialize drink controller
            drinkController = new DrinkController(levels);

            // Various Properties
            PriceVariationBox.Text = "Current Price Variation: $" + this.levels_to_variation(levels).ToString("F2");
            admin_price_set_button.Hide();
            delete_drink_button.Hide();
            change_price_button.Hide();
        }

        // Load Drinks
        private void btnDrinkDemo_Click(object sender, EventArgs e)
        {
            update_drink_list();
        }

        // If user wants to add a drink
        private void btnCreateDrink_Click(object sender, EventArgs e)
        {
            add_drink_instance.Show();
        }

        // If user wants to change how much drinks can change price
        private void overall_price_variation_button_click(object sender, EventArgs e)
        {
            price_variation_instance.Show();
        }

        // If user wants a drink to "vary" or "not vary"
        private void price_set_click(object sender, EventArgs e)
        {
            // Get drink index
            int drink = drinkBox.SelectedIndex;

            // Error checking
            if (drink >= 0)
            {
                // Change variation of Drink object
                drinkController.drink_list[drink].changeVariation();
                // Update admin text
                selectedDrinkLabel.Text = drinkController.drink_list[drink].getMenuOptions(levels);
                // Update price change button
                update_price_change_button(drink);
            }
        }

        // If user wants to delete a drink
        private void delete_drink_button_click(object sender, EventArgs e)
        {
            int drink = drinkBox.SelectedIndex;

            drinkController.drink_list.RemoveAt(drink);

            update_drink_list();
        }

        // If user wants to change the listed price of a drink
        private void change_price_button_Click(object sender, EventArgs e)
        {
            int drink = drinkBox.SelectedIndex;

            change_price_instance.load_form(drink);
        }

        // If admin selects a drink on the left hand panel
        private void drinkBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Show drink editing buttons
            admin_price_set_button.Show();
            delete_drink_button.Show();
            change_price_button.Show();

            // Get drink index
            int drink = drinkBox.SelectedIndex;
            // Display Drink properties
            selectedDrinkLabel.Text = drinkController.drink_list[drink].getMenuOptions(levels);
            // Update price change button
            update_price_change_button(drink);
        }

        // If a drink is set to "not varies" or "varies"
        public void change_price_variation()
        {
            int drink = drinkBox.SelectedIndex;
            selectedDrinkLabel.Text = drinkController.drink_list[drink].getMenuOptions(levels);
        }

        // If user wants to change price of single drink
        public void change_price(int drink_index, double new_price)
        {
            this.drinkController.drink_list[drink_index].set_initial_price(new_price);
            update_drink_list();
            selectedDrinkLabel.Text = drinkController.drink_list[drink_index].getMenuOptions(levels);
        }

        // If 1/multiple drink properties change, update it
        private void update_drink_list()
        {
            drinkBox.Items.Clear();
            foreach (Drink drink in drinkController.drink_list)
            {
                drinkBox.Items.Add(drink.getNameAndPrice());
            }
        }

        // If price variation changes
        public void changeVariationDisplay()
        {
            PriceVariationBox.Text = "Current Price Variation: $" + levels_to_variation(levels).ToString("F2");
        }

        // If current drink is set to "not varies" or "varies", display different text
        private void update_price_change_button(int drink_index)
        {
            if (drinkController.drink_list[drink_index].varies)
            {
                admin_price_set_button.Text = "Do not change price";
            }
            else
            {
                admin_price_set_button.Text = "Allow price to change";
            }
        }

        // Convert levels to a double price (ex. 9 -> 1.00)
        private double levels_to_variation(int levels)
        {
            double variation = 0;
            double levels_to_price = (levels - 1) / 2;
            // Levels will include negative and positive ints - why the need for / 2
            variation = levels_to_price * .25;
            return variation;
        }

        private void open_simulation_button_Click(object sender, EventArgs e)
        {
            drink_simulation_instance = new Drink_Simulation(this);
            drink_simulation_instance.Show();
        }
    }
}

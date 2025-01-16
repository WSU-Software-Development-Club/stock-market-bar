using Drink_Class_Library;
using System.Diagnostics;
using static System.Windows.Forms.LinkLabel;

namespace UI_WinForms
{
    public partial class AdminController : Form
    {

        public delegate void DrinksUpdatedEventHandler();  // Define delegate type for the event
        public event DrinksUpdatedEventHandler DrinksUpdated;  // Define the event

        // Create DrinkClass
        public DrinkController drinkController;

        // Create Form Instances
        public DrinkSimulation? drink_simulation_instance;
        public AddDrink add_drink_instance;
        public PriceVariation price_variation_instance;
        public ChangePrice change_price_instance;

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
            drinkController = new DrinkController();

            // Various Properties
            admin_price_set_button.Hide();
            delete_drink_button.Hide();
            change_price_button.Hide();

            // Initialize events
            DrinksUpdated += RefreshDrinkList;
        }

        public void OnDrinkAdded()
        {
            // Trigger the DrinksUpdated event, if there are any subscribers
            DrinksUpdated?.Invoke();
        }

        // Load Drinks
        private void btnDrinkDemo_Click(object sender, EventArgs e)
        {
            update_drink_list();
        }

        private void RefreshDrinkList()
        {
            // Logic to update the drink list (e.g., refresh ListBox or GridView)
            drinkBox.Items.Clear();
            foreach (var drink in drinkController.drinkRepository.GetAllDrinks())
            {
                drinkBox.Items.Add($"{drink.name} - ${drink.initial_price:F2}");
            }
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
                Drink? selected_drink = drinkController.drinkRepository.GetDrinkByIndex(drink);
                // Change variation of Drink object
                if (selected_drink != null)
                {
                    // Change variation variable for selected drink
                    drinkController.drinkRepository.ChangeVariation(selected_drink);
                    // Update admin text for selected drink
                    selectedDrinkLabel.Text = selected_drink.getMenuOptions(this.levels);
                    // Update price change button
                    update_price_change_button(drink);
                }
                
                
            }
        }

        // If user wants to delete a drink
        private void delete_drink_button_click(object sender, EventArgs e)
        {
            int drink = drinkBox.SelectedIndex;
            
            // Error checking
            if (drink >= 0) {

                drinkController.drinkRepository.RemoveDrinkAtIndex(drink);

                update_drink_list();
            }
            
        }

        // If user wants to change the listed price of a drink
        private void change_price_button_Click(object sender, EventArgs e)
        {
            int drink = drinkBox.SelectedIndex;
            if (drink >= 0)
            {
                change_price_instance.load_form(drink);
            }
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
            // Error checking
            if (drink >= 0)
            {
                Drink? selected_drink = drinkController.drinkRepository.GetDrinkByIndex(drink);
                // Display Drink properties
                if (selected_drink != null)
                {
                    // Update drink label text for selected drink
                    selectedDrinkLabel.Text = selected_drink.getMenuOptions(this.levels);
                    // Update price change button
                    update_price_change_button(drink);
                }
                                
            }
           
        }

        // If a drink is set to "not varies" or "varies"
        public void change_price_variation()
        {
            int drink = drinkBox.SelectedIndex;
            // Error checking
            if (drink >= 0)
            {
                Drink? selected_drink = drinkController.drinkRepository.GetDrinkByIndex(drink);
                if (selected_drink != null)
                {
                    selectedDrinkLabel.Text = selected_drink.getMenuOptions(this.levels);
                }
                else
                {
                    Console.WriteLine("Unexpected Error occured finding drink");
                }
            }
        }

        // If user wants to change price of single drink
        public void change_price(int drink_index, double new_price)
        {
            Drink? selected_drink = this.drinkController.drinkRepository.GetDrinkByIndex(drink_index);
            if (selected_drink != null)
            {
                selected_drink.set_initial_price(new_price);
                update_drink_list();
                selectedDrinkLabel.Text = selected_drink.getMenuOptions(this.levels);
            }
            
        }

        // If 1/multiple drink properties change, update it
        private void update_drink_list()
        {
            drinkBox.Items.Clear();
            if (drinkController.drinkRepository.GetAllDrinks().Count > 0)
            {
                foreach (Drink drink in drinkController.drinkRepository.GetAllDrinks())
                {
                    drinkBox.Items.Add(drink.getNameAndPrice());
                }
            }
            else
            {
                drinkController.InitializeNewDrinkList(10);
            }
        }

        // If current drink is set to "not varies" or "varies", display different text
        private void update_price_change_button(int drink_index)
        {
            Drink? selected_drink = drinkController.drinkRepository.GetDrinkByIndex(drink_index);
            if (selected_drink != null && selected_drink.varies)
            {
                admin_price_set_button.Text = "Freeze price";
            }
            else
            {
                admin_price_set_button.Text = "Unfreeze Price";
            }
        }

        private void open_simulation_button_Click(object sender, EventArgs e)
        {
            drink_simulation_instance = new DrinkSimulation(this);
            drink_simulation_instance.Show();
        }
    }
}

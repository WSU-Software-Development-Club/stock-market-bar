using Drink_Class_Library;
using System.Diagnostics;
using static System.Windows.Forms.LinkLabel;

namespace UI_WinForms
{
    public partial class AdminController : Form
    {

        public AddDrink add_drink_instance;
        public PriceVariation price_variation_instance;
        public ChangePrice change_price_instance;

        // Create DrinkClass
        public DrinkController drinkController;
        public int levels = 9;

        public AdminController()
        {
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


        private void btnDrinkDemo_Click(object sender, EventArgs e)
        {
            change_drink_list();
        }

        private void change_drink_list()
        {
            drinkBox.Items.Clear();
            foreach (Drink drink in drinkController.drink_list)
            {
                drinkBox.Items.Add(drink.getNameAndPrice());
            }
        }

        private void drinkBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            admin_price_set_button.Show();
            delete_drink_button.Show();
            change_price_button.Show();
            int drink = drinkBox.SelectedIndex;

            selectedDrinkLabel.Text = drinkController.drink_list[drink].getMenuOptions(levels);
            update_price_change_button(drink);
        }

        public void change_price_variation()
        {
            int drink = drinkBox.SelectedIndex;
            selectedDrinkLabel.Text = drinkController.drink_list[drink].getMenuOptions(levels);
        }

        public void change_price(int drink_index, double new_price)
        {
            this.drinkController.drink_list[drink_index].initial_price = new_price;
            change_drink_list();
        }


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

        private void btnCreateDrink_Click(object sender, EventArgs e)
        {
            add_drink_instance.Show();
        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            price_variation_instance.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private double levels_to_variation(int levels)
        {
            double variation = 0;
            double levels_to_price = (levels - 1) / 2;
            // Levels will include negative and positive ints - why the need for / 2
            variation = levels_to_price * .25;
            return variation;
        }

        public void changeVariationDisplay()
        {
            PriceVariationBox.Text = "Current Price Variation: $" + levels_to_variation(levels).ToString("F2");
        }

        private void price_set_click(object sender, EventArgs e)
        {
            int drink = drinkBox.SelectedIndex;

            drinkController.drink_list[drink].changeVariation();
            selectedDrinkLabel.Text = drinkController.drink_list[drink].getMenuOptions(levels);
            update_price_change_button(drink);
        }

        private void delete_drink_button_click(object sender, EventArgs e)
        {
            int drink = drinkBox.SelectedIndex;

            drinkController.drink_list.RemoveAt(drink);

            change_drink_list();
        }

        private void change_price_button_Click(object sender, EventArgs e)
        {
            int drink = drinkBox.SelectedIndex;

            change_price_instance.load_form(drink);
        }
    }
}

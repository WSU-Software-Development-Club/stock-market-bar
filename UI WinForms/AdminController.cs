using Drink_Class_Library;
using System.Diagnostics;

namespace UI_WinForms
{
    public partial class AdminController : Form
    {
        public List<Tuple<string, double>> drinksDemo;

        public AddDrink admin_add_drink;
        public PriceVariation price_variation_instance;

        // Create DrinkClass
        public DrinkController drinkController;
        public int levels = 9;

        public AdminController()
        {
            InitializeComponent();

            admin_add_drink = new AddDrink(this);
            price_variation_instance = new PriceVariation(this);
            drinkController = new DrinkController(levels);
        }


        private void btnDrinkDemo_Click(object sender, EventArgs e)
        {
            drinkBox.Items.Clear();
            foreach (var drink in drinksDemo)
            {
                drinkBox.Items.Add(drink);
            }
        }

        private void drinkBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int drink = drinkBox.SelectedIndex;

            selectedDrinkLabel.Text = drinksDemo[drink].Item1;
        }

        private void btnCreateDrink_Click(object sender, EventArgs e)
        {
            admin_add_drink.Show();
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
            // Levels will include negative and positive ints - why the need for * 2
            variation = levels_to_price * .25;
            return variation;
        }

        public void changeVariationDisplay()
        {
            PriceVariationBox.Text = "Current Price Variation: $" + levels_to_variation(levels).ToString("F2");
        }
    }
}

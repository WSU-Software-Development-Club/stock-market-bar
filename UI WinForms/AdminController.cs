using Drink_Class_Library;

namespace UI_WinForms
{
    public partial class AdminController : Form
    {
        public List<Tuple<string, double>> drinksDemo;

        AddDrink instance;

        // Create DrinkClass
        DrinkController drinkController = new DrinkController();

        public AdminController()
        {
            InitializeComponent();

            drinksDemo = drinkController.InitializeDrinkDemoList();

            instance = new AddDrink(this);
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
            instance.Show();
        }
    }
}

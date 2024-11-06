using Drink_Class_Library;

namespace UI_WinForms
{
    public partial class AdminController : Form
    {

        // Create DrinkClass
        DrinkController drinkController = new DrinkController();

        private List<Tuple<string, double>> drinksDemo;

        public AdminController()
        {
            InitializeComponent();

            drinksDemo = drinkController.InitializeDrinkDemoList();
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
    }
}

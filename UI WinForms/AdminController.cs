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

            drinksDemo = InitializeDrinkDemoList();

            instance = new AddDrink(this);
        }

        private List<Tuple<string, double>> InitializeDrinkDemoList()
        {
            List<Tuple<string, double>> tempList = new List<Tuple<string, double>>();
            tempList.Add(new Tuple<string, double>("Bud Lite", 3.45));
            tempList.Add(new Tuple<string, double>("Corona Extra", 4.25));
            tempList.Add(new Tuple<string, double>("Pabst Blue Ribbon", 3.75));
            tempList.Add(new Tuple<string, double>("Coors Lite", 2.85));
            tempList.Add(new Tuple<string, double>("Guiness", 4.55));

            return tempList;

            //drinksDemo = drinkController.InitializeDrinkDemoList();
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

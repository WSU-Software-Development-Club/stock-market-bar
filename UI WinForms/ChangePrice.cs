﻿using Drink_Class_Library;
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
    public partial class ChangePrice : Form
    {
        public AdminController adminController;
        private int drink_index;
        public ChangePrice(AdminController AdminController)
        {
            InitializeComponent();
            adminController = AdminController;
            drink_index = -1;

        }

        public void load_form(int drink_index)
        {
            this.Show();
            this.drink_index = drink_index;
            Drink? selected_drink = adminController.drinkController.drinkRepository.GetDrinkByIndex(drink_index);
            if (selected_drink != null)
            {
                drink_info.Text = "Drink: " + selected_drink.getNameAndPrice();
            }
            else
            {
                Console.WriteLine("Unexepected Error occured.");
            }
        }

        private void ChangePrice_Load(object sender, EventArgs e)
        {

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            // Check if it is a valid double and non-negative
            if (double.TryParse(change_price_box.Text, out double new_price) && new_price > 0)
            {
                adminController.change_price(this.drink_index, new_price);
            }
            this.Hide();
        }
    }
}

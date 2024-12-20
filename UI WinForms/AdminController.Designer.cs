﻿namespace UI_WinForms
{
    partial class AdminController
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainPanel = new Panel();
            rightPanel = new Panel();
            change_price_button = new Button();
            delete_drink_button = new Button();
            admin_price_set_button = new Button();
            PriceVariationBox = new TextBox();
            price_variation_button = new Button();
            selectedDrinkLabel = new Label();
            btnDemo = new Button();
            leftPanel = new Panel();
            btnCreateDrink = new Button();
            drinkBox = new ListBox();
            open_simulation_button = new Button();
            mainPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(rightPanel);
            mainPanel.Controls.Add(leftPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1130, 650);
            mainPanel.TabIndex = 0;
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(open_simulation_button);
            rightPanel.Controls.Add(change_price_button);
            rightPanel.Controls.Add(delete_drink_button);
            rightPanel.Controls.Add(admin_price_set_button);
            rightPanel.Controls.Add(PriceVariationBox);
            rightPanel.Controls.Add(price_variation_button);
            rightPanel.Controls.Add(selectedDrinkLabel);
            rightPanel.Controls.Add(btnDemo);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(276, 0);
            rightPanel.Margin = new Padding(2);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(854, 650);
            rightPanel.TabIndex = 1;
            // 
            // change_price_button
            // 
            change_price_button.Location = new Point(353, 85);
            change_price_button.Name = "change_price_button";
            change_price_button.Size = new Size(127, 56);
            change_price_button.TabIndex = 5;
            change_price_button.Text = "Set Original Price";
            change_price_button.UseVisualStyleBackColor = true;
            change_price_button.Click += change_price_button_Click;
            // 
            // delete_drink_button
            // 
            delete_drink_button.Location = new Point(25, 85);
            delete_drink_button.Name = "delete_drink_button";
            delete_drink_button.Size = new Size(149, 56);
            delete_drink_button.TabIndex = 4;
            delete_drink_button.Text = "Delete Drink";
            delete_drink_button.UseVisualStyleBackColor = true;
            delete_drink_button.Click += delete_drink_button_click;
            // 
            // admin_price_set_button
            // 
            admin_price_set_button.Location = new Point(191, 85);
            admin_price_set_button.Name = "admin_price_set_button";
            admin_price_set_button.Size = new Size(145, 56);
            admin_price_set_button.TabIndex = 3;
            admin_price_set_button.Text = "Do Not Change Price";
            admin_price_set_button.UseVisualStyleBackColor = true;
            admin_price_set_button.Click += price_set_click;
            // 
            // PriceVariationBox
            // 
            PriceVariationBox.Font = new Font("Segoe UI", 11F);
            PriceVariationBox.Location = new Point(519, 528);
            PriceVariationBox.Name = "PriceVariationBox";
            PriceVariationBox.Size = new Size(298, 32);
            PriceVariationBox.TabIndex = 2;
            // 
            // price_variation_button
            // 
            price_variation_button.Location = new Point(432, 584);
            price_variation_button.Name = "price_variation_button";
            price_variation_button.Size = new Size(422, 63);
            price_variation_button.TabIndex = 1;
            price_variation_button.Text = "Set Price Variation";
            price_variation_button.UseVisualStyleBackColor = true;
            price_variation_button.Click += overall_price_variation_button_click;
            // 
            // selectedDrinkLabel
            // 
            selectedDrinkLabel.Dock = DockStyle.Top;
            selectedDrinkLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectedDrinkLabel.Location = new Point(0, 0);
            selectedDrinkLabel.Margin = new Padding(2, 0, 2, 0);
            selectedDrinkLabel.Name = "selectedDrinkLabel";
            selectedDrinkLabel.Size = new Size(854, 37);
            selectedDrinkLabel.TabIndex = 1;
            selectedDrinkLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDemo
            // 
            btnDemo.Location = new Point(0, 581);
            btnDemo.Margin = new Padding(2);
            btnDemo.Name = "btnDemo";
            btnDemo.Size = new Size(427, 69);
            btnDemo.TabIndex = 0;
            btnDemo.Text = "Demo Loading Drinks";
            btnDemo.UseVisualStyleBackColor = true;
            btnDemo.Click += btnDrinkDemo_Click;
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(btnCreateDrink);
            leftPanel.Controls.Add(drinkBox);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Margin = new Padding(2);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(276, 650);
            leftPanel.TabIndex = 0;
            // 
            // btnCreateDrink
            // 
            btnCreateDrink.Dock = DockStyle.Fill;
            btnCreateDrink.Location = new Point(0, 579);
            btnCreateDrink.Margin = new Padding(2);
            btnCreateDrink.Name = "btnCreateDrink";
            btnCreateDrink.Size = new Size(276, 71);
            btnCreateDrink.TabIndex = 1;
            btnCreateDrink.Text = "Create New Drink";
            btnCreateDrink.UseVisualStyleBackColor = true;
            btnCreateDrink.Click += btnCreateDrink_Click;
            // 
            // drinkBox
            // 
            drinkBox.Dock = DockStyle.Top;
            drinkBox.Font = new Font("Segoe UI", 11F);
            drinkBox.FormattingEnabled = true;
            drinkBox.ItemHeight = 25;
            drinkBox.Location = new Point(0, 0);
            drinkBox.Margin = new Padding(2);
            drinkBox.Name = "drinkBox";
            drinkBox.Size = new Size(276, 579);
            drinkBox.TabIndex = 0;
            drinkBox.SelectedIndexChanged += drinkBox_SelectedIndexChanged;
            // 
            // open_simulation_button
            // 
            open_simulation_button.Location = new Point(38, 505);
            open_simulation_button.Name = "open_simulation_button";
            open_simulation_button.Size = new Size(351, 71);
            open_simulation_button.TabIndex = 6;
            open_simulation_button.Text = "Open Simulation";
            open_simulation_button.UseVisualStyleBackColor = true;
            open_simulation_button.Click += open_simulation_button_Click;
            // 
            // AdminController
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 650);
            Controls.Add(mainPanel);
            Margin = new Padding(2);
            Name = "AdminController";
            Text = "Admin Controller";
            mainPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            leftPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel rightPanel;
        private Button btnDemo;
        private Panel leftPanel;
        private ListBox drinkBox;
        private Label selectedDrinkLabel;
        private Button btnCreateDrink;
        private Button price_variation_button;
        private TextBox PriceVariationBox;
        private Button admin_price_set_button;
        private Button delete_drink_button;
        private Button change_price_button;
        private Button open_simulation_button;
    }
}

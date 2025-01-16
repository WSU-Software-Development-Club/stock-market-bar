namespace UI_WinForms
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
            open_simulation_button = new Button();
            change_price_button = new Button();
            delete_drink_button = new Button();
            admin_price_set_button = new Button();
            selectedDrinkLabel = new Label();
            btnDemo = new Button();
            leftPanel = new Panel();
            btnCreateDrink = new Button();
            drinkBox = new ListBox();
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
            mainPanel.Size = new Size(823, 436);
            mainPanel.TabIndex = 0;
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(open_simulation_button);
            rightPanel.Controls.Add(change_price_button);
            rightPanel.Controls.Add(delete_drink_button);
            rightPanel.Controls.Add(admin_price_set_button);
            rightPanel.Controls.Add(selectedDrinkLabel);
            rightPanel.Controls.Add(btnDemo);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(276, 0);
            rightPanel.Margin = new Padding(2);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(547, 436);
            rightPanel.TabIndex = 1;
            // 
            // open_simulation_button
            // 
            open_simulation_button.BackColor = Color.Black;
            open_simulation_button.Font = new Font("Segoe UI", 12F);
            open_simulation_button.ForeColor = Color.White;
            open_simulation_button.Location = new Point(278, 166);
            open_simulation_button.Name = "open_simulation_button";
            open_simulation_button.Size = new Size(208, 83);
            open_simulation_button.TabIndex = 6;
            open_simulation_button.Text = "Open Bar Simulation";
            open_simulation_button.UseVisualStyleBackColor = false;
            open_simulation_button.Click += open_simulation_button_Click;
            // 
            // change_price_button
            // 
            change_price_button.BackColor = Color.LightGray;
            change_price_button.Font = new Font("Segoe UI", 12F);
            change_price_button.Location = new Point(355, 85);
            change_price_button.Name = "change_price_button";
            change_price_button.Size = new Size(155, 56);
            change_price_button.TabIndex = 5;
            change_price_button.Text = "Change Price";
            change_price_button.UseVisualStyleBackColor = false;
            change_price_button.Click += change_price_button_Click;
            // 
            // delete_drink_button
            // 
            delete_drink_button.BackColor = Color.Red;
            delete_drink_button.Font = new Font("Segoe UI", 12F);
            delete_drink_button.Location = new Point(25, 85);
            delete_drink_button.Name = "delete_drink_button";
            delete_drink_button.Size = new Size(149, 56);
            delete_drink_button.TabIndex = 4;
            delete_drink_button.Text = "Delete Drink";
            delete_drink_button.UseVisualStyleBackColor = false;
            delete_drink_button.Click += delete_drink_button_click;
            // 
            // admin_price_set_button
            // 
            admin_price_set_button.BackColor = Color.LightGray;
            admin_price_set_button.Font = new Font("Segoe UI", 12F);
            admin_price_set_button.Location = new Point(191, 85);
            admin_price_set_button.Name = "admin_price_set_button";
            admin_price_set_button.Size = new Size(146, 56);
            admin_price_set_button.TabIndex = 3;
            admin_price_set_button.Text = "Lock Price";
            admin_price_set_button.UseVisualStyleBackColor = false;
            admin_price_set_button.Click += price_set_click;
            // 
            // selectedDrinkLabel
            // 
            selectedDrinkLabel.Dock = DockStyle.Top;
            selectedDrinkLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectedDrinkLabel.Location = new Point(0, 0);
            selectedDrinkLabel.Margin = new Padding(2, 0, 2, 0);
            selectedDrinkLabel.Name = "selectedDrinkLabel";
            selectedDrinkLabel.Size = new Size(547, 37);
            selectedDrinkLabel.TabIndex = 1;
            selectedDrinkLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDemo
            // 
            btnDemo.BackColor = Color.LightGray;
            btnDemo.Font = new Font("Segoe UI", 12F);
            btnDemo.Location = new Point(71, 166);
            btnDemo.Margin = new Padding(2);
            btnDemo.Name = "btnDemo";
            btnDemo.Size = new Size(190, 83);
            btnDemo.TabIndex = 0;
            btnDemo.Text = "Load Drinks";
            btnDemo.UseVisualStyleBackColor = false;
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
            leftPanel.Size = new Size(276, 436);
            leftPanel.TabIndex = 0;
            // 
            // btnCreateDrink
            // 
            btnCreateDrink.BackColor = Color.Green;
            btnCreateDrink.Dock = DockStyle.Fill;
            btnCreateDrink.Font = new Font("Segoe UI", 15F);
            btnCreateDrink.ForeColor = Color.Snow;
            btnCreateDrink.Location = new Point(0, 329);
            btnCreateDrink.Margin = new Padding(2);
            btnCreateDrink.Name = "btnCreateDrink";
            btnCreateDrink.Size = new Size(276, 107);
            btnCreateDrink.TabIndex = 1;
            btnCreateDrink.Text = "Add New Drink";
            btnCreateDrink.UseVisualStyleBackColor = false;
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
            drinkBox.Size = new Size(276, 329);
            drinkBox.TabIndex = 0;
            drinkBox.SelectedIndexChanged += drinkBox_SelectedIndexChanged;
            // 
            // AdminController
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 436);
            Controls.Add(mainPanel);
            Margin = new Padding(2);
            Name = "AdminController";
            Text = "Admin Controller";
            mainPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
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
        private Button admin_price_set_button;
        private Button delete_drink_button;
        private Button change_price_button;
        private Button open_simulation_button;
    }
}

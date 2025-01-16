namespace UI_WinForms
{
    partial class DrinkSimulation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            simulation_tabs = new TabControl();
            admin_tab = new TabPage();
            admin_textbox = new TextBox();
            admin_ten_drink_button = new Button();
            admin_one_drink_button = new Button();
            dynamic_tab = new TabPage();
            dynamic_ten_drinks_button = new Button();
            dynamic_one_drink_button = new Button();
            dynamic_textbox = new TextBox();
            simulation_tabs.SuspendLayout();
            admin_tab.SuspendLayout();
            dynamic_tab.SuspendLayout();
            SuspendLayout();
            // 
            // simulation_tabs
            // 
            simulation_tabs.Controls.Add(admin_tab);
            simulation_tabs.Controls.Add(dynamic_tab);
            simulation_tabs.Dock = DockStyle.Fill;
            simulation_tabs.Font = new Font("Segoe UI", 11F);
            simulation_tabs.Location = new Point(0, 0);
            simulation_tabs.Margin = new Padding(4);
            simulation_tabs.Name = "simulation_tabs";
            simulation_tabs.SelectedIndex = 0;
            simulation_tabs.Size = new Size(1000, 562);
            simulation_tabs.TabIndex = 0;
            // 
            // admin_tab
            // 
            admin_tab.Controls.Add(admin_textbox);
            admin_tab.Controls.Add(admin_ten_drink_button);
            admin_tab.Controls.Add(admin_one_drink_button);
            admin_tab.Location = new Point(4, 34);
            admin_tab.Margin = new Padding(4);
            admin_tab.Name = "admin_tab";
            admin_tab.Padding = new Padding(4);
            admin_tab.Size = new Size(992, 524);
            admin_tab.TabIndex = 0;
            admin_tab.Text = "Admin";
            admin_tab.UseVisualStyleBackColor = true;
            // 
            // admin_textbox
            // 
            admin_textbox.Location = new Point(0, 4);
            admin_textbox.Margin = new Padding(4);
            admin_textbox.Multiline = true;
            admin_textbox.Name = "admin_textbox";
            admin_textbox.Size = new Size(816, 506);
            admin_textbox.TabIndex = 2;
            // 
            // admin_ten_drink_button
            // 
            admin_ten_drink_button.Font = new Font("Segoe UI", 11F);
            admin_ten_drink_button.Location = new Point(829, 142);
            admin_ten_drink_button.Margin = new Padding(4);
            admin_ten_drink_button.Name = "admin_ten_drink_button";
            admin_ten_drink_button.Size = new Size(151, 61);
            admin_ten_drink_button.TabIndex = 1;
            admin_ten_drink_button.Text = "Buy 10 drinks";
            admin_ten_drink_button.UseVisualStyleBackColor = true;
            admin_ten_drink_button.Click += admin_ten_drink_button_Click;
            // 
            // admin_one_drink_button
            // 
            admin_one_drink_button.Location = new Point(829, 40);
            admin_one_drink_button.Margin = new Padding(4);
            admin_one_drink_button.Name = "admin_one_drink_button";
            admin_one_drink_button.Size = new Size(151, 59);
            admin_one_drink_button.TabIndex = 0;
            admin_one_drink_button.Text = "Buy 1 drink";
            admin_one_drink_button.UseVisualStyleBackColor = true;
            admin_one_drink_button.Click += admin_one_drink_button_Click;
            // 
            // dynamic_tab
            // 
            dynamic_tab.Controls.Add(dynamic_ten_drinks_button);
            dynamic_tab.Controls.Add(dynamic_one_drink_button);
            dynamic_tab.Controls.Add(dynamic_textbox);
            dynamic_tab.Location = new Point(4, 34);
            dynamic_tab.Margin = new Padding(4);
            dynamic_tab.Name = "dynamic_tab";
            dynamic_tab.Padding = new Padding(4);
            dynamic_tab.Size = new Size(992, 524);
            dynamic_tab.TabIndex = 1;
            dynamic_tab.Text = "Dynamic";
            dynamic_tab.UseVisualStyleBackColor = true;
            // 
            // dynamic_ten_drinks_button
            // 
            dynamic_ten_drinks_button.Location = new Point(825, 142);
            dynamic_ten_drinks_button.Margin = new Padding(4);
            dynamic_ten_drinks_button.Name = "dynamic_ten_drinks_button";
            dynamic_ten_drinks_button.Size = new Size(155, 55);
            dynamic_ten_drinks_button.TabIndex = 2;
            dynamic_ten_drinks_button.Text = "Buy 10 drinks";
            dynamic_ten_drinks_button.UseVisualStyleBackColor = true;
            dynamic_ten_drinks_button.Click += dynamic_ten_drinks_button_Click;
            // 
            // dynamic_one_drink_button
            // 
            dynamic_one_drink_button.Location = new Point(825, 44);
            dynamic_one_drink_button.Margin = new Padding(4);
            dynamic_one_drink_button.Name = "dynamic_one_drink_button";
            dynamic_one_drink_button.Size = new Size(158, 60);
            dynamic_one_drink_button.TabIndex = 1;
            dynamic_one_drink_button.Text = "Buy 1 drink";
            dynamic_one_drink_button.UseVisualStyleBackColor = true;
            dynamic_one_drink_button.Click += dynamic_one_drink_button_Click;
            // 
            // dynamic_textbox
            // 
            dynamic_textbox.Font = new Font("Segoe UI", 11F);
            dynamic_textbox.Location = new Point(4, 4);
            dynamic_textbox.Margin = new Padding(4);
            dynamic_textbox.Multiline = true;
            dynamic_textbox.Name = "dynamic_textbox";
            dynamic_textbox.Size = new Size(813, 513);
            dynamic_textbox.TabIndex = 0;
            // 
            // DrinkSimulation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1000, 562);
            Controls.Add(simulation_tabs);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "DrinkSimulation";
            Text = "DrinkSimulation";
            Load += DrinkSimulation_Load;
            simulation_tabs.ResumeLayout(false);
            admin_tab.ResumeLayout(false);
            admin_tab.PerformLayout();
            dynamic_tab.ResumeLayout(false);
            dynamic_tab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl simulation_tabs;
        private TabPage admin_tab;
        private TabPage dynamic_tab;
        private TextBox admin_textbox;
        private Button admin_ten_drink_button;
        private Button admin_one_drink_button;
        private Button dynamic_ten_drinks_button;
        private Button dynamic_one_drink_button;
        private TextBox dynamic_textbox;
    }
}
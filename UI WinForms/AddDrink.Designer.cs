namespace UI_WinForms
{
    partial class AddDrink
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
            mainPanel = new Panel();
            btnAddDrink = new Button();
            drinkPriceBox = new TextBox();
            drinkNameBox = new TextBox();
            enterDrinkNameLabel = new Label();
            enterDrinkPriceLabel = new Label();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(enterDrinkPriceLabel);
            mainPanel.Controls.Add(enterDrinkNameLabel);
            mainPanel.Controls.Add(btnAddDrink);
            mainPanel.Controls.Add(drinkPriceBox);
            mainPanel.Controls.Add(drinkNameBox);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(800, 450);
            mainPanel.TabIndex = 0;
            // 
            // btnAddDrink
            // 
            btnAddDrink.Anchor = AnchorStyles.None;
            btnAddDrink.Location = new Point(275, 314);
            btnAddDrink.Name = "btnAddDrink";
            btnAddDrink.Size = new Size(241, 34);
            btnAddDrink.TabIndex = 2;
            btnAddDrink.Text = "Add Drink";
            btnAddDrink.UseVisualStyleBackColor = true;
            btnAddDrink.Click += btnAddDrink_Click;
            // 
            // drinkPriceBox
            // 
            drinkPriceBox.Anchor = AnchorStyles.None;
            drinkPriceBox.Location = new Point(275, 213);
            drinkPriceBox.Name = "drinkPriceBox";
            drinkPriceBox.Size = new Size(241, 31);
            drinkPriceBox.TabIndex = 1;
            // 
            // drinkNameBox
            // 
            drinkNameBox.Anchor = AnchorStyles.None;
            drinkNameBox.Location = new Point(275, 114);
            drinkNameBox.Name = "drinkNameBox";
            drinkNameBox.Size = new Size(241, 31);
            drinkNameBox.TabIndex = 0;
            // 
            // enterDrinkNameLabel
            // 
            enterDrinkNameLabel.AutoSize = true;
            enterDrinkNameLabel.Location = new Point(275, 86);
            enterDrinkNameLabel.Name = "enterDrinkNameLabel";
            enterDrinkNameLabel.Size = new Size(106, 25);
            enterDrinkNameLabel.TabIndex = 3;
            enterDrinkNameLabel.Text = "Drink Name";
            // 
            // enterDrinkPriceLabel
            // 
            enterDrinkPriceLabel.AutoSize = true;
            enterDrinkPriceLabel.Location = new Point(275, 185);
            enterDrinkPriceLabel.Name = "enterDrinkPriceLabel";
            enterDrinkPriceLabel.Size = new Size(96, 25);
            enterDrinkPriceLabel.TabIndex = 4;
            enterDrinkPriceLabel.Text = "Drink Price";
            // 
            // AddDrink
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainPanel);
            Name = "AddDrink";
            Text = "Add a new drink";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Button btnAddDrink;
        private TextBox drinkPriceBox;
        private TextBox drinkNameBox;
        private Label enterDrinkPriceLabel;
        private Label enterDrinkNameLabel;
    }
}
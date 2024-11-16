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
            enterDrinkPriceLabel = new Label();
            enterDrinkNameLabel = new Label();
            btnAddDrink = new Button();
            drinkPriceBox = new TextBox();
            drinkNameBox = new TextBox();
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
            mainPanel.Margin = new Padding(2, 2, 2, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(640, 360);
            mainPanel.TabIndex = 0;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // enterDrinkPriceLabel
            // 
            enterDrinkPriceLabel.AutoSize = true;
            enterDrinkPriceLabel.Location = new Point(220, 148);
            enterDrinkPriceLabel.Margin = new Padding(2, 0, 2, 0);
            enterDrinkPriceLabel.Name = "enterDrinkPriceLabel";
            enterDrinkPriceLabel.Size = new Size(80, 20);
            enterDrinkPriceLabel.TabIndex = 4;
            enterDrinkPriceLabel.Text = "Drink Price";
            // 
            // enterDrinkNameLabel
            // 
            enterDrinkNameLabel.AutoSize = true;
            enterDrinkNameLabel.Location = new Point(220, 69);
            enterDrinkNameLabel.Margin = new Padding(2, 0, 2, 0);
            enterDrinkNameLabel.Name = "enterDrinkNameLabel";
            enterDrinkNameLabel.Size = new Size(88, 20);
            enterDrinkNameLabel.TabIndex = 3;
            enterDrinkNameLabel.Text = "Drink Name";
            // 
            // btnAddDrink
            // 
            btnAddDrink.Anchor = AnchorStyles.None;
            btnAddDrink.Location = new Point(220, 251);
            btnAddDrink.Margin = new Padding(2, 2, 2, 2);
            btnAddDrink.Name = "btnAddDrink";
            btnAddDrink.Size = new Size(193, 27);
            btnAddDrink.TabIndex = 2;
            btnAddDrink.Text = "Add Drink";
            btnAddDrink.UseVisualStyleBackColor = true;
            btnAddDrink.Click += btnAddDrink_Click;
            // 
            // drinkPriceBox
            // 
            drinkPriceBox.Anchor = AnchorStyles.None;
            drinkPriceBox.Location = new Point(220, 170);
            drinkPriceBox.Margin = new Padding(2, 2, 2, 2);
            drinkPriceBox.Name = "drinkPriceBox";
            drinkPriceBox.Size = new Size(194, 27);
            drinkPriceBox.TabIndex = 1;
            // 
            // drinkNameBox
            // 
            drinkNameBox.Anchor = AnchorStyles.None;
            drinkNameBox.Location = new Point(220, 91);
            drinkNameBox.Margin = new Padding(2, 2, 2, 2);
            drinkNameBox.Name = "drinkNameBox";
            drinkNameBox.Size = new Size(194, 27);
            drinkNameBox.TabIndex = 0;
            // 
            // AddDrink
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(mainPanel);
            Margin = new Padding(2, 2, 2, 2);
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
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
            btnDemo = new Button();
            panel1 = new Panel();
            drinkBox = new ListBox();
            selectedDrinkLabel = new Label();
            mainPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(rightPanel);
            mainPanel.Controls.Add(panel1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1412, 812);
            mainPanel.TabIndex = 0;
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(selectedDrinkLabel);
            rightPanel.Controls.Add(btnDemo);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(345, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(1067, 812);
            rightPanel.TabIndex = 1;
            // 
            // btnDemo
            // 
            btnDemo.Dock = DockStyle.Bottom;
            btnDemo.Location = new Point(0, 719);
            btnDemo.Name = "btnDemo";
            btnDemo.Size = new Size(1067, 93);
            btnDemo.TabIndex = 0;
            btnDemo.Text = "Demo Loading Drinks";
            btnDemo.UseVisualStyleBackColor = true;
            btnDemo.Click += btnDrinkDemo_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(drinkBox);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 812);
            panel1.TabIndex = 0;
            // 
            // drinkBox
            // 
            drinkBox.Dock = DockStyle.Fill;
            drinkBox.FormattingEnabled = true;
            drinkBox.ItemHeight = 25;
            drinkBox.Location = new Point(0, 0);
            drinkBox.Name = "drinkBox";
            drinkBox.Size = new Size(345, 812);
            drinkBox.TabIndex = 0;
            drinkBox.SelectedIndexChanged += drinkBox_SelectedIndexChanged;
            // 
            // selectedDrinkLabel
            // 
            selectedDrinkLabel.Dock = DockStyle.Top;
            selectedDrinkLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectedDrinkLabel.Location = new Point(0, 0);
            selectedDrinkLabel.Name = "selectedDrinkLabel";
            selectedDrinkLabel.Size = new Size(1067, 46);
            selectedDrinkLabel.TabIndex = 1;
            selectedDrinkLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AdminController
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1412, 812);
            Controls.Add(mainPanel);
            Name = "AdminController";
            Text = "Admin Controller";
            mainPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel rightPanel;
        private Button btnDemo;
        private Panel panel1;
        private ListBox drinkBox;
        private Label selectedDrinkLabel;
    }
}

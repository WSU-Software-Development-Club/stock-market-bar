namespace UI_WinForms
{
    partial class ChangePrice
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
            change_price_box = new TextBox();
            title = new Label();
            drink_info = new Label();
            save_button = new Button();
            SuspendLayout();
            // 
            // change_price_box
            // 
            change_price_box.Location = new Point(326, 209);
            change_price_box.Name = "change_price_box";
            change_price_box.Size = new Size(125, 27);
            change_price_box.TabIndex = 0;
            change_price_box.Text = "$";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 15F);
            title.Location = new Point(278, 29);
            title.Name = "title";
            title.Size = new Size(226, 35);
            title.TabIndex = 1;
            title.Text = "Change Drink Price";
            // 
            // drink_info
            // 
            drink_info.AutoSize = true;
            drink_info.Location = new Point(358, 92);
            drink_info.Name = "drink_info";
            drink_info.Size = new Size(0, 20);
            drink_info.TabIndex = 2;
            // 
            // save_button
            // 
            save_button.Location = new Point(302, 287);
            save_button.Name = "save_button";
            save_button.Size = new Size(173, 46);
            save_button.TabIndex = 3;
            save_button.Text = "Save Changes";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_Click;
            // 
            // ChangePrice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(save_button);
            Controls.Add(drink_info);
            Controls.Add(title);
            Controls.Add(change_price_box);
            Name = "ChangePrice";
            Text = "ChangePrice";
            Load += ChangePrice_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox change_price_box;
        private Label title;
        private Label drink_info;
        private Button save_button;
    }
}
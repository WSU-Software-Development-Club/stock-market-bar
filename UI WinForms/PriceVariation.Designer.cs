namespace UI_WinForms
{
    partial class PriceVariation
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            price_input = new TextBox();
            label1 = new Label();
            save_button = new Button();
            SuspendLayout();
            // 
            // price_input
            // 
            price_input.Location = new Point(348, 214);
            price_input.Name = "price_input";
            price_input.Size = new Size(99, 27);
            price_input.TabIndex = 0;
            price_input.Text = "$";
            price_input.TextChanged += price_change_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(33, 151);
            label1.Name = "label1";
            label1.Size = new Size(736, 60);
            label1.TabIndex = 1;
            label1.Text = "Enter how much you would like the price to vary (ex. 1.00 = -$1.00 - $1.00)\r\n(Round to .25c)\r\n";
            label1.Click += label1_Click;
            // 
            // save_button
            // 
            save_button.Location = new Point(297, 285);
            save_button.Name = "save_button";
            save_button.Size = new Size(207, 53);
            save_button.TabIndex = 2;
            save_button.Text = "Save Price Change";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_Click;
            // 
            // PriceVariation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(save_button);
            Controls.Add(label1);
            Controls.Add(price_input);
            Name = "PriceVariation";
            Text = "Form1";
            Load += PriceVariation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox price_input;
        private Label label1;
        private Button save_button;
    }
}
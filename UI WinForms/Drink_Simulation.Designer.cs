namespace UI_WinForms
{
    partial class Drink_Simulation
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
            tabControl1 = new TabControl();
            admin_tab = new TabPage();
            admin_start_button = new Button();
            admin_textbox = new TextBox();
            normal_tab = new TabPage();
            normal_start_button = new Button();
            normal_textbox = new TextBox();
            lock_tab = new TabPage();
            locked_start_button = new Button();
            locked_textbox = new TextBox();
            unbalanced_tab = new TabPage();
            unbalanced_start_button = new Button();
            unbalanced_textbox = new TextBox();
            large_tab = new TabPage();
            large_start_button = new Button();
            large_textbox = new TextBox();
            tabControl1.SuspendLayout();
            admin_tab.SuspendLayout();
            normal_tab.SuspendLayout();
            lock_tab.SuspendLayout();
            unbalanced_tab.SuspendLayout();
            large_tab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(admin_tab);
            tabControl1.Controls.Add(normal_tab);
            tabControl1.Controls.Add(lock_tab);
            tabControl1.Controls.Add(unbalanced_tab);
            tabControl1.Controls.Add(large_tab);
            tabControl1.Location = new Point(0, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(600, 755);
            tabControl1.TabIndex = 0;
            // 
            // admin_tab
            // 
            admin_tab.Controls.Add(admin_start_button);
            admin_tab.Controls.Add(admin_textbox);
            admin_tab.Font = new Font("Segoe UI", 11F);
            admin_tab.Location = new Point(4, 29);
            admin_tab.Name = "admin_tab";
            admin_tab.Padding = new Padding(3);
            admin_tab.Size = new Size(592, 722);
            admin_tab.TabIndex = 0;
            admin_tab.Text = "Admin";
            admin_tab.UseVisualStyleBackColor = true;
            // 
            // admin_start_button
            // 
            admin_start_button.Location = new Point(415, 6);
            admin_start_button.Name = "admin_start_button";
            admin_start_button.Size = new Size(169, 67);
            admin_start_button.TabIndex = 1;
            admin_start_button.Text = "Start Simulation";
            admin_start_button.UseVisualStyleBackColor = true;
            admin_start_button.Click += admin_start_button_Click;
            // 
            // admin_textbox
            // 
            admin_textbox.Dock = DockStyle.Fill;
            admin_textbox.Location = new Point(3, 3);
            admin_textbox.Multiline = true;
            admin_textbox.Name = "admin_textbox";
            admin_textbox.Size = new Size(586, 716);
            admin_textbox.TabIndex = 0;
            // 
            // normal_tab
            // 
            normal_tab.Controls.Add(normal_start_button);
            normal_tab.Controls.Add(normal_textbox);
            normal_tab.Font = new Font("Segoe UI", 11F);
            normal_tab.Location = new Point(4, 29);
            normal_tab.Name = "normal_tab";
            normal_tab.Padding = new Padding(3);
            normal_tab.Size = new Size(592, 722);
            normal_tab.TabIndex = 1;
            normal_tab.Text = "Normal";
            normal_tab.UseVisualStyleBackColor = true;
            // 
            // normal_start_button
            // 
            normal_start_button.Location = new Point(415, 15);
            normal_start_button.Name = "normal_start_button";
            normal_start_button.Size = new Size(169, 67);
            normal_start_button.TabIndex = 2;
            normal_start_button.Text = "Start Simulation";
            normal_start_button.UseVisualStyleBackColor = true;
            normal_start_button.Click += normal_start_button_Click;
            // 
            // normal_textbox
            // 
            normal_textbox.Dock = DockStyle.Fill;
            normal_textbox.Location = new Point(3, 3);
            normal_textbox.Multiline = true;
            normal_textbox.Name = "normal_textbox";
            normal_textbox.Size = new Size(586, 716);
            normal_textbox.TabIndex = 1;
            // 
            // lock_tab
            // 
            lock_tab.Controls.Add(locked_start_button);
            lock_tab.Controls.Add(locked_textbox);
            lock_tab.Font = new Font("Segoe UI", 11F);
            lock_tab.Location = new Point(4, 29);
            lock_tab.Name = "lock_tab";
            lock_tab.Size = new Size(592, 722);
            lock_tab.TabIndex = 2;
            lock_tab.Text = "Lock";
            lock_tab.UseVisualStyleBackColor = true;
            // 
            // locked_start_button
            // 
            locked_start_button.Location = new Point(415, 14);
            locked_start_button.Name = "locked_start_button";
            locked_start_button.Size = new Size(169, 72);
            locked_start_button.TabIndex = 2;
            locked_start_button.Text = "Start Simulation";
            locked_start_button.UseVisualStyleBackColor = true;
            locked_start_button.Click += locked_start_button_Click;
            // 
            // locked_textbox
            // 
            locked_textbox.Dock = DockStyle.Fill;
            locked_textbox.Location = new Point(0, 0);
            locked_textbox.Multiline = true;
            locked_textbox.Name = "locked_textbox";
            locked_textbox.Size = new Size(592, 722);
            locked_textbox.TabIndex = 1;
            // 
            // unbalanced_tab
            // 
            unbalanced_tab.Controls.Add(unbalanced_start_button);
            unbalanced_tab.Controls.Add(unbalanced_textbox);
            unbalanced_tab.Font = new Font("Segoe UI", 11F);
            unbalanced_tab.Location = new Point(4, 29);
            unbalanced_tab.Name = "unbalanced_tab";
            unbalanced_tab.Size = new Size(592, 722);
            unbalanced_tab.TabIndex = 3;
            unbalanced_tab.Text = "Unbalanced";
            unbalanced_tab.UseVisualStyleBackColor = true;
            // 
            // unbalanced_start_button
            // 
            unbalanced_start_button.Location = new Point(415, 12);
            unbalanced_start_button.Name = "unbalanced_start_button";
            unbalanced_start_button.Size = new Size(169, 68);
            unbalanced_start_button.TabIndex = 2;
            unbalanced_start_button.Text = "Start Simulation";
            unbalanced_start_button.UseVisualStyleBackColor = true;
            unbalanced_start_button.Click += unbalanced_start_button_Click;
            // 
            // unbalanced_textbox
            // 
            unbalanced_textbox.Dock = DockStyle.Fill;
            unbalanced_textbox.Location = new Point(0, 0);
            unbalanced_textbox.Multiline = true;
            unbalanced_textbox.Name = "unbalanced_textbox";
            unbalanced_textbox.Size = new Size(592, 722);
            unbalanced_textbox.TabIndex = 1;
            // 
            // large_tab
            // 
            large_tab.Controls.Add(large_start_button);
            large_tab.Controls.Add(large_textbox);
            large_tab.Font = new Font("Segoe UI", 11F);
            large_tab.Location = new Point(4, 29);
            large_tab.Name = "large_tab";
            large_tab.Size = new Size(592, 722);
            large_tab.TabIndex = 4;
            large_tab.Text = "Large";
            large_tab.UseVisualStyleBackColor = true;
            // 
            // large_start_button
            // 
            large_start_button.Location = new Point(415, 9);
            large_start_button.Name = "large_start_button";
            large_start_button.Size = new Size(169, 62);
            large_start_button.TabIndex = 2;
            large_start_button.Text = "Start Simulation";
            large_start_button.UseVisualStyleBackColor = true;
            large_start_button.Click += large_start_button_Click;
            // 
            // large_textbox
            // 
            large_textbox.Dock = DockStyle.Fill;
            large_textbox.Location = new Point(0, 0);
            large_textbox.Multiline = true;
            large_textbox.Name = "large_textbox";
            large_textbox.Size = new Size(592, 722);
            large_textbox.TabIndex = 1;
            // 
            // Drink_Simulation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 753);
            Controls.Add(tabControl1);
            Name = "Drink_Simulation";
            Text = "Drink_Simulation";
            tabControl1.ResumeLayout(false);
            admin_tab.ResumeLayout(false);
            admin_tab.PerformLayout();
            normal_tab.ResumeLayout(false);
            normal_tab.PerformLayout();
            lock_tab.ResumeLayout(false);
            lock_tab.PerformLayout();
            unbalanced_tab.ResumeLayout(false);
            unbalanced_tab.PerformLayout();
            large_tab.ResumeLayout(false);
            large_tab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage admin_tab;
        private TabPage normal_tab;
        private TabPage lock_tab;
        private TabPage unbalanced_tab;
        private TabPage large_tab;
        private TextBox admin_textbox;
        private TextBox normal_textbox;
        private TextBox locked_textbox;
        private TextBox unbalanced_textbox;
        private TextBox large_textbox;
        private Button admin_start_button;
        private Button normal_start_button;
        private Button locked_start_button;
        private Button unbalanced_start_button;
        private Button large_start_button;
    }
}
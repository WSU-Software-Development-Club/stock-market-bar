namespace WindowsFormsApp1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.priceGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.drinkHightlight = new System.Windows.Forms.Panel();
            this.highlight5 = new System.Windows.Forms.Label();
            this.highlight4 = new System.Windows.Forms.Label();
            this.hightlight3 = new System.Windows.Forms.Label();
            this.hightlight2 = new System.Windows.Forms.Label();
            this.highlight1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.priceGraph)).BeginInit();
            this.drinkHightlight.SuspendLayout();
            this.SuspendLayout();
            // 
            // priceGraph
            // 
            chartArea4.Name = "ChartArea1";
            this.priceGraph.ChartAreas.Add(chartArea4);
            this.priceGraph.Cursor = System.Windows.Forms.Cursors.Default;
            legend4.Name = "Legend1";
            this.priceGraph.Legends.Add(legend4);
            this.priceGraph.Location = new System.Drawing.Point(0, 1);
            this.priceGraph.Name = "priceGraph";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.priceGraph.Series.Add(series4);
            this.priceGraph.Size = new System.Drawing.Size(788, 419);
            this.priceGraph.TabIndex = 0;
            this.priceGraph.Text = "priceGraph";
            // 
            // drinkHightlight
            // 
            this.drinkHightlight.Controls.Add(this.highlight5);
            this.drinkHightlight.Controls.Add(this.highlight4);
            this.drinkHightlight.Controls.Add(this.hightlight3);
            this.drinkHightlight.Controls.Add(this.hightlight2);
            this.drinkHightlight.Controls.Add(this.highlight1);
            this.drinkHightlight.Location = new System.Drawing.Point(0, 414);
            this.drinkHightlight.Name = "drinkHightlight";
            this.drinkHightlight.Size = new System.Drawing.Size(788, 37);
            this.drinkHightlight.TabIndex = 1;
            this.drinkHightlight.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // highlight5
            // 
            this.highlight5.Location = new System.Drawing.Point(638, 2);
            this.highlight5.Name = "highlight5";
            this.highlight5.Size = new System.Drawing.Size(150, 35);
            this.highlight5.TabIndex = 4;
            this.highlight5.Text = "highlight5";
            this.highlight5.Click += new System.EventHandler(this.highlight5_Click);
            // 
            // highlight4
            // 
            this.highlight4.Location = new System.Drawing.Point(466, 2);
            this.highlight4.Name = "highlight4";
            this.highlight4.Size = new System.Drawing.Size(166, 35);
            this.highlight4.TabIndex = 3;
            this.highlight4.Text = "highlight4";
            this.highlight4.Click += new System.EventHandler(this.highlight4_Click);
            // 
            // hightlight3
            // 
            this.hightlight3.Location = new System.Drawing.Point(310, 2);
            this.hightlight3.Name = "hightlight3";
            this.hightlight3.Size = new System.Drawing.Size(150, 35);
            this.hightlight3.TabIndex = 2;
            this.hightlight3.Text = "highlight3";
            // 
            // hightlight2
            // 
            this.hightlight2.Location = new System.Drawing.Point(154, 2);
            this.hightlight2.Name = "hightlight2";
            this.hightlight2.Size = new System.Drawing.Size(150, 35);
            this.hightlight2.TabIndex = 1;
            this.hightlight2.Text = "highlight2";
            // 
            // highlight1
            // 
            this.highlight1.Location = new System.Drawing.Point(-2, 2);
            this.highlight1.Name = "highlight1";
            this.highlight1.Size = new System.Drawing.Size(150, 35);
            this.highlight1.TabIndex = 0;
            this.highlight1.Text = "highlight1";
            this.highlight1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 455);
            this.Controls.Add(this.drinkHightlight);
            this.Controls.Add(this.priceGraph);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceGraph)).EndInit();
            this.drinkHightlight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart priceGraph;
        private System.Windows.Forms.Panel drinkHightlight;
        private System.Windows.Forms.Label highlight1;
        private System.Windows.Forms.Label highlight4;
        private System.Windows.Forms.Label hightlight3;
        private System.Windows.Forms.Label hightlight2;
        private System.Windows.Forms.Label highlight5;
    }
}


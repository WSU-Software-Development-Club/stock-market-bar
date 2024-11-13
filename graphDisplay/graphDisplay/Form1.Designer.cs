﻿using System.Runtime.CompilerServices;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.priceGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.scrollAnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.highlight1 = new System.Windows.Forms.Label();
            this.highlight2 = new System.Windows.Forms.Label();
            this.highlight3 = new System.Windows.Forms.Label();
            this.highlight4 = new System.Windows.Forms.Label();
            this.highlight5 = new System.Windows.Forms.Label();
            this.drinkHighlight = new System.Windows.Forms.Panel();
            this.scrollTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.priceGraph)).BeginInit();
            this.drinkHighlight.SuspendLayout();
            this.SuspendLayout();
            // 
            // priceGraph
            // 
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY2.Crossing = 1.7976931348623157E+308D;
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisY2.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.priceGraph.ChartAreas.Add(chartArea2);
            this.priceGraph.Cursor = System.Windows.Forms.Cursors.Default;
            this.priceGraph.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.priceGraph.Legends.Add(legend2);
            this.priceGraph.Location = new System.Drawing.Point(0, 0);
            this.priceGraph.Name = "priceGraph";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.priceGraph.Series.Add(series2);
            this.priceGraph.Size = new System.Drawing.Size(790, 443);
            this.priceGraph.TabIndex = 0;
            this.priceGraph.Text = "priceGraph";
            // 
            // scrollAnimationTimer
            // 
            this.scrollAnimationTimer.Tick += new System.EventHandler(this.scrollAnimationTimer_Tick);
            // 
            // highlight1
            // 
            this.highlight1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlight1.Location = new System.Drawing.Point(-2, 0);
            this.highlight1.Name = "highlight1";
            this.highlight1.Size = new System.Drawing.Size(150, 30);
            this.highlight1.TabIndex = 0;
            this.highlight1.Text = "highlight1";
            this.highlight1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highlight2
            // 
            this.highlight2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlight2.Location = new System.Drawing.Point(154, 0);
            this.highlight2.Name = "highlight2";
            this.highlight2.Size = new System.Drawing.Size(150, 30);
            this.highlight2.TabIndex = 1;
            this.highlight2.Text = "highlight2";
            this.highlight2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highlight3
            // 
            this.highlight3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlight3.Location = new System.Drawing.Point(310, 0);
            this.highlight3.Name = "highlight3";
            this.highlight3.Size = new System.Drawing.Size(150, 30);
            this.highlight3.TabIndex = 2;
            this.highlight3.Text = "highlight3";
            this.highlight3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highlight4
            // 
            this.highlight4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlight4.Location = new System.Drawing.Point(468, 0);
            this.highlight4.Name = "highlight4";
            this.highlight4.Size = new System.Drawing.Size(166, 30);
            this.highlight4.TabIndex = 3;
            this.highlight4.Text = "highlight4";
            this.highlight4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highlight5
            // 
            this.highlight5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlight5.Location = new System.Drawing.Point(640, 0);
            this.highlight5.Name = "highlight5";
            this.highlight5.Size = new System.Drawing.Size(150, 30);
            this.highlight5.TabIndex = 4;
            this.highlight5.Text = "highlight5";
            this.highlight5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drinkHighlight
            // 
            this.drinkHighlight.Controls.Add(this.highlight5);
            this.drinkHighlight.Controls.Add(this.highlight4);
            this.drinkHighlight.Controls.Add(this.highlight3);
            this.drinkHighlight.Controls.Add(this.highlight2);
            this.drinkHighlight.Controls.Add(this.highlight1);
            this.drinkHighlight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.drinkHighlight.Location = new System.Drawing.Point(0, 425);
            this.drinkHighlight.Name = "drinkHighlight";
            this.drinkHighlight.Size = new System.Drawing.Size(790, 30);
            this.drinkHighlight.TabIndex = 1;
            this.drinkHighlight.Resize += new System.EventHandler(this.drinkHighlights_Resize);
            // 
            // scrollTimer
            // 
            this.scrollTimer.Enabled = true;
            this.scrollTimer.Interval = 5000;
            this.scrollTimer.Tick += new System.EventHandler(this.ChangeTextWithVerticalScroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 455);
            this.Controls.Add(this.drinkHighlight);
            this.Controls.Add(this.priceGraph);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceGraph)).EndInit();
            this.drinkHighlight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart priceGraph;
        private System.Windows.Forms.Timer scrollAnimationTimer;
        private System.Windows.Forms.Label highlight1;
        private System.Windows.Forms.Label highlight2;
        private System.Windows.Forms.Label highlight3;
        private System.Windows.Forms.Label highlight4;
        private System.Windows.Forms.Label highlight5;
        private System.Windows.Forms.Panel drinkHighlight;
        private System.Windows.Forms.Timer scrollTimer;
    }
}

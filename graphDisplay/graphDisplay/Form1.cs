using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int textPosition = 0;
        private string[] highlightText = { "Highlight1", "Highlight2", "Highlight3", "Highlight4", "Highlight5" };

        private bool[] scrollingUp;
        private int[] initialY;
        private int[] targetY;

        private System.Windows.Forms.Label[] highlightLabels;

        public Form1()
        {
            InitializeComponent();
            SetupChart();

            drinkHighlight.Resize += drinkHighlights_Resize;
            highlightLabels = new System.Windows.Forms.Label[] {highlight1, highlight2, highlight3, highlight4, highlight5};
            initialY = new int[] { 0, 0, 0, 0, 0 };
            targetY = new int[] { 0, 0, 0, 0, 0 };
            scrollingUp = new bool[] {false, false, false, false, false };

            for (int i=0; i<5; i++)
            {
                highlightLabels[i].Text = highlightText[i];
                initialY[i] = highlightLabels[i].Top;
            }

            scrollAnimationTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SetupChart()
        {
            // Clear any existing series
            priceGraph.Series.Clear();

            // Create a new series for the line chart
            Series series = new Series
            {
                Name = "DataSeries",
                Color = Color.Blue,
                ChartType = SeriesChartType.Line  // Set ChartType here on the Series, not the Chart
            };

            // Add the series to the chart
            priceGraph.Series.Add(series);

            // Add data points
            series.Points.AddXY(1, 10);  // X and Y coordinates
            series.Points.AddXY(2, 20);
            series.Points.AddXY(3, 15);
            series.Points.AddXY(4, 25);
            series.Points.AddXY(5, 30);
        }

        private void scrollAnimationTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i<5; i++)
            {
                if (scrollingUp[i])
                {
                    // Move label upwards
                    highlightLabels[i].Top -= 5; // Adjust this speed if needed

                    // Check if it’s out of view
                    if (highlightLabels[i].Top <= targetY[i])
                    {
                        highlightLabels[i].Top = initialY[i] + highlightLabels[i].Height;  // Reset position below
                        highlightLabels[i].Text = highlightText[i];                         // Update text
                        scrollingUp[i] = false;                                  // Now scroll it into view
                    }
                }
                else
                {
                    // Move label upwards to bring it into view
                    highlightLabels[i].Top -= 5;  // Adjust speed as needed

                    // Stop animation when it reaches original position
                    if (highlightLabels[i].Top <= initialY[i])
                    {
                        highlightLabels[i].Top = initialY[i];   // Ensure it lands exactly
                        scrollAnimationTimer.Stop();             // Stop the timer
                    }
                }
            }
        }

        private string[] GetHighlightText()
        {
            string[] text = new string[5] { "Rum 10.00 \u25B2", "Budlight 5.00 \u25BC", "Corona 4.50 \u25B2", "ESP Martini 17.30 \u25BC", "Heineken 4.70 \u25B2" };
            return text;
        }

        public void ChangeTextWithVerticalScroll(object sender, EventArgs e)
        {
            string[] text = GetHighlightText();
            for (int i = 0; i < 5; i++)
            {
                highlightText[i] = text[i];
                targetY[i] = initialY[i] - highlightLabels[i].Height;  // Target position above
                scrollingUp[i] = true;                         // Start scrolling up
                scrollAnimationTimer.Start();
            }
        }

        private void drinkHighlights_Resize(object sender, EventArgs e)
        {
            DistributeLabelsHorizontally();
        }

        private void DistributeLabelsHorizontally()
        {
            int panelWidth = drinkHighlight.ClientSize.Width;
            int labelCount = highlightLabels.Length;

            // Calculate the horizontal space between each label
            int spacing = panelWidth / (labelCount + 1);

            for (int i = 0; i < labelCount; i++)
            {
                // Position each label with calculated spacing
                highlightLabels[i].Left = spacing * (i + 1) - (highlightLabels[i].Width / 2); // Center each label horizontally
                highlightLabels[i].Top = (drinkHighlight.ClientSize.Height - highlightLabels[i].Height) / 2; // Center vertically in panel
            }
        }

    }
}

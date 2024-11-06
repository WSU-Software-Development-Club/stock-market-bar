using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupChart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void priceGraph_Click(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void highlight5_Click(object sender, EventArgs e)
        {

        }

        private void highlight4_Click(object sender, EventArgs e)
        {

        }
    }
}

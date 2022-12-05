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
using System.Drawing;

namespace Practice_Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Charting chart = new Charting();
            chart.CreateLineChart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }

    class Charting
    {
        public void CreateLineChart()
        {
            // Image Path (where the image will be generated)
            string imagePath = @"C:\Users\traff\OneDrive\Documents\Coding\C Sharp\Practice_Chart\Practice_Chart\chart_graph_gen.png";

            Chart chart = new Chart(); // Creates an instance of the chart class
            ChartArea CA = chart.ChartAreas.Add("A1"); // Naming the chart instance
            Series S1 = chart.Series.Add("S1"); // Naming the series instance
            S1.ChartType = SeriesChartType.Line; // Specifies the type of the graph

            // Create Data Points
            S1.Points.AddXY("12/5/22", 10);
            S1.Points.AddXY("12/6/22", 15);

            // Set the background colors
            chart.BackColor = Color.Transparent; // Set the background of the chart to transparent
            CA.BackColor = Color.Transparent; // Set the background of the chart itself to transparent
            
            // Labels the Axis
            CA.AxisX.Title = "X Label Demo Text";
            CA.AxisY.Title = "Y Label Demo Text";

            // Centers the label text
            CA.AxisX.TitleAlignment = StringAlignment.Center; 
            CA.AxisY.TitleAlignment = StringAlignment.Center;

            // Alter the font
            CA.AxisX.TitleFont = new Font("Arial", 15, FontStyle.Bold);
            CA.AxisY.TitleFont = new Font("Arial", 15, FontStyle.Bold);

            // Create Title for the chart itself. Note "Titles", with an S.
            // You are essentially adding a title to a collection of titles.
            chart.Titles.Add("Title Demo");
            chart.Titles.ElementAt(0).Font = new Font("Arial", 25, FontStyle.Bold); // Since it's a collection, you can reach the title via an index.

            // Set the size of the chart
            chart.Size = new Size(1000, 800); // WxH

            // Change line thickness
            chart.Series["S1"].BorderWidth = 5;

            // Add anti-aliasing
            chart.AntiAliasing = AntiAliasingStyles.Graphics;
            chart.TextAntiAliasingQuality = TextAntiAliasingQuality.High;

            chart.SaveImage(imagePath, ChartImageFormat.Png); // Outputs the chart into a png, does NOT output into the app.
        }
    }
}

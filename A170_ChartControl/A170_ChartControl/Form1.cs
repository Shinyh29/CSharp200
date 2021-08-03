using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace A170_ChartControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Using Chart Control";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            chart1.Titles.Add("005930 TimeSerieal");
            for (int i = 0; i < 10; i++)
            {
                chart1.Series["Series1"].Points.Add(r.Next(100));
            }
            chart1.Series["Series1"].LegendText = "px_close";
            chart1.Series["Series1"].ChartType = SeriesChartType.Line;
            chart1.Series["Series1"].Label = "Hello";

            Random r2 = new Random();

            chart2.Titles.Add("000123 TimeSerieal");
            for (int i = 0; i < 20; i++)
            {
                // collection 에   Series2 를 정의해야함 
                chart2.Series["Series2"].Points.Add(r2.Next(10));
            }
            chart2.Series["Series2"].LegendText = "px_close";
            chart2.Series["Series2"].ChartType = SeriesChartType.Line;
            chart2.Series["Series2"].Label = "HI2";
        }
    }
}

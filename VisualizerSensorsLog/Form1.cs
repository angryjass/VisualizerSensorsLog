using ParserSensorsLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualizerSensorsLog
{
    public partial class Form1 : Form
    {
        private static string _pathOfSensorFile;
        public Form1()
        {
            InitializeComponent();
        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            _pathOfSensorFile = openFileDialog1.FileName;
            path_txtBox.Text = _pathOfSensorFile;

        }

        private void goParse_btn_Click(object sender, EventArgs e)
        {
            ParserSensorsLog_GPU_Z parser_gpu_z = new ParserSensorsLog_GPU_Z(_pathOfSensorFile);
            var records = parser_gpu_z.ParseSensorLogFile();

            chart1.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series() 
            { 
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String,
                YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double,
                Name = "Температура"
            });

            foreach(var record in records)
            {
                chart1.Series[0].Points.AddXY(record.Date, record.GPU_Temp);
            }
            
        }
    }
}

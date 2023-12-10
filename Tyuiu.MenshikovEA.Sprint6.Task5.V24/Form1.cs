using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MenshikovEA.Sprint6.Task5.V24.Lib;

namespace Tyuiu.MenshikovEA.Sprint6.Task5.V24
{
    public partial class FormMain_MEA : Form
    {
        private static readonly string path = @"C:\DataSprint6\InPutFileTask5V24.txt";
        DataService ds = new DataService();

        public FormMain_MEA()
        {
            InitializeComponent();
        }

        private void buttonHelp_MEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнил студент группы ИИПб-23-1 Меньшиков Е. А.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_MEA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonDone_MEA_Click(object sender, EventArgs e)
        {
            dataGridViewOutPut_MEA.Rows.Clear();
            chartGraphic_MEA.Series[0].Points.Clear();

            dataGridViewOutPut_MEA.ColumnCount = 2;
            dataGridViewOutPut_MEA.Columns[0].Width = 20;
            dataGridViewOutPut_MEA.Columns[1].Width = 50;

            chartGraphic_MEA.ChartAreas[0].AxisX.Title = "Ось X";
            chartGraphic_MEA.ChartAreas[0].AxisY.Title = "Ось Y";

            double[] serviceArray = ds.LoadFromDataFile(path);
            for (int i = 0; i < serviceArray.Length; i++)
            {
                dataGridViewOutPut_MEA.Rows.Add(i + 1, serviceArray[i]);
                chartGraphic_MEA.Series[0].Points.AddXY(i, serviceArray[i]);
            }
        }
    }
}

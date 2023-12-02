using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MenshikovEA.Sprint6.Task2.V19.Lib;

namespace Tyuiu.MenshikovEA.Sprint6.Task2.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonToDo_MEA_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartInput_MEA.Text);
                int stopValue = Convert.ToInt32(textBoxEndInput_MEA.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartFunction_MEA.Titles.Add("График функции sin(x)/(x + 1.7) - cos(x) * 4x - 6");

                this.chartFunction_MEA.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_MEA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_MEA.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));

                    this.chartFunction_MEA.Series[0].Points.AddXY(startValue, valueArray[i]);

                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_MEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-23-1 Меньшиков Егор Александрович", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chartFunction_MEA_Click(object sender, EventArgs e)
        {
            //
        }

        private void buttonToDo_MEA_MouseEnter(object sender, EventArgs e)
        {
            buttonToDo_MEA.BackColor = Color.Red;
        }

        private void buttonToDo_MEA_MouseLeave(object sender, EventArgs e)
        {
            buttonToDo_MEA.BackColor = Color.Green;
        }

        private void buttonToDo_MEA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonToDo_MEA.BackColor = Color.Blue;
        }
    }
}

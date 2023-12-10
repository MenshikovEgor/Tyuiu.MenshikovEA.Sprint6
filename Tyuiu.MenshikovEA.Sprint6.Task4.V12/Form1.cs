using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.MenshikovEA.Sprint6.Task4.V12.Lib;

namespace Tyuiu.MenshikovEA.Sprint6.Task4.V12
{
    public partial class FormMain_MEA : Form
    {
        DataService ds = new DataService();
        
        public FormMain_MEA()
        {
            InitializeComponent();
        }

        private void textBoxOutput_MEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_MEA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartInput_MEA.Text);
                int stopStep = Convert.ToInt32(textBoxStopInput_MEA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_MEA.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_MEA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxOutput_MEA.Text = "";

                chartFunction_MEA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_MEA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxOutput_MEA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_MEA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V12.txt";
                File.WriteAllText(path, textBoxOutput_MEA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блакноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_MEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПб-23-1 Меньшиков Егор Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

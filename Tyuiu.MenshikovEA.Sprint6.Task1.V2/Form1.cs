using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MenshikovEA.Sprint6.Task1.V2.Lib;

namespace Tyuiu.MenshikovEA.Sprint6.Task1.V2
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
                int startStep = Convert.ToInt32(textBoxStartInput_MEA.Text);
                int stopStep = Convert.ToInt32(textBoxEndInput_MEA.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResultScroll_MEA.Text = "";
                textBoxResultScroll_MEA.AppendText("+-----------+------------+" + Environment.NewLine);
                textBoxResultScroll_MEA.AppendText("|     X     |    f(x)    |" + Environment.NewLine);
                textBoxResultScroll_MEA.AppendText("+-----------+------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}      | {1,6:f2}     | ", startStep, valueArray[i]);
                    textBoxResultScroll_MEA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResultScroll_MEA.AppendText("+-----------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_MEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-23-1 Меньшиков Егор Александрович", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

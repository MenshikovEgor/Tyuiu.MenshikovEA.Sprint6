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
using Tyuiu.MenshikovEA.Sprint6.Task6.V6.Lib;

namespace Tyuiu.MenshikovEA.Sprint6.Task6.V6
{
    public partial class FormMain_MEA : Form
    {
        public FormMain_MEA()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonChooseFile_MEA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_MEA.ShowDialog();
            openFilePath = openFileDialogTask_MEA.FileName;
            textBoxInput_MEA.Text = File.ReadAllText(openFilePath);
            groupBoxOutPut_MEA.Text = groupBoxOutPut_MEA.Text + " " + openFileDialogTask_MEA.FileName;
            buttonDone_MEA.Enabled = true;
        }

        private void buttonDone_MEA_Click(object sender, EventArgs e)
        {
            textBoxOutPut_MEA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_MEA_Click(object sender, EventArgs e)
        {
            FormAbout_MEA formAbout = new FormAbout_MEA();
            formAbout.ShowDialog();
        }
    }
}

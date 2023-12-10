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
using Tyuiu.MenshikovEA.Sprint6.Task7.V14.Lib;

namespace Tyuiu.MenshikovEA.Sprint6.Task7.V14
{
    public partial class FormMain_MEA : Form
    {
        public FormMain_MEA()
        {
            InitializeComponent();

            openFileDialogTask_MEA.Filter = "Значения, разделенные запятыми(*.csv)|*csv.|Все файлы(*.*)|(*.*)";
            saveFileDialogMatrix_MEA.Filter = "Значения, разделенные запятыми(*.csv)|*csv.|Все файлы(*.*)|(*.*)";
        }

        string path;
        static int rows;
        static int cols;
        int[,] mtrx;
        DataService ds = new DataService();

        private void buttonChooseFile_MEA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_MEA.ShowDialog();
            path = openFileDialogTask_MEA.FileName;

            mtrx = ds.GetMatrix(path);
            rows = mtrx.GetUpperBound(0) + 1;
            cols = mtrx.Length / rows;
            int[,] arrayValues = new int[rows, cols];

            arrayValues = LoadFromFileData(path);

            dataGridViewInPut_MEA.ColumnCount = cols;
            dataGridViewInPut_MEA.RowCount = rows;
            dataGridViewOutPut_MEA.ColumnCount = cols;
            dataGridViewOutPut_MEA.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewInPut_MEA.Columns[i].Width = 25;
                dataGridViewOutPut_MEA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridViewInPut_MEA.Rows[r].Cells[c].Value = mtrx[r, c];
                }
            }

            buttonDone_MEA.Enabled = true;

        }
        private void buttonSave_MEA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_MEA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_MEA.InitialDirectory = Directory.GetCurrentDirectory();
            string outPath = saveFileDialogMatrix_MEA.FileName;

            FileInfo fileinfo = new FileInfo(outPath);
            bool fileex = fileinfo.Exists;
            if (fileex)
            {
                File.Delete(outPath);
            }
            saveFileDialogMatrix_MEA.ShowDialog();

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        str += dataGridViewOutPut_MEA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOutPut_MEA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(outPath, str + Environment.NewLine);
                str = "";
            }
        }

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            cols = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        

        private void buttonDone_MEA_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j == 8)
                    {
                        dataGridViewOutPut_MEA.Rows[i].Cells[j].Value = 11;
                        mtrx[i, j] = 11;
                    }
                    else
                    {
                        dataGridViewOutPut_MEA.Rows[i].Cells[j].Value = mtrx[i, j];
                    }
                }
            }
            buttonChooseFile_MEA.Enabled = true;
        }

        private void buttonHelp_MEA_Click(object sender, EventArgs e)
        {
            FormAbout_MEA formabout = new FormAbout_MEA();
            formabout.ShowDialog();
        }
    }
}


namespace Tyuiu.MenshikovEA.Sprint6.Task2.V19
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition_MEA = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_MEA = new System.Windows.Forms.TextBox();
            this.groupBoxInputData_MEA = new System.Windows.Forms.GroupBox();
            this.textBoxStart_MEA = new System.Windows.Forms.TextBox();
            this.textBoxStartInput_MEA = new System.Windows.Forms.TextBox();
            this.textBoxEndInput_MEA = new System.Windows.Forms.TextBox();
            this.textBoxEnd_MEA = new System.Windows.Forms.TextBox();
            this.buttonHelp_MEA = new System.Windows.Forms.Button();
            this.buttonToDo_MEA = new System.Windows.Forms.Button();
            this.groupBoxOutput_MEA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_MEA = new System.Windows.Forms.TextBox();
            this.dataGridViewFunction_MEA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_MEA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxCondition_MEA.SuspendLayout();
            this.groupBoxInputData_MEA.SuspendLayout();
            this.groupBoxOutput_MEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_MEA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_MEA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_MEA
            // 
            this.groupBoxCondition_MEA.Controls.Add(this.textBoxCondition_MEA);
            this.groupBoxCondition_MEA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_MEA.Name = "groupBoxCondition_MEA";
            this.groupBoxCondition_MEA.Size = new System.Drawing.Size(692, 340);
            this.groupBoxCondition_MEA.TabIndex = 0;
            this.groupBoxCondition_MEA.TabStop = false;
            this.groupBoxCondition_MEA.Text = "Условие";
            // 
            // textBoxCondition_MEA
            // 
            this.textBoxCondition_MEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_MEA.Location = new System.Drawing.Point(7, 22);
            this.textBoxCondition_MEA.Multiline = true;
            this.textBoxCondition_MEA.Name = "textBoxCondition_MEA";
            this.textBoxCondition_MEA.ReadOnly = true;
            this.textBoxCondition_MEA.Size = new System.Drawing.Size(547, 42);
            this.textBoxCondition_MEA.TabIndex = 0;
            this.textBoxCondition_MEA.Text = "Протабулировать функцию f(x) = sin(x)/(x + 1.7) - cos(x) * 4x - 6 на заданном диа" +
    "пазоне. \r\nРезультат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxInputData_MEA
            // 
            this.groupBoxInputData_MEA.Controls.Add(this.textBoxEnd_MEA);
            this.groupBoxInputData_MEA.Controls.Add(this.textBoxEndInput_MEA);
            this.groupBoxInputData_MEA.Controls.Add(this.textBoxStartInput_MEA);
            this.groupBoxInputData_MEA.Controls.Add(this.textBoxStart_MEA);
            this.groupBoxInputData_MEA.Location = new System.Drawing.Point(12, 359);
            this.groupBoxInputData_MEA.Name = "groupBoxInputData_MEA";
            this.groupBoxInputData_MEA.Size = new System.Drawing.Size(452, 79);
            this.groupBoxInputData_MEA.TabIndex = 1;
            this.groupBoxInputData_MEA.TabStop = false;
            this.groupBoxInputData_MEA.Text = "Ввод данных";
            // 
            // textBoxStart_MEA
            // 
            this.textBoxStart_MEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStart_MEA.Location = new System.Drawing.Point(7, 22);
            this.textBoxStart_MEA.Name = "textBoxStart_MEA";
            this.textBoxStart_MEA.ReadOnly = true;
            this.textBoxStart_MEA.Size = new System.Drawing.Size(100, 15);
            this.textBoxStart_MEA.TabIndex = 0;
            this.textBoxStart_MEA.Text = "Старт шага: ";
            // 
            // textBoxStartInput_MEA
            // 
            this.textBoxStartInput_MEA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStartInput_MEA.Location = new System.Drawing.Point(7, 44);
            this.textBoxStartInput_MEA.Name = "textBoxStartInput_MEA";
            this.textBoxStartInput_MEA.Size = new System.Drawing.Size(210, 22);
            this.textBoxStartInput_MEA.TabIndex = 1;
            // 
            // textBoxEndInput_MEA
            // 
            this.textBoxEndInput_MEA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEndInput_MEA.Location = new System.Drawing.Point(223, 44);
            this.textBoxEndInput_MEA.Name = "textBoxEndInput_MEA";
            this.textBoxEndInput_MEA.Size = new System.Drawing.Size(223, 22);
            this.textBoxEndInput_MEA.TabIndex = 2;
            // 
            // textBoxEnd_MEA
            // 
            this.textBoxEnd_MEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEnd_MEA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEnd_MEA.Location = new System.Drawing.Point(223, 21);
            this.textBoxEnd_MEA.Name = "textBoxEnd_MEA";
            this.textBoxEnd_MEA.ReadOnly = true;
            this.textBoxEnd_MEA.Size = new System.Drawing.Size(100, 15);
            this.textBoxEnd_MEA.TabIndex = 3;
            this.textBoxEnd_MEA.Text = "Конец шага: ";
            // 
            // buttonHelp_MEA
            // 
            this.buttonHelp_MEA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_MEA.Location = new System.Drawing.Point(470, 359);
            this.buttonHelp_MEA.Name = "buttonHelp_MEA";
            this.buttonHelp_MEA.Size = new System.Drawing.Size(96, 79);
            this.buttonHelp_MEA.TabIndex = 2;
            this.buttonHelp_MEA.Text = "Справка";
            this.buttonHelp_MEA.UseVisualStyleBackColor = false;
            this.buttonHelp_MEA.Click += new System.EventHandler(this.buttonHelp_MEA_Click);
            // 
            // buttonToDo_MEA
            // 
            this.buttonToDo_MEA.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonToDo_MEA.Location = new System.Drawing.Point(572, 359);
            this.buttonToDo_MEA.Name = "buttonToDo_MEA";
            this.buttonToDo_MEA.Size = new System.Drawing.Size(132, 79);
            this.buttonToDo_MEA.TabIndex = 3;
            this.buttonToDo_MEA.Text = "Выполнить";
            this.buttonToDo_MEA.UseVisualStyleBackColor = false;
            this.buttonToDo_MEA.Click += new System.EventHandler(this.buttonToDo_MEA_Click);
            this.buttonToDo_MEA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonToDo_MEA_MouseDown);
            this.buttonToDo_MEA.MouseEnter += new System.EventHandler(this.buttonToDo_MEA_MouseEnter);
            this.buttonToDo_MEA.MouseLeave += new System.EventHandler(this.buttonToDo_MEA_MouseLeave);
            // 
            // groupBoxOutput_MEA
            // 
            this.groupBoxOutput_MEA.Controls.Add(this.chartFunction_MEA);
            this.groupBoxOutput_MEA.Controls.Add(this.dataGridViewFunction_MEA);
            this.groupBoxOutput_MEA.Controls.Add(this.textBoxResult_MEA);
            this.groupBoxOutput_MEA.Location = new System.Drawing.Point(711, 13);
            this.groupBoxOutput_MEA.Name = "groupBoxOutput_MEA";
            this.groupBoxOutput_MEA.Size = new System.Drawing.Size(668, 425);
            this.groupBoxOutput_MEA.TabIndex = 4;
            this.groupBoxOutput_MEA.TabStop = false;
            this.groupBoxOutput_MEA.Text = "Вывод данных";
            // 
            // textBoxResult_MEA
            // 
            this.textBoxResult_MEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult_MEA.Location = new System.Drawing.Point(7, 22);
            this.textBoxResult_MEA.Name = "textBoxResult_MEA";
            this.textBoxResult_MEA.ReadOnly = true;
            this.textBoxResult_MEA.Size = new System.Drawing.Size(100, 15);
            this.textBoxResult_MEA.TabIndex = 0;
            this.textBoxResult_MEA.Text = "Результат:";
            // 
            // dataGridViewFunction_MEA
            // 
            this.dataGridViewFunction_MEA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewFunction_MEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_MEA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.F});
            this.dataGridViewFunction_MEA.Location = new System.Drawing.Point(7, 44);
            this.dataGridViewFunction_MEA.Name = "dataGridViewFunction_MEA";
            this.dataGridViewFunction_MEA.RowHeadersVisible = false;
            this.dataGridViewFunction_MEA.RowHeadersWidth = 51;
            this.dataGridViewFunction_MEA.RowTemplate.Height = 24;
            this.dataGridViewFunction_MEA.Size = new System.Drawing.Size(203, 368);
            this.dataGridViewFunction_MEA.TabIndex = 1;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.ReadOnly = true;
            // 
            // F
            // 
            this.F.HeaderText = "F(X)";
            this.F.MinimumWidth = 6;
            this.F.Name = "F";
            this.F.ReadOnly = true;
            // 
            // chartFunction_MEA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_MEA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_MEA.Legends.Add(legend1);
            this.chartFunction_MEA.Location = new System.Drawing.Point(217, 44);
            this.chartFunction_MEA.Name = "chartFunction_MEA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_MEA.Series.Add(series1);
            this.chartFunction_MEA.Size = new System.Drawing.Size(445, 368);
            this.chartFunction_MEA.TabIndex = 2;
            this.chartFunction_MEA.Text = "chart1";
            this.chartFunction_MEA.Click += new System.EventHandler(this.chartFunction_MEA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 450);
            this.Controls.Add(this.groupBoxOutput_MEA);
            this.Controls.Add(this.buttonToDo_MEA);
            this.Controls.Add(this.buttonHelp_MEA);
            this.Controls.Add(this.groupBoxInputData_MEA);
            this.Controls.Add(this.groupBoxCondition_MEA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 19 | Меньшиков Е. А.";
            this.groupBoxCondition_MEA.ResumeLayout(false);
            this.groupBoxCondition_MEA.PerformLayout();
            this.groupBoxInputData_MEA.ResumeLayout(false);
            this.groupBoxInputData_MEA.PerformLayout();
            this.groupBoxOutput_MEA.ResumeLayout(false);
            this.groupBoxOutput_MEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_MEA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_MEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_MEA;
        private System.Windows.Forms.TextBox textBoxCondition_MEA;
        private System.Windows.Forms.GroupBox groupBoxInputData_MEA;
        private System.Windows.Forms.TextBox textBoxEnd_MEA;
        private System.Windows.Forms.TextBox textBoxEndInput_MEA;
        private System.Windows.Forms.TextBox textBoxStartInput_MEA;
        private System.Windows.Forms.TextBox textBoxStart_MEA;
        private System.Windows.Forms.Button buttonHelp_MEA;
        private System.Windows.Forms.Button buttonToDo_MEA;
        private System.Windows.Forms.GroupBox groupBoxOutput_MEA;
        private System.Windows.Forms.TextBox textBoxResult_MEA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_MEA;
        private System.Windows.Forms.DataGridView dataGridViewFunction_MEA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
    }
}


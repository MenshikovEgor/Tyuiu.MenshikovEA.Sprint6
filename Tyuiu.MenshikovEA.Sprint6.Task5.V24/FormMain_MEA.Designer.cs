
namespace Tyuiu.MenshikovEA.Sprint6.Task5.V24
{
    partial class FormMain_MEA
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelInfo_MEA = new System.Windows.Forms.Panel();
            this.panelOutput_MEA = new System.Windows.Forms.Panel();
            this.panelGraphic_MEA = new System.Windows.Forms.Panel();
            this.groupBoxCondition_MEA = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_MEA = new System.Windows.Forms.TextBox();
            this.buttonDone_MEA = new System.Windows.Forms.Button();
            this.buttonOpen_MEA = new System.Windows.Forms.Button();
            this.buttonHelp_MEA = new System.Windows.Forms.Button();
            this.dataGridViewOutPut_MEA = new System.Windows.Forms.DataGridView();
            this.ColumnCount_MEA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnData_MEA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartGraphic_MEA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelInfo_MEA.SuspendLayout();
            this.panelOutput_MEA.SuspendLayout();
            this.panelGraphic_MEA.SuspendLayout();
            this.groupBoxCondition_MEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_MEA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphic_MEA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfo_MEA
            // 
            this.panelInfo_MEA.Controls.Add(this.buttonHelp_MEA);
            this.panelInfo_MEA.Controls.Add(this.buttonOpen_MEA);
            this.panelInfo_MEA.Controls.Add(this.buttonDone_MEA);
            this.panelInfo_MEA.Controls.Add(this.groupBoxCondition_MEA);
            this.panelInfo_MEA.Location = new System.Drawing.Point(0, 0);
            this.panelInfo_MEA.Name = "panelInfo_MEA";
            this.panelInfo_MEA.Size = new System.Drawing.Size(964, 126);
            this.panelInfo_MEA.TabIndex = 0;
            // 
            // panelOutput_MEA
            // 
            this.panelOutput_MEA.Controls.Add(this.dataGridViewOutPut_MEA);
            this.panelOutput_MEA.Location = new System.Drawing.Point(0, 124);
            this.panelOutput_MEA.Name = "panelOutput_MEA";
            this.panelOutput_MEA.Size = new System.Drawing.Size(286, 425);
            this.panelOutput_MEA.TabIndex = 1;
            // 
            // panelGraphic_MEA
            // 
            this.panelGraphic_MEA.Controls.Add(this.chartGraphic_MEA);
            this.panelGraphic_MEA.Location = new System.Drawing.Point(286, 127);
            this.panelGraphic_MEA.Name = "panelGraphic_MEA";
            this.panelGraphic_MEA.Size = new System.Drawing.Size(678, 425);
            this.panelGraphic_MEA.TabIndex = 2;
            // 
            // groupBoxCondition_MEA
            // 
            this.groupBoxCondition_MEA.Controls.Add(this.textBoxCondition_MEA);
            this.groupBoxCondition_MEA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_MEA.Name = "groupBoxCondition_MEA";
            this.groupBoxCondition_MEA.Size = new System.Drawing.Size(598, 105);
            this.groupBoxCondition_MEA.TabIndex = 0;
            this.groupBoxCondition_MEA.TabStop = false;
            this.groupBoxCondition_MEA.Text = "Условие:";
            // 
            // textBoxCondition_MEA
            // 
            this.textBoxCondition_MEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_MEA.Location = new System.Drawing.Point(7, 22);
            this.textBoxCondition_MEA.Multiline = true;
            this.textBoxCondition_MEA.Name = "textBoxCondition_MEA";
            this.textBoxCondition_MEA.ReadOnly = true;
            this.textBoxCondition_MEA.Size = new System.Drawing.Size(562, 77);
            this.textBoxCondition_MEA.TabIndex = 0;
            this.textBoxCondition_MEA.Text = "Прочитать данные из файла InPutFileTask5V24.txt. Вывести в dataGridView\r\nвсе знач" +
    "ения кроме 0 и построить по ним диаграмму.\r\n\r\n";
            // 
            // buttonDone_MEA
            // 
            this.buttonDone_MEA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_MEA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_MEA.Location = new System.Drawing.Point(618, 13);
            this.buttonDone_MEA.Name = "buttonDone_MEA";
            this.buttonDone_MEA.Size = new System.Drawing.Size(100, 99);
            this.buttonDone_MEA.TabIndex = 1;
            this.buttonDone_MEA.Text = "Выполнить";
            this.buttonDone_MEA.UseVisualStyleBackColor = false;
            this.buttonDone_MEA.Click += new System.EventHandler(this.buttonDone_MEA_Click);
            // 
            // buttonOpen_MEA
            // 
            this.buttonOpen_MEA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOpen_MEA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpen_MEA.Location = new System.Drawing.Point(724, 12);
            this.buttonOpen_MEA.Name = "buttonOpen_MEA";
            this.buttonOpen_MEA.Size = new System.Drawing.Size(100, 99);
            this.buttonOpen_MEA.TabIndex = 2;
            this.buttonOpen_MEA.Text = "Открыть файл";
            this.buttonOpen_MEA.UseVisualStyleBackColor = false;
            this.buttonOpen_MEA.Click += new System.EventHandler(this.buttonOpen_MEA_Click);
            // 
            // buttonHelp_MEA
            // 
            this.buttonHelp_MEA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_MEA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_MEA.Location = new System.Drawing.Point(830, 12);
            this.buttonHelp_MEA.Name = "buttonHelp_MEA";
            this.buttonHelp_MEA.Size = new System.Drawing.Size(100, 99);
            this.buttonHelp_MEA.TabIndex = 3;
            this.buttonHelp_MEA.Text = "Справка";
            this.buttonHelp_MEA.UseVisualStyleBackColor = false;
            this.buttonHelp_MEA.Click += new System.EventHandler(this.buttonHelp_MEA_Click);
            // 
            // dataGridViewOutPut_MEA
            // 
            this.dataGridViewOutPut_MEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_MEA.ColumnHeadersVisible = false;
            this.dataGridViewOutPut_MEA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCount_MEA,
            this.ColumnData_MEA});
            this.dataGridViewOutPut_MEA.Location = new System.Drawing.Point(13, 9);
            this.dataGridViewOutPut_MEA.Name = "dataGridViewOutPut_MEA";
            this.dataGridViewOutPut_MEA.ReadOnly = true;
            this.dataGridViewOutPut_MEA.RowHeadersVisible = false;
            this.dataGridViewOutPut_MEA.RowHeadersWidth = 51;
            this.dataGridViewOutPut_MEA.RowTemplate.Height = 24;
            this.dataGridViewOutPut_MEA.Size = new System.Drawing.Size(253, 404);
            this.dataGridViewOutPut_MEA.TabIndex = 0;
            // 
            // ColumnCount_MEA
            // 
            this.ColumnCount_MEA.HeaderText = "";
            this.ColumnCount_MEA.MinimumWidth = 6;
            this.ColumnCount_MEA.Name = "ColumnCount_MEA";
            this.ColumnCount_MEA.ReadOnly = true;
            this.ColumnCount_MEA.Width = 125;
            // 
            // ColumnData_MEA
            // 
            this.ColumnData_MEA.HeaderText = "";
            this.ColumnData_MEA.MinimumWidth = 6;
            this.ColumnData_MEA.Name = "ColumnData_MEA";
            this.ColumnData_MEA.ReadOnly = true;
            this.ColumnData_MEA.Width = 125;
            // 
            // chartGraphic_MEA
            // 
            chartArea3.Name = "ChartArea1";
            this.chartGraphic_MEA.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chartGraphic_MEA.Legends.Add(legend3);
            this.chartGraphic_MEA.Location = new System.Drawing.Point(3, 0);
            this.chartGraphic_MEA.Name = "chartGraphic_MEA";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartGraphic_MEA.Series.Add(series3);
            this.chartGraphic_MEA.Size = new System.Drawing.Size(675, 422);
            this.chartGraphic_MEA.TabIndex = 0;
            // 
            // FormMain_MEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 549);
            this.Controls.Add(this.panelGraphic_MEA);
            this.Controls.Add(this.panelOutput_MEA);
            this.Controls.Add(this.panelInfo_MEA);
            this.Name = "FormMain_MEA";
            this.Text = "Спринт 6 | Таск 5 | Вариант 24| Меньшиков Е. А.";
            this.panelInfo_MEA.ResumeLayout(false);
            this.panelOutput_MEA.ResumeLayout(false);
            this.panelGraphic_MEA.ResumeLayout(false);
            this.groupBoxCondition_MEA.ResumeLayout(false);
            this.groupBoxCondition_MEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_MEA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphic_MEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelInfo_MEA;
        private System.Windows.Forms.Panel panelOutput_MEA;
        private System.Windows.Forms.Panel panelGraphic_MEA;
        private System.Windows.Forms.Button buttonHelp_MEA;
        private System.Windows.Forms.Button buttonOpen_MEA;
        private System.Windows.Forms.Button buttonDone_MEA;
        private System.Windows.Forms.GroupBox groupBoxCondition_MEA;
        private System.Windows.Forms.TextBox textBoxCondition_MEA;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_MEA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCount_MEA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnData_MEA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraphic_MEA;
    }
}


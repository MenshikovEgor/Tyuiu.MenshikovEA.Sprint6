
namespace Tyuiu.MenshikovEA.Sprint6.Task4.V12
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
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelInfo_MEA = new System.Windows.Forms.Panel();
            this.panelOutputText_MEA = new System.Windows.Forms.Panel();
            this.panelGraphicOutput_MEA = new System.Windows.Forms.Panel();
            this.groupBoxCondition_MEA = new System.Windows.Forms.GroupBox();
            this.groupBoxInput_MEA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput_MEA = new System.Windows.Forms.GroupBox();
            this.textBoxOutput_MEA = new System.Windows.Forms.TextBox();
            this.chartFunction_MEA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxData_MEA = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_MEA = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_MEA = new System.Windows.Forms.TextBox();
            this.textBoxStartInput_MEA = new System.Windows.Forms.TextBox();
            this.textBoxStopInput_MEA = new System.Windows.Forms.TextBox();
            this.buttonDone_MEA = new System.Windows.Forms.Button();
            this.buttonHelp_MEA = new System.Windows.Forms.Button();
            this.buttonSave_MEA = new System.Windows.Forms.Button();
            this.panelInfo_MEA.SuspendLayout();
            this.panelOutputText_MEA.SuspendLayout();
            this.panelGraphicOutput_MEA.SuspendLayout();
            this.groupBoxCondition_MEA.SuspendLayout();
            this.groupBoxInput_MEA.SuspendLayout();
            this.groupBoxOutput_MEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_MEA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfo_MEA
            // 
            this.panelInfo_MEA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelInfo_MEA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo_MEA.Controls.Add(this.buttonSave_MEA);
            this.panelInfo_MEA.Controls.Add(this.buttonHelp_MEA);
            this.panelInfo_MEA.Controls.Add(this.buttonDone_MEA);
            this.panelInfo_MEA.Controls.Add(this.groupBoxInput_MEA);
            this.panelInfo_MEA.Controls.Add(this.groupBoxCondition_MEA);
            this.panelInfo_MEA.Location = new System.Drawing.Point(0, 0);
            this.panelInfo_MEA.Name = "panelInfo_MEA";
            this.panelInfo_MEA.Size = new System.Drawing.Size(1060, 100);
            this.panelInfo_MEA.TabIndex = 0;
            // 
            // panelOutputText_MEA
            // 
            this.panelOutputText_MEA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelOutputText_MEA.Controls.Add(this.groupBoxOutput_MEA);
            this.panelOutputText_MEA.Location = new System.Drawing.Point(0, 100);
            this.panelOutputText_MEA.Name = "panelOutputText_MEA";
            this.panelOutputText_MEA.Size = new System.Drawing.Size(327, 394);
            this.panelOutputText_MEA.TabIndex = 1;
            // 
            // panelGraphicOutput_MEA
            // 
            this.panelGraphicOutput_MEA.BackColor = System.Drawing.SystemColors.Control;
            this.panelGraphicOutput_MEA.Controls.Add(this.chartFunction_MEA);
            this.panelGraphicOutput_MEA.Location = new System.Drawing.Point(333, 100);
            this.panelGraphicOutput_MEA.Name = "panelGraphicOutput_MEA";
            this.panelGraphicOutput_MEA.Size = new System.Drawing.Size(727, 394);
            this.panelGraphicOutput_MEA.TabIndex = 1;
            // 
            // groupBoxCondition_MEA
            // 
            this.groupBoxCondition_MEA.Controls.Add(this.textBoxData_MEA);
            this.groupBoxCondition_MEA.Location = new System.Drawing.Point(4, 4);
            this.groupBoxCondition_MEA.Name = "groupBoxCondition_MEA";
            this.groupBoxCondition_MEA.Size = new System.Drawing.Size(486, 89);
            this.groupBoxCondition_MEA.TabIndex = 0;
            this.groupBoxCondition_MEA.TabStop = false;
            this.groupBoxCondition_MEA.Text = "Условие";
            // 
            // groupBoxInput_MEA
            // 
            this.groupBoxInput_MEA.Controls.Add(this.textBoxStopInput_MEA);
            this.groupBoxInput_MEA.Controls.Add(this.textBoxStartInput_MEA);
            this.groupBoxInput_MEA.Controls.Add(this.textBoxStopStep_MEA);
            this.groupBoxInput_MEA.Controls.Add(this.textBoxStartStep_MEA);
            this.groupBoxInput_MEA.Location = new System.Drawing.Point(496, 4);
            this.groupBoxInput_MEA.Name = "groupBoxInput_MEA";
            this.groupBoxInput_MEA.Size = new System.Drawing.Size(255, 89);
            this.groupBoxInput_MEA.TabIndex = 1;
            this.groupBoxInput_MEA.TabStop = false;
            this.groupBoxInput_MEA.Text = "Ввод данных";
            // 
            // groupBoxOutput_MEA
            // 
            this.groupBoxOutput_MEA.Controls.Add(this.textBoxOutput_MEA);
            this.groupBoxOutput_MEA.Location = new System.Drawing.Point(5, 6);
            this.groupBoxOutput_MEA.Name = "groupBoxOutput_MEA";
            this.groupBoxOutput_MEA.Size = new System.Drawing.Size(274, 376);
            this.groupBoxOutput_MEA.TabIndex = 0;
            this.groupBoxOutput_MEA.TabStop = false;
            this.groupBoxOutput_MEA.Text = "Вывод";
            // 
            // textBoxOutput_MEA
            // 
            this.textBoxOutput_MEA.Location = new System.Drawing.Point(8, 21);
            this.textBoxOutput_MEA.Multiline = true;
            this.textBoxOutput_MEA.Name = "textBoxOutput_MEA";
            this.textBoxOutput_MEA.ReadOnly = true;
            this.textBoxOutput_MEA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput_MEA.Size = new System.Drawing.Size(268, 354);
            this.textBoxOutput_MEA.TabIndex = 0;
            this.textBoxOutput_MEA.TextChanged += new System.EventHandler(this.textBoxOutput_MEA_TextChanged);
            // 
            // chartFunction_MEA
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFunction_MEA.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartFunction_MEA.Legends.Add(legend3);
            this.chartFunction_MEA.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_MEA.Name = "chartFunction_MEA";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "SeriesFunc_MEA";
            this.chartFunction_MEA.Series.Add(series3);
            this.chartFunction_MEA.Size = new System.Drawing.Size(727, 391);
            this.chartFunction_MEA.TabIndex = 0;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            title3.ForeColor = System.Drawing.Color.MidnightBlue;
            title3.Name = "TitleFunction_MEA";
            title3.Text = "График функции";
            this.chartFunction_MEA.Titles.Add(title3);
            // 
            // textBoxData_MEA
            // 
            this.textBoxData_MEA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxData_MEA.Location = new System.Drawing.Point(8, 22);
            this.textBoxData_MEA.Multiline = true;
            this.textBoxData_MEA.Name = "textBoxData_MEA";
            this.textBoxData_MEA.ReadOnly = true;
            this.textBoxData_MEA.Size = new System.Drawing.Size(472, 61);
            this.textBoxData_MEA.TabIndex = 0;
            this.textBoxData_MEA.Text = "Протабулировать F(x) = sin(x) + 2/(3x * 0,5) - 2cos(x) * 2x на отрезке [-5; 5].\r\n" +
    "Результат вывести в textBox. Построить график функции и сохранить в файл OutPutF" +
    "ileTask.txt по нажатию кнопки.";
            // 
            // textBoxStartStep_MEA
            // 
            this.textBoxStartStep_MEA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxStartStep_MEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStartStep_MEA.Location = new System.Drawing.Point(7, 22);
            this.textBoxStartStep_MEA.Name = "textBoxStartStep_MEA";
            this.textBoxStartStep_MEA.ReadOnly = true;
            this.textBoxStartStep_MEA.Size = new System.Drawing.Size(116, 15);
            this.textBoxStartStep_MEA.TabIndex = 0;
            this.textBoxStartStep_MEA.Text = "Старт шага:";
            // 
            // textBoxStopStep_MEA
            // 
            this.textBoxStopStep_MEA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxStopStep_MEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStopStep_MEA.Location = new System.Drawing.Point(129, 21);
            this.textBoxStopStep_MEA.Name = "textBoxStopStep_MEA";
            this.textBoxStopStep_MEA.ReadOnly = true;
            this.textBoxStopStep_MEA.Size = new System.Drawing.Size(116, 15);
            this.textBoxStopStep_MEA.TabIndex = 1;
            this.textBoxStopStep_MEA.Text = "Конец шага:";
            // 
            // textBoxStartInput_MEA
            // 
            this.textBoxStartInput_MEA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStartInput_MEA.Location = new System.Drawing.Point(7, 44);
            this.textBoxStartInput_MEA.Name = "textBoxStartInput_MEA";
            this.textBoxStartInput_MEA.Size = new System.Drawing.Size(116, 22);
            this.textBoxStartInput_MEA.TabIndex = 2;
            // 
            // textBoxStopInput_MEA
            // 
            this.textBoxStopInput_MEA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStopInput_MEA.Location = new System.Drawing.Point(129, 44);
            this.textBoxStopInput_MEA.Name = "textBoxStopInput_MEA";
            this.textBoxStopInput_MEA.Size = new System.Drawing.Size(116, 22);
            this.textBoxStopInput_MEA.TabIndex = 3;
            // 
            // buttonDone_MEA
            // 
            this.buttonDone_MEA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_MEA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_MEA.Location = new System.Drawing.Point(758, 12);
            this.buttonDone_MEA.Name = "buttonDone_MEA";
            this.buttonDone_MEA.Size = new System.Drawing.Size(93, 75);
            this.buttonDone_MEA.TabIndex = 2;
            this.buttonDone_MEA.Text = "Выполнить";
            this.buttonDone_MEA.UseVisualStyleBackColor = false;
            this.buttonDone_MEA.Click += new System.EventHandler(this.buttonDone_MEA_Click);
            // 
            // buttonHelp_MEA
            // 
            this.buttonHelp_MEA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_MEA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_MEA.Location = new System.Drawing.Point(954, 11);
            this.buttonHelp_MEA.Name = "buttonHelp_MEA";
            this.buttonHelp_MEA.Size = new System.Drawing.Size(93, 75);
            this.buttonHelp_MEA.TabIndex = 3;
            this.buttonHelp_MEA.Text = "Справка";
            this.buttonHelp_MEA.UseVisualStyleBackColor = false;
            this.buttonHelp_MEA.Click += new System.EventHandler(this.buttonHelp_MEA_Click);
            // 
            // buttonSave_MEA
            // 
            this.buttonSave_MEA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave_MEA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_MEA.Location = new System.Drawing.Point(857, 12);
            this.buttonSave_MEA.Name = "buttonSave_MEA";
            this.buttonSave_MEA.Size = new System.Drawing.Size(93, 75);
            this.buttonSave_MEA.TabIndex = 4;
            this.buttonSave_MEA.Text = "Сохранить";
            this.buttonSave_MEA.UseVisualStyleBackColor = false;
            this.buttonSave_MEA.Click += new System.EventHandler(this.buttonSave_MEA_Click);
            // 
            // FormMain_MEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 494);
            this.Controls.Add(this.panelGraphicOutput_MEA);
            this.Controls.Add(this.panelOutputText_MEA);
            this.Controls.Add(this.panelInfo_MEA);
            this.Name = "FormMain_MEA";
            this.Text = "Спринт 6 | Таск 4 | Вариант 0 | Меньшиков Е. А.";
            this.panelInfo_MEA.ResumeLayout(false);
            this.panelOutputText_MEA.ResumeLayout(false);
            this.panelGraphicOutput_MEA.ResumeLayout(false);
            this.groupBoxCondition_MEA.ResumeLayout(false);
            this.groupBoxCondition_MEA.PerformLayout();
            this.groupBoxInput_MEA.ResumeLayout(false);
            this.groupBoxInput_MEA.PerformLayout();
            this.groupBoxOutput_MEA.ResumeLayout(false);
            this.groupBoxOutput_MEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_MEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInfo_MEA;
        private System.Windows.Forms.Panel panelOutputText_MEA;
        private System.Windows.Forms.Panel panelGraphicOutput_MEA;
        private System.Windows.Forms.GroupBox groupBoxInput_MEA;
        private System.Windows.Forms.GroupBox groupBoxCondition_MEA;
        private System.Windows.Forms.GroupBox groupBoxOutput_MEA;
        private System.Windows.Forms.TextBox textBoxOutput_MEA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_MEA;
        private System.Windows.Forms.TextBox textBoxData_MEA;
        private System.Windows.Forms.TextBox textBoxStopStep_MEA;
        private System.Windows.Forms.TextBox textBoxStartStep_MEA;
        private System.Windows.Forms.Button buttonDone_MEA;
        private System.Windows.Forms.TextBox textBoxStopInput_MEA;
        private System.Windows.Forms.TextBox textBoxStartInput_MEA;
        private System.Windows.Forms.Button buttonSave_MEA;
        private System.Windows.Forms.Button buttonHelp_MEA;
    }
}


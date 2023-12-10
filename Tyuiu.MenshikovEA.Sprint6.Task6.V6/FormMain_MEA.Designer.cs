
namespace Tyuiu.MenshikovEA.Sprint6.Task6.V6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_MEA));
            this.panelButtons_MEA = new System.Windows.Forms.Panel();
            this.buttonHelp_MEA = new System.Windows.Forms.Button();
            this.buttonDone_MEA = new System.Windows.Forms.Button();
            this.buttonChooseFile_MEA = new System.Windows.Forms.Button();
            this.panelCondition_MEA = new System.Windows.Forms.Panel();
            this.groupBoxCondition_MEA = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_MEA = new System.Windows.Forms.TextBox();
            this.panelInput_MEA = new System.Windows.Forms.Panel();
            this.groupBoxInput_MEA = new System.Windows.Forms.GroupBox();
            this.textBoxInput_MEA = new System.Windows.Forms.TextBox();
            this.panelOutPut_MEA = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_MEA = new System.Windows.Forms.GroupBox();
            this.textBoxOutPut_MEA = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_MEA = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_MEA = new System.Windows.Forms.ToolTip(this.components);
            this.panelButtons_MEA.SuspendLayout();
            this.panelCondition_MEA.SuspendLayout();
            this.groupBoxCondition_MEA.SuspendLayout();
            this.panelInput_MEA.SuspendLayout();
            this.groupBoxInput_MEA.SuspendLayout();
            this.panelOutPut_MEA.SuspendLayout();
            this.groupBoxOutPut_MEA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons_MEA
            // 
            this.panelButtons_MEA.Controls.Add(this.buttonHelp_MEA);
            this.panelButtons_MEA.Controls.Add(this.buttonDone_MEA);
            this.panelButtons_MEA.Controls.Add(this.buttonChooseFile_MEA);
            this.panelButtons_MEA.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_MEA.Name = "panelButtons_MEA";
            this.panelButtons_MEA.Size = new System.Drawing.Size(1067, 76);
            this.panelButtons_MEA.TabIndex = 0;
            // 
            // buttonHelp_MEA
            // 
            this.buttonHelp_MEA.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHelp_MEA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_MEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_MEA.Image")));
            this.buttonHelp_MEA.Location = new System.Drawing.Point(981, 4);
            this.buttonHelp_MEA.Name = "buttonHelp_MEA";
            this.buttonHelp_MEA.Size = new System.Drawing.Size(83, 65);
            this.buttonHelp_MEA.TabIndex = 2;
            this.toolTip_MEA.SetToolTip(this.buttonHelp_MEA, "Сведения о программе\r\n");
            this.buttonHelp_MEA.UseVisualStyleBackColor = false;
            this.buttonHelp_MEA.Click += new System.EventHandler(this.buttonHelp_MEA_Click);
            // 
            // buttonDone_MEA
            // 
            this.buttonDone_MEA.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDone_MEA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_MEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_MEA.Image")));
            this.buttonDone_MEA.Location = new System.Drawing.Point(90, 4);
            this.buttonDone_MEA.Name = "buttonDone_MEA";
            this.buttonDone_MEA.Size = new System.Drawing.Size(83, 65);
            this.buttonDone_MEA.TabIndex = 1;
            this.toolTip_MEA.SetToolTip(this.buttonDone_MEA, "Производит поиск в файле вхождений символа \"b\"\r\nи выводит все слова в которых при" +
        "сутствует\r\nэтот символ");
            this.buttonDone_MEA.UseVisualStyleBackColor = false;
            this.buttonDone_MEA.Click += new System.EventHandler(this.buttonDone_MEA_Click);
            // 
            // buttonChooseFile_MEA
            // 
            this.buttonChooseFile_MEA.BackColor = System.Drawing.SystemColors.Control;
            this.buttonChooseFile_MEA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChooseFile_MEA.Image = ((System.Drawing.Image)(resources.GetObject("buttonChooseFile_MEA.Image")));
            this.buttonChooseFile_MEA.Location = new System.Drawing.Point(4, 4);
            this.buttonChooseFile_MEA.Name = "buttonChooseFile_MEA";
            this.buttonChooseFile_MEA.Size = new System.Drawing.Size(80, 65);
            this.buttonChooseFile_MEA.TabIndex = 0;
            this.toolTip_MEA.SetToolTip(this.buttonChooseFile_MEA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            this.buttonChooseFile_MEA.UseVisualStyleBackColor = false;
            this.buttonChooseFile_MEA.Click += new System.EventHandler(this.buttonChooseFile_MEA_Click);
            // 
            // panelCondition_MEA
            // 
            this.panelCondition_MEA.Controls.Add(this.groupBoxCondition_MEA);
            this.panelCondition_MEA.Location = new System.Drawing.Point(0, 75);
            this.panelCondition_MEA.Name = "panelCondition_MEA";
            this.panelCondition_MEA.Size = new System.Drawing.Size(1067, 116);
            this.panelCondition_MEA.TabIndex = 1;
            // 
            // groupBoxCondition_MEA
            // 
            this.groupBoxCondition_MEA.Controls.Add(this.textBoxCondition_MEA);
            this.groupBoxCondition_MEA.Location = new System.Drawing.Point(12, 11);
            this.groupBoxCondition_MEA.Name = "groupBoxCondition_MEA";
            this.groupBoxCondition_MEA.Size = new System.Drawing.Size(1043, 98);
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
            this.textBoxCondition_MEA.Size = new System.Drawing.Size(1030, 70);
            this.textBoxCondition_MEA.TabIndex = 0;
            this.textBoxCondition_MEA.Text = resources.GetString("textBoxCondition_MEA.Text");
            // 
            // panelInput_MEA
            // 
            this.panelInput_MEA.Controls.Add(this.groupBoxInput_MEA);
            this.panelInput_MEA.Location = new System.Drawing.Point(0, 190);
            this.panelInput_MEA.Name = "panelInput_MEA";
            this.panelInput_MEA.Size = new System.Drawing.Size(533, 404);
            this.panelInput_MEA.TabIndex = 2;
            // 
            // groupBoxInput_MEA
            // 
            this.groupBoxInput_MEA.Controls.Add(this.textBoxInput_MEA);
            this.groupBoxInput_MEA.Location = new System.Drawing.Point(4, 8);
            this.groupBoxInput_MEA.Name = "groupBoxInput_MEA";
            this.groupBoxInput_MEA.Size = new System.Drawing.Size(524, 384);
            this.groupBoxInput_MEA.TabIndex = 0;
            this.groupBoxInput_MEA.TabStop = false;
            this.groupBoxInput_MEA.Text = "Ввод:";
            // 
            // textBoxInput_MEA
            // 
            this.textBoxInput_MEA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxInput_MEA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInput_MEA.Location = new System.Drawing.Point(9, 22);
            this.textBoxInput_MEA.Multiline = true;
            this.textBoxInput_MEA.Name = "textBoxInput_MEA";
            this.textBoxInput_MEA.ReadOnly = true;
            this.textBoxInput_MEA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput_MEA.Size = new System.Drawing.Size(509, 356);
            this.textBoxInput_MEA.TabIndex = 0;
            // 
            // panelOutPut_MEA
            // 
            this.panelOutPut_MEA.Controls.Add(this.groupBoxOutPut_MEA);
            this.panelOutPut_MEA.Location = new System.Drawing.Point(534, 190);
            this.panelOutPut_MEA.Name = "panelOutPut_MEA";
            this.panelOutPut_MEA.Size = new System.Drawing.Size(533, 404);
            this.panelOutPut_MEA.TabIndex = 3;
            // 
            // groupBoxOutPut_MEA
            // 
            this.groupBoxOutPut_MEA.Controls.Add(this.textBoxOutPut_MEA);
            this.groupBoxOutPut_MEA.Location = new System.Drawing.Point(6, 8);
            this.groupBoxOutPut_MEA.Name = "groupBoxOutPut_MEA";
            this.groupBoxOutPut_MEA.Size = new System.Drawing.Size(515, 384);
            this.groupBoxOutPut_MEA.TabIndex = 0;
            this.groupBoxOutPut_MEA.TabStop = false;
            this.groupBoxOutPut_MEA.Text = "Вывод:";
            // 
            // textBoxOutPut_MEA
            // 
            this.textBoxOutPut_MEA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxOutPut_MEA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOutPut_MEA.Location = new System.Drawing.Point(0, 22);
            this.textBoxOutPut_MEA.Multiline = true;
            this.textBoxOutPut_MEA.Name = "textBoxOutPut_MEA";
            this.textBoxOutPut_MEA.ReadOnly = true;
            this.textBoxOutPut_MEA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPut_MEA.Size = new System.Drawing.Size(509, 356);
            this.textBoxOutPut_MEA.TabIndex = 1;
            // 
            // openFileDialogTask_MEA
            // 
            this.openFileDialogTask_MEA.FileName = "openFileDialogTask_MEA";
            // 
            // toolTip_MEA
            // 
            this.toolTip_MEA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_MEA.ToolTipTitle = "Подсказка";
            // 
            // FormMain_MEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 594);
            this.Controls.Add(this.panelOutPut_MEA);
            this.Controls.Add(this.panelInput_MEA);
            this.Controls.Add(this.panelCondition_MEA);
            this.Controls.Add(this.panelButtons_MEA);
            this.Name = "FormMain_MEA";
            this.Text = "Спринт 6 | Таск 6 | Вариант 6 | Меньшиков Е. А.";
            this.panelButtons_MEA.ResumeLayout(false);
            this.panelCondition_MEA.ResumeLayout(false);
            this.groupBoxCondition_MEA.ResumeLayout(false);
            this.groupBoxCondition_MEA.PerformLayout();
            this.panelInput_MEA.ResumeLayout(false);
            this.groupBoxInput_MEA.ResumeLayout(false);
            this.groupBoxInput_MEA.PerformLayout();
            this.panelOutPut_MEA.ResumeLayout(false);
            this.groupBoxOutPut_MEA.ResumeLayout(false);
            this.groupBoxOutPut_MEA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_MEA;
        private System.Windows.Forms.Button buttonHelp_MEA;
        private System.Windows.Forms.ToolTip toolTip_MEA;
        private System.Windows.Forms.Button buttonDone_MEA;
        private System.Windows.Forms.Button buttonChooseFile_MEA;
        private System.Windows.Forms.Panel panelCondition_MEA;
        private System.Windows.Forms.GroupBox groupBoxCondition_MEA;
        private System.Windows.Forms.TextBox textBoxCondition_MEA;
        private System.Windows.Forms.Panel panelInput_MEA;
        private System.Windows.Forms.GroupBox groupBoxInput_MEA;
        private System.Windows.Forms.TextBox textBoxInput_MEA;
        private System.Windows.Forms.Panel panelOutPut_MEA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_MEA;
        private System.Windows.Forms.TextBox textBoxOutPut_MEA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_MEA;
    }
}


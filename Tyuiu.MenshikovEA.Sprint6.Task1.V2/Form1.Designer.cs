
namespace Tyuiu.MenshikovEA.Sprint6.Task1.V2
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
            this.groupBoxCondition_MEA = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_MEA = new System.Windows.Forms.TextBox();
            this.groupBoxResultOutput_MEA = new System.Windows.Forms.GroupBox();
            this.textBoxResultMark_MEA = new System.Windows.Forms.TextBox();
            this.textBoxResultScroll_MEA = new System.Windows.Forms.TextBox();
            this.buttonToDo_MEA = new System.Windows.Forms.Button();
            this.buttonHelp_MEA = new System.Windows.Forms.Button();
            this.groupBoxDataInput_MEA = new System.Windows.Forms.GroupBox();
            this.textBoxStartStep_MEA = new System.Windows.Forms.TextBox();
            this.textBoxEndStep_MEA = new System.Windows.Forms.TextBox();
            this.textBoxStartInput_MEA = new System.Windows.Forms.TextBox();
            this.textBoxEndInput_MEA = new System.Windows.Forms.TextBox();
            this.groupBoxCondition_MEA.SuspendLayout();
            this.groupBoxResultOutput_MEA.SuspendLayout();
            this.groupBoxDataInput_MEA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_MEA
            // 
            this.groupBoxCondition_MEA.Controls.Add(this.textBoxCondition_MEA);
            this.groupBoxCondition_MEA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_MEA.Name = "groupBoxCondition_MEA";
            this.groupBoxCondition_MEA.Size = new System.Drawing.Size(566, 335);
            this.groupBoxCondition_MEA.TabIndex = 0;
            this.groupBoxCondition_MEA.TabStop = false;
            this.groupBoxCondition_MEA.Text = "Условие";
            // 
            // textBoxCondition_MEA
            // 
            this.textBoxCondition_MEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_MEA.Location = new System.Drawing.Point(6, 21);
            this.textBoxCondition_MEA.Multiline = true;
            this.textBoxCondition_MEA.Name = "textBoxCondition_MEA";
            this.textBoxCondition_MEA.ReadOnly = true;
            this.textBoxCondition_MEA.Size = new System.Drawing.Size(355, 42);
            this.textBoxCondition_MEA.TabIndex = 0;
            this.textBoxCondition_MEA.Text = "Протабулировать функцию на заданном диапозоне. Результат вывести в виде таблицы.";
            // 
            // groupBoxResultOutput_MEA
            // 
            this.groupBoxResultOutput_MEA.Controls.Add(this.textBoxResultScroll_MEA);
            this.groupBoxResultOutput_MEA.Controls.Add(this.textBoxResultMark_MEA);
            this.groupBoxResultOutput_MEA.Location = new System.Drawing.Point(584, 12);
            this.groupBoxResultOutput_MEA.Name = "groupBoxResultOutput_MEA";
            this.groupBoxResultOutput_MEA.Size = new System.Drawing.Size(344, 426);
            this.groupBoxResultOutput_MEA.TabIndex = 1;
            this.groupBoxResultOutput_MEA.TabStop = false;
            this.groupBoxResultOutput_MEA.Text = "Вывод данных";
            // 
            // textBoxResultMark_MEA
            // 
            this.textBoxResultMark_MEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResultMark_MEA.Location = new System.Drawing.Point(6, 21);
            this.textBoxResultMark_MEA.Name = "textBoxResultMark_MEA";
            this.textBoxResultMark_MEA.ReadOnly = true;
            this.textBoxResultMark_MEA.Size = new System.Drawing.Size(100, 15);
            this.textBoxResultMark_MEA.TabIndex = 0;
            this.textBoxResultMark_MEA.Text = "Результат:";
            // 
            // textBoxResultScroll_MEA
            // 
            this.textBoxResultScroll_MEA.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResultScroll_MEA.Location = new System.Drawing.Point(6, 42);
            this.textBoxResultScroll_MEA.Multiline = true;
            this.textBoxResultScroll_MEA.Name = "textBoxResultScroll_MEA";
            this.textBoxResultScroll_MEA.ReadOnly = true;
            this.textBoxResultScroll_MEA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultScroll_MEA.Size = new System.Drawing.Size(332, 378);
            this.textBoxResultScroll_MEA.TabIndex = 1;
            // 
            // buttonToDo_MEA
            // 
            this.buttonToDo_MEA.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonToDo_MEA.Location = new System.Drawing.Point(443, 353);
            this.buttonToDo_MEA.Name = "buttonToDo_MEA";
            this.buttonToDo_MEA.Size = new System.Drawing.Size(135, 85);
            this.buttonToDo_MEA.TabIndex = 2;
            this.buttonToDo_MEA.Text = "Выполнить";
            this.buttonToDo_MEA.UseVisualStyleBackColor = false;
            this.buttonToDo_MEA.Click += new System.EventHandler(this.buttonToDo_MEA_Click);
            // 
            // buttonHelp_MEA
            // 
            this.buttonHelp_MEA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_MEA.Location = new System.Drawing.Point(334, 353);
            this.buttonHelp_MEA.Name = "buttonHelp_MEA";
            this.buttonHelp_MEA.Size = new System.Drawing.Size(96, 85);
            this.buttonHelp_MEA.TabIndex = 3;
            this.buttonHelp_MEA.Text = "Справка";
            this.buttonHelp_MEA.UseVisualStyleBackColor = false;
            this.buttonHelp_MEA.Click += new System.EventHandler(this.buttonHelp_MEA_Click);
            // 
            // groupBoxDataInput_MEA
            // 
            this.groupBoxDataInput_MEA.Controls.Add(this.textBoxEndInput_MEA);
            this.groupBoxDataInput_MEA.Controls.Add(this.textBoxStartInput_MEA);
            this.groupBoxDataInput_MEA.Controls.Add(this.textBoxEndStep_MEA);
            this.groupBoxDataInput_MEA.Controls.Add(this.textBoxStartStep_MEA);
            this.groupBoxDataInput_MEA.Location = new System.Drawing.Point(12, 354);
            this.groupBoxDataInput_MEA.Name = "groupBoxDataInput_MEA";
            this.groupBoxDataInput_MEA.Size = new System.Drawing.Size(316, 84);
            this.groupBoxDataInput_MEA.TabIndex = 4;
            this.groupBoxDataInput_MEA.TabStop = false;
            this.groupBoxDataInput_MEA.Text = "Ввод данных";
            // 
            // textBoxStartStep_MEA
            // 
            this.textBoxStartStep_MEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStartStep_MEA.Location = new System.Drawing.Point(7, 22);
            this.textBoxStartStep_MEA.Name = "textBoxStartStep_MEA";
            this.textBoxStartStep_MEA.ReadOnly = true;
            this.textBoxStartStep_MEA.Size = new System.Drawing.Size(100, 15);
            this.textBoxStartStep_MEA.TabIndex = 0;
            this.textBoxStartStep_MEA.Text = "Старт шага:";
            // 
            // textBoxEndStep_MEA
            // 
            this.textBoxEndStep_MEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEndStep_MEA.Location = new System.Drawing.Point(162, 21);
            this.textBoxEndStep_MEA.Name = "textBoxEndStep_MEA";
            this.textBoxEndStep_MEA.ReadOnly = true;
            this.textBoxEndStep_MEA.Size = new System.Drawing.Size(100, 15);
            this.textBoxEndStep_MEA.TabIndex = 1;
            this.textBoxEndStep_MEA.Text = "Конец шага:";
            // 
            // textBoxStartInput_MEA
            // 
            this.textBoxStartInput_MEA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStartInput_MEA.Location = new System.Drawing.Point(7, 43);
            this.textBoxStartInput_MEA.Name = "textBoxStartInput_MEA";
            this.textBoxStartInput_MEA.Size = new System.Drawing.Size(145, 22);
            this.textBoxStartInput_MEA.TabIndex = 2;
            // 
            // textBoxEndInput_MEA
            // 
            this.textBoxEndInput_MEA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEndInput_MEA.Location = new System.Drawing.Point(162, 42);
            this.textBoxEndInput_MEA.Name = "textBoxEndInput_MEA";
            this.textBoxEndInput_MEA.Size = new System.Drawing.Size(145, 22);
            this.textBoxEndInput_MEA.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.groupBoxDataInput_MEA);
            this.Controls.Add(this.buttonHelp_MEA);
            this.Controls.Add(this.buttonToDo_MEA);
            this.Controls.Add(this.groupBoxResultOutput_MEA);
            this.Controls.Add(this.groupBoxCondition_MEA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 2 | Меньшиков Е. А.";
            this.groupBoxCondition_MEA.ResumeLayout(false);
            this.groupBoxCondition_MEA.PerformLayout();
            this.groupBoxResultOutput_MEA.ResumeLayout(false);
            this.groupBoxResultOutput_MEA.PerformLayout();
            this.groupBoxDataInput_MEA.ResumeLayout(false);
            this.groupBoxDataInput_MEA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_MEA;
        private System.Windows.Forms.TextBox textBoxCondition_MEA;
        private System.Windows.Forms.GroupBox groupBoxResultOutput_MEA;
        private System.Windows.Forms.TextBox textBoxResultScroll_MEA;
        private System.Windows.Forms.TextBox textBoxResultMark_MEA;
        private System.Windows.Forms.Button buttonToDo_MEA;
        private System.Windows.Forms.Button buttonHelp_MEA;
        private System.Windows.Forms.GroupBox groupBoxDataInput_MEA;
        private System.Windows.Forms.TextBox textBoxEndInput_MEA;
        private System.Windows.Forms.TextBox textBoxStartInput_MEA;
        private System.Windows.Forms.TextBox textBoxEndStep_MEA;
        private System.Windows.Forms.TextBox textBoxStartStep_MEA;
    }
}


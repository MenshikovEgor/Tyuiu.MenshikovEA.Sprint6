
namespace Tyuiu.MenshikovEA.Sprint6.Task0.V30
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_MEA = new System.Windows.Forms.GroupBox();
            this.pictureConditionFormula_MEA = new System.Windows.Forms.PictureBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.groupBoxInput_MEA = new System.Windows.Forms.GroupBox();
            this.textBoxVarA_MEA = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_MEA = new System.Windows.Forms.GroupBox();
            this.textBoxOutputRes_MEA = new System.Windows.Forms.TextBox();
            this.textBoxResult_MEA = new System.Windows.Forms.TextBox();
            this.textBoxVarAInput_MEA = new System.Windows.Forms.TextBox();
            this.buttonDone_MEA = new System.Windows.Forms.Button();
            this.buttonHelp_MEA = new System.Windows.Forms.Button();
            this.groupBoxTask_MEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureConditionFormula_MEA)).BeginInit();
            this.groupBoxInput_MEA.SuspendLayout();
            this.groupBoxOutput_MEA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_MEA
            // 
            this.groupBoxTask_MEA.Controls.Add(this.pictureConditionFormula_MEA);
            this.groupBoxTask_MEA.Controls.Add(this.textBoxTask);
            this.groupBoxTask_MEA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_MEA.Name = "groupBoxTask_MEA";
            this.groupBoxTask_MEA.Size = new System.Drawing.Size(832, 255);
            this.groupBoxTask_MEA.TabIndex = 0;
            this.groupBoxTask_MEA.TabStop = false;
            this.groupBoxTask_MEA.Text = "Условие";
            // 
            // pictureConditionFormula_MEA
            // 
            this.pictureConditionFormula_MEA.Image = ((System.Drawing.Image)(resources.GetObject("pictureConditionFormula_MEA.Image")));
            this.pictureConditionFormula_MEA.Location = new System.Drawing.Point(626, 21);
            this.pictureConditionFormula_MEA.Name = "pictureConditionFormula_MEA";
            this.pictureConditionFormula_MEA.Size = new System.Drawing.Size(200, 45);
            this.pictureConditionFormula_MEA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureConditionFormula_MEA.TabIndex = 1;
            this.pictureConditionFormula_MEA.TabStop = false;
            // 
            // textBoxTask
            // 
            this.textBoxTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask.Location = new System.Drawing.Point(6, 21);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(614, 228);
            this.textBoxTask.TabIndex = 0;
            this.textBoxTask.Text = "Вычислить выражение по формуле";
            this.textBoxTask.Visible = false;
            // 
            // groupBoxInput_MEA
            // 
            this.groupBoxInput_MEA.Controls.Add(this.textBoxVarAInput_MEA);
            this.groupBoxInput_MEA.Controls.Add(this.textBoxVarA_MEA);
            this.groupBoxInput_MEA.Location = new System.Drawing.Point(12, 278);
            this.groupBoxInput_MEA.Name = "groupBoxInput_MEA";
            this.groupBoxInput_MEA.Size = new System.Drawing.Size(564, 138);
            this.groupBoxInput_MEA.TabIndex = 1;
            this.groupBoxInput_MEA.TabStop = false;
            this.groupBoxInput_MEA.Text = "Ввод данных";
            // 
            // textBoxVarA_MEA
            // 
            this.textBoxVarA_MEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVarA_MEA.Location = new System.Drawing.Point(202, 55);
            this.textBoxVarA_MEA.Name = "textBoxVarA_MEA";
            this.textBoxVarA_MEA.ReadOnly = true;
            this.textBoxVarA_MEA.Size = new System.Drawing.Size(136, 15);
            this.textBoxVarA_MEA.TabIndex = 0;
            this.textBoxVarA_MEA.Text = "Переменная А:";
            this.textBoxVarA_MEA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxOutput_MEA
            // 
            this.groupBoxOutput_MEA.Controls.Add(this.textBoxOutputRes_MEA);
            this.groupBoxOutput_MEA.Controls.Add(this.textBoxResult_MEA);
            this.groupBoxOutput_MEA.Location = new System.Drawing.Point(582, 278);
            this.groupBoxOutput_MEA.Name = "groupBoxOutput_MEA";
            this.groupBoxOutput_MEA.Size = new System.Drawing.Size(262, 138);
            this.groupBoxOutput_MEA.TabIndex = 2;
            this.groupBoxOutput_MEA.TabStop = false;
            this.groupBoxOutput_MEA.Text = "Вывод данных";
            // 
            // textBoxOutputRes_MEA
            // 
            this.textBoxOutputRes_MEA.Location = new System.Drawing.Point(6, 83);
            this.textBoxOutputRes_MEA.Name = "textBoxOutputRes_MEA";
            this.textBoxOutputRes_MEA.ReadOnly = true;
            this.textBoxOutputRes_MEA.Size = new System.Drawing.Size(250, 22);
            this.textBoxOutputRes_MEA.TabIndex = 1;
            // 
            // textBoxResult_MEA
            // 
            this.textBoxResult_MEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult_MEA.Location = new System.Drawing.Point(6, 55);
            this.textBoxResult_MEA.Name = "textBoxResult_MEA";
            this.textBoxResult_MEA.ReadOnly = true;
            this.textBoxResult_MEA.Size = new System.Drawing.Size(140, 15);
            this.textBoxResult_MEA.TabIndex = 0;
            this.textBoxResult_MEA.Text = "Результат:";
            // 
            // textBoxVarAInput_MEA
            // 
            this.textBoxVarAInput_MEA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVarAInput_MEA.Location = new System.Drawing.Point(202, 83);
            this.textBoxVarAInput_MEA.Name = "textBoxVarAInput_MEA";
            this.textBoxVarAInput_MEA.Size = new System.Drawing.Size(136, 22);
            this.textBoxVarAInput_MEA.TabIndex = 1;
            // 
            // buttonDone_MEA
            // 
            this.buttonDone_MEA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDone_MEA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDone_MEA.Location = new System.Drawing.Point(701, 422);
            this.buttonDone_MEA.Name = "buttonDone_MEA";
            this.buttonDone_MEA.Size = new System.Drawing.Size(143, 30);
            this.buttonDone_MEA.TabIndex = 3;
            this.buttonDone_MEA.Text = "Выполнить";
            this.buttonDone_MEA.UseVisualStyleBackColor = false;
            this.buttonDone_MEA.Click += new System.EventHandler(this.ButtonDone_Click);
            // 
            // buttonHelp_MEA
            // 
            this.buttonHelp_MEA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonHelp_MEA.Location = new System.Drawing.Point(665, 422);
            this.buttonHelp_MEA.Name = "buttonHelp_MEA";
            this.buttonHelp_MEA.Size = new System.Drawing.Size(30, 30);
            this.buttonHelp_MEA.TabIndex = 4;
            this.buttonHelp_MEA.Text = "?";
            this.buttonHelp_MEA.UseVisualStyleBackColor = true;
            this.buttonHelp_MEA.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(856, 464);
            this.Controls.Add(this.buttonHelp_MEA);
            this.Controls.Add(this.buttonDone_MEA);
            this.Controls.Add(this.groupBoxOutput_MEA);
            this.Controls.Add(this.groupBoxInput_MEA);
            this.Controls.Add(this.groupBoxTask_MEA);
            this.Name = "FormMain";
            this.groupBoxTask_MEA.ResumeLayout(false);
            this.groupBoxTask_MEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureConditionFormula_MEA)).EndInit();
            this.groupBoxInput_MEA.ResumeLayout(false);
            this.groupBoxInput_MEA.PerformLayout();
            this.groupBoxOutput_MEA.ResumeLayout(false);
            this.groupBoxOutput_MEA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_MEA;
        private System.Windows.Forms.PictureBox pictureConditionFormula_MEA;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.GroupBox groupBoxInput_MEA;
        private System.Windows.Forms.TextBox textBoxVarA_MEA;
        private System.Windows.Forms.GroupBox groupBoxOutput_MEA;
        private System.Windows.Forms.TextBox textBoxResult_MEA;
        private System.Windows.Forms.TextBox textBoxOutputRes_MEA;
        private System.Windows.Forms.TextBox textBoxVarAInput_MEA;
        private System.Windows.Forms.Button buttonDone_MEA;
        private System.Windows.Forms.Button buttonHelp_MEA;
    }
}


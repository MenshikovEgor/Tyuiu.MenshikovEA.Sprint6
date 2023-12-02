
namespace Tyuiu.MenshikovEA.Sprint6.Task3.V13
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
            this.dataGridViewMatrix_MEA = new System.Windows.Forms.DataGridView();
            this.groupBoxResult_MEA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_MEA = new System.Windows.Forms.TextBox();
            this.buttonHelp_MEA = new System.Windows.Forms.Button();
            this.buttonToDo_MEA = new System.Windows.Forms.Button();
            this.groupBoxCondition_MEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_MEA)).BeginInit();
            this.groupBoxResult_MEA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_MEA
            // 
            this.groupBoxCondition_MEA.Controls.Add(this.textBoxCondition_MEA);
            this.groupBoxCondition_MEA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_MEA.Name = "groupBoxCondition_MEA";
            this.groupBoxCondition_MEA.Size = new System.Drawing.Size(274, 338);
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
            this.textBoxCondition_MEA.Size = new System.Drawing.Size(273, 187);
            this.textBoxCondition_MEA.TabIndex = 0;
            this.textBoxCondition_MEA.Text = "Дана матрица 5 на 5\r\n -7   34  -2  25  5\r\n-16 -12  30 -3 17\r\n  3  -15  12  5  -5\r" +
    "\n 17   22 -3  32 -11\r\n  9    28  1  -9  -2\r\nВыполнить сортировку по возрастанию " +
    "\r\nво втором столбце  ";
            // 
            // dataGridViewMatrix_MEA
            // 
            this.dataGridViewMatrix_MEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_MEA.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_MEA.Location = new System.Drawing.Point(27, 52);
            this.dataGridViewMatrix_MEA.Name = "dataGridViewMatrix_MEA";
            this.dataGridViewMatrix_MEA.ReadOnly = true;
            this.dataGridViewMatrix_MEA.RowHeadersVisible = false;
            this.dataGridViewMatrix_MEA.RowHeadersWidth = 51;
            this.dataGridViewMatrix_MEA.RowTemplate.Height = 24;
            this.dataGridViewMatrix_MEA.Size = new System.Drawing.Size(388, 357);
            this.dataGridViewMatrix_MEA.TabIndex = 1;
            // 
            // groupBoxResult_MEA
            // 
            this.groupBoxResult_MEA.Controls.Add(this.textBoxResult_MEA);
            this.groupBoxResult_MEA.Controls.Add(this.dataGridViewMatrix_MEA);
            this.groupBoxResult_MEA.Location = new System.Drawing.Point(300, 13);
            this.groupBoxResult_MEA.Name = "groupBoxResult_MEA";
            this.groupBoxResult_MEA.Size = new System.Drawing.Size(440, 425);
            this.groupBoxResult_MEA.TabIndex = 2;
            this.groupBoxResult_MEA.TabStop = false;
            this.groupBoxResult_MEA.Text = "Вывод данных";
            // 
            // textBoxResult_MEA
            // 
            this.textBoxResult_MEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult_MEA.Location = new System.Drawing.Point(27, 22);
            this.textBoxResult_MEA.Name = "textBoxResult_MEA";
            this.textBoxResult_MEA.ReadOnly = true;
            this.textBoxResult_MEA.Size = new System.Drawing.Size(133, 15);
            this.textBoxResult_MEA.TabIndex = 2;
            this.textBoxResult_MEA.Text = "Результат:";
            // 
            // buttonHelp_MEA
            // 
            this.buttonHelp_MEA.Location = new System.Drawing.Point(13, 358);
            this.buttonHelp_MEA.Name = "buttonHelp_MEA";
            this.buttonHelp_MEA.Size = new System.Drawing.Size(109, 80);
            this.buttonHelp_MEA.TabIndex = 3;
            this.buttonHelp_MEA.Text = "Справка";
            this.buttonHelp_MEA.UseVisualStyleBackColor = true;
            this.buttonHelp_MEA.Click += new System.EventHandler(this.buttonHelp_MEA_Click);
            // 
            // buttonToDo_MEA
            // 
            this.buttonToDo_MEA.Location = new System.Drawing.Point(128, 358);
            this.buttonToDo_MEA.Name = "buttonToDo_MEA";
            this.buttonToDo_MEA.Size = new System.Drawing.Size(159, 80);
            this.buttonToDo_MEA.TabIndex = 4;
            this.buttonToDo_MEA.Text = "Выполнить";
            this.buttonToDo_MEA.UseVisualStyleBackColor = true;
            this.buttonToDo_MEA.Click += new System.EventHandler(this.buttonToDo_MEA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.buttonToDo_MEA);
            this.Controls.Add(this.buttonHelp_MEA);
            this.Controls.Add(this.groupBoxResult_MEA);
            this.Controls.Add(this.groupBoxCondition_MEA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 13 | Меньшиков Е. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_MEA.ResumeLayout(false);
            this.groupBoxCondition_MEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_MEA)).EndInit();
            this.groupBoxResult_MEA.ResumeLayout(false);
            this.groupBoxResult_MEA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_MEA;
        private System.Windows.Forms.TextBox textBoxCondition_MEA;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_MEA;
        private System.Windows.Forms.GroupBox groupBoxResult_MEA;
        private System.Windows.Forms.TextBox textBoxResult_MEA;
        private System.Windows.Forms.Button buttonHelp_MEA;
        private System.Windows.Forms.Button buttonToDo_MEA;
    }
}


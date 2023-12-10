
namespace Tyuiu.MenshikovEA.Sprint6.Task7.V14
{
    partial class FormAbout_MEA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_MEA));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxInfo_MEA = new System.Windows.Forms.TextBox();
            this.buttonOk_MEA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxInfo_MEA
            // 
            this.textBoxInfo_MEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_MEA.Location = new System.Drawing.Point(160, 13);
            this.textBoxInfo_MEA.Multiline = true;
            this.textBoxInfo_MEA.Name = "textBoxInfo_MEA";
            this.textBoxInfo_MEA.ReadOnly = true;
            this.textBoxInfo_MEA.Size = new System.Drawing.Size(483, 174);
            this.textBoxInfo_MEA.TabIndex = 1;
            this.textBoxInfo_MEA.Text = resources.GetString("textBoxInfo_MEA.Text");
            // 
            // buttonOk_MEA
            // 
            this.buttonOk_MEA.Location = new System.Drawing.Point(520, 194);
            this.buttonOk_MEA.Name = "buttonOk_MEA";
            this.buttonOk_MEA.Size = new System.Drawing.Size(120, 33);
            this.buttonOk_MEA.TabIndex = 2;
            this.buttonOk_MEA.Text = "OK";
            this.buttonOk_MEA.UseVisualStyleBackColor = true;
            this.buttonOk_MEA.Click += new System.EventHandler(this.buttonOk_MEA_Click);
            // 
            // FormAbout_MEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 239);
            this.Controls.Add(this.buttonOk_MEA);
            this.Controls.Add(this.textBoxInfo_MEA);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormAbout_MEA";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxInfo_MEA;
        private System.Windows.Forms.Button buttonOk_MEA;
    }
}
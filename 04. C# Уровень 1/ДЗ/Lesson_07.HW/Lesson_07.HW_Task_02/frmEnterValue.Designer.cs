namespace Lesson_07.HW_Task_02
{
    partial class frmEnterValue
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
            this.btnEnterNumber = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEnterNumber
            // 
            this.btnEnterNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEnterNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnterNumber.Location = new System.Drawing.Point(12, 44);
            this.btnEnterNumber.Name = "btnEnterNumber";
            this.btnEnterNumber.Size = new System.Drawing.Size(140, 30);
            this.btnEnterNumber.TabIndex = 4;
            this.btnEnterNumber.Text = "Ввести число";
            this.btnEnterNumber.UseVisualStyleBackColor = true;
            this.btnEnterNumber.Click += new System.EventHandler(this.btnEnterNumber_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNumber.Location = new System.Drawing.Point(12, 12);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(140, 26);
            this.txtNumber.TabIndex = 5;
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmEnterValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 86);
            this.ControlBox = false;
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnEnterNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEnterValue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ответ?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterNumber;
        private System.Windows.Forms.TextBox txtNumber;
    }
}
namespace Lesson_08.HW_Task_02
{
    partial class frmTask02
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
            this.nudUpDown = new System.Windows.Forms.NumericUpDown();
            this.tbxText = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nudUpDown
            // 
            this.nudUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudUpDown.Location = new System.Drawing.Point(256, 12);
            this.nudUpDown.Name = "nudUpDown";
            this.nudUpDown.Size = new System.Drawing.Size(70, 31);
            this.nudUpDown.TabIndex = 0;
            this.nudUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudUpDown.ValueChanged += new System.EventHandler(this.nudUpDown_ValueChanged);
            // 
            // tbxText
            // 
            this.tbxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxText.Location = new System.Drawing.Point(185, 12);
            this.tbxText.Name = "tbxText";
            this.tbxText.Size = new System.Drawing.Size(65, 31);
            this.tbxText.TabIndex = 1;
            this.tbxText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxText.TextChanged += new System.EventHandler(this.tbxText_TextChanged);
            this.tbxText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxText_KeyPress);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblText.Location = new System.Drawing.Point(6, 15);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(173, 25);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Жми вверх/вниз";
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.ForeColor = System.Drawing.Color.Maroon;
            this.lblInfo.Location = new System.Drawing.Point(6, 51);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(320, 47);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Максимальное значение 999, при превышении скидывается на ноль";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTask02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 103);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.tbxText);
            this.Controls.Add(this.nudUpDown);
            this.Name = "frmTask02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание №2";
            ((System.ComponentModel.ISupportInitialize)(this.nudUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudUpDown;
        private System.Windows.Forms.TextBox tbxText;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblInfo;
    }
}
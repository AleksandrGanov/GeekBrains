namespace Lesson_08.Exp_05
{
    partial class frmInfo
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
            this.btnOK = new System.Windows.Forms.Button();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblAuthorText = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblVersionText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.Location = new System.Drawing.Point(79, 73);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(73, 28);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAuthor.Location = new System.Drawing.Point(13, 13);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(57, 16);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Автор:";
            // 
            // lblAuthorText
            // 
            this.lblAuthorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAuthorText.Location = new System.Drawing.Point(76, 13);
            this.lblAuthorText.Name = "lblAuthorText";
            this.lblAuthorText.Size = new System.Drawing.Size(146, 16);
            this.lblAuthorText.TabIndex = 2;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVersion.Location = new System.Drawing.Point(13, 40);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(65, 16);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Версия:";
            // 
            // lblVersionText
            // 
            this.lblVersionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVersionText.Location = new System.Drawing.Point(76, 40);
            this.lblVersionText.Name = "lblVersionText";
            this.lblVersionText.Size = new System.Drawing.Size(146, 16);
            this.lblVersionText.TabIndex = 2;
            // 
            // frmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 109);
            this.ControlBox = false;
            this.Controls.Add(this.lblVersionText);
            this.Controls.Add(this.lblAuthorText);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmInfo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О програме";
            this.Shown += new System.EventHandler(this.frmInfo_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblAuthorText;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblVersionText;
    }
}
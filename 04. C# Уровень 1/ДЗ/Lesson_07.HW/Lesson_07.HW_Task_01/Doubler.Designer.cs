namespace Lesson_07.HW_Task_01
{
    partial class Doubler
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPlus1 = new System.Windows.Forms.Button();
            this.btnX2 = new System.Windows.Forms.Button();
            this.lblCalculationValue = new System.Windows.Forms.Label();
            this.lblClickNumValue = new System.Windows.Forms.Label();
            this.lblClickNumText = new System.Windows.Forms.Label();
            this.lblCalculationText = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.менюFormMain = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGame = new System.Windows.Forms.ToolStripMenuItem();
            this.labStackText = new System.Windows.Forms.Label();
            this.lblStackValue = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(167, 35);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(71, 44);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPlus1
            // 
            this.btnPlus1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus1.Location = new System.Drawing.Point(13, 35);
            this.btnPlus1.Name = "btnPlus1";
            this.btnPlus1.Size = new System.Drawing.Size(71, 44);
            this.btnPlus1.TabIndex = 0;
            this.btnPlus1.Text = "х1";
            this.btnPlus1.UseVisualStyleBackColor = true;
            this.btnPlus1.Click += new System.EventHandler(this.btnPlus1_Click);
            // 
            // btnX2
            // 
            this.btnX2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnX2.Location = new System.Drawing.Point(90, 35);
            this.btnX2.Name = "btnX2";
            this.btnX2.Size = new System.Drawing.Size(71, 44);
            this.btnX2.TabIndex = 0;
            this.btnX2.Text = "х2";
            this.btnX2.UseVisualStyleBackColor = true;
            this.btnX2.Click += new System.EventHandler(this.btnX2_Click);
            // 
            // lblCalculationValue
            // 
            this.lblCalculationValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCalculationValue.Location = new System.Drawing.Point(157, 91);
            this.lblCalculationValue.Name = "lblCalculationValue";
            this.lblCalculationValue.Size = new System.Drawing.Size(84, 24);
            this.lblCalculationValue.TabIndex = 1;
            this.lblCalculationValue.Text = "0";
            this.lblCalculationValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCalculationValue.TextChanged += new System.EventHandler(this.lblCalculationValue_TextChanged);
            // 
            // lblClickNumValue
            // 
            this.lblClickNumValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblClickNumValue.ForeColor = System.Drawing.Color.Maroon;
            this.lblClickNumValue.Location = new System.Drawing.Point(157, 115);
            this.lblClickNumValue.Name = "lblClickNumValue";
            this.lblClickNumValue.Size = new System.Drawing.Size(64, 24);
            this.lblClickNumValue.TabIndex = 1;
            this.lblClickNumValue.Text = "0";
            this.lblClickNumValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClickNumText
            // 
            this.lblClickNumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblClickNumText.ForeColor = System.Drawing.Color.Maroon;
            this.lblClickNumText.Location = new System.Drawing.Point(13, 115);
            this.lblClickNumText.Name = "lblClickNumText";
            this.lblClickNumText.Size = new System.Drawing.Size(139, 24);
            this.lblClickNumText.TabIndex = 1;
            this.lblClickNumText.Text = "Кол-во кликов:";
            this.lblClickNumText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCalculationText
            // 
            this.lblCalculationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCalculationText.Location = new System.Drawing.Point(13, 91);
            this.lblCalculationText.Name = "lblCalculationText";
            this.lblCalculationText.Size = new System.Drawing.Size(139, 24);
            this.lblCalculationText.TabIndex = 1;
            this.lblCalculationText.Text = "Расчет данных";
            this.lblCalculationText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюFormMain});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(253, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "Меню";
            // 
            // менюFormMain
            // 
            this.менюFormMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemGame});
            this.менюFormMain.Name = "менюFormMain";
            this.менюFormMain.Size = new System.Drawing.Size(53, 20);
            this.менюFormMain.Text = "Меню";
            // 
            // menuItemGame
            // 
            this.menuItemGame.Name = "menuItemGame";
            this.menuItemGame.Size = new System.Drawing.Size(112, 22);
            this.menuItemGame.Text = "Играть";
            this.menuItemGame.Click += new System.EventHandler(this.menuItemGame_Click);
            // 
            // labStackText
            // 
            this.labStackText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labStackText.ForeColor = System.Drawing.Color.Black;
            this.labStackText.Location = new System.Drawing.Point(13, 142);
            this.labStackText.Name = "labStackText";
            this.labStackText.Size = new System.Drawing.Size(139, 24);
            this.labStackText.TabIndex = 1;
            this.labStackText.Text = "Stack current value:";
            this.labStackText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStackValue
            // 
            this.lblStackValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStackValue.ForeColor = System.Drawing.Color.Black;
            this.lblStackValue.Location = new System.Drawing.Point(144, 142);
            this.lblStackValue.Name = "lblStackValue";
            this.lblStackValue.Size = new System.Drawing.Size(46, 24);
            this.lblStackValue.TabIndex = 1;
            this.lblStackValue.Text = "0";
            this.lblStackValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUndo
            // 
            this.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUndo.Location = new System.Drawing.Point(190, 142);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(51, 24);
            this.btnUndo.TabIndex = 0;
            this.btnUndo.TabStop = false;
            this.btnUndo.Text = "undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // Doubler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 175);
            this.Controls.Add(this.lblClickNumValue);
            this.Controls.Add(this.lblCalculationText);
            this.Controls.Add(this.lblStackValue);
            this.Controls.Add(this.labStackText);
            this.Controls.Add(this.lblClickNumText);
            this.Controls.Add(this.lblCalculationValue);
            this.Controls.Add(this.btnX2);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnPlus1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.menuStrip);
            this.Name = "Doubler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удвоитель";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPlus1;
        private System.Windows.Forms.Button btnX2;
        private System.Windows.Forms.Label lblCalculationValue;
        private System.Windows.Forms.Label lblClickNumValue;
        private System.Windows.Forms.Label lblClickNumText;
        private System.Windows.Forms.Label lblCalculationText;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem менюFormMain;
        private System.Windows.Forms.ToolStripMenuItem menuItemGame;
        private System.Windows.Forms.Label labStackText;
        private System.Windows.Forms.Label lblStackValue;
        private System.Windows.Forms.Button btnUndo;
    }
}
namespace Lesson_08.Exp_05
{
    partial class BelieveOrNotBelieve
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
            this.tbxQuestion = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.cbxTrue = new System.Windows.Forms.CheckBox();
            this.mstMenu = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.mstMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxQuestion
            // 
            this.tbxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxQuestion.Location = new System.Drawing.Point(14, 27);
            this.tbxQuestion.Multiline = true;
            this.tbxQuestion.Name = "tbxQuestion";
            this.tbxQuestion.Size = new System.Drawing.Size(422, 205);
            this.tbxQuestion.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(14, 240);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(112, 240);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 28);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(210, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 28);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudNumber
            // 
            this.nudNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudNumber.Location = new System.Drawing.Point(314, 246);
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(42, 20);
            this.nudNumber.TabIndex = 3;
            this.nudNumber.ValueChanged += new System.EventHandler(this.nudNumber_ValueChanged);
            // 
            // cbxTrue
            // 
            this.cbxTrue.AutoSize = true;
            this.cbxTrue.Location = new System.Drawing.Point(362, 249);
            this.cbxTrue.Name = "cbxTrue";
            this.cbxTrue.Size = new System.Drawing.Size(64, 17);
            this.cbxTrue.TabIndex = 4;
            this.cbxTrue.Text = "Правда";
            this.cbxTrue.UseVisualStyleBackColor = true;
            // 
            // mstMenu
            // 
            this.mstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile});
            this.mstMenu.Location = new System.Drawing.Point(0, 0);
            this.mstMenu.Name = "mstMenu";
            this.mstMenu.Size = new System.Drawing.Size(448, 24);
            this.mstMenu.TabIndex = 5;
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.miOpen,
            this.miSave,
            this.toolStripSeparator1,
            this.miExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(48, 20);
            this.miFile.Text = "Файл";
            // 
            // miNew
            // 
            this.miNew.Name = "miNew";
            this.miNew.Size = new System.Drawing.Size(132, 22);
            this.miNew.Text = "Новый";
            this.miNew.Click += new System.EventHandler(this.miNew_Click);
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(132, 22);
            this.miOpen.Text = "Открыть";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.Size = new System.Drawing.Size(132, 22);
            this.miSave.Text = "Сохранить";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(132, 22);
            this.miExit.Text = "Выход";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // BelieveOrNotBelieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 280);
            this.Controls.Add(this.cbxTrue);
            this.Controls.Add(this.nudNumber);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxQuestion);
            this.Controls.Add(this.mstMenu);
            this.MainMenuStrip = this.mstMenu;
            this.Name = "BelieveOrNotBelieve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Верю - Не верю";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.mstMenu.ResumeLayout(false);
            this.mstMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxQuestion;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.CheckBox cbxTrue;
        private System.Windows.Forms.MenuStrip mstMenu;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miNew;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miExit;
    }
}
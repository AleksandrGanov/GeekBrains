using System;
using System.Windows.Forms;

namespace Lesson_08.Exp_05
{
    public partial class BelieveOrNotBelieve : Form
    {
        TrueFalse database;

        public BelieveOrNotBelieve()
        {
            InitializeComponent();
        }

        private void miNew_Click(System.Object sender, System.EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Add("Начальные данные", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            };
        }
        private void miOpen_Click(System.Object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
            }
            ofd.Dispose();
        }
        private void miSave_Click(System.Object sender, System.EventArgs e)
        {
            if (database != null)
            {
                btnSave.PerformClick();
                //btnSave_Click(this, e);
                database.Save();
            }
            else MessageBox.Show("База данных не создана");
        }
        private void miSaveAs_Click(Object sender, EventArgs e)
        {
            if (database != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                string fileName;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    fileName = sfd.FileName;
                    btnSave.PerformClick();
                    database.SaveAs(fileName);
                }
                sfd.Dispose();
            }
            else MessageBox.Show("База данных не создана");
        }
        private void miExit_Click(System.Object sender, System.EventArgs e)
        {
            Close();
        }
        private void miInfo_Click(System.Object sender, System.EventArgs e)
        {
            new frmInfo().Show();
        }

        private void nudNumber_ValueChanged(System.Object sender, System.EventArgs e)
        {
            if (database != null)
            {
                tbxQuestion.Text = database[(int)nudNumber.Value - 1].Text;
                cbxTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;
            }
        }

        private void btnAdd_Click(System.Object sender, System.EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add((database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }
        private void btnDelete_Click(System.Object sender, System.EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null) return;
            database.Remove((int)nudNumber.Value);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
        }
        private void btnSave_Click(System.Object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxQuestion.Text))
            {
                database[(int)nudNumber.Value - 1].Text = tbxQuestion.Text;
                database[(int)nudNumber.Value - 1].TrueFalse = cbxTrue.Checked; ;
            }
        }
    }
}
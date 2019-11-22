using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lesson_07.HW_Task_01
{
    public partial class Doubler : Form
    {
        int clickNum = 0;
        Random rnd = new Random();
        Stack<int> stack = new Stack<int>();


        public Doubler()
        {
            InitializeComponent();
            btnPlus1.Text = "+1";
            btnX2.Text = "x2";
            btnReset.Text = "Сброс";
            lblCalculationValue.Text = "0";
            lblClickNumText.Text = "Кол-во кликов";
            lblClickNumValue.Text = "0";
            lblStackValue.Text = "0";
            Text = "Удвоитель";
            stack.Push(int.Parse(lblCalculationValue.Text));
        }

        private void btnPlus1_Click(object sender, EventArgs e)
        {
            lblCalculationValue.Text = (int.Parse(lblCalculationValue.Text) + 1).ToString();
            lblClickNumValue.Text = ClickNum().ToString();
        }

        private void btnReset_Click(Object sender, EventArgs e)
        {
            lblCalculationValue.Text = "1";
            lblClickNumValue.Text = ClickNum().ToString();
            stack.Push(1);
            lblStackValue.Text = stack.Peek().ToString();
        }

        private void btnX2_Click(Object sender, EventArgs e)
        {
            lblCalculationValue.Text = (int.Parse(lblCalculationValue.Text) * 2).ToString();
            lblClickNumValue.Text = ClickNum().ToString();
        }

        private void btnUndo_Click(Object sender, EventArgs e)
        {
            try
            {
                stack.Pop();
                lblCalculationValue.Text = stack.Peek().ToString();
                lblStackValue.Text = lblCalculationValue.Text;
            }
            catch (Exception)
            {
                MessageBox.Show($"Стек пуст");
                lblStackValue.Text = "0";
            }
            lblClickNumValue.Text = ClickNum().ToString();
        }

        private void lblCalculationValue_TextChanged(Object sender, EventArgs e)
        {
            if (stack.Count() != 0 && int.Parse(lblCalculationValue.Text) > stack.Peek())
            {
                stack.Push(int.Parse(lblCalculationValue.Text));
                lblStackValue.Text = stack.Peek().ToString();
            }
            else if (stack.Count() == 0)
            {
                stack.Push(int.Parse(lblCalculationValue.Text));
                lblStackValue.Text = stack.Peek().ToString();
            }
        }

        private void menuItemGame_Click(Object sender, EventArgs e)
        {
            MessageBox.Show($"Получите за минимальное кол-во ходов число: {rnd.Next(10, 100)}");
        }

        // Вспомогательные методы
        private int ClickNum()
        {
            return ++clickNum;
        }
    }
}
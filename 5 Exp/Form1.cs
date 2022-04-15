using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Exp
{
    public partial class ExpCalc : Form
    {
        public ExpCalc()
        {
            InitializeComponent();
        }

        // Закрыть программу
        private void but_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Очистить все поля
        private void but_reset_Click(object sender, EventArgs e)
        {
            lab_initial.Text = "";
            lab_accuracy.Text = "";
            lab_roundval.Text = "";
            lab_summs.Text = "";
            lab_accurval.Text = "";
            textBox.Text = "";
            radioButton1.Checked = true;
        }

        // Фильтрация вводимых данных
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            else
            {
                if ((e.KeyChar != '-') && !(Char.IsControl(e.KeyChar)))
                {

                    toolTip1.Show("Недопустимый символ", textBox, 58, 20, 2000);
                }
            }
            if (e.KeyChar == '-')
            {
                if (textBox.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    but_calculate.Focus();
                return;
            } e.Handled = true;
        }

        // Вычислить экспоненту
        private void but_calculate_Click(object sender, EventArgs e)
        {
            double exp = 1, temp = 1, x, round_acc_num = 0.1;
            int round_acc, i = 1;
            string acc;
            if ((textBox.Text == "") || (Convert.ToInt16(textBox.Text) < -13) || 
                (Convert.ToInt16(textBox.Text) > 20))
            {
                toolTip1.Show("Введите корректное значение X", textBox, 58, 20, 2000);
                return;
            }
            acc = lab_accuracy.Text;
            // Выбор точности округления
            switch (acc)
            {
                case "0.1":
                    round_acc = 1;
                    round_acc_num = 0.1;
                    break;
                case "0.01":
                    round_acc = 2;
                    round_acc_num = 0.01;
                    break;
                case "0.001":
                    round_acc = 3;
                    round_acc_num = 0.001;
                    break;
                case "0.0001":
                    round_acc = 4;
                    round_acc_num = 0.0001;
                    break;
                case "0.00001":
                    round_acc = 5;
                    round_acc_num = 0.00001;
                    break;
                case "0.000001":
                    round_acc_num = 0.000001;
                    round_acc = 6;
                    break;
                default: 
                    round_acc = 1;
                    break;
            }
            x = Convert.ToInt16(textBox.Text);
            do
            {
                temp = temp * x / i;
                exp += temp;
                i++;
            } while (Math.Abs(temp) >= round_acc_num);

            lab_initial.Text = textBox.Text;
            lab_accurval.Text = Convert.ToString(Math.Round(exp, round_acc + 1));
            lab_roundval.Text = Convert.ToString(Math.Round(System.Math.Exp(x), round_acc + 1));
            lab_summs.Text = Convert.ToString(i);
        }

        // Очистка полей при переключении точности
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lab_accuracy.Text = radioButton1.Text;
            lab_initial.Text = "";
            lab_roundval.Text = "";
            lab_summs.Text = "";
            lab_accurval.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lab_accuracy.Text = radioButton2.Text;
            lab_initial.Text = "";
            lab_roundval.Text = "";
            lab_summs.Text = "";
            lab_accurval.Text = "";
        }
        
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lab_accuracy.Text = radioButton3.Text;
            lab_initial.Text = "";
            lab_roundval.Text = "";
            lab_summs.Text = "";
            lab_accurval.Text = "";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            lab_accuracy.Text = radioButton4.Text;
            lab_initial.Text = "";
            lab_roundval.Text = "";
            lab_summs.Text = "";
            lab_accurval.Text = "";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            lab_accuracy.Text = radioButton5.Text;
            lab_initial.Text = "";
            lab_roundval.Text = "";
            lab_summs.Text = "";
            lab_accurval.Text = "";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            lab_accuracy.Text = radioButton6.Text;
            lab_initial.Text = "";
            lab_roundval.Text = "";
            lab_summs.Text = "";
            lab_accurval.Text = "";
        }

    }
}

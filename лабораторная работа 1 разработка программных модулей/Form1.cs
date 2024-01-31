using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;


namespace лабораторная_работа_1_разработка_программных_модулей
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private BigInteger калькулятор(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                BigInteger результат = 1;
                for (int i = 1; i <= n; i++)
                {
                    результат *= i;
                }
                return результат;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                int число = Convert.ToInt32(textBox1.Text);
                if (число >= 0)
                {
                    BigInteger результат = калькулятор(число);
                    label2.Text = $"факториал числа {число} равен {результат}";
                }
            }
            else
            {
                MessageBox.Show("введите число для вычисления факториала.");
            }
        }
    }
}

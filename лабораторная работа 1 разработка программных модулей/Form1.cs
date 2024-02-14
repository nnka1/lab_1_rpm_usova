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

        private BigInteger CalculateFactorial(int n)
        {
            if (n < 0)
            {
                MessageBox.Show("Ошибка", "Факториала отрицательных чисел не существует", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; 
            }
            else if (n == 0)
            {
                return 1;
            }
            else
            {
                BigInteger result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);

            BigInteger ответ = CalculateFactorial(n);

            if (ответ != -1) 
            {
                textBox2.Text = n.ToString() + ответ.ToString();
            }
        }
    }
}


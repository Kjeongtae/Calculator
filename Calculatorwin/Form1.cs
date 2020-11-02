using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCShapWin
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void HelloLabel_Click(object sender, EventArgs e)
        {
            int number1 = 1;
            int number2 = 2;

            int sum = number1 + number2;

            HelloLabel.Text = sum.ToString();
        }

        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }
        public float Add(float number1, float number2)
        {
            float sum = number1 + number2;
            return sum;
        }
        public int sub(int number1, int number2)
        {
            int sub = number1 - number2;
            return sub;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = 0;
            int number2 = 0;

            if (string.IsNullOrWhiteSpace(Sum1.Text))
            {
                MessageBox.Show("sum1에 숫자를 입력해주새요.");
                Sum1.Focus();
                return;
            }
            if (int.TryParse(Sum1.Text, out number1) == false)
            {
                MessageBox.Show("Sum1에 문자가 들어왔습니다. 숫자를 입력해 주세요.");
                Sum1.SelectAll();
                Sum1.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(Sum2.Text))
            {
                MessageBox.Show("sum2에 숫자를 입력해주새요.");
                Sum2.Focus();
                return;
            }
            if (int.TryParse(Sum2.Text, out number2) == false)
            {
                MessageBox.Show("Sum2에 문자가 들어왔습니다. 숫자를 입력해 주세요.");
                Sum2.SelectAll();
                Sum2.Focus();
                return;
            }

            int sum = number1 + number2;
            SumResult.Text = sum.ToString();
        }
    }
}

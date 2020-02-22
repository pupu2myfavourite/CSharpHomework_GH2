using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCalculator_GH
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bool isValue1, isValue2;

            string text1, text2;
            text1 = BoxNumber1.Text;
            text2 = BoxNumber2.Text;

            double num1, num2;
            double res;
            // isValue1 = Double.TryParse(text1, out num1);
            //isValue2 = Double.TryParse(text2, out num2);

            //if (isValue1 && isValue2)
            if (Double.TryParse(text1, out num1)&& Double.TryParse(text2, out num2))
            {
                string func = Convert.ToString(Function.SelectedItem);

                switch (func)
                {
                    case "+":
                        res = num1 + num2;
                        Commit.Text = Convert.ToString(res);
                        break;
                    case "-":
                        res = num1 - num2;
                        Commit.Text = Convert.ToString(res);
                        break;
                    case "*":
                        res = num1 * num2;
                        Commit.Text = Convert.ToString(res);
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            MessageBox.Show("除数不能为0，请重新输入");
                            break;
                        }
                        else {
                            res = num1 / num2;
                            Commit.Text = Convert.ToString(res);
                            break;
                        }
                    default:
                        Commit.Text = "Wrong!!";
                        MessageBox.Show("请选择正确的操作符");
                        break;
                }
            }
            else
            {
                Commit.Text = "wrong";
                MessageBox.Show("请输入正确的数字");
                Commit.Text = "commit";
            }

        }
    }
}

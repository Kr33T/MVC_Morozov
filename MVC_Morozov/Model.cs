using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MVC_Morozov
{
    internal class Model
    {
        public static string firstTB;
        public static string secondTB;

        public static List<string> operCB_Text = new List<string>() { "Сложение", "Вычитание", "Умножение", "Деление" };
        public static List<string> operSignTB_Text = new List<string>() { "+", "-", "*", "/" };

        public static TextBlock operSignTB = new TextBlock();
        public static TextBox resultTB = new TextBox();

        public static int operSignTB_set
        {
            set
            {
                operSignTB.Text = operSignTB_Text[value];
            }
        }

        public static int operResult_set
        {
            set
            {
                try
                {
                    double first = Convert.ToDouble(firstTB);
                    double second = Convert.ToDouble(secondTB);

                    switch (value)
                    {
                        case 0:
                            resultTB.Text = (first + second).ToString();
                            break;
                        case 1:
                            resultTB.Text = (first - second).ToString();
                            break;
                        case 2:
                            resultTB.Text = (first * second).ToString();
                            break;
                        case 3:
                            if (second == 0)
                            {
                                resultTB.Text = "Деление на ноль невозможно";
                            }
                            else
                            {
                                resultTB.Text = (first / second).ToString();
                            }
                            break;
                    }
                }
                catch
                {
                    resultTB.Text = "Проверьте корректность введенных данных";
                }
            }
        }
    }
}

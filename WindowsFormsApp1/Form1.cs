using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        string action;        //Действие
        string enteredNumber; //Введенное число
        bool numberDialed;    //Флаг того что первое число набранно

        public Calculator()
        {
            InitializeComponent();
            numberDialed = false;
        }       
        private void button11_Click(object sender, EventArgs e)// Adding Numbers to the Panel | Добавдение чисел на панель
        {
            Button button = (Button)sender;
            action = button.Text;
            enteredNumber = textBox1.Text;
            numberDialed = true;
        }
        private void button10_Click(object sender, EventArgs e)// Equals | Ранво | =
        {
            double numberOne, numberTwo, result; //Первое число, Второе число, Результат.
            result = 0;
            numberOne = Convert.ToDouble(enteredNumber);
            numberTwo = Convert.ToDouble(textBox1.Text);
            if(action == "+")
            {
                result = numberOne + numberTwo;
            }
            if(action == "-")
            {
                result = numberOne - numberTwo;
            }
            if(action == "*")
            {
                result = numberOne * numberTwo;
            }
            if(action == "/")
            {
                result = numberOne / numberTwo;
            }
            if(action == "%")
            {
                result = numberOne * numberTwo / 100;
            }

            action = "=";
            numberDialed = true;
            textBox1.Text = result.ToString();

        }
        private void button6_Click_1(object sender, EventArgs e)// Numbers | Числа
        {
            if (numberDialed)
            {
                numberDialed = false;
                textBox1.Text = "0";
            }
            Button button = (Button)sender;
            if(textBox1.Text == "0")
            {
                textBox1.Text = button.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button.Text;
            }
        }
        private void button17_Click(object sender, EventArgs e)// Removal | Удаление | CE/C
        {
            textBox1.Text = "0";
        }
        private void button22_Click(object sender, EventArgs e)// Root | Корень
        {
            double numberOne, result;//Введенное число, Результат

            numberOne = Convert.ToDouble(textBox1.Text);
            result = Math.Sqrt(numberOne);
            textBox1.Text = result.ToString();
        }
        private void button23_Click(object sender, EventArgs e)// Square | Квадрат
        {
            double numberOne, result;//Введенное число, Результат

            numberOne = Convert.ToDouble(textBox1.Text);
            result = Math.Pow(numberOne, 2);
            textBox1.Text = result.ToString();
        }
        private void button24_Click(object sender, EventArgs e)// Derivative | Производная 
        {
            double numberOne, result;//Введенное число, Результат

            numberOne = Convert.ToDouble(textBox1.Text);
            result = 1 / numberOne;
            textBox1.Text = result.ToString();
        }
        private void button18_Click(object sender, EventArgs e)// Signs | Знаки | +\-
        {
            double numberOne, result;//Введенное число, Результат

            numberOne = Convert.ToDouble(textBox1.Text);
            result = -numberOne;
            textBox1.Text = result.ToString();
        }
        private void button19_Click(object sender, EventArgs e)// Dot | Точка | .
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text = textBox1.Text + ",";
            }
            
        }
        private void button20_Click(object sender, EventArgs e)// Delete | Удаление
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}

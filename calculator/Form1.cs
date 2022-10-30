using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        decimal FirstValue = 0.0m;
        decimal SecondValue = 0.0m;
        decimal Result = 0.0m;
        string Operation = "+";
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox2.TextAlign = HorizontalAlignment.Right;
            MaximizeBox = false;
            MinimizeBox = false;
            
        }
        // disable wrong output in textbox2 if user click on "=" more time without changing numbers
        private void ChangeLastCharacter(char character)
        {
            if (textBox2.Text.EndsWith("="))
            {
                textBox2.Text = textBox2.Text.Replace(textBox2.Text[textBox2.Text.Length - 1], character);
            }
        }
        // disable to modify the result of two operations similar to windows calculator
        private void CompareTextBoxResult()
        {
            if (textBox1.Text == Result.ToString())
            {
                textBox2.Clear();
                textBox1.Clear();
            }
        }
        private void NumberOne_Click(object sender, EventArgs e)
        {
            // "if" statement is used to replace number zero that is always first number in textbox
            CompareTextBoxResult();
            if (textBox1.Text == "0" || textBox1.Text== "Cannot divide by zero")
            {
                textBox2.Clear();
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += NumberOne.Text;
            }
            
        }

        private void NumberTwo_Click(object sender, EventArgs e)
        {
            CompareTextBoxResult();
            if (textBox1.Text == "0" || textBox1.Text == "Cannot divide by zero")
            {
                textBox2.Clear();
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += NumberTwo.Text;
            }
        }

        private void NumberThree_Click(object sender, EventArgs e)
        {
            CompareTextBoxResult();
            if (textBox1.Text == "0" || textBox1.Text == "Cannot divide by zero")
            {
                textBox2.Clear();
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += NumberThree.Text;
            }
            
        }

        private void NumberFour_Click(object sender, EventArgs e)
        {
            CompareTextBoxResult();
            if (textBox1.Text == "0" || textBox1.Text == "Cannot divide by zero")
            {
                textBox2.Clear();
                textBox1.Text = "4";
            }
            else{
                textBox1.Text += NumberFour.Text;
            }
        }

        private void NumberFive_Click(object sender, EventArgs e)
        {
            CompareTextBoxResult();
            if (textBox1.Text == "0" || textBox1.Text == "Cannot divide by zero")
            {
                textBox2.Clear();
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += NumberFive.Text;
            }
            
        }

        private void NumberSix_Click(object sender, EventArgs e)
        {
            CompareTextBoxResult();
            if (textBox1.Text == "0" || textBox1.Text == "Cannot divide by zero")
            {
                textBox2.Clear();
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += NumberSix.Text;
            }
                
        }

        private void NumberSeven_Click(object sender, EventArgs e)
        {
            CompareTextBoxResult();
            if (textBox1.Text == "0" || textBox1.Text == "Cannot divide by zero")
            {
                textBox2.Clear();
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += NumberSeven.Text;
            }
        }

        private void NumberEight_Click(object sender, EventArgs e)
        {
            CompareTextBoxResult();
            if (textBox1.Text == "0" || textBox1.Text == "Cannot divide by zero")
            {
                textBox2.Clear();
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += NumberEight.Text;
            }
        }

        private void NumberNine_Click(object sender, EventArgs e)
        {
            CompareTextBoxResult();
            if (textBox1.Text == "0" || textBox1.Text == "Cannot divide by zero")
            {
                textBox2.Clear();
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += NumberNine.Text;
            }
        }

        private void NumberZero_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox2.Clear();
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += NumberZero.Text;
            }
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += Dot.Text;
            }
        }

        private void Sign_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("-"))
            {
                textBox1.Text = textBox1.Text.Trim('-');
            }
            else
            {
                textBox1.Text = "-" + textBox1.Text;
            }
        }
        private void Plus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                //convert string from textbox to decimal value
                FirstValue = decimal.Parse(textBox1.Text);
            }
            textBox2.Text = FirstValue.ToString() + "+";
            textBox1.Clear();
            Operation = "+";
        }
        private void Minus_Click(object sender, EventArgs e)
        {
            // to not have error if user want to change opreation
            if (textBox1.Text != "")
            {
                FirstValue = decimal.Parse(textBox1.Text);
            }
            textBox2.Text = FirstValue.ToString() + "-";
            textBox1.Clear();
            Operation = "-";
        }

        private void Times_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                FirstValue = decimal.Parse(textBox1.Text);
            }
            textBox2.Text = FirstValue.ToString() + "*";
            textBox1.Clear();
            Operation = "*";
        }

        private void Divides_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                FirstValue = decimal.Parse(textBox1.Text);
            }
            textBox2.Text = FirstValue.ToString() + "/";
            textBox1.Clear();
            Operation = "/";
        }

        private void Module_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                FirstValue = decimal.Parse(textBox1.Text);
            }
            
            textBox2.Text = FirstValue.ToString() + "%";
            textBox1.Clear();
            Operation = "%";
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            //clear all steps
            if (textBox1.Text == Result.ToString())
            {
                textBox2.Clear();
            }
            textBox1.Text = "0";
            
        }

        private void EqualsTo_Click(object sender, EventArgs e)
        {
            switch (Operation)
            {
                case "+":
                    if(textBox1.Text != "")
                    {
                        SecondValue = decimal.Parse(textBox1.Text);
                    }
                    ChangeLastCharacter('+');
                    textBox2.Text = textBox2.Text + SecondValue.ToString() + "=";
                    Result = FirstValue + SecondValue;
                    textBox1.Text = Result.ToString();
                    break;
                case "-":
                    if (textBox1.Text != "")
                    {
                        SecondValue = decimal.Parse(textBox1.Text);
                    }
                    ChangeLastCharacter('-');
                    textBox2.Text = textBox2.Text + SecondValue.ToString() + "=";
                    Result = FirstValue - SecondValue;
                    textBox1.Text = Result.ToString();
                    break;
                case "*":
                    if (textBox1.Text != "")
                    {
                        SecondValue = decimal.Parse(textBox1.Text);
                    }
                    ChangeLastCharacter('*');
                    textBox2.Text = textBox2.Text + SecondValue.ToString() + "=";
                    Result = FirstValue * SecondValue;
                    textBox1.Text = Result.ToString();
                    break;
                case "/":
                    if (textBox1.Text != "")
                    {
                        SecondValue = decimal.Parse(textBox1.Text);
                    }
                    ChangeLastCharacter('/');
                    textBox2.Text = textBox2.Text + SecondValue.ToString() + "=";
                    // division by zero is not possible, if statement disables program crash
                    if (SecondValue != 0)
                    {
                        Result = FirstValue / SecondValue;
                        textBox1.Text = Result.ToString();
                    }
                    else
                    {
                        textBox1.Text = "Cannot divide by zero";
                    }
                    break;
                case "%":
                    if (textBox1.Text != "")
                    {
                        SecondValue = decimal.Parse(textBox1.Text);
                    }
                    ChangeLastCharacter('%');
                    textBox2.Text = textBox2.Text + SecondValue.ToString() + "=";
                    Result = FirstValue % SecondValue;
                    textBox1.Text = Result.ToString();
                    break;
            }
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Text = "0";
            Result = 0.0m;
            FirstValue = 0.0m;
            SecondValue = 0.0m;
        }
    }
}

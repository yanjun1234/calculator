using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Yanjun
{
    public partial class Calculator : Form
    {
        private decimal resultValue = 0;
        private String operation = "";
        // indicate if a operation has been performed
        private bool isOperationPerformed = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, EventArgs e)
        {
            // clear the textbox when textbox contains a leading 0 or when the operation has been performed
            if ((textBox_Value.Text == "0") || (isOperationPerformed))
            {
                textBox_Value.Clear();
            }

            isOperationPerformed = false;
            Button button = (Button)sender;
            
            // check if the button being pressed is a decimal
            if (button.Text == "." )
            {
                // no decimal in the textBox_Value, append the decimal to the end of the textBox_Value
                if (!textBox_Value.Text.Contains("."))
                {
                    textBox_Value.Text = textBox_Value.Text + button.Text;
                }
            }
            else
            {
                // append the digit to the end of the textBox_Value 
                textBox_Value.Text = textBox_Value.Text + button.Text;
            }


        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                // perform the operation
                equals.PerformClick();
                operation = button.Text;
                operationLabel.Text = resultValue + " " + operation;
                isOperationPerformed = true;

            }else
            {
                // set operation to the value of the current pressed button 
                operation = button.Text;
                // set resultValue to the current textBox_Value
                resultValue = Decimal.Parse(textBox_Value.Text);
                // change the label to the current formula
                operationLabel.Text = resultValue + " " + operation;
                isOperationPerformed = true;
            }

        }
        

        private void sign_Click(object sender, EventArgs e)
        {
            // add the sign to the begining of the current textBox_Value
            textBox_Value.Text = "-" + textBox_Value.Text;
        }

        private void clearEntry_Click(object sender, EventArgs e)
        {
            // set the current textBox_Value to 0
            textBox_Value.Text = "0";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            // set the previous entries to 0
            textBox_Value.Text = "0";
            operationLabel.Text = "";
            resultValue = 0;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            switch(operation){
                
                case "+":
                    // display the current formula
                    operationLabel.Text = resultValue + " " + operation + " " + textBox_Value.Text;
                    // do the calculation and display the result to the textBox
                    textBox_Value.Text = (resultValue + Decimal.Parse(textBox_Value.Text)).ToString();
                    break;
                case "-":
                    operationLabel.Text = resultValue + " " + operation + " " + textBox_Value.Text;
                    textBox_Value.Text = (resultValue - Decimal.Parse(textBox_Value.Text)).ToString();
                    break;
                case "X":
                    operationLabel.Text = resultValue + " " + operation + " " + textBox_Value.Text;
                    textBox_Value.Text = (resultValue * Decimal.Parse(textBox_Value.Text)).ToString();
                    break;
                case "/":
                    operationLabel.Text = resultValue + " " + operation + " " + textBox_Value.Text;
                    textBox_Value.Text = (resultValue / Decimal.Parse(textBox_Value.Text)).ToString();
                    break;
                default:
                    break;
                
            }
            // set to the default operation
            operation = "";
            // set resultValue to the result calculated within "switch" 
            resultValue = Decimal.Parse(textBox_Value.Text);
            isOperationPerformed = true;
        }

        private void operatorSpecial_Click(object sender, EventArgs e)
        {
            // 
            Button button = (Button)sender;
            String specialOperator = button.Text;

            // do the calculation when the special character is pressed and display the result
            switch (specialOperator)
            {
                case "1/x":
                    textBox_Value.Text = (1 / Decimal.Parse(textBox_Value.Text)).ToString();
                    break;
                case "sqrt":
                    textBox_Value.Text = (Math.Sqrt(Double.Parse(textBox_Value.Text))).ToString();
                    break;
                case "x^2":
                    textBox_Value.Text = (Math.Pow(Double.Parse(textBox_Value.Text), 2)).ToString();
                    break;
                case "%":
                    textBox_Value.Text = (Double.Parse(textBox_Value.Text) / 100).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Decimal.Parse(textBox_Value.Text);
            isOperationPerformed = true;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            // delete the character when the length of the current textBox_Value is greater than 0
            // and operation has not been performed
            if (textBox_Value.Text.Length > 0 && (isOperationPerformed == false))
                textBox_Value.Text = textBox_Value.Text.Remove(textBox_Value.Text.Length - 1);
        }
    }
}

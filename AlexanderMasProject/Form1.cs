using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlexanderMasProject
{
    public partial class Form1 : Form
    {
        // GLOBAL VARIABLES
        string input = "0";                 // user input, initially 0
        string operand1 = string.Empty;     // first operand
        string operand2 = string.Empty;     // second operand
        char operation;                     // operation
        double result = 0.0;                // result
        bool previouslyCalculated = false;  // keep track of if a calculation has been made (to assist with continuous calculations)
        bool modified = false;              // assist with continuous calculations
        double memory = 0;                  // stores a number, initially 0

        // initialize form and initialize display to 0
        public Form1()
        {
            InitializeComponent();
            displayBox.Text = input;
        }

        // see if a calculation has already been made; if so, reset
        private void recalculate()
        {
            if (previouslyCalculated == true && modified == true)
            {
                input = "0";
            }
            else if (previouslyCalculated == true)
            {
                operand1 = string.Empty;
                input = "0";
            }
        
        }

        // 0
        private void button0_Click(object sender, EventArgs e)
        {
            // check if calculation was previously made
            recalculate();
            // refresh display
            displayBox.Text = "";
            // if input is 0, set to this digit alone
            if (input == "0")
            {
                input = "0";
            }
            // else, append this digit
            else
            {
                input += "0";
            }
            // append input to the display
            displayBox.Text += input;
            // calculation bool is reset
            previouslyCalculated = false;
        }

        // 1
        private void button1_Click(object sender, EventArgs e)
        {
            recalculate();
            displayBox.Text = "";
            if (input == "0")
            {
                input = "1";
            }
            else
            {
                input += "1";
            }
            displayBox.Text += input;
            previouslyCalculated = false;
        }

        // 2
        private void button2_Click(object sender, EventArgs e)
        {
            recalculate();
            displayBox.Text = "";
            if (input == "0")
            {
                input = "2";
            }
            else
            {
                input += "2";
            }
            displayBox.Text += input;
            previouslyCalculated = false;
        }

        // 3
        private void button3_Click(object sender, EventArgs e)
        {
            recalculate();
            displayBox.Text = "";
            if (input == "0")
            {
                input = "3";
            }
            else
            {
                input += "3";
            }
            displayBox.Text += input;
            previouslyCalculated = false;
        }

        // 4
        private void button4_Click(object sender, EventArgs e)
        {
            recalculate();
            displayBox.Text = "";
            if (input == "0")
            {
                input = "4";
            }
            else
            {
                input += "4";
            }
            displayBox.Text += input;
            previouslyCalculated = false;
        }

        // 5
        private void button5_Click(object sender, EventArgs e)
        {
            recalculate();
            displayBox.Text = "";
            if (input == "0")
            {
                input = "5";
            }
            else
            {
                input += "5";
            }
            displayBox.Text += input;
            previouslyCalculated = false;
        }
        // 6
        private void button6_Click(object sender, EventArgs e)
        {
            recalculate();
            displayBox.Text = "";
            if (input == "0")
            {
                input = "6";
            }
            else
            {
                input += "6";
            }
            displayBox.Text += input;
            previouslyCalculated = false;
        }
        // 7
        private void button7_Click(object sender, EventArgs e)
        {
            recalculate();
            displayBox.Text = "";
            if (input == "0")
            {
                input = "7";
            }
            else
            {
                input += "7";
            }
            displayBox.Text += input;
            previouslyCalculated = false;
        }

        // 8
        private void button8_Click(object sender, EventArgs e)
        {
            recalculate();
            displayBox.Text = "";
            if (input == "0")
            {
                input = "8";
            }
            else
            {
                input += "8";
            }
            displayBox.Text += input;
            previouslyCalculated = false;
        }

        // 9 
        private void button9_Click(object sender, EventArgs e)
        {
            recalculate();
            displayBox.Text = "";
            if (input == "0")
            {
                input = "9";
            }
            else
            {
                input += "9";
            }
            displayBox.Text += input;
            previouslyCalculated = false;
        }

        // decimal point
        private void decimalButton_Click(object sender, EventArgs e)
        {
            recalculate();
            displayBox.Text = "";
            // if input is empty, set it to 0.
            if (input == "")
            {
                input = "0.";
            }
            // else, if there is already a decimal point
            else if (input.Contains("."))
            {
                // don't allow another decimal to be typed
            }
            // else, append a decimal point
            else
            {
                input += ".";
            }
            displayBox.Text += input;
            previouslyCalculated = false;
        }

        // change sign
        private void signButton_Click(object sender, EventArgs e)
        {
            double convertInput;
            // if the input is negative, make it positive
            if (displayBox.Text.Contains("-")) {
                double.TryParse(input, out convertInput);
                convertInput /= -1;
                input = convertInput.ToString();
                displayBox.Text = input;

            }
            // else if input is 0 or empty
            else if (displayBox.Text == "0" || displayBox.Text == "")
            {
                // nothing to make negative
            }
            // else, make input negative
            else
            {
                input = "-" + displayBox.Text;
                displayBox.Text = input;
            }

        }

        // divide
        private void divideButton_Click(object sender, EventArgs e)
        {
            // check for continuous calculation
            if (operand1 != "" && input != "" && previouslyCalculated == false)
            {
                previouslyCalculated = false;
                
                modifiedCalculate();
                operation = '/';
            }
            else
            {
                previouslyCalculated = false;
                // retrieve operand1 from display
                operand1 = displayBox.Text;
                // set operation
                operation = '/';
                input = string.Empty;
            }
        }

        // multiply
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (operand1 != "" && input != "" && previouslyCalculated == false)
            {
                previouslyCalculated = false;
               
                modifiedCalculate();
                operation = '*';
            }
            else
            {
                previouslyCalculated = false;
                operand1 = displayBox.Text;
                operation = '*';
                input = string.Empty;
            }
        }

        // subtract
        private void subtractButton_Click(object sender, EventArgs e)
        {
            if (operand1 != "" && input != "" && previouslyCalculated == false)
            {
                previouslyCalculated = false;
                
                modifiedCalculate();
                operation = '-';
            }
            else
            {
                previouslyCalculated = false;
                operand1 = displayBox.Text;
                operation = '-';
                input = string.Empty;
            }
        }

        // add
        private void addButton_Click(object sender, EventArgs e)
        {
            
            if (operand1 != "" && input != "" && previouslyCalculated == false)
            {
                previouslyCalculated = false;

                modifiedCalculate();
                operation = '+';
            }
            else
            {
                previouslyCalculated = false;
                operand1 = displayBox.Text;
                operation = '+';
                input = string.Empty;
            }
        
        }

        // clear entry
        private void clearEntryButton_Click(object sender, EventArgs e)
        {
            displayBox.Text = "0";
            input = "0";
            operand1 = string.Empty;
            operand2 = string.Empty;
        }

        // clear
        private void clearButton_Click(object sender, EventArgs e)
        {
            displayBox.Text = "0";
            input = "0";
            operand1 = string.Empty;
            operand2 = string.Empty;
        }

        private void modifiedCalculate()
        {
            // retrieve operand2 from input, and parse operands
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            // if statements to determine operation to be made
            if (operation == '+')
            {
                result = num1 + num2;
                displayBox.Text = result.ToString();
                operand1 = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                displayBox.Text = result.ToString();
                operand1 = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                displayBox.Text = result.ToString();
                operand1 = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    displayBox.Text = result.ToString();
                    operand1 = result.ToString();
                }
                else
                {
                    // print error message for trying to divide by 0
                    displayBox.Text = "cannot divide by zero!";
                    operand1 = string.Empty;
                }
            }

            previouslyCalculated = true;
            modified = true;
        }

        // equals
        private void equalsButton_Click(object sender, EventArgs e)
        {
            // reset modified calculation
            modified = false;

            // retrieve operand2 from input, and parse operands
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            // if statements to determine operation to be made
            if (operation == '+')
            {
                result = num1 + num2;
                displayBox.Text = result.ToString();
                operand1 = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                displayBox.Text = result.ToString();
                operand1 = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                displayBox.Text = result.ToString();
                operand1 = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    displayBox.Text = result.ToString();
                    operand1 = result.ToString();
                }
                else
                {
                    // print error message for trying to divide by 0
                    displayBox.Text = "cannot divide by zero!";
                    operand1 = string.Empty;
                }
            }

            previouslyCalculated = true;
        }

        // sqrt
        private void sqrtButton_Click(object sender, EventArgs e)
        {
            previouslyCalculated = false;
            operand1 = displayBox.Text;
            double numSquare;
            double.TryParse(operand1, out numSquare);
            // Math function to find sqrt
            numSquare = Math.Sqrt(numSquare);
            displayBox.Text = numSquare.ToString();
            operand1 = numSquare.ToString();
        }

        // mod
        private void modButton_Click(object sender, EventArgs e)
        {
            double numMod;
            double num1;
            double.TryParse(operand1, out num1);
            double.TryParse(displayBox.Text, out numMod);
            numMod = (num1 * numMod) / 100;
            input = numMod.ToString();
            displayBox.Text = input;
            previouslyCalculated = false;
        }

        private void reciprocalButton_Click(object sender, EventArgs e)
        {
            double reciprocal;
            double.TryParse(displayBox.Text, out reciprocal);
            reciprocal = 1 / reciprocal;
            input = reciprocal.ToString();
            displayBox.Text = input;
            previouslyCalculated = false;
        }

        private void memSaveButton_Click(object sender, EventArgs e)
        {
            double.TryParse(displayBox.Text, out memory);
            memIndicator.Text = "M";
            previouslyCalculated = true;
        }

        private void memRecallButton_Click(object sender, EventArgs e)
        {
            input = memory.ToString();
            displayBox.Text = memory.ToString();
            previouslyCalculated = true;
        }

        private void memAddButton_Click(object sender, EventArgs e)
        {
            double addMemory;
            double.TryParse(displayBox.Text, out addMemory);
            memory += addMemory;
            previouslyCalculated = true;
        }

        private void memClearButton_Click(object sender, EventArgs e)
        {
            memory = 0;
            memIndicator.Text = "";
        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            if (input.Length == 1)
            {
                input = "0";
                displayBox.Text = input;
            }
            else if (input.Length > 0)
            {
                input = input.Remove(input.Length - 1);
                displayBox.Text = input;
            }
        }
    }
}

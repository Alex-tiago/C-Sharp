using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorGUI
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textbox_Result.Text == "0") || (isOperationPerformed))
                textbox_Result.Clear();

            isOperationPerformed = false; ;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textbox_Result.Text.Contains("."))
                    textbox_Result.Text = textbox_Result.Text + button.Text;
            } else
            textbox_Result.Text = textbox_Result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                buttonEqual.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textbox_Result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void buttonCE_click(object sender, EventArgs e)
        {
            textbox_Result.Text = "0";
        }

        private void buttonC_click(object sender, EventArgs e)
        {
            textbox_Result.Text = "0";
            resultValue = 0;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textbox_Result.Text = (resultValue + Double.Parse(textbox_Result.Text)).ToString();
                    break;
                case "-":
                    textbox_Result.Text = (resultValue - Double.Parse(textbox_Result.Text)).ToString();
                    break;
                case "*":
                    textbox_Result.Text = (resultValue * Double.Parse(textbox_Result.Text)).ToString();
                    break;
                case "/":
                    textbox_Result.Text = (resultValue / Double.Parse(textbox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textbox_Result.Text);
            labelCurrentOperation.Text = "";
        }
    }
}

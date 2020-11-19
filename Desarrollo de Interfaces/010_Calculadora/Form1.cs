using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _010_Calculadora
{
    public partial class Form1 : Form
    {
        private string[] operatorAcumulator = {null, null};
        private double?[] numberAcumulator = {null, null};
        private string numberString = "";
        public Form1()
        {
            InitializeComponent();
        }

        private double parseNumberFromTbox(string numberString)
        {
            numberString = numberString.Replace(numberAcumulator[0].ToString(), "");
            return Double.Parse(numberString);
        }
        private bool insertNumberAcumulator()
        {
            bool isNumberAcumulatorFull = false;

            if (numberString != "")
            {
                if (numberAcumulator[0] == null)
                {
                    numberAcumulator[0] = Double.Parse(numberString);
                }
                else
                {
                    numberAcumulator[1] = parseNumberFromTbox(numberString);
                    isNumberAcumulatorFull = true;
                }
            } else
            {

            }

            numberString = "";
            return isNumberAcumulatorFull;
        }

        private string calculate()
        {
            double? result = null;
            switch (operatorAcumulator[0])
            {
                case "*":
                    result = numberAcumulator[0] * numberAcumulator[1];
                    break;
                case "/":
                    result = numberAcumulator[0] / numberAcumulator[1];
                    break;
                case "+":
                    result = numberAcumulator[0] + numberAcumulator[1];
                    break;
                case "-":
                    result = numberAcumulator[0] - numberAcumulator[1];
                    break;
            }
            numberAcumulator[0] = result;
            numberAcumulator[1] = null;
            operatorAcumulator[0] = operatorAcumulator[1];
            operatorAcumulator[1] = null;
            return result.ToString();
        }

        private void numericBtn_Click(object sender, EventArgs e)
        {
            string numberString = ((string)((Button)sender).Tag);
            tbox_input.Text += numberString;
            this.numberString += numberString;
            tbox_history.Text += numberString;
        }

        private void espBtn_Click(object sender, EventArgs e)
        {
            string buttonValue = ((string)((Button)sender).Tag);
            switch (insertNumberAcumulator())
            {
                case false:
                    operatorAcumulator[0] = buttonValue;
                    tbox_input.Text += buttonValue;
                    tbox_history.Text += buttonValue;
                    break;
                case true:
                    operatorAcumulator[1] = buttonValue;
                    string calcResult = calculate();
                    tbox_input.Text = calcResult;
                    tbox_input.Text += buttonValue;
                    tbox_history.Text += " = ";
                    tbox_history.Text += calcResult;
                    tbox_history.Text += buttonValue;
                    break;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            insertNumberAcumulator();
            if (numberAcumulator[0] != null && numberAcumulator[1] != null)
            {
                string calcResult = calculate();
                tbox_input.Text = calcResult;
                tbox_history.Text += " = ";
                tbox_history.Text += calcResult;
                
            }
        }
    }
}

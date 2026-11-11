using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal Operand1 = Convert.ToDecimal(txtOperand1.Text);
            string Operator = Convert.ToString(txtOperator.Text);
            decimal Operand2 = Convert.ToDecimal(txtOperand2.Text);
            decimal Result = Calculate(Operand1, Operator, Operand2);
            txtResult.Text = Result.ToString();
        }

        private decimal Calculate(decimal Operand1, string Operator, decimal Operand2)
        {
            decimal Result = 0;
            if (Operator == "+")
            {
                Result = Operand1 + Operand2;
            }
            else if (Operator == "-")
            {
                Result = Operand1 - Operand2;
            }
            else if (Operator == "*")
            {
                Result = Operand1 * Operand2;
            }
            else if (Operator == "/")
            {
                Result = Operand1 / Operand2;
            }
            else if (Operator == "%")
            {
                Result = Operand1 % Operand2;
            }
            return Result;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

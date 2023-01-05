using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        private string user_equation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Output.Text += num7.Text;
            user_equation += num7.Text;
        }

        private void num1_Click(object sender, EventArgs e)
        {
            Output.Text += num1.Text;
            user_equation += num1.Text;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            Output.Text += num4.Text;
            user_equation += num4.Text;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            Output.Text += num2.Text;
            user_equation += num2.Text;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            Output.Text += num5.Text;
            user_equation += num5.Text;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            Output.Text += num8.Text;
            user_equation += num8.Text;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            Output.Text += num3.Text;
            user_equation += num3.Text;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            Output.Text += num6.Text;
            user_equation += num6.Text;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            Output.Text += num9.Text;
            user_equation += num9.Text;
        }

        private void num0_Click(object sender, EventArgs e)
        {
            Output.Text += num0.Text;
            user_equation += num0.Text;
        }

        private void functionAdd_Click(object sender, EventArgs e)
        {
            Output.Text += functionAdd.Text;
            user_equation += "%" + functionAdd.Text + "%";
        }

        private void functionSubtract_Click(object sender, EventArgs e)
        {
            Output.Text += functionSubtract.Text;
            user_equation += "%" + functionSubtract.Text + "%";
        }

        private void functionMultiply_Click(object sender, EventArgs e)
        {
            Output.Text += functionMultiply.Text;
            user_equation += "%" + functionMultiply.Text + "%";
        }

        private void functionDivide_Click(object sender, EventArgs e)
        {
            Output.Text += functionDivide.Text;
            user_equation += "%" + functionDivide.Text + "%";
        }

    }
}
/*
 Developer Notes:
- I use the percentage symbol(%) to seperate all operators
- When calculating the text of the output text box is split to find operators used and from there generate an equation


        private void num2_Click(object sender, EventArgs e)
        {
            Output.Text += num2.Text;
            user_equation += num2.Text;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            Output.Text += num5.Text;
            user_equation += num5.Text;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            Output.Text += num8.Text;
            user_equation += num8.Text;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            Output.Text += num3.Text;
            user_equation += num3.Text;
        }
        private void num6_Click(object sender, EventArgs e)
        {
            Output.Text += num6.Text;
            user_equation += num6.Text;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            Output.Text += num9.Text;
            user_equation += num9.Text;
        }
 */
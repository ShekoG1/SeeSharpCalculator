using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using calculate;

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

        protected void showError(string message)
        {
            errorBox.Text = message;
        }

        protected void clearError()
        {
            errorBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Output.Text += num7.Text;
            user_equation += num7.Text;
            clearError();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            Output.Text += num1.Text;
            user_equation += num1.Text;
            clearError();
        }

        private void num4_Click(object sender, EventArgs e)
        {
            Output.Text += num4.Text;
            user_equation += num4.Text;
            clearError();
        }

        private void num2_Click(object sender, EventArgs e)
        {
            Output.Text += num2.Text;
            user_equation += num2.Text;
            clearError();
        }

        private void num5_Click(object sender, EventArgs e)
        {
            Output.Text += num5.Text;
            user_equation += num5.Text;
            clearError();
        }

        private void num8_Click(object sender, EventArgs e)
        {
            Output.Text += num8.Text;
            user_equation += num8.Text;
            clearError();
        }

        private void num3_Click(object sender, EventArgs e)
        {
            Output.Text += num3.Text;
            user_equation += num3.Text;
            clearError();
        }

        private void num6_Click(object sender, EventArgs e)
        {
            Output.Text += num6.Text;
            user_equation += num6.Text;
            clearError();
        }

        private void num9_Click(object sender, EventArgs e)
        {
            Output.Text += num9.Text;
            user_equation += num9.Text;
            clearError();
        }

        private void num0_Click(object sender, EventArgs e)
        {
            Output.Text += num0.Text;
            user_equation += num0.Text;
            clearError();
        }

        private void functionAdd_Click(object sender, EventArgs e)
        {
            if (user_equation.EndsWith("%"))
            {
                showError("You cannot enter operators consecutively. Please try again using a typical equation format, for example, 1 + 1 X 2");
            }
            else
            {
                clearError();
                Output.Text += functionAdd.Text;
                user_equation += "%" + functionAdd.Text + "%";
            }
        }

        private void functionSubtract_Click(object sender, EventArgs e)
        {
            if (user_equation.EndsWith("%"))
            {
                showError("You cannot enter operators consecutively. Please try again using a typical equation format, for example, 1 + 1 X 2");
            }
            else
            {
                clearError();
                Output.Text += functionSubtract.Text;
                user_equation += "%" + functionSubtract.Text + "%";
            }
        }

        private void functionMultiply_Click(object sender, EventArgs e)
        {
            if (user_equation.EndsWith("%"))
            {
                showError("You cannot enter operators consecutively. Please try again using a typical equation format, for example, 1 + 1 X 2");
            }
            else
            {
                clearError();
                Output.Text += functionMultiply.Text;
                user_equation += "%" + functionMultiply.Text + "%";
            }
        }

        private void functionDivide_Click(object sender, EventArgs e)
        {
            if (user_equation.EndsWith("%"))
            {
                showError("You cannot enter operators consecutively. Please try again using a typical equation format, for example, 1 + 1 X 2");
            }
            else
            {
                clearError();
                Output.Text += functionDivide.Text;
                user_equation += "%" + functionDivide.Text + "%";
            }
        }

        
        /*
         * 
         * private void writeEquation(string equation)
        {

            string folder = Directory.GetCurrentDirectory();
            string main_folder = "";
            bool isProjectroot = false;
            Console.WriteLine(folder);

            while (!isProjectroot)
            {
                Console.WriteLine(folder);
                if (folder.Split('\\').ToList().Last() == "CalculatorApp")
                {
                    main_folder = folder;
                    isProjectroot = true;
                }
                else
                {
                    folder = Directory.GetParent(folder).FullName;
                }
            }

            string fileName = "CSharpCornerAuthors.cs";
            string fullPath = main_folder + "\\" + fileName;
            Console.WriteLine("Main folder is " + main_folder);


            List<string> contents = new List<string>();

            contents.Add("using System;\r\nusing System.Collections.Generic;\r\nusing System.ComponentModel;\r\nusing System.Data;\r\nusing System.Drawing;\r\nusing System.IO;\r\nusing System.Linq;\r\nusing System.Text;\r\nusing System.Threading.Tasks;\r\nusing System.Windows.Forms;\r\n\r\nnamespace calculate\r\n{\r\n\r\n    public class calc\r\n    {\r\n\r\n        public int calculate()\r\n        {\r\n\r\n            return " + equation.Replace("X", "*").Replace("%", "") + ";\r\n\r\n        }\r\n    }\r\n}");

            File.WriteAllLines(fullPath, contents);
            

            string readText = File.ReadAllText(fullPath);

                calc calulate_answer = new calc();
                Output.Text = calulate_answer.calculate().ToString();
        }
        
         */

        private void calculate_Click_1(object sender, EventArgs e)
        {
            clearError();
            if (user_equation.EndsWith("%"))
            {
                showError("You cannot end the equation with an oeprator (+;-;X;/)! Please re-enter your equation and try again!");
            }
            else
            {
                try
                {
                    Console.WriteLine(user_equation.Replace("X", "*").Replace("%", ""));
                    Output.Text = new DataTable().Compute(user_equation.Replace("X", "*").Replace("%", ""), null).ToString();
                    user_equation = Output.Text;
                }
                catch (Exception error) 
                {
                    showError(error.ToString());
                }
            }
        }

    }
}
/*
 Developer Notes:
- I use the percentage symbol(%) to seperate all operators
- When calculating the text of the output text box is split to find operators used and from there generate an equation
 */
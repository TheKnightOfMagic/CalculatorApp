using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculatorApp
{
    public enum Operator
    {
        MULTIPLY,
        DIVIDE,
        SUBTRACT,
        ADD,
        NONE

    }
    public partial class MainPage : ContentPage
    {


        string numerics = "1234567890.";
        private int count = 0;
        private string[] input = new string[2];

        private string result = "";
        public Operator op = Operator.NONE;

        public MainPage()
        {
            InitializeComponent();
        }

        private void b_Clicked(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            if (numerics.IndexOf((button.Text)) != -1)
            {
                input[count] += button.Text;
                labelOutput.Text = input[count];
            }
            else if (button.Text == "C")
            {
                input[0] = "";
                input[1] = "";
                labelOutput.Text = "0";
                count = 0;
            }
            else if (button.Text == "Del")
            {
                input[count] = "";
                labelOutput.Text = "0";
            }
            else if (button.Text == "+")
            {
                op = Operator.ADD;
                count = 1;
            }
            else if (button.Text == "-")
            {
                op = Operator.SUBTRACT;
                count = 1;

            }
            else if (button.Text == "/")
            {
                op = Operator.DIVIDE;
                count = 1;
            }
            else if (button.Text == "*")
            {
                op = Operator.MULTIPLY;
                count = 1;
            }
            else if (button.Text == "=")
            {
                if (op == Operator.ADD)
                {
                    result = (Convert.ToDouble(input[0]) + Convert.ToDouble(input[1])).ToString();
                }
                else if (op == Operator.SUBTRACT)
                {
                    result = (Convert.ToDouble(input[0]) - Convert.ToDouble(input[1])).ToString();
                }
                else if (op == Operator.DIVIDE)
                {
                    result = (Convert.ToDouble(input[0]) / Convert.ToDouble(input[1])).ToString();
                }
                else if (op == Operator.MULTIPLY)
                {
                    result = (Convert.ToDouble(input[0]) * Convert.ToDouble(input[1])).ToString();
                }
                input[0] = result;
                input[1] = "";
                labelOutput.Text = result;
            }


        }


    }
}

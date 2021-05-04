using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_calculator
{
    public partial class Form1 : Form 
    {
        double value;
        string op = "";
        bool op_press = false; //first execution 
        bool eq_press = false; //second execution 

        public Form1()
        {
            InitializeComponent();
        }
        private void button_click(object sender, EventArgs e)
        {
            if (resultbox.Text == "0") // ensures there is never a zero infront of numbers input ex: 012
            {
                resultbox.Clear();
            }
            if(eq_press == true) //This is so people cannot press numbers while the calculator is displaying a result
            {
                
            }
            else
            {
            Button b = (Button)sender; //convert button press
            resultbox.Text = resultbox.Text + b.Text; //outbut button press 
            }
        }

        private void button_CE_click(object sender, EventArgs e) //Clear everything button main function 
        {
            resultbox.Text = "0";
            equation.Text = "0";
            value = 0;
            op_press = false;
            eq_press = false;
        }
        //all the function keys are the same: they convert to button press, put operator used into op, then clear 
        private void button_add_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            op = b.Text;
            value = Double.Parse(resultbox.Text);
            op_press = true;
            equation.Text = value + " " + op;
            resultbox.Text = "0";
            eq_press = false; //reset on eq_press parameter to allow further use 
        }
        private void button_min_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            op = b.Text;
            value = Double.Parse(resultbox.Text);
            op_press = true;
            equation.Text = value + " " + op;
            resultbox.Text = "0";
            eq_press = false;
        }

        private void button_mul_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            op = b.Text;
            value = Double.Parse(resultbox.Text);
            op_press = true;
            equation.Text = value + " " + op;
            resultbox.Text = "0";
            eq_press = false;
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            op = b.Text;
            value = Double.Parse(resultbox.Text);
            op_press = true;
            equation.Text = value + " " + op;
            resultbox.Text = "0";
            eq_press = false;
        }

        private void button_C_Click(object sender, EventArgs e) //only clears what is in the resultbox
        {
            if (eq_press == true) //This is so people cannot clear while result is up, that would be silly
            {

            }
            else
            resultbox.Text = "0";
        }
        private void button_neg_Click(object sender, EventArgs e)
        {
            double tval;
            if (resultbox.Text == "0") //to ensure -0 does not exist 
            {

            }    
            else
            {
            Button b = (Button)sender;
            tval = -Double.Parse(resultbox.Text);   //converts the box to a negative 
            resultbox.Text = Convert.ToString(tval);
            }
        }
        private void button_eq_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case "+":
                    resultbox.Text = (value + double.Parse(resultbox.Text)).ToString();
                    break;
                case "-":
                    resultbox.Text = (value - double.Parse(resultbox.Text)).ToString();
                    break;
                case "/":
                    resultbox.Text = (value / double.Parse(resultbox.Text)).ToString();
                    break;
                case "*":
                    resultbox.Text = (value * double.Parse(resultbox.Text)).ToString();
                    break;
                default:
                    break;
            }
            equation.Text = resultbox.Text;
            op_press = false;
            eq_press = true;
        }
    }
}


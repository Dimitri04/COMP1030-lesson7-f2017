using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wk7_After_StrikeClass1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoop1_Click(object sender, EventArgs e)
        {
            //Removes the instructions from the label
            lblMsg1.Text = "";
            //use a loop to display # from 100 to 120 on our label
            //for loop structure: start #; Condition for Continuing; Increment
            //Counter ++ is the same as counter = counter + 1
            for (Int32 counter = 100; counter <= 120; counter += 2)
            {
                lblMsg1.Text += counter.ToString() + " ";
            }
        }

        private void btnWhileLoop_Click(object sender, EventArgs e)
        {
            //Removes the instructions from the label
            lblMsg1.Text = "";

            //Set start number to 100
            Int32 counter = 100;

            //use a while loop to display from 100 to 120
            while (counter <= 120)
            {
                lblMsg1.Text += counter.ToString() + " ";

                //Increment counter
                counter++;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Int32 value1 = 0, value2 = 0, result = 0;
            //store input from use in X and Y text box
            value1 = Convert.ToInt32(txtX.Text);
            value2 = Convert.ToInt32(txtY.Text);

            //call addNumbers function and store results in result variable
            result  = addNumbers(value1, value2);

            //dispaly results
            lblMsg2.Text = Convert.ToString(result);
        }

        private Int32 addNumbers(Int32 x, Int32 y)
        {
            Int32 sum = 0;
            //add x and y values together and store results in sum variable
            sum = x + y;
            //return sum
            return sum;
        }
    }
}

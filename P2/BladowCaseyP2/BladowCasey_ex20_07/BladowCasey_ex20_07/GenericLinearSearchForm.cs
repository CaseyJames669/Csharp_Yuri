using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BladowCasey_ex20_07
{
    public partial class GenericLinearSearchForm : Form
    {
        int[] array1 = new int[20];
        double[] array2 = new double[20];
        bool createInt;
        public GenericLinearSearchForm()
        {
            InitializeComponent();
        }

        private void createIntegersButton_Click(object sender, EventArgs e)
        {
            //create array that prints index values and the actual values in textbox
            /*
             * Index   Values
             * 0        345
             * 1        877
             * 2        202
             * 3        743
             * 4        etc...
             * 5
             * 6
             * 7
             * 8
             * 9
             * 10
             * 11
             * 12
             * 13
             * 14
             * 15
             * 16
             * 17
             * 18
             * 19
             * 
             * */
            string str = "Here\r\nshould be\r\ninteger\r\nvalues!";
            textBox.Text = str;
        }

        private void createDoublesButton_Click(object sender, EventArgs e)
        {
            //create array that prints index values and the actual values in textbox
            /*
            * Index   Values
            * 0        32.03
            * 1        88.45
            * 2        20.34
            * 3        74.67
            * 4        etc...
            * 5
            * 6
            * 7
            * 8
            * 9
            * 10
            * 11
            * 12
            * 13
            * 14
            * 15
            * 16
            * 17
            * 18
            * 19
            * 
            * */
            MessageBox.Show("hello from Generic Search", "Generic Search", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //takes value from inputTextBox and searches for it through the array
            //print either 'value not found' or 'found value in index (index position)'
            resultLabel.Text = "Example from the create button";
        }
    }
}

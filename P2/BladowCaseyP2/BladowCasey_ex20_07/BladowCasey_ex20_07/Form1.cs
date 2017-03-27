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
    public partial class Form1 : Form
    {
        int[] array1 = new int[20];
        double[] array2 = new double[20];
        bool createInt;
        public Form1()
        {
            InitializeComponent();
        }

        private void createIntegersButton_Click(object sender, EventArgs e)
        {
            Random randomNumber = new Random();
            string output = "Index\tValue\r\n";

            //Create string containing 20 random numbers
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = randomNumber.Next(1000);
                output += (i + "\t" + array1[i] + "\r\n");
                textBox.Text = output;

            }
            createInt = false;
            searchButton.Enabled = true;
        }

        private void createDoublesButton_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            Random randomNumber = new Random();
            string output2 = "Index\tValue\r\n";

            //Create string containing 20 random numbers
            for (int j = 0; j < array2.Length; j++)
            {
                array2[j] = Math.Round(randomNumber.NextDouble() * 1000, 2);
                output2 += (j + "\t" + array2[j] + "\r\n");
                textBox.Text = output2;

            }
            createInt = true;
            searchButton.Enabled = true;
        }
        
        private void searchButton_Click(object sender, EventArgs e)
        {
            int index;
            if (createInt == true)
                index = GenericLinearSearch.DisplayArray<double>(array2, Convert.ToDouble(inputTextBox.Text));
            else
                index = GenericLinearSearch.DisplayArray<int>(array1, Convert.ToInt32(inputTextBox.Text));

            if (index >= 0)
                resultLabel.Text = string.Format("found value at index {0}", index);

            else
                resultLabel.Text = "value not found"; 
        }
    }
}

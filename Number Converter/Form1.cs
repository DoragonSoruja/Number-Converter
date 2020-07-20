using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string wordNumber = "";

        string[] oneToNineTeen = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        string[] ten = new string[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        string[] tens = new string[] { "", "", "Twenty ", "Thirty ", "Forty ", "Fifty ", "Sixty ", "Seventy ", "Eighty ", "Ninty " };

        private void convertButton_Click(object sender, EventArgs e)
        {
            wordNumber = tens[Int64.Parse(userInput.Text) % 100 / 10] + oneToNineTeen[Int64.Parse(userInput.Text) % 10];
            results.Text = wordNumber;
        }

        
    }
}

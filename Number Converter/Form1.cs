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
            if (Int64.Parse(userInput.Text) < 20 && Int64.Parse(userInput.Text) > 9)
            {
                switch (Int64.Parse(userInput.Text))
                {
                    case 10:
                        wordNumber = "Ten";
                        break;
                    case 11:
                        wordNumber = "Eleven";
                        break;
                    case 12:
                        wordNumber = "Twelve";
                        break;
                    case 13:
                        wordNumber = "Thirteen";
                        break;
                    case 14:
                        wordNumber = "Fourteen";
                        break;
                    case 15:
                        wordNumber = "Ten";
                        break;
                    case 16:
                        wordNumber = "Ten";
                        break;
                    case 17:
                        wordNumber = "Ten";
                        break;
                    case 18:
                        wordNumber = "Ten";
                        break;
                    case 19:
                        wordNumber = "Ten";
                        break;
                }
            }
            else
            {
                wordNumber = tens[Int64.Parse(userInput.Text) % 100 / 10] + oneToNineTeen[Int64.Parse(userInput.Text) % 10];
            }
            results.Text = wordNumber;
        }

        
    }
}

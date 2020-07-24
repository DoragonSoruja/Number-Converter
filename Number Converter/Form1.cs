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

        ///////////////////////////////////
        //Numerals to Decimal
        ///////////////////////////////////
        private void convertButtonTwo_Click(object sender, EventArgs e)
        {
            if (userInput.Text == "")
            {
                MessageBox.Show("Please enter in a valid number");
                return;
            }
            results.Text = WordsToNumber(userInput.Text.Trim()).ToString();
        }

        public static long WordsToNumber(string number)
        {
            long numberWord = 0;
            long tempNum = 0;
            number = number.Replace('-', ' ').ToLower();
            string[] numberArr = number.Split(' ');
            foreach(string word in numberArr)
            {
                switch(word.Trim())
                {
                    case "one":
                        tempNum += 1;
                        break;
                    case "two":
                        tempNum += 2;
                        break;
                    case "three":
                        tempNum += 3;
                        break;
                    case "four":
                        tempNum += 4;
                        break;
                    case "five":
                        tempNum += 5;
                        break;
                    case "six":
                        tempNum += 6;
                        break;
                    case "seven":
                        tempNum += 7;
                        break;
                    case "eight":
                        tempNum += 8;
                        break;
                    case "nine":
                        tempNum += 9;
                        break;
                    case "ten":
                        tempNum += 10;
                        break;
                    case "eleven":
                        tempNum += 11;
                        break;
                    case "twelve":
                        tempNum += 12;
                        break;
                    case "thirteen":
                        tempNum += 13;
                        break;
                    case "fourteen":
                        tempNum += 14;
                        break;
                    case "fifteen":
                        tempNum += 15;
                        break;
                    case "sixteen":
                        tempNum += 16;
                        break;
                    case "seventeen":
                        tempNum += 17;
                        break;
                    case "eighteen":
                        tempNum += 18;
                        break;
                    case "nineteen":
                        tempNum += 19;
                        break;
                    case "twenty":
                        tempNum += 20;
                        break;
                    case "thirty":
                        tempNum += 30;
                        break;
                    case "forty":
                        tempNum += 40;
                        break;
                    case "fifty":
                        tempNum += 50;
                        break;
                    case "sixty":
                        tempNum += 60;
                        break;
                    case "seventy":
                        tempNum += 70;
                        break;
                    case "eighty":
                        tempNum += 80;
                        break;
                    case "ninety":
                        tempNum += 90;
                        break;
                    case "hundred":
                        tempNum *= 100;
                        break;
                    case "thousand":
                        numberWord += tempNum * 1000;
                        tempNum = 0;
                        break;
                    case "million":
                        numberWord += tempNum * 1000000;
                        tempNum = 0;
                        break;
                    case "billion":
                        numberWord += tempNum * 1000000000;
                        tempNum = 0;
                        break;
                    case "trillion":
                        numberWord += tempNum * 1000000000000;
                        tempNum = 0;
                        break;
                }
            }
            numberWord += tempNum;
            return numberWord;
        }

        ///////////////////////////////////
        //Decimal to Numerals
        ///////////////////////////////////
        private void convertButton_Click(object sender, EventArgs e)
        {
            if(userInput.Text == "")
            {
                MessageBox.Show("Please enter in a valid number");
                return;
            }
            long userNumber = Int64.Parse(userInput.Text);
            wordNumber = NumberToWords(userNumber);
            results.Text = wordNumber;
        }

        public static string NumberToWords(long number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000000000) > 0)
            {
                words += NumberToWords(number / 1000000000000) + " trillion ";
                number %= 1000000000000;
            }

            if ((number / 1000000000) > 0)
            {
                words += NumberToWords(number / 1000000000) + " billion ";
                number %= 1000000000;
            }

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }

        ///////////////////////////////////
        //Enter and Leave methods for text box tips
        ///////////////////////////////////
        private void numberToWords_Enter(object sender, EventArgs e)
        {
            if (userInput.Text == "Ex: 28, 549")
            {
                userInput.Text = "";
                userInput.ForeColor = Color.Black;
            }
        }

        private void numberToWords_Leave(object sender, EventArgs e)
        {
            if (userInput.Text == "")
            {
                userInput.Text = "Ex: 28, 549";
                userInput.ForeColor = Color.Silver;
            }
        }

        private void wordsToNumber_Enter(object sender, EventArgs e)
        {
            if (userInput.Text == "Ex: Two Hundred Fifty Seven, Forty-Nine")
            {
                userInput.Text = "";
                userInput.ForeColor = Color.Black;
            }
        }

        private void wordsToNumber_Leave(object sender, EventArgs e)
        {
            if (userInput.Text == "")
            {
                userInput.Text = "Ex: Two Hundred Fifty Seven, Forty-Nine";
                userInput.ForeColor = Color.Silver;
            }
        }

        ///////////////////////////////////
        //Menu Strip GUI changes
        ///////////////////////////////////
        private void numberToWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clear Textboxes
            results.Clear();
            userInput.Clear();

            //Tips
            description.Text = "Whole Numbers";
            userInput.Text = "Ex: 28, 549";

            //Relocations and Resizes
            results.Size = new Size(276, 62);
            userInput.Size = new Size(190, 22);
            convertButton.Location = new Point(355, 55);
            results.Size = new Size(276, 62);
            userInput.MaxLength = 10;

            // Methods Changes
            this.userInput.Enter -= new EventHandler(this.wordsToNumber_Enter);
            this.userInput.Leave -= new EventHandler(this.wordsToNumber_Leave);
            this.userInput.Enter += new EventHandler(this.numberToWords_Enter);
            this.userInput.Leave += new EventHandler(this.numberToWords_Leave);
            this.convertButton.Click -= new EventHandler(this.convertButtonTwo_Click);
            this.convertButton.Click += new EventHandler(this.convertButton_Click);
        }

        private void wordsToNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tips
            description.Text = "English Numerals";
            userInput.Text = "Ex: Two Hundred Fifty Seven, Forty-Nine";

            //Relocations and Resizes
            userInput.Size = new Size(271, 52);
            convertButton.Location = new Point(355, 112);
            results.Size = new Size(276, 22);
            userInput.MaxLength = 100;

            // Methods Changes
            this.userInput.Enter -= new EventHandler(this.numberToWords_Enter);
            this.userInput.Leave -= new EventHandler(this.numberToWords_Leave);
            this.userInput.Enter += new EventHandler(this.wordsToNumber_Enter);
            this.userInput.Leave += new EventHandler(this.wordsToNumber_Leave);
            this.convertButton.Click -= new EventHandler(this.convertButton_Click);
            this.convertButton.Click += new EventHandler(this.convertButtonTwo_Click);
        }
    }
}

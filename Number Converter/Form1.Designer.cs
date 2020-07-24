namespace Number_Converter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberToWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordsToNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userInput = new System.Windows.Forms.RichTextBox();
            this.description = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a number:";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(355, 55);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 21);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your number is:";
            // 
            // results
            // 
            this.results.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results.Location = new System.Drawing.Point(154, 160);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(276, 62);
            this.results.TabIndex = 5;
            this.results.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(485, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberToWordsToolStripMenuItem,
            this.wordsToNumberToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // numberToWordsToolStripMenuItem
            // 
            this.numberToWordsToolStripMenuItem.Name = "numberToWordsToolStripMenuItem";
            this.numberToWordsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.numberToWordsToolStripMenuItem.Text = "Number To Words";
            this.numberToWordsToolStripMenuItem.Click += new System.EventHandler(this.numberToWordsToolStripMenuItem_Click);
            // 
            // wordsToNumberToolStripMenuItem
            // 
            this.wordsToNumberToolStripMenuItem.Name = "wordsToNumberToolStripMenuItem";
            this.wordsToNumberToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.wordsToNumberToolStripMenuItem.Text = "Words To Number";
            this.wordsToNumberToolStripMenuItem.Click += new System.EventHandler(this.wordsToNumberToolStripMenuItem_Click);
            // 
            // userInput
            // 
            this.userInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInput.Location = new System.Drawing.Point(159, 55);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(190, 22);
            this.userInput.TabIndex = 9;
            this.userInput.Text = "";
            this.userInput.Enter += new System.EventHandler(this.numberToWords_Enter);
            this.userInput.Leave += new System.EventHandler(this.numberToWords_Leave);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(52, 84);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(96, 15);
            this.description.TabIndex = 10;
            this.description.Text = "Whole Numbers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 271);
            this.Controls.Add(this.description);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.results);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Number Converter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox results;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberToWordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordsToNumberToolStripMenuItem;
        private System.Windows.Forms.RichTextBox userInput;
        private System.Windows.Forms.Label description;
    }
}


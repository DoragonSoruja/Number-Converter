﻿namespace Number_Converter
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
            this.userInput = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // userInput
            // 
            this.userInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInput.Location = new System.Drawing.Point(159, 55);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(190, 21);
            this.userInput.TabIndex = 1;
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
            // results
            // 
            this.results.AutoSize = true;
            this.results.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results.Location = new System.Drawing.Point(154, 156);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(0, 24);
            this.results.TabIndex = 3;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 273);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.results);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label results;
        private System.Windows.Forms.Label label2;
    }
}


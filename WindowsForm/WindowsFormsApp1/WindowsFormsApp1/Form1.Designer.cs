namespace WindowsFormsApp1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.enterStringLabel = new System.Windows.Forms.Label();
            this.StringList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1.Location = new System.Drawing.Point(166, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 29);
            this.textBox1.TabIndex = 0;
            // 
            // submitButton
            // 
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.submitButton.Location = new System.Drawing.Point(354, 59);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 30);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // enterStringLabel
            // 
            this.enterStringLabel.AutoSize = true;
            this.enterStringLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.enterStringLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enterStringLabel.Location = new System.Drawing.Point(35, 62);
            this.enterStringLabel.Name = "enterStringLabel";
            this.enterStringLabel.Size = new System.Drawing.Size(125, 24);
            this.enterStringLabel.TabIndex = 2;
            this.enterStringLabel.Text = "Enter a string:";
            // 
            // StringList
            // 
            this.StringList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.StringList.FormattingEnabled = true;
            this.StringList.ItemHeight = 25;
            this.StringList.Location = new System.Drawing.Point(166, 134);
            this.StringList.Name = "StringList";
            this.StringList.Size = new System.Drawing.Size(263, 229);
            this.StringList.Sorted = true;
            this.StringList.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.StringList);
            this.Controls.Add(this.enterStringLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label enterStringLabel;
        private System.Windows.Forms.ListBox StringList;
    }
}


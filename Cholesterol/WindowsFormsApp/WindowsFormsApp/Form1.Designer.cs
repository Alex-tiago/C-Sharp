namespace WindowsFormsApp
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
            this.labelValues = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTri = new System.Windows.Forms.TextBox();
            this.textBoxHDL = new System.Windows.Forms.TextBox();
            this.textBoxLDL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelValues
            // 
            this.labelValues.AutoSize = true;
            this.labelValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelValues.ForeColor = System.Drawing.Color.White;
            this.labelValues.Location = new System.Drawing.Point(48, 26);
            this.labelValues.Name = "labelValues";
            this.labelValues.Size = new System.Drawing.Size(114, 24);
            this.labelValues.TabIndex = 0;
            this.labelValues.Text = "Enter values";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Triglycerides:";
            // 
            // textBoxTri
            // 
            this.textBoxTri.Location = new System.Drawing.Point(147, 62);
            this.textBoxTri.Name = "textBoxTri";
            this.textBoxTri.Size = new System.Drawing.Size(41, 20);
            this.textBoxTri.TabIndex = 5;
            // 
            // textBoxHDL
            // 
            this.textBoxHDL.Location = new System.Drawing.Point(147, 99);
            this.textBoxHDL.Name = "textBoxHDL";
            this.textBoxHDL.Size = new System.Drawing.Size(41, 20);
            this.textBoxHDL.TabIndex = 6;
            // 
            // textBoxLDL
            // 
            this.textBoxLDL.Location = new System.Drawing.Point(147, 136);
            this.textBoxLDL.Name = "textBoxLDL";
            this.textBoxLDL.Size = new System.Drawing.Size(41, 20);
            this.textBoxLDL.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "HDL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(54, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "LDL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(54, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Cholesterol:";
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelResults.ForeColor = System.Drawing.Color.White;
            this.labelResults.Location = new System.Drawing.Point(172, 206);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(0, 20);
            this.labelResults.TabIndex = 11;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(101, 174);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 12;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(194, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "mg/dl";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(194, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "mg/dl";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(194, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "mg/dl";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(281, 305);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLDL);
            this.Controls.Add(this.textBoxHDL);
            this.Controls.Add(this.textBoxTri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelValues);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTri;
        private System.Windows.Forms.TextBox textBoxHDL;
        private System.Windows.Forms.TextBox textBoxLDL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}


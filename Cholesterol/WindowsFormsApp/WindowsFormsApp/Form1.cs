using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int Triglycerides = 0;
            int HDL = 0;
            int LDL = 0;

            Triglycerides = int.Parse(textBoxTri.Text);
            HDL = int.Parse(textBoxHDL.Text);
            LDL = int.Parse(textBoxLDL.Text);

            //LDL + HDL + (triglycerides/5) = total cholesterol
            int results = LDL + HDL + (Triglycerides / 5);
            labelResults.Text = results.ToString();
        }

        
    }
}

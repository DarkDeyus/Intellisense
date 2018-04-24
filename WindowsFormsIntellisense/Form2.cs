using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsIntellisense
{
    public partial class Form2 : Form
    {
        public string result ="";
        public Form2()
        {
            InitializeComponent();
            textBox1.Select();
        }

        public Form2(string arg)
        {
            InitializeComponent();
            result = arg;
            textBox1.Select();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            result = "";
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            
            ErrorProvider ep = new ErrorProvider();
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                ep.SetError(textBox1, "Text cannot be empty!");
                MessageBox.Show("Error", "Verification error!", MessageBoxButtons.OK);              
                return;

            }
            //foreach (char c in textBox1.Text)
            //    if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || c=='ą' || c =='ę' || c == 'ź' || c =='ż' || c =='ł' || c =='ó' || c =='ś' || c =='ć' || c =='Ą' || c =='Ę' || c =='Ż' || c =='Ź' || c =='Ł' || c == 'Ó' || c == 'Ś' || c == 'Ć'))
            //    {
            //        ep.SetError(textBox1, "Only letters are allowed");
            //        MessageBox.Show("Error", "Verification error!", MessageBoxButtons.OK);
            //        return;
            //    }                           
            if(!textBox1.Text.All(Char.IsLetter))
            {
                ep.SetError(textBox1, "Only letters are allowed");
                MessageBox.Show("Error", "Verification error!", MessageBoxButtons.OK);
                return;
            }
            this.DialogResult = DialogResult.OK;
            result = textBox1.Text;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = result;
        }
    }
}

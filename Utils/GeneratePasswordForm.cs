using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EncryptorDecryptorRijndael.Utils
{
    public partial class GeneratePasswordForm : Form
    {
        public GeneratePasswordForm(NumericUpDown mainFormKeyLength, MaskedTextBox mainFormKey1, MaskedTextBox mainFormKey2)
        {
            InitializeComponent();
            generator = new PasswordGenerator();
            password = generator.generatePassword((int)keyLengthNumericUpDown.Value);
            richTextBox1.Text="your password: "+Environment.NewLine+password;

            //this.mainFormKeyLength = mainFormKeyLength;
            this.mainFormKey1 = mainFormKey1;
            this.mainFormKey2 = mainFormKey2;
        }

        private void generateKeyButton_Click(object sender, EventArgs e)
        {
            password=generator.generatePassword((int)keyLengthNumericUpDown.Value);
            richTextBox1.Text = "your password: " + Environment.NewLine + password;
        }

        private void setKeyButton_Click(object sender, EventArgs e)
        {
            //mainFormKeyLength.Value = keyLengthNumericUpDown.Value;
            mainFormKey1.Text = mainFormKey2.Text = password;
        }

        private string password;
        private PasswordGenerator generator;
        //private NumericUpDown mainFormKeyLength;
        private MaskedTextBox mainFormKey1, mainFormKey2;
    }
}

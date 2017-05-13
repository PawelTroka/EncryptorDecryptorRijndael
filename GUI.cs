using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EncryptorDecryptorRijndael
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
            modeComboBox.Text = "CBC";
            encryptBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(encryptBackgroundWorker_RunWorkerCompleted);
            decryptBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(decryptBackgroundWorker_RunWorkerCompleted);
        }

        void decryptBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                System.Windows.Forms.MessageBox.Show("Error:" + e.Error);
                decryptProgressBar.Value = 0;
            }
            else if (e.Cancelled)
            {
                System.Windows.Forms.MessageBox.Show("Decryption task was cancelled by user!");
                decryptProgressBar.Value = 0;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Decryption task completed!");
                decryptProgressBar.Value = 100;
            }
            cancelDecryptButton.Enabled = false; startDecryptButton.Enabled = true;
            decryptBackgroundWorker.DoWork -= decryptor.decrypt;
        }

        void encryptBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + e.Error);
                encryptProgressBar.Value = 0;
            }
            else if (e.Cancelled)
            {
                System.Windows.Forms.MessageBox.Show("Encryption task was cancelled by user!");
                encryptProgressBar.Value = 0;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Encryption task completed!");
                encryptProgressBar.Value = 100;
            }
            cancelEncryptButton.Enabled = false; startEncryptButton.Enabled = true;
            encryptBackgroundWorker.DoWork -= encryptor.encrypt;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paweł Troka 132334");
        }

        private void startEncryptButton_Click(object sender, EventArgs e)
        {
            if (Encrypt.BaseEncrypt.validatePassword(encryptPasswordMaskedTextBox.Text, encryptRepeatPasswordMaskedTextBox.Text))
            {
                cancelEncryptButton.Enabled = true; startEncryptButton.Enabled = false;
                try
                {
                    encryptor = new Encrypt.Encryptor(encryptInputFileTextBox.Text, encryptOutputFileTextBox.Text, (int)keyLengthNumericUpDown.Value, (int)blockSizeNumericUpDown.Value, (string)modeComboBox.SelectedItem, encryptPasswordMaskedTextBox.Text, (int)feedbackSizeNumericUpDown.Value);
                    encryptBackgroundWorker.DoWork += encryptor.encrypt;
                    encryptBackgroundWorker.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cancelEncryptButton.Enabled = false; startEncryptButton.Enabled = true;
                }
            }
        }

        private void cancelEncryptButton_Click(object sender, EventArgs e)
        {
            if (encryptBackgroundWorker.IsBusy)
            {
                encryptBackgroundWorker.CancelAsync();
                cancelEncryptButton.Enabled = false; startEncryptButton.Enabled = true;
            }
        }

        private void encryptChooseInputFileButton_Click(object sender, EventArgs e)
        {
            var result = inputEncryptOpenFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                encryptInputFileTextBox.Text = inputEncryptOpenFileDialog.FileName;
            }
        }

        private void encryptChooseOutputFileButton_Click(object sender, EventArgs e)
        {
            var result = outputEncryptOpenFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                encryptOutputFileTextBox.Text = outputEncryptOpenFileDialog.FileName;
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            encryptProgressBar.Value = e.ProgressPercentage;
        }

        private void keyGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var keyGenerator = new Utils.GeneratePasswordForm(keyLengthNumericUpDown, encryptPasswordMaskedTextBox, encryptRepeatPasswordMaskedTextBox);
            keyGenerator.Show();
        }

        private void feedbackSizeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (feedbackSizeNumericUpDown.Value > blockSizeNumericUpDown.Value)
            {
                MessageBox.Show("Feedback size cannot be larger than block size!", "Error");
                feedbackSizeNumericUpDown.Value = blockSizeNumericUpDown.Value;
            }
        }

        private void modeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modeComboBox.SelectedItem.ToString() == "CFB" || modeComboBox.SelectedItem.ToString() == "OFB")
            {
                bitsLabel.Visible = feedbackSizeNumericUpDown.Visible = feedbackSizeLabel.Visible = true;
            }
            else
            {
                bitsLabel.Visible = feedbackSizeNumericUpDown.Visible = feedbackSizeLabel.Visible = false;
            }
        }

        private void decryptInputChooseFileButton_Click(object sender, EventArgs e)
        {
            var result = inputEncryptOpenFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                decryptInputFileTextBox.Text = inputEncryptOpenFileDialog.FileName;
            }
        }

        private void decryptOutputChooseFileButton_Click(object sender, EventArgs e)
        {
            var result = outputEncryptOpenFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                decryptOutputFileTextBox.Text = outputEncryptOpenFileDialog.FileName;
            }
        }

        private void startDecryptButton_Click(object sender, EventArgs e)
        {
            cancelDecryptButton.Enabled = true; startDecryptButton.Enabled = false;
            try
            {
                decryptor = new Encrypt.Decryptor(decryptInputFileTextBox.Text, decryptOutputFileTextBox.Text, decryptPasswordMaskedTextBox.Text);
                decryptBackgroundWorker.DoWork += decryptor.decrypt;
                decryptBackgroundWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cancelDecryptButton.Enabled = false; startDecryptButton.Enabled = true;
            }
        }

        private void decryptBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            decryptProgressBar.Value = e.ProgressPercentage;
        }


        private Encrypt.Encryptor encryptor;
        private Encrypt.Decryptor decryptor;
    }
}

namespace EncryptorDecryptorRijndael
{
    partial class GUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.utilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cancelEncryptButton = new System.Windows.Forms.Button();
            this.encryptProgressBar = new System.Windows.Forms.ProgressBar();
            this.startEncryptButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.feedbackSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bitsLabel = new System.Windows.Forms.Label();
            this.feedbackSizeLabel = new System.Windows.Forms.Label();
            this.modeComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.blockSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.keyLengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.encryptRepeatPasswordMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.encryptPasswordMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.encryptChooseOutputFileButton = new System.Windows.Forms.Button();
            this.encryptOutputFileTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.encryptChooseInputFileButton = new System.Windows.Forms.Button();
            this.encryptInputFileTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cancelDecryptButton = new System.Windows.Forms.Button();
            this.decryptProgressBar = new System.Windows.Forms.ProgressBar();
            this.startDecryptButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.decryptPasswordMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.decryptOutputChooseFileButton = new System.Windows.Forms.Button();
            this.decryptOutputFileTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.decryptInputChooseFileButton = new System.Windows.Forms.Button();
            this.decryptInputFileTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.errorsTextBox = new System.Windows.Forms.RichTextBox();
            this.encryptBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.inputEncryptOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.outputEncryptOpenFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.decryptBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackSizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockSizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyLengthNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // utilsToolStripMenuItem
            // 
            this.utilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keyGeneratorToolStripMenuItem});
            this.utilsToolStripMenuItem.Name = "utilsToolStripMenuItem";
            this.utilsToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
            this.utilsToolStripMenuItem.Text = "Utils";
            // 
            // keyGeneratorToolStripMenuItem
            // 
            this.keyGeneratorToolStripMenuItem.Name = "keyGeneratorToolStripMenuItem";
            this.keyGeneratorToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.keyGeneratorToolStripMenuItem.Text = "Password generator";
            this.keyGeneratorToolStripMenuItem.Click += new System.EventHandler(this.keyGeneratorToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(58, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(598, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Size = new System.Drawing.Size(598, 441);
            this.splitContainer1.SplitterDistance = 358;
            this.splitContainer1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(598, 358);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cancelEncryptButton);
            this.tabPage1.Controls.Add(this.encryptProgressBar);
            this.tabPage1.Controls.Add(this.startEncryptButton);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(590, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cancelEncryptButton
            // 
            this.cancelEncryptButton.Enabled = false;
            this.cancelEncryptButton.Location = new System.Drawing.Point(8, 300);
            this.cancelEncryptButton.Name = "cancelEncryptButton";
            this.cancelEncryptButton.Size = new System.Drawing.Size(151, 23);
            this.cancelEncryptButton.TabIndex = 4;
            this.cancelEncryptButton.Text = "Cancel";
            this.cancelEncryptButton.UseVisualStyleBackColor = true;
            this.cancelEncryptButton.Click += new System.EventHandler(this.cancelEncryptButton_Click);
            // 
            // encryptProgressBar
            // 
            this.encryptProgressBar.Location = new System.Drawing.Point(165, 254);
            this.encryptProgressBar.Name = "encryptProgressBar";
            this.encryptProgressBar.Size = new System.Drawing.Size(414, 69);
            this.encryptProgressBar.Step = 1;
            this.encryptProgressBar.TabIndex = 3;
            // 
            // startEncryptButton
            // 
            this.startEncryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startEncryptButton.Location = new System.Drawing.Point(9, 254);
            this.startEncryptButton.Name = "startEncryptButton";
            this.startEncryptButton.Size = new System.Drawing.Size(150, 40);
            this.startEncryptButton.TabIndex = 2;
            this.startEncryptButton.Text = "Start encrypt!";
            this.startEncryptButton.UseVisualStyleBackColor = true;
            this.startEncryptButton.Click += new System.EventHandler(this.startEncryptButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.feedbackSizeNumericUpDown);
            this.groupBox2.Controls.Add(this.bitsLabel);
            this.groupBox2.Controls.Add(this.feedbackSizeLabel);
            this.groupBox2.Controls.Add(this.modeComboBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.blockSizeNumericUpDown);
            this.groupBox2.Controls.Add(this.keyLengthNumericUpDown);
            this.groupBox2.Controls.Add(this.encryptRepeatPasswordMaskedTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.encryptPasswordMaskedTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rijndael Options";
            // 
            // feedbackSizeNumericUpDown
            // 
            this.feedbackSizeNumericUpDown.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.feedbackSizeNumericUpDown.Location = new System.Drawing.Point(382, 61);
            this.feedbackSizeNumericUpDown.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.feedbackSizeNumericUpDown.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.feedbackSizeNumericUpDown.Name = "feedbackSizeNumericUpDown";
            this.feedbackSizeNumericUpDown.Size = new System.Drawing.Size(53, 22);
            this.feedbackSizeNumericUpDown.TabIndex = 16;
            this.feedbackSizeNumericUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.feedbackSizeNumericUpDown.Visible = false;
            this.feedbackSizeNumericUpDown.ValueChanged += new System.EventHandler(this.feedbackSizeNumericUpDown_ValueChanged);
            // 
            // bitsLabel
            // 
            this.bitsLabel.AutoSize = true;
            this.bitsLabel.Location = new System.Drawing.Point(441, 64);
            this.bitsLabel.Name = "bitsLabel";
            this.bitsLabel.Size = new System.Drawing.Size(30, 17);
            this.bitsLabel.TabIndex = 15;
            this.bitsLabel.Text = "bits";
            this.bitsLabel.Visible = false;
            // 
            // feedbackSizeLabel
            // 
            this.feedbackSizeLabel.AutoSize = true;
            this.feedbackSizeLabel.Location = new System.Drawing.Point(273, 63);
            this.feedbackSizeLabel.Name = "feedbackSizeLabel";
            this.feedbackSizeLabel.Size = new System.Drawing.Size(103, 17);
            this.feedbackSizeLabel.TabIndex = 14;
            this.feedbackSizeLabel.Text = "Feedback size:";
            this.feedbackSizeLabel.Visible = false;
            // 
            // modeComboBox
            // 
            this.modeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeComboBox.FormattingEnabled = true;
            this.modeComboBox.Items.AddRange(new object[] {
            "CBC",
            "CFB",
            "ECB",
            "OFB"});
            this.modeComboBox.Location = new System.Drawing.Point(381, 31);
            this.modeComboBox.Name = "modeComboBox";
            this.modeComboBox.Size = new System.Drawing.Size(59, 24);
            this.modeComboBox.TabIndex = 13;
            this.modeComboBox.SelectedIndexChanged += new System.EventHandler(this.modeComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Mode:";
            // 
            // blockSizeNumericUpDown
            // 
            this.blockSizeNumericUpDown.Increment = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.blockSizeNumericUpDown.Location = new System.Drawing.Point(116, 61);
            this.blockSizeNumericUpDown.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.blockSizeNumericUpDown.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.blockSizeNumericUpDown.Name = "blockSizeNumericUpDown";
            this.blockSizeNumericUpDown.Size = new System.Drawing.Size(53, 22);
            this.blockSizeNumericUpDown.TabIndex = 11;
            this.blockSizeNumericUpDown.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            // 
            // keyLengthNumericUpDown
            // 
            this.keyLengthNumericUpDown.Increment = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.keyLengthNumericUpDown.Location = new System.Drawing.Point(116, 31);
            this.keyLengthNumericUpDown.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.keyLengthNumericUpDown.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.keyLengthNumericUpDown.Name = "keyLengthNumericUpDown";
            this.keyLengthNumericUpDown.Size = new System.Drawing.Size(53, 22);
            this.keyLengthNumericUpDown.TabIndex = 10;
            this.keyLengthNumericUpDown.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            // 
            // encryptRepeatPasswordMaskedTextBox
            // 
            this.encryptRepeatPasswordMaskedTextBox.AsciiOnly = true;
            this.encryptRepeatPasswordMaskedTextBox.BeepOnError = true;
            this.encryptRepeatPasswordMaskedTextBox.Culture = new System.Globalization.CultureInfo("");
            this.encryptRepeatPasswordMaskedTextBox.Location = new System.Drawing.Point(389, 97);
            this.encryptRepeatPasswordMaskedTextBox.Name = "encryptRepeatPasswordMaskedTextBox";
            this.encryptRepeatPasswordMaskedTextBox.PasswordChar = '*';
            this.encryptRepeatPasswordMaskedTextBox.Size = new System.Drawing.Size(178, 22);
            this.encryptRepeatPasswordMaskedTextBox.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Repeat password:";
            // 
            // encryptPasswordMaskedTextBox
            // 
            this.encryptPasswordMaskedTextBox.AsciiOnly = true;
            this.encryptPasswordMaskedTextBox.BeepOnError = true;
            this.encryptPasswordMaskedTextBox.Culture = new System.Globalization.CultureInfo("");
            this.encryptPasswordMaskedTextBox.Location = new System.Drawing.Point(85, 97);
            this.encryptPasswordMaskedTextBox.Name = "encryptPasswordMaskedTextBox";
            this.encryptPasswordMaskedTextBox.PasswordChar = '*';
            this.encryptPasswordMaskedTextBox.Size = new System.Drawing.Size(178, 22);
            this.encryptPasswordMaskedTextBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "bits";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Block size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Key length:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.encryptChooseOutputFileButton);
            this.groupBox1.Controls.Add(this.encryptOutputFileTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.encryptChooseInputFileButton);
            this.groupBox1.Controls.Add(this.encryptInputFileTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files";
            // 
            // encryptChooseOutputFileButton
            // 
            this.encryptChooseOutputFileButton.Location = new System.Drawing.Point(446, 62);
            this.encryptChooseOutputFileButton.Name = "encryptChooseOutputFileButton";
            this.encryptChooseOutputFileButton.Size = new System.Drawing.Size(102, 23);
            this.encryptChooseOutputFileButton.TabIndex = 5;
            this.encryptChooseOutputFileButton.Text = "Choose file";
            this.encryptChooseOutputFileButton.UseVisualStyleBackColor = true;
            this.encryptChooseOutputFileButton.Click += new System.EventHandler(this.encryptChooseOutputFileButton_Click);
            // 
            // encryptOutputFileTextBox
            // 
            this.encryptOutputFileTextBox.Location = new System.Drawing.Point(97, 62);
            this.encryptOutputFileTextBox.Name = "encryptOutputFileTextBox";
            this.encryptOutputFileTextBox.Size = new System.Drawing.Size(343, 22);
            this.encryptOutputFileTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output file:";
            // 
            // encryptChooseInputFileButton
            // 
            this.encryptChooseInputFileButton.Location = new System.Drawing.Point(446, 21);
            this.encryptChooseInputFileButton.Name = "encryptChooseInputFileButton";
            this.encryptChooseInputFileButton.Size = new System.Drawing.Size(102, 23);
            this.encryptChooseInputFileButton.TabIndex = 2;
            this.encryptChooseInputFileButton.Text = "Choose file";
            this.encryptChooseInputFileButton.UseVisualStyleBackColor = true;
            this.encryptChooseInputFileButton.Click += new System.EventHandler(this.encryptChooseInputFileButton_Click);
            // 
            // encryptInputFileTextBox
            // 
            this.encryptInputFileTextBox.Location = new System.Drawing.Point(97, 21);
            this.encryptInputFileTextBox.Name = "encryptInputFileTextBox";
            this.encryptInputFileTextBox.Size = new System.Drawing.Size(343, 22);
            this.encryptInputFileTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input file:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cancelDecryptButton);
            this.tabPage2.Controls.Add(this.decryptProgressBar);
            this.tabPage2.Controls.Add(this.startDecryptButton);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(590, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decrypt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cancelDecryptButton
            // 
            this.cancelDecryptButton.Enabled = false;
            this.cancelDecryptButton.Location = new System.Drawing.Point(9, 300);
            this.cancelDecryptButton.Name = "cancelDecryptButton";
            this.cancelDecryptButton.Size = new System.Drawing.Size(151, 23);
            this.cancelDecryptButton.TabIndex = 9;
            this.cancelDecryptButton.Text = "Cancel";
            this.cancelDecryptButton.UseVisualStyleBackColor = true;
            // 
            // decryptProgressBar
            // 
            this.decryptProgressBar.Location = new System.Drawing.Point(166, 254);
            this.decryptProgressBar.Name = "decryptProgressBar";
            this.decryptProgressBar.Size = new System.Drawing.Size(414, 69);
            this.decryptProgressBar.Step = 1;
            this.decryptProgressBar.TabIndex = 8;
            // 
            // startDecryptButton
            // 
            this.startDecryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startDecryptButton.Location = new System.Drawing.Point(10, 254);
            this.startDecryptButton.Name = "startDecryptButton";
            this.startDecryptButton.Size = new System.Drawing.Size(150, 40);
            this.startDecryptButton.TabIndex = 7;
            this.startDecryptButton.Text = "Start decrypt!";
            this.startDecryptButton.UseVisualStyleBackColor = true;
            this.startDecryptButton.Click += new System.EventHandler(this.startDecryptButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.decryptPasswordMaskedTextBox);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(7, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(573, 134);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rijndael Options";
            // 
            // decryptPasswordMaskedTextBox
            // 
            this.decryptPasswordMaskedTextBox.Location = new System.Drawing.Point(205, 61);
            this.decryptPasswordMaskedTextBox.Name = "decryptPasswordMaskedTextBox";
            this.decryptPasswordMaskedTextBox.PasswordChar = '*';
            this.decryptPasswordMaskedTextBox.Size = new System.Drawing.Size(178, 22);
            this.decryptPasswordMaskedTextBox.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(126, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Password:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.decryptOutputChooseFileButton);
            this.groupBox4.Controls.Add(this.decryptOutputFileTextBox);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.decryptInputChooseFileButton);
            this.groupBox4.Controls.Add(this.decryptInputFileTextBox);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Location = new System.Drawing.Point(7, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(576, 102);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Files";
            // 
            // decryptOutputChooseFileButton
            // 
            this.decryptOutputChooseFileButton.Location = new System.Drawing.Point(446, 62);
            this.decryptOutputChooseFileButton.Name = "decryptOutputChooseFileButton";
            this.decryptOutputChooseFileButton.Size = new System.Drawing.Size(102, 23);
            this.decryptOutputChooseFileButton.TabIndex = 5;
            this.decryptOutputChooseFileButton.Text = "Choose file";
            this.decryptOutputChooseFileButton.UseVisualStyleBackColor = true;
            this.decryptOutputChooseFileButton.Click += new System.EventHandler(this.decryptOutputChooseFileButton_Click);
            // 
            // decryptOutputFileTextBox
            // 
            this.decryptOutputFileTextBox.Location = new System.Drawing.Point(97, 62);
            this.decryptOutputFileTextBox.Name = "decryptOutputFileTextBox";
            this.decryptOutputFileTextBox.Size = new System.Drawing.Size(343, 22);
            this.decryptOutputFileTextBox.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 17);
            this.label17.TabIndex = 3;
            this.label17.Text = "Output file:";
            // 
            // decryptInputChooseFileButton
            // 
            this.decryptInputChooseFileButton.Location = new System.Drawing.Point(446, 21);
            this.decryptInputChooseFileButton.Name = "decryptInputChooseFileButton";
            this.decryptInputChooseFileButton.Size = new System.Drawing.Size(102, 23);
            this.decryptInputChooseFileButton.TabIndex = 2;
            this.decryptInputChooseFileButton.Text = "Choose file";
            this.decryptInputChooseFileButton.UseVisualStyleBackColor = true;
            this.decryptInputChooseFileButton.Click += new System.EventHandler(this.decryptInputChooseFileButton_Click);
            // 
            // decryptInputFileTextBox
            // 
            this.decryptInputFileTextBox.Location = new System.Drawing.Point(97, 21);
            this.decryptInputFileTextBox.Name = "decryptInputFileTextBox";
            this.decryptInputFileTextBox.Size = new System.Drawing.Size(343, 22);
            this.decryptInputFileTextBox.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(26, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 17);
            this.label18.TabIndex = 0;
            this.label18.Text = "Input file:";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(598, 79);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.outputTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(590, 50);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Output";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTextBox.Location = new System.Drawing.Point(3, 3);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(584, 44);
            this.outputTextBox.TabIndex = 0;
            this.outputTextBox.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.errorsTextBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(590, 50);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Errors";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // errorsTextBox
            // 
            this.errorsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorsTextBox.Location = new System.Drawing.Point(3, 3);
            this.errorsTextBox.Name = "errorsTextBox";
            this.errorsTextBox.Size = new System.Drawing.Size(584, 44);
            this.errorsTextBox.TabIndex = 0;
            this.errorsTextBox.Text = "";
            // 
            // encryptBackgroundWorker
            // 
            this.encryptBackgroundWorker.WorkerReportsProgress = true;
            this.encryptBackgroundWorker.WorkerSupportsCancellation = true;
            this.encryptBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            // 
            // decryptBackgroundWorker
            // 
            this.decryptBackgroundWorker.WorkerReportsProgress = true;
            this.decryptBackgroundWorker.WorkerSupportsCancellation = true;
            this.decryptBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.decryptBackgroundWorker_ProgressChanged);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 491);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUI";
            this.Text = "Encryptor-Decryptor Rijndael";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackSizeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockSizeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyLengthNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker encryptBackgroundWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button encryptChooseOutputFileButton;
        private System.Windows.Forms.TextBox encryptOutputFileTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button encryptChooseInputFileButton;
        private System.Windows.Forms.TextBox encryptInputFileTextBox;
        private System.Windows.Forms.OpenFileDialog inputEncryptOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog outputEncryptOpenFileDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox encryptPasswordMaskedTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox encryptRepeatPasswordMaskedTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button startEncryptButton;
        private System.Windows.Forms.ProgressBar encryptProgressBar;
        private System.Windows.Forms.Button cancelEncryptButton;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.RichTextBox errorsTextBox;
        private System.Windows.Forms.NumericUpDown keyLengthNumericUpDown;
        private System.Windows.Forms.NumericUpDown blockSizeNumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox modeComboBox;
        private System.Windows.Forms.Button cancelDecryptButton;
        private System.Windows.Forms.ProgressBar decryptProgressBar;
        private System.Windows.Forms.Button startDecryptButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox decryptPasswordMaskedTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button decryptOutputChooseFileButton;
        private System.Windows.Forms.TextBox decryptOutputFileTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button decryptInputChooseFileButton;
        private System.Windows.Forms.TextBox decryptInputFileTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown feedbackSizeNumericUpDown;
        private System.Windows.Forms.Label bitsLabel;
        private System.Windows.Forms.Label feedbackSizeLabel;
        private System.Windows.Forms.ToolStripMenuItem utilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyGeneratorToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker decryptBackgroundWorker;
    }
}


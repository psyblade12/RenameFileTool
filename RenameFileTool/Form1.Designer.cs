namespace RenameFileTool
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
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFileNames = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbNumbericOrder = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cbNumericOrder1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbNumericOrder2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdditionalText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSepChar = new System.Windows.Forms.TextBox();
            this.rbNumbericOrderWithNChars = new System.Windows.Forms.RadioButton();
            this.txtNumberOfChars = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbReplaceExtension = new System.Windows.Forms.RadioButton();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.rbReplaceFileName = new System.Windows.Forms.RadioButton();
            this.txtStringToBeReplaced = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNewString = new System.Windows.Forms.TextBox();
            this.rbChangeToUpperCase = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.rbChangeToLowerCase = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rbRandomName = new System.Windows.Forms.RadioButton();
            this.txtNumberOfRandomChars = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbAdditionalOption = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStartingNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbAdditionalOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(580, 19);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(108, 23);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Select Files";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFileNames
            // 
            this.txtFileNames.Location = new System.Drawing.Point(76, 21);
            this.txtFileNames.Name = "txtFileNames";
            this.txtFileNames.Size = new System.Drawing.Size(498, 20);
            this.txtFileNames.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Files:";
            // 
            // rbNumbericOrder
            // 
            this.rbNumbericOrder.AutoSize = true;
            this.rbNumbericOrder.Checked = true;
            this.rbNumbericOrder.Location = new System.Drawing.Point(20, 34);
            this.rbNumbericOrder.Name = "rbNumbericOrder";
            this.rbNumbericOrder.Size = new System.Drawing.Size(206, 17);
            this.rbNumbericOrder.TabIndex = 3;
            this.rbNumbericOrder.TabStop = true;
            this.rbNumbericOrder.Text = "Numerical order (ex: 1.jpg, 2.jpg, 3.jpg)";
            this.rbNumbericOrder.UseVisualStyleBackColor = true;
            this.rbNumbericOrder.CheckedChanged += new System.EventHandler(this.rbNumbericOrder_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Folder:";
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(76, 59);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(498, 20);
            this.txtFolderPath.TabIndex = 5;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(580, 56);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(108, 24);
            this.btnSelectFolder.TabIndex = 6;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(34, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Rename";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbNumericOrder1
            // 
            this.cbNumericOrder1.AutoSize = true;
            this.cbNumericOrder1.Location = new System.Drawing.Point(137, 22);
            this.cbNumericOrder1.Name = "cbNumericOrder1";
            this.cbNumericOrder1.Size = new System.Drawing.Size(88, 17);
            this.cbNumericOrder1.TabIndex = 8;
            this.cbNumericOrder1.Text = "To beginning";
            this.cbNumericOrder1.UseVisualStyleBackColor = true;
            this.cbNumericOrder1.CheckedChanged += new System.EventHandler(this.cbNumericOrder1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbAdditionalOption);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtNumberOfRandomChars);
            this.groupBox1.Controls.Add(this.rbRandomName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rbChangeToLowerCase);
            this.groupBox1.Controls.Add(this.rbChangeToUpperCase);
            this.groupBox1.Controls.Add(this.txtNewString);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtStringToBeReplaced);
            this.groupBox1.Controls.Add(this.rbReplaceFileName);
            this.groupBox1.Controls.Add(this.txtExtension);
            this.groupBox1.Controls.Add(this.rbReplaceExtension);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNumberOfChars);
            this.groupBox1.Controls.Add(this.rbNumbericOrderWithNChars);
            this.groupBox1.Controls.Add(this.rbNumbericOrder);
            this.groupBox1.Location = new System.Drawing.Point(14, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 328);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option";
            // 
            // cbNumericOrder2
            // 
            this.cbNumericOrder2.AutoSize = true;
            this.cbNumericOrder2.Location = new System.Drawing.Point(231, 23);
            this.cbNumericOrder2.Name = "cbNumericOrder2";
            this.cbNumericOrder2.Size = new System.Drawing.Size(60, 17);
            this.cbNumericOrder2.TabIndex = 8;
            this.cbNumericOrder2.Text = "To end";
            this.cbNumericOrder2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Also add";
            // 
            // txtAdditionalText
            // 
            this.txtAdditionalText.Location = new System.Drawing.Point(65, 19);
            this.txtAdditionalText.Name = "txtAdditionalText";
            this.txtAdditionalText.Size = new System.Drawing.Size(66, 20);
            this.txtAdditionalText.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Separating Char:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSepChar
            // 
            this.txtSepChar.Location = new System.Drawing.Point(231, 52);
            this.txtSepChar.Name = "txtSepChar";
            this.txtSepChar.Size = new System.Drawing.Size(44, 20);
            this.txtSepChar.TabIndex = 12;
            this.txtSepChar.TextChanged += new System.EventHandler(this.txtSepChar_TextChanged);
            // 
            // rbNumbericOrderWithNChars
            // 
            this.rbNumbericOrderWithNChars.AutoSize = true;
            this.rbNumbericOrderWithNChars.Location = new System.Drawing.Point(20, 68);
            this.rbNumbericOrderWithNChars.Name = "rbNumbericOrderWithNChars";
            this.rbNumbericOrderWithNChars.Size = new System.Drawing.Size(110, 17);
            this.rbNumbericOrderWithNChars.TabIndex = 13;
            this.rbNumbericOrderWithNChars.Text = "Numerical order in";
            this.rbNumbericOrderWithNChars.UseVisualStyleBackColor = true;
            this.rbNumbericOrderWithNChars.CheckedChanged += new System.EventHandler(this.rbNumbericOrderWithNChars_CheckedChanged);
            // 
            // txtNumberOfChars
            // 
            this.txtNumberOfChars.Location = new System.Drawing.Point(130, 65);
            this.txtNumberOfChars.Name = "txtNumberOfChars";
            this.txtNumberOfChars.Size = new System.Drawing.Size(23, 20);
            this.txtNumberOfChars.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "char(s) (ex: input=3 => 001.jpg, 002.jpg...)";
            // 
            // rbReplaceExtension
            // 
            this.rbReplaceExtension.AutoSize = true;
            this.rbReplaceExtension.Location = new System.Drawing.Point(20, 133);
            this.rbReplaceExtension.Name = "rbReplaceExtension";
            this.rbReplaceExtension.Size = new System.Drawing.Size(182, 17);
            this.rbReplaceExtension.TabIndex = 16;
            this.rbReplaceExtension.Text = "Change file names\' extensions to:";
            this.rbReplaceExtension.UseVisualStyleBackColor = true;
            this.rbReplaceExtension.CheckedChanged += new System.EventHandler(this.rbReplaceExtension_CheckedChanged);
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(211, 132);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(47, 20);
            this.txtExtension.TabIndex = 17;
            // 
            // rbReplaceFileName
            // 
            this.rbReplaceFileName.AutoSize = true;
            this.rbReplaceFileName.Location = new System.Drawing.Point(20, 168);
            this.rbReplaceFileName.Name = "rbReplaceFileName";
            this.rbReplaceFileName.Size = new System.Drawing.Size(68, 17);
            this.rbReplaceFileName.TabIndex = 18;
            this.rbReplaceFileName.Text = "Replace ";
            this.rbReplaceFileName.UseVisualStyleBackColor = true;
            this.rbReplaceFileName.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtStringToBeReplaced
            // 
            this.txtStringToBeReplaced.Location = new System.Drawing.Point(88, 167);
            this.txtStringToBeReplaced.Name = "txtStringToBeReplaced";
            this.txtStringToBeReplaced.Size = new System.Drawing.Size(49, 20);
            this.txtStringToBeReplaced.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "in file names with";
            // 
            // txtNewString
            // 
            this.txtNewString.Location = new System.Drawing.Point(236, 167);
            this.txtNewString.Name = "txtNewString";
            this.txtNewString.Size = new System.Drawing.Size(55, 20);
            this.txtNewString.TabIndex = 21;
            // 
            // rbChangeToUpperCase
            // 
            this.rbChangeToUpperCase.AutoSize = true;
            this.rbChangeToUpperCase.Location = new System.Drawing.Point(20, 204);
            this.rbChangeToUpperCase.Name = "rbChangeToUpperCase";
            this.rbChangeToUpperCase.Size = new System.Drawing.Size(192, 17);
            this.rbChangeToUpperCase.TabIndex = 22;
            this.rbChangeToUpperCase.Text = "Change to file names to upper case";
            this.rbChangeToUpperCase.UseVisualStyleBackColor = true;
            this.rbChangeToUpperCase.CheckedChanged += new System.EventHandler(this.rbChangeToUpperCase_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(613, 429);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rbChangeToLowerCase
            // 
            this.rbChangeToLowerCase.AutoSize = true;
            this.rbChangeToLowerCase.Location = new System.Drawing.Point(20, 237);
            this.rbChangeToLowerCase.Name = "rbChangeToLowerCase";
            this.rbChangeToLowerCase.Size = new System.Drawing.Size(190, 17);
            this.rbChangeToLowerCase.TabIndex = 23;
            this.rbChangeToLowerCase.Text = "Change to file names to lower case";
            this.rbChangeToLowerCase.UseVisualStyleBackColor = true;
            this.rbChangeToLowerCase.CheckedChanged += new System.EventHandler(this.rbChangeToLowerCase_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "(ex: abc.txt; xyz.txt => abc.dat; xyz.dat)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(275, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "(ex: abc.txt; ayz.txt, input1=a, input2=z => zbc.txt; zyz.txt)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(208, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(285, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "(ex: abc.txt; ayz.txt, input1=a, input2=z => ABC.txt, AYZ.txt)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(208, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(285, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "(ex: ABC.txt; AYZ.txt, input1=a, input2=z => abc.txt, ayz.txt)";
            // 
            // rbRandomName
            // 
            this.rbRandomName.AutoSize = true;
            this.rbRandomName.Location = new System.Drawing.Point(20, 271);
            this.rbRandomName.Name = "rbRandomName";
            this.rbRandomName.Size = new System.Drawing.Size(218, 17);
            this.rbRandomName.TabIndex = 25;
            this.rbRandomName.Text = "Change file names to random names with";
            this.rbRandomName.UseVisualStyleBackColor = true;
            this.rbRandomName.CheckedChanged += new System.EventHandler(this.rbRandomName_CheckedChanged);
            // 
            // txtNumberOfRandomChars
            // 
            this.txtNumberOfRandomChars.Location = new System.Drawing.Point(240, 268);
            this.txtNumberOfRandomChars.Name = "txtNumberOfRandomChars";
            this.txtNumberOfRandomChars.Size = new System.Drawing.Size(51, 20);
            this.txtNumberOfRandomChars.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(297, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "digit(s)";
            // 
            // gbAdditionalOption
            // 
            this.gbAdditionalOption.Controls.Add(this.txtStartingNumber);
            this.gbAdditionalOption.Controls.Add(this.label12);
            this.gbAdditionalOption.Controls.Add(this.label3);
            this.gbAdditionalOption.Controls.Add(this.cbNumericOrder1);
            this.gbAdditionalOption.Controls.Add(this.cbNumericOrder2);
            this.gbAdditionalOption.Controls.Add(this.txtAdditionalText);
            this.gbAdditionalOption.Controls.Add(this.label4);
            this.gbAdditionalOption.Controls.Add(this.txtSepChar);
            this.gbAdditionalOption.Location = new System.Drawing.Point(368, 19);
            this.gbAdditionalOption.Name = "gbAdditionalOption";
            this.gbAdditionalOption.Size = new System.Drawing.Size(296, 87);
            this.gbAdditionalOption.TabIndex = 28;
            this.gbAdditionalOption.TabStop = false;
            this.gbAdditionalOption.Text = "Additional Option";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Start from:";
            // 
            // txtStartingNumber
            // 
            this.txtStartingNumber.Location = new System.Drawing.Point(65, 52);
            this.txtStartingNumber.Name = "txtStartingNumber";
            this.txtStartingNumber.Size = new System.Drawing.Size(66, 20);
            this.txtStartingNumber.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileNames);
            this.Controls.Add(this.btnSelectFile);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rename File";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbAdditionalOption.ResumeLayout(false);
            this.gbAdditionalOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFileNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbNumbericOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox cbNumericOrder1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbNumericOrder2;
        private System.Windows.Forms.TextBox txtSepChar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdditionalText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumberOfChars;
        private System.Windows.Forms.RadioButton rbNumbericOrderWithNChars;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.RadioButton rbReplaceExtension;
        private System.Windows.Forms.RadioButton rbReplaceFileName;
        private System.Windows.Forms.TextBox txtNewString;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStringToBeReplaced;
        private System.Windows.Forms.RadioButton rbChangeToUpperCase;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rbChangeToLowerCase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbRandomName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumberOfRandomChars;
        private System.Windows.Forms.GroupBox gbAdditionalOption;
        private System.Windows.Forms.TextBox txtStartingNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
    }
}


namespace Activity5
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
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SelectFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxLowercase = new System.Windows.Forms.TextBox();
            this.TextBoxFirstWordAlphabetically = new System.Windows.Forms.TextBox();
            this.TextBoxLastWordAlphabetically = new System.Windows.Forms.TextBox();
            this.TextBoxLongestWord = new System.Windows.Forms.TextBox();
            this.TextBoxWordWithMostVowels = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // SelectFile
            // 
            this.SelectFile.Location = new System.Drawing.Point(199, 68);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(100, 20);
            this.SelectFile.TabIndex = 0;
            this.SelectFile.Text = "Select File";
            this.SelectFile.UseVisualStyleBackColor = true;
            this.SelectFile.Click += new System.EventHandler(this.SelectFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(40, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text In All Lowercase:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Word Alphabetically:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Word Alphabetically:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(84, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Longest Word:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(20, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Word With Most Vowels:";
            // 
            // TextBoxLowercase
            // 
            this.TextBoxLowercase.Location = new System.Drawing.Point(199, 94);
            this.TextBoxLowercase.Name = "TextBoxLowercase";
            this.TextBoxLowercase.Size = new System.Drawing.Size(300, 20);
            this.TextBoxLowercase.TabIndex = 6;
            // 
            // TextBoxFirstWordAlphabetically
            // 
            this.TextBoxFirstWordAlphabetically.Location = new System.Drawing.Point(199, 128);
            this.TextBoxFirstWordAlphabetically.Name = "TextBoxFirstWordAlphabetically";
            this.TextBoxFirstWordAlphabetically.Size = new System.Drawing.Size(100, 20);
            this.TextBoxFirstWordAlphabetically.TabIndex = 7;
            // 
            // TextBoxLastWordAlphabetically
            // 
            this.TextBoxLastWordAlphabetically.Location = new System.Drawing.Point(199, 158);
            this.TextBoxLastWordAlphabetically.Name = "TextBoxLastWordAlphabetically";
            this.TextBoxLastWordAlphabetically.Size = new System.Drawing.Size(100, 20);
            this.TextBoxLastWordAlphabetically.TabIndex = 8;
            // 
            // TextBoxLongestWord
            // 
            this.TextBoxLongestWord.Location = new System.Drawing.Point(199, 188);
            this.TextBoxLongestWord.Name = "TextBoxLongestWord";
            this.TextBoxLongestWord.Size = new System.Drawing.Size(100, 20);
            this.TextBoxLongestWord.TabIndex = 9;
            // 
            // TextBoxWordWithMostVowels
            // 
            this.TextBoxWordWithMostVowels.Location = new System.Drawing.Point(199, 220);
            this.TextBoxWordWithMostVowels.Name = "TextBoxWordWithMostVowels";
            this.TextBoxWordWithMostVowels.Size = new System.Drawing.Size(100, 20);
            this.TextBoxWordWithMostVowels.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(520, 350);
            this.Controls.Add(this.TextBoxWordWithMostVowels);
            this.Controls.Add(this.TextBoxLongestWord);
            this.Controls.Add(this.TextBoxLastWordAlphabetically);
            this.Controls.Add(this.TextBoxFirstWordAlphabetically);
            this.Controls.Add(this.TextBoxLowercase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectFile);
            this.Name = "Form1";
            this.Text = "File Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button SelectFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxLowercase;
        private System.Windows.Forms.TextBox TextBoxFirstWordAlphabetically;
        private System.Windows.Forms.TextBox TextBoxLastWordAlphabetically;
        private System.Windows.Forms.TextBox TextBoxLongestWord;
        private System.Windows.Forms.TextBox TextBoxWordWithMostVowels;
    }
}


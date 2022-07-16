
namespace KTANE_Solver
{
    partial class SeaShellsForm
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
            this.firstPhraseComboBox = new System.Windows.Forms.ComboBox();
            this.secondPhraseComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bigButtonComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.strikeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Phrase: ";
            // 
            // firstPhraseComboBox
            // 
            this.firstPhraseComboBox.FormattingEnabled = true;
            this.firstPhraseComboBox.Location = new System.Drawing.Point(199, 23);
            this.firstPhraseComboBox.Name = "firstPhraseComboBox";
            this.firstPhraseComboBox.Size = new System.Drawing.Size(121, 21);
            this.firstPhraseComboBox.TabIndex = 1;
            // 
            // secondPhraseComboBox
            // 
            this.secondPhraseComboBox.FormattingEnabled = true;
            this.secondPhraseComboBox.Location = new System.Drawing.Point(199, 68);
            this.secondPhraseComboBox.Name = "secondPhraseComboBox";
            this.secondPhraseComboBox.Size = new System.Drawing.Size(121, 21);
            this.secondPhraseComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Second Phrase: ";
            // 
            // bigButtonComboBox
            // 
            this.bigButtonComboBox.FormattingEnabled = true;
            this.bigButtonComboBox.Location = new System.Drawing.Point(199, 113);
            this.bigButtonComboBox.Name = "bigButtonComboBox";
            this.bigButtonComboBox.Size = new System.Drawing.Size(121, 21);
            this.bigButtonComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Big Button: ";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 172);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(85, 36);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(358, 172);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(85, 36);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // strikeButton
            // 
            this.strikeButton.Location = new System.Drawing.Point(183, 172);
            this.strikeButton.Name = "strikeButton";
            this.strikeButton.Size = new System.Drawing.Size(85, 36);
            this.strikeButton.TabIndex = 8;
            this.strikeButton.Text = "Strike";
            this.strikeButton.UseVisualStyleBackColor = true;
            this.strikeButton.Click += new System.EventHandler(this.strikeButton_Click);
            // 
            // SeaShellsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 220);
            this.Controls.Add(this.strikeButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.bigButtonComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secondPhraseComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstPhraseComboBox);
            this.Controls.Add(this.label1);
            this.Name = "SeaShellsForm";
            this.Text = "SeaShellsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox firstPhraseComboBox;
        private System.Windows.Forms.ComboBox secondPhraseComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button strikeButton;
        private System.Windows.Forms.ComboBox bigButtonComboBox;
    }
}
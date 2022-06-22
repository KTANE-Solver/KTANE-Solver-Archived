
namespace KTANE_Solver
{
    partial class FastMathOtherStageForm
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
            this.resetButton = new System.Windows.Forms.Button();
            this.strikeButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.moduleSelectionButton = new System.Windows.Forms.Button();
            this.rightLetterTextBox = new System.Windows.Forms.TextBox();
            this.leftLetterTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(215, 186);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(93, 55);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // strikeButton
            // 
            this.strikeButton.Location = new System.Drawing.Point(316, 185);
            this.strikeButton.Margin = new System.Windows.Forms.Padding(4);
            this.strikeButton.Name = "strikeButton";
            this.strikeButton.Size = new System.Drawing.Size(93, 55);
            this.strikeButton.TabIndex = 11;
            this.strikeButton.Text = "Strike";
            this.strikeButton.UseVisualStyleBackColor = true;
            this.strikeButton.Click += new System.EventHandler(this.strikeButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(419, 186);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(93, 55);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(115, 185);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 55);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // moduleSelectionButton
            // 
            this.moduleSelectionButton.Location = new System.Drawing.Point(13, 185);
            this.moduleSelectionButton.Margin = new System.Windows.Forms.Padding(4);
            this.moduleSelectionButton.Name = "moduleSelectionButton";
            this.moduleSelectionButton.Size = new System.Drawing.Size(93, 55);
            this.moduleSelectionButton.TabIndex = 8;
            this.moduleSelectionButton.Text = "Module Selection";
            this.moduleSelectionButton.UseVisualStyleBackColor = true;
            this.moduleSelectionButton.Click += new System.EventHandler(this.moduleSelectionButton_Click);
            // 
            // rightLetterTextBox
            // 
            this.rightLetterTextBox.Location = new System.Drawing.Point(248, 124);
            this.rightLetterTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.rightLetterTextBox.Name = "rightLetterTextBox";
            this.rightLetterTextBox.Size = new System.Drawing.Size(160, 22);
            this.rightLetterTextBox.TabIndex = 15;
            // 
            // leftLetterTextBox
            // 
            this.leftLetterTextBox.Location = new System.Drawing.Point(248, 46);
            this.leftLetterTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.leftLetterTextBox.Name = "leftLetterTextBox";
            this.leftLetterTextBox.Size = new System.Drawing.Size(160, 22);
            this.leftLetterTextBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Right Letter:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Left Letter:";
            // 
            // FastMathOtherStageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 255);
            this.Controls.Add(this.rightLetterTextBox);
            this.Controls.Add(this.leftLetterTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.strikeButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.moduleSelectionButton);
            this.Name = "FastMathOtherStageForm";
            this.Text = "KTANE Bot by Hawker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button strikeButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button moduleSelectionButton;
        private System.Windows.Forms.TextBox rightLetterTextBox;
        private System.Windows.Forms.TextBox leftLetterTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

namespace KTANE_Solver
{
    partial class WordSearchForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.topLeftTextBox = new System.Windows.Forms.TextBox();
            this.topRightTextBox = new System.Windows.Forms.TextBox();
            this.bottomLeftTextBox = new System.Windows.Forms.TextBox();
            this.bottomRightTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.strikeButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Top Left Letter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Top Right Letter:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bottom Left Letter:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bottom Right Letter:";
            // 
            // topLeftTextBox
            // 
            this.topLeftTextBox.Location = new System.Drawing.Point(239, 23);
            this.topLeftTextBox.Name = "topLeftTextBox";
            this.topLeftTextBox.Size = new System.Drawing.Size(100, 20);
            this.topLeftTextBox.TabIndex = 4;
            // 
            // topRightTextBox
            // 
            this.topRightTextBox.Location = new System.Drawing.Point(239, 80);
            this.topRightTextBox.Name = "topRightTextBox";
            this.topRightTextBox.Size = new System.Drawing.Size(100, 20);
            this.topRightTextBox.TabIndex = 5;
            // 
            // bottomLeftTextBox
            // 
            this.bottomLeftTextBox.Location = new System.Drawing.Point(239, 139);
            this.bottomLeftTextBox.Name = "bottomLeftTextBox";
            this.bottomLeftTextBox.Size = new System.Drawing.Size(100, 20);
            this.bottomLeftTextBox.TabIndex = 6;
            // 
            // bottomRightTextBox
            // 
            this.bottomRightTextBox.Location = new System.Drawing.Point(239, 206);
            this.bottomRightTextBox.Name = "bottomRightTextBox";
            this.bottomRightTextBox.Size = new System.Drawing.Size(100, 20);
            this.bottomRightTextBox.TabIndex = 7;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(25, 260);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(98, 43);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // strikeButton
            // 
            this.strikeButton.Location = new System.Drawing.Point(168, 260);
            this.strikeButton.Name = "strikeButton";
            this.strikeButton.Size = new System.Drawing.Size(98, 43);
            this.strikeButton.TabIndex = 9;
            this.strikeButton.Text = "Strike";
            this.strikeButton.UseVisualStyleBackColor = true;
            this.strikeButton.Click += new System.EventHandler(this.strikeButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(302, 260);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(98, 43);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // WordSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 315);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.strikeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.bottomRightTextBox);
            this.Controls.Add(this.bottomLeftTextBox);
            this.Controls.Add(this.topRightTextBox);
            this.Controls.Add(this.topLeftTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WordSearchForm";
            this.Text = "WordSearchForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WordSearchForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox topLeftTextBox;
        private System.Windows.Forms.TextBox topRightTextBox;
        private System.Windows.Forms.TextBox bottomLeftTextBox;
        private System.Windows.Forms.TextBox bottomRightTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button strikeButton;
        private System.Windows.Forms.Button submitButton;
    }
}
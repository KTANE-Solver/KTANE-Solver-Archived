
namespace KTANE_Solver
{
    partial class AdjacentLettersForm
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
            this.row1TextBox = new System.Windows.Forms.TextBox();
            this.row2TextBox = new System.Windows.Forms.TextBox();
            this.row3TextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.strikeButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Row 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Row 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Row 3:";
            // 
            // row1TextBox
            // 
            this.row1TextBox.Location = new System.Drawing.Point(157, 35);
            this.row1TextBox.Name = "row1TextBox";
            this.row1TextBox.Size = new System.Drawing.Size(111, 20);
            this.row1TextBox.TabIndex = 3;
            // 
            // row2TextBox
            // 
            this.row2TextBox.Location = new System.Drawing.Point(157, 88);
            this.row2TextBox.Name = "row2TextBox";
            this.row2TextBox.Size = new System.Drawing.Size(111, 20);
            this.row2TextBox.TabIndex = 4;
            // 
            // row3TextBox
            // 
            this.row3TextBox.Location = new System.Drawing.Point(157, 139);
            this.row3TextBox.Name = "row3TextBox";
            this.row3TextBox.Size = new System.Drawing.Size(111, 20);
            this.row3TextBox.TabIndex = 5;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 193);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(82, 38);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // strikeButton
            // 
            this.strikeButton.Location = new System.Drawing.Point(148, 193);
            this.strikeButton.Name = "strikeButton";
            this.strikeButton.Size = new System.Drawing.Size(82, 38);
            this.strikeButton.TabIndex = 7;
            this.strikeButton.Text = "Strike";
            this.strikeButton.UseVisualStyleBackColor = true;
            this.strikeButton.Click += new System.EventHandler(this.strikeButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(277, 193);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(82, 38);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // AdjacentLettersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 243);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.strikeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.row3TextBox);
            this.Controls.Add(this.row2TextBox);
            this.Controls.Add(this.row1TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdjacentLettersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox row1TextBox;
        private System.Windows.Forms.TextBox row2TextBox;
        private System.Windows.Forms.TextBox row3TextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button strikeButton;
        private System.Windows.Forms.Button submitButton;
    }
}

namespace KTANE_Solver
{
    partial class TicTacToeForm
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
            this.topRowTextBox = new System.Windows.Forms.TextBox();
            this.bottomRowTextBox = new System.Windows.Forms.TextBox();
            this.middleRowTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.strikeButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // topRowTextBox
            // 
            this.topRowTextBox.Location = new System.Drawing.Point(110, 25);
            this.topRowTextBox.Name = "topRowTextBox";
            this.topRowTextBox.Size = new System.Drawing.Size(100, 20);
            this.topRowTextBox.TabIndex = 0;
            // 
            // bottomRowTextBox
            // 
            this.bottomRowTextBox.Location = new System.Drawing.Point(110, 110);
            this.bottomRowTextBox.Name = "bottomRowTextBox";
            this.bottomRowTextBox.Size = new System.Drawing.Size(100, 20);
            this.bottomRowTextBox.TabIndex = 1;
            // 
            // middleRowTextBox
            // 
            this.middleRowTextBox.Location = new System.Drawing.Point(110, 64);
            this.middleRowTextBox.Name = "middleRowTextBox";
            this.middleRowTextBox.Size = new System.Drawing.Size(100, 20);
            this.middleRowTextBox.TabIndex = 2;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 174);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(81, 36);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // strikeButton
            // 
            this.strikeButton.Location = new System.Drawing.Point(110, 174);
            this.strikeButton.Name = "strikeButton";
            this.strikeButton.Size = new System.Drawing.Size(81, 36);
            this.strikeButton.TabIndex = 4;
            this.strikeButton.Text = "Strike";
            this.strikeButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(200, 174);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(81, 36);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Top Row:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Middle Row:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bottom Row:";
            // 
            // TicTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 222);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.strikeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.middleRowTextBox);
            this.Controls.Add(this.bottomRowTextBox);
            this.Controls.Add(this.topRowTextBox);
            this.Name = "TicTacToeForm";
            this.Text = "TicTacToeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox topRowTextBox;
        private System.Windows.Forms.TextBox bottomRowTextBox;
        private System.Windows.Forms.TextBox middleRowTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button strikeButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

namespace KTANE_Solver
{
    partial class ConnectionCheckForm
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
            this.topLeftTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.topRightTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bottomLeftTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bottomRightTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.strikeButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topLeftTextBox
            // 
            this.topLeftTextBox.Location = new System.Drawing.Point(108, 36);
            this.topLeftTextBox.Name = "topLeftTextBox";
            this.topLeftTextBox.Size = new System.Drawing.Size(100, 20);
            this.topLeftTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Top Left:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Top Right:";
            // 
            // topRightTextBox
            // 
            this.topRightTextBox.Location = new System.Drawing.Point(333, 36);
            this.topRightTextBox.Name = "topRightTextBox";
            this.topRightTextBox.Size = new System.Drawing.Size(100, 20);
            this.topRightTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bottom Left:";
            // 
            // bottomLeftTextBox
            // 
            this.bottomLeftTextBox.Location = new System.Drawing.Point(108, 127);
            this.bottomLeftTextBox.Name = "bottomLeftTextBox";
            this.bottomLeftTextBox.Size = new System.Drawing.Size(100, 20);
            this.bottomLeftTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bottom Right:";
            // 
            // bottomRightTextBox
            // 
            this.bottomRightTextBox.Location = new System.Drawing.Point(333, 130);
            this.bottomRightTextBox.Name = "bottomRightTextBox";
            this.bottomRightTextBox.Size = new System.Drawing.Size(100, 20);
            this.bottomRightTextBox.TabIndex = 6;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 179);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(89, 44);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // strikeButton
            // 
            this.strikeButton.Location = new System.Drawing.Point(186, 179);
            this.strikeButton.Name = "strikeButton";
            this.strikeButton.Size = new System.Drawing.Size(89, 44);
            this.strikeButton.TabIndex = 9;
            this.strikeButton.Text = "Strike";
            this.strikeButton.UseVisualStyleBackColor = true;
            this.strikeButton.Click += new System.EventHandler(this.strikeButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(352, 179);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(89, 44);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // ConnectCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 235);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.strikeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bottomRightTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bottomLeftTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.topRightTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topLeftTextBox);
            this.Name = "ConnectCheckForm";
            this.Text = "ConnectCheckForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox topLeftTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox topRightTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bottomLeftTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bottomRightTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button strikeButton;
        private System.Windows.Forms.Button submitButton;
    }
}
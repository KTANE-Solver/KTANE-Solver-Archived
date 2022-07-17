
namespace KTANE_Solver
{
    partial class SafetySafeForm
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
            this.topLeftLabel = new System.Windows.Forms.Label();
            this.topMidLabel = new System.Windows.Forms.Label();
            this.topRightLabel = new System.Windows.Forms.Label();
            this.bottomRightLabel = new System.Windows.Forms.Label();
            this.bottomMidLabel = new System.Windows.Forms.Label();
            this.bottomLeftLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.strikeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topLeftLabel
            // 
            this.topLeftLabel.AutoSize = true;
            this.topLeftLabel.Location = new System.Drawing.Point(35, 26);
            this.topLeftLabel.Name = "topLeftLabel";
            this.topLeftLabel.Size = new System.Drawing.Size(35, 13);
            this.topLeftLabel.TabIndex = 0;
            this.topLeftLabel.Text = "label1";
            // 
            // topMidLabel
            // 
            this.topMidLabel.AutoSize = true;
            this.topMidLabel.Location = new System.Drawing.Point(172, 26);
            this.topMidLabel.Name = "topMidLabel";
            this.topMidLabel.Size = new System.Drawing.Size(35, 13);
            this.topMidLabel.TabIndex = 1;
            this.topMidLabel.Text = "label2";
            // 
            // topRightLabel
            // 
            this.topRightLabel.AutoSize = true;
            this.topRightLabel.Location = new System.Drawing.Point(290, 26);
            this.topRightLabel.Name = "topRightLabel";
            this.topRightLabel.Size = new System.Drawing.Size(35, 13);
            this.topRightLabel.TabIndex = 2;
            this.topRightLabel.Text = "label3";
            this.topRightLabel.Click += new System.EventHandler(this.topRightLabel_Click);
            // 
            // bottomRightLabel
            // 
            this.bottomRightLabel.AutoSize = true;
            this.bottomRightLabel.Location = new System.Drawing.Point(290, 81);
            this.bottomRightLabel.Name = "bottomRightLabel";
            this.bottomRightLabel.Size = new System.Drawing.Size(35, 13);
            this.bottomRightLabel.TabIndex = 5;
            this.bottomRightLabel.Text = "label4";
            this.bottomRightLabel.Click += new System.EventHandler(this.bottomRightLabel_Click);
            // 
            // bottomMidLabel
            // 
            this.bottomMidLabel.AutoSize = true;
            this.bottomMidLabel.Location = new System.Drawing.Point(172, 81);
            this.bottomMidLabel.Name = "bottomMidLabel";
            this.bottomMidLabel.Size = new System.Drawing.Size(35, 13);
            this.bottomMidLabel.TabIndex = 4;
            this.bottomMidLabel.Text = "label5";
            // 
            // bottomLeftLabel
            // 
            this.bottomLeftLabel.AutoSize = true;
            this.bottomLeftLabel.Location = new System.Drawing.Point(35, 81);
            this.bottomLeftLabel.Name = "bottomLeftLabel";
            this.bottomLeftLabel.Size = new System.Drawing.Size(35, 13);
            this.bottomLeftLabel.TabIndex = 3;
            this.bottomLeftLabel.Text = "label6";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 136);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(99, 40);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // strikeButton
            // 
            this.strikeButton.Location = new System.Drawing.Point(282, 136);
            this.strikeButton.Name = "strikeButton";
            this.strikeButton.Size = new System.Drawing.Size(99, 40);
            this.strikeButton.TabIndex = 8;
            this.strikeButton.Text = "Strike";
            this.strikeButton.UseVisualStyleBackColor = true;
            this.strikeButton.Click += new System.EventHandler(this.strikeButton_Click);
            // 
            // SafetySafeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 188);
            this.Controls.Add(this.strikeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.bottomRightLabel);
            this.Controls.Add(this.bottomMidLabel);
            this.Controls.Add(this.bottomLeftLabel);
            this.Controls.Add(this.topRightLabel);
            this.Controls.Add(this.topMidLabel);
            this.Controls.Add(this.topLeftLabel);
            this.Name = "SafetySafeForm";
            this.Text = "KTANE Bot by Hawker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLeftLabel;
        private System.Windows.Forms.Label topMidLabel;
        private System.Windows.Forms.Label topRightLabel;
        private System.Windows.Forms.Label bottomRightLabel;
        private System.Windows.Forms.Label bottomMidLabel;
        private System.Windows.Forms.Label bottomLeftLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button strikeButton;
    }
}
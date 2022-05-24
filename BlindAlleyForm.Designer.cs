
namespace KTANE_Solver
{
    partial class BlindAlleyForm
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
            this.answerLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.strikeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(181, 9);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(35, 104);
            this.answerLabel.TabIndex = 0;
            this.answerLabel.Text = "label1\r\nlabel1\r\nlabel1\r\nlabel1\r\nlabel1\r\nlabel1\r\nlabel1\r\nlabel1";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 158);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(91, 47);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // strikeButton
            // 
            this.strikeButton.Location = new System.Drawing.Point(320, 158);
            this.strikeButton.Name = "strikeButton";
            this.strikeButton.Size = new System.Drawing.Size(91, 47);
            this.strikeButton.TabIndex = 2;
            this.strikeButton.Text = "Strike";
            this.strikeButton.UseVisualStyleBackColor = true;
            this.strikeButton.Click += new System.EventHandler(this.strikeButton_Click);
            // 
            // BlindAlleyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 217);
            this.Controls.Add(this.strikeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.answerLabel);
            this.Name = "BlindAlleyForm";
            this.Text = "KTANE Bot by Hawker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button strikeButton;
    }
}
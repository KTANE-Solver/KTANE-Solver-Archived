
namespace KTANE_Solver
{
    partial class SimonSaysForm
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.strikeButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.stageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(231, 52);
            this.instructionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(72, 68);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "B - Blue\r\nG - Green\r\nR - Red\r\nY - Yellow";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(125, 134);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(291, 22);
            this.inputTextBox.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(16, 185);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(120, 55);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // strikeButton
            // 
            this.strikeButton.Location = new System.Drawing.Point(193, 185);
            this.strikeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.strikeButton.Name = "strikeButton";
            this.strikeButton.Size = new System.Drawing.Size(120, 55);
            this.strikeButton.TabIndex = 3;
            this.strikeButton.Text = "Strike";
            this.strikeButton.UseVisualStyleBackColor = true;
            this.strikeButton.Click += new System.EventHandler(this.strikeButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(365, 185);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(120, 55);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // stageLabel
            // 
            this.stageLabel.AutoSize = true;
            this.stageLabel.Location = new System.Drawing.Point(231, 19);
            this.stageLabel.Name = "stageLabel";
            this.stageLabel.Size = new System.Drawing.Size(57, 17);
            this.stageLabel.TabIndex = 5;
            this.stageLabel.Tag = "";
            this.stageLabel.Text = "Stage 1";
            // 
            // SimonSaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 255);
            this.Controls.Add(this.stageLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.strikeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.instructionLabel);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "SimonSaysForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button strikeButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label stageLabel;
    }
}

namespace KTANE_Solver
{
    partial class SimonSaysOtherStageForm
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.stageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.moduleSelectionButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.strikeButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(125, 134);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(291, 22);
            this.inputTextBox.TabIndex = 0;
            // 
            // stageLabel
            // 
            this.stageLabel.AutoSize = true;
            this.stageLabel.Location = new System.Drawing.Point(231, 19);
            this.stageLabel.Name = "stageLabel";
            this.stageLabel.Size = new System.Drawing.Size(57, 17);
            this.stageLabel.TabIndex = 1;
            this.stageLabel.Text = "Stage ?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "B - Blue\r\nG - Green\r\nR - Red\r\nY - Yellow";
            // 
            // moduleSelectionButton
            // 
            this.moduleSelectionButton.Location = new System.Drawing.Point(13, 187);
            this.moduleSelectionButton.Margin = new System.Windows.Forms.Padding(4);
            this.moduleSelectionButton.Name = "moduleSelectionButton";
            this.moduleSelectionButton.Size = new System.Drawing.Size(94, 55);
            this.moduleSelectionButton.TabIndex = 3;
            this.moduleSelectionButton.Text = "Module Selection";
            this.moduleSelectionButton.UseVisualStyleBackColor = true;
            this.moduleSelectionButton.Click += new System.EventHandler(this.moduleSelectionButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(114, 187);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(94, 55);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(418, 188);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(94, 55);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // strikeButton
            // 
            this.strikeButton.Location = new System.Drawing.Point(316, 187);
            this.strikeButton.Margin = new System.Windows.Forms.Padding(4);
            this.strikeButton.Name = "strikeButton";
            this.strikeButton.Size = new System.Drawing.Size(94, 55);
            this.strikeButton.TabIndex = 6;
            this.strikeButton.Text = "Strike";
            this.strikeButton.UseVisualStyleBackColor = true;
            this.strikeButton.Click += new System.EventHandler(this.strikeButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(215, 188);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(94, 55);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // SimonSaysOtherStageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 255);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.strikeButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.moduleSelectionButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stageLabel);
            this.Controls.Add(this.inputTextBox);
            this.Name = "SimonSaysOtherStageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label stageLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button moduleSelectionButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button strikeButton;
        private System.Windows.Forms.Button resetButton;
    }
}
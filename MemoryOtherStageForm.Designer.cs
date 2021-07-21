
namespace KTANE_Solver
{
    partial class MemoryOtherStageForm
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
            this.stageLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.moduleSelectionButton = new System.Windows.Forms.Button();
            this.strikeButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stageLabel
            // 
            this.stageLabel.AutoSize = true;
            this.stageLabel.Location = new System.Drawing.Point(184, 18);
            this.stageLabel.Name = "stageLabel";
            this.stageLabel.Size = new System.Drawing.Size(44, 13);
            this.stageLabel.TabIndex = 1;
            this.stageLabel.Text = "Stage ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter the display:";
            // 
            // displayTextBox
            // 
            this.displayTextBox.Location = new System.Drawing.Point(138, 84);
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.Size = new System.Drawing.Size(136, 20);
            this.displayTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter the 4 numbers from left to right:";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(138, 171);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(136, 20);
            this.numberTextBox.TabIndex = 6;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 224);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(83, 41);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // moduleSelectionButton
            // 
            this.moduleSelectionButton.Location = new System.Drawing.Point(117, 224);
            this.moduleSelectionButton.Name = "moduleSelectionButton";
            this.moduleSelectionButton.Size = new System.Drawing.Size(83, 41);
            this.moduleSelectionButton.TabIndex = 8;
            this.moduleSelectionButton.Text = "Module Selection";
            this.moduleSelectionButton.UseVisualStyleBackColor = true;
            this.moduleSelectionButton.Click += new System.EventHandler(this.moduleSelectionButton_Click);
            // 
            // strikeButton
            // 
            this.strikeButton.Location = new System.Drawing.Point(211, 224);
            this.strikeButton.Name = "strikeButton";
            this.strikeButton.Size = new System.Drawing.Size(83, 41);
            this.strikeButton.TabIndex = 9;
            this.strikeButton.Text = "Strike";
            this.strikeButton.UseVisualStyleBackColor = true;
            this.strikeButton.Click += new System.EventHandler(this.strikeButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(308, 224);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(83, 41);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // MemoryOtherStageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 277);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.strikeButton);
            this.Controls.Add(this.moduleSelectionButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stageLabel);
            this.Name = "MemoryOtherStageForm";
            this.Text = "MemoryOtherStageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stageLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button moduleSelectionButton;
        private System.Windows.Forms.Button strikeButton;
        private System.Windows.Forms.Button submitButton;
    }
}
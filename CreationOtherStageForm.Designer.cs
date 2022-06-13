
namespace KTANE_Solver
{
    partial class CreationOtherStageForm
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
            this.submitButton = new System.Windows.Forms.Button();
            this.strikeButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.weatherComboBox = new System.Windows.Forms.ComboBox();
            this.moduleSelectionButton = new System.Windows.Forms.Button();
            this.stageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(307, 128);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(83, 43);
            this.submitButton.TabIndex = 12;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // strikeButton
            // 
            this.strikeButton.Location = new System.Drawing.Point(216, 128);
            this.strikeButton.Margin = new System.Windows.Forms.Padding(4);
            this.strikeButton.Name = "strikeButton";
            this.strikeButton.Size = new System.Drawing.Size(83, 43);
            this.strikeButton.TabIndex = 11;
            this.strikeButton.Text = "Stike";
            this.strikeButton.UseVisualStyleBackColor = true;
            this.strikeButton.Click += new System.EventHandler(this.strikeButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(14, 128);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(83, 43);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Current Weather:";
            // 
            // weatherComboBox
            // 
            this.weatherComboBox.FormattingEnabled = true;
            this.weatherComboBox.Location = new System.Drawing.Point(126, 82);
            this.weatherComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.weatherComboBox.Name = "weatherComboBox";
            this.weatherComboBox.Size = new System.Drawing.Size(160, 24);
            this.weatherComboBox.TabIndex = 13;
            // 
            // moduleSelectionButton
            // 
            this.moduleSelectionButton.Location = new System.Drawing.Point(105, 128);
            this.moduleSelectionButton.Margin = new System.Windows.Forms.Padding(4);
            this.moduleSelectionButton.Name = "moduleSelectionButton";
            this.moduleSelectionButton.Size = new System.Drawing.Size(83, 43);
            this.moduleSelectionButton.TabIndex = 14;
            this.moduleSelectionButton.Text = "Module Selection";
            this.moduleSelectionButton.UseVisualStyleBackColor = true;
            this.moduleSelectionButton.Click += new System.EventHandler(this.moduleSelectionButton_Click);
            // 
            // stageLabel
            // 
            this.stageLabel.AutoSize = true;
            this.stageLabel.Location = new System.Drawing.Point(178, 9);
            this.stageLabel.Name = "stageLabel";
            this.stageLabel.Size = new System.Drawing.Size(61, 17);
            this.stageLabel.TabIndex = 15;
            this.stageLabel.Text = "Stage: ?";
            // 
            // CreationOtherStageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 184);
            this.Controls.Add(this.stageLabel);
            this.Controls.Add(this.moduleSelectionButton);
            this.Controls.Add(this.weatherComboBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.strikeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Name = "CreationOtherStageForm";
            this.Text = "KTANE Bot by Hawker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button strikeButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox weatherComboBox;
        private System.Windows.Forms.Button moduleSelectionButton;
        private System.Windows.Forms.Label stageLabel;
    }
}
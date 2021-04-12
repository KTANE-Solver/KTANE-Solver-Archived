namespace KTANE_Solver
{
    partial class EdgeworkSelectionForm
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
            this.promptLabel = new System.Windows.Forms.Label();
            this.automaticButton = new System.Windows.Forms.Button();
            this.manualButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(64, 9);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(549, 17);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Would you like to manually input the edgework or use the information in Edgework." +
    "txt?";
            // 
            // automaticButton
            // 
            this.automaticButton.Location = new System.Drawing.Point(263, 39);
            this.automaticButton.Name = "automaticButton";
            this.automaticButton.Size = new System.Drawing.Size(84, 41);
            this.automaticButton.TabIndex = 1;
            this.automaticButton.Text = "Automatic";
            this.automaticButton.UseVisualStyleBackColor = true;
            this.automaticButton.Click += new System.EventHandler(this.automaticButton_Click);
            // 
            // manualButton
            // 
            this.manualButton.Location = new System.Drawing.Point(263, 86);
            this.manualButton.Name = "manualButton";
            this.manualButton.Size = new System.Drawing.Size(84, 41);
            this.manualButton.TabIndex = 2;
            this.manualButton.Text = "Manual";
            this.manualButton.UseVisualStyleBackColor = true;
            this.manualButton.Click += new System.EventHandler(this.manualButton_Click);
            // 
            // EdgeworkSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 132);
            this.Controls.Add(this.manualButton);
            this.Controls.Add(this.automaticButton);
            this.Controls.Add(this.promptLabel);
            this.Name = "EdgeworkSelectionForm";
            this.Text = "KTANE Bot by Hawker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EdgeworkSelectionForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Button automaticButton;
        private System.Windows.Forms.Button manualButton;
    }
}


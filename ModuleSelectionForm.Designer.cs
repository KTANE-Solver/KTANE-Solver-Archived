namespace KTANE_Solver
{
    partial class ModuleSelectionForm
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
            this.moduleComboBox = new System.Windows.Forms.ComboBox();
            this.changeEdgeworkButton = new System.Windows.Forms.Button();
            this.checkEdgeworkButton = new System.Windows.Forms.Button();
            this.saveEdgeworkButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // moduleComboBox
            // 
            this.moduleComboBox.FormattingEnabled = true;
            this.moduleComboBox.Location = new System.Drawing.Point(151, 37);
            this.moduleComboBox.Name = "moduleComboBox";
            this.moduleComboBox.Size = new System.Drawing.Size(262, 24);
            this.moduleComboBox.TabIndex = 0;
            // 
            // changeEdgeworkButton
            // 
            this.changeEdgeworkButton.AutoSize = true;
            this.changeEdgeworkButton.Location = new System.Drawing.Point(12, 91);
            this.changeEdgeworkButton.Name = "changeEdgeworkButton";
            this.changeEdgeworkButton.Size = new System.Drawing.Size(133, 34);
            this.changeEdgeworkButton.TabIndex = 1;
            this.changeEdgeworkButton.Text = "Change Edgework";
            this.changeEdgeworkButton.UseVisualStyleBackColor = true;
            this.changeEdgeworkButton.Click += new System.EventHandler(this.changeEdgeworkButton_Click);
            // 
            // checkEdgeworkButton
            // 
            this.checkEdgeworkButton.AutoSize = true;
            this.checkEdgeworkButton.Location = new System.Drawing.Point(167, 91);
            this.checkEdgeworkButton.Name = "checkEdgeworkButton";
            this.checkEdgeworkButton.Size = new System.Drawing.Size(123, 34);
            this.checkEdgeworkButton.TabIndex = 2;
            this.checkEdgeworkButton.Text = "Check Edgework";
            this.checkEdgeworkButton.UseVisualStyleBackColor = true;
            this.checkEdgeworkButton.Click += new System.EventHandler(this.checkEdgeworkButton_Click);
            // 
            // saveEdgeworkButton
            // 
            this.saveEdgeworkButton.AutoSize = true;
            this.saveEdgeworkButton.Location = new System.Drawing.Point(313, 91);
            this.saveEdgeworkButton.Name = "saveEdgeworkButton";
            this.saveEdgeworkButton.Size = new System.Drawing.Size(116, 34);
            this.saveEdgeworkButton.TabIndex = 3;
            this.saveEdgeworkButton.Text = "Save Edgework";
            this.saveEdgeworkButton.UseVisualStyleBackColor = true;
            this.saveEdgeworkButton.Click += new System.EventHandler(this.saveEdgeworkButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.AutoSize = true;
            this.submitButton.Location = new System.Drawing.Point(451, 91);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 34);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // ModuleSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 147);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.saveEdgeworkButton);
            this.Controls.Add(this.checkEdgeworkButton);
            this.Controls.Add(this.changeEdgeworkButton);
            this.Controls.Add(this.moduleComboBox);
            this.Name = "ModuleSelectionForm";
            this.Text = "ModuleSelectionForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModuleSelectionForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox moduleComboBox;
        private System.Windows.Forms.Button changeEdgeworkButton;
        private System.Windows.Forms.Button checkEdgeworkButton;
        private System.Windows.Forms.Button saveEdgeworkButton;
        private System.Windows.Forms.Button submitButton;
    }
}
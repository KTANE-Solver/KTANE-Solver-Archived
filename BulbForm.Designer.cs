
namespace KTANE_Solver
{
    partial class BulbForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.litCheckBox = new System.Windows.Forms.CheckBox();
            this.opaqueCheckBox = new System.Windows.Forms.CheckBox();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.strikeButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // litCheckBox
            // 
            this.litCheckBox.AutoSize = true;
            this.litCheckBox.Location = new System.Drawing.Point(113, 123);
            this.litCheckBox.Name = "litCheckBox";
            this.litCheckBox.Size = new System.Drawing.Size(37, 17);
            this.litCheckBox.TabIndex = 1;
            this.litCheckBox.Text = "Lit";
            this.litCheckBox.UseVisualStyleBackColor = true;
            // 
            // opaqueCheckBox
            // 
            this.opaqueCheckBox.AutoSize = true;
            this.opaqueCheckBox.Location = new System.Drawing.Point(233, 123);
            this.opaqueCheckBox.Name = "opaqueCheckBox";
            this.opaqueCheckBox.Size = new System.Drawing.Size(64, 17);
            this.opaqueCheckBox.TabIndex = 2;
            this.opaqueCheckBox.Text = "Opaque";
            this.opaqueCheckBox.UseVisualStyleBackColor = true;
            // 
            // colorComboBox
            // 
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(176, 59);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(121, 21);
            this.colorComboBox.TabIndex = 3;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 183);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(97, 40);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // strikeButton
            // 
            this.strikeButton.Location = new System.Drawing.Point(166, 183);
            this.strikeButton.Name = "strikeButton";
            this.strikeButton.Size = new System.Drawing.Size(97, 40);
            this.strikeButton.TabIndex = 5;
            this.strikeButton.Text = "Strike";
            this.strikeButton.UseVisualStyleBackColor = true;
            this.strikeButton.Click += new System.EventHandler(this.strikeButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(319, 183);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(97, 40);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // BulbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 235);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.strikeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.opaqueCheckBox);
            this.Controls.Add(this.litCheckBox);
            this.Controls.Add(this.label1);
            this.Name = "BulbForm";
            this.Text = "BulbForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox litCheckBox;
        private System.Windows.Forms.CheckBox opaqueCheckBox;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button strikeButton;
        private System.Windows.Forms.Button submitButton;
    }
}
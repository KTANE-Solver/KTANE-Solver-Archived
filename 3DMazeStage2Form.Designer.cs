
namespace KTANE_Solver
{
    partial class _3DMazeStage2Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.cardinalComboBox = new System.Windows.Forms.ComboBox();
            this.moduleSelectionButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.strikeButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "What is the cardinal";
            // 
            // cardinalComboBox
            // 
            this.cardinalComboBox.FormattingEnabled = true;
            this.cardinalComboBox.Location = new System.Drawing.Point(128, 72);
            this.cardinalComboBox.Name = "cardinalComboBox";
            this.cardinalComboBox.Size = new System.Drawing.Size(121, 21);
            this.cardinalComboBox.TabIndex = 2;
            // 
            // moduleSelectionButton
            // 
            this.moduleSelectionButton.Location = new System.Drawing.Point(12, 115);
            this.moduleSelectionButton.Name = "moduleSelectionButton";
            this.moduleSelectionButton.Size = new System.Drawing.Size(83, 39);
            this.moduleSelectionButton.TabIndex = 3;
            this.moduleSelectionButton.Text = "Module Selection";
            this.moduleSelectionButton.UseVisualStyleBackColor = true;
            this.moduleSelectionButton.Click += new System.EventHandler(this.moduleSelectionButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(101, 115);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(83, 39);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // strikeButton
            // 
            this.strikeButton.Location = new System.Drawing.Point(190, 115);
            this.strikeButton.Name = "strikeButton";
            this.strikeButton.Size = new System.Drawing.Size(83, 39);
            this.strikeButton.TabIndex = 5;
            this.strikeButton.Text = "Strike";
            this.strikeButton.UseVisualStyleBackColor = true;
            this.strikeButton.Click += new System.EventHandler(this.strikeButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(279, 115);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(83, 39);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // _3DMazeStage2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 163);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.strikeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.moduleSelectionButton);
            this.Controls.Add(this.cardinalComboBox);
            this.Controls.Add(this.label2);
            this.Name = "_3DMazeStage2Form";
            this.Text = "KTANE Bot by Hawker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cardinalComboBox;
        private System.Windows.Forms.Button moduleSelectionButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button strikeButton;
        private System.Windows.Forms.Button submitButton;
    }
}
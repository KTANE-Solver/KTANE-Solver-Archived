
namespace KTANE_Solver
{
    partial class CreationForm
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
            this.weatherComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.upperLeftComboBox = new System.Windows.Forms.ComboBox();
            this.bottomLeftComboBox = new System.Windows.Forms.ComboBox();
            this.upperRightComboBox = new System.Windows.Forms.ComboBox();
            this.bottomRightComboBox = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.strikeButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weatherComboBox
            // 
            this.weatherComboBox.FormattingEnabled = true;
            this.weatherComboBox.Location = new System.Drawing.Point(169, 34);
            this.weatherComboBox.Name = "weatherComboBox";
            this.weatherComboBox.Size = new System.Drawing.Size(121, 21);
            this.weatherComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Starting Weather:";
            // 
            // upperLeftComboBox
            // 
            this.upperLeftComboBox.FormattingEnabled = true;
            this.upperLeftComboBox.Location = new System.Drawing.Point(41, 74);
            this.upperLeftComboBox.Name = "upperLeftComboBox";
            this.upperLeftComboBox.Size = new System.Drawing.Size(99, 21);
            this.upperLeftComboBox.TabIndex = 2;
            // 
            // bottomLeftComboBox
            // 
            this.bottomLeftComboBox.FormattingEnabled = true;
            this.bottomLeftComboBox.Location = new System.Drawing.Point(41, 144);
            this.bottomLeftComboBox.Name = "bottomLeftComboBox";
            this.bottomLeftComboBox.Size = new System.Drawing.Size(99, 21);
            this.bottomLeftComboBox.TabIndex = 3;
            // 
            // upperRightComboBox
            // 
            this.upperRightComboBox.FormattingEnabled = true;
            this.upperRightComboBox.Location = new System.Drawing.Point(319, 74);
            this.upperRightComboBox.Name = "upperRightComboBox";
            this.upperRightComboBox.Size = new System.Drawing.Size(99, 21);
            this.upperRightComboBox.TabIndex = 4;
            // 
            // bottomRightComboBox
            // 
            this.bottomRightComboBox.FormattingEnabled = true;
            this.bottomRightComboBox.Location = new System.Drawing.Point(319, 133);
            this.bottomRightComboBox.Name = "bottomRightComboBox";
            this.bottomRightComboBox.Size = new System.Drawing.Size(99, 21);
            this.bottomRightComboBox.TabIndex = 5;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 195);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(90, 35);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // strikeButton
            // 
            this.strikeButton.Location = new System.Drawing.Point(185, 195);
            this.strikeButton.Name = "strikeButton";
            this.strikeButton.Size = new System.Drawing.Size(90, 35);
            this.strikeButton.TabIndex = 7;
            this.strikeButton.Text = "Stike";
            this.strikeButton.UseVisualStyleBackColor = true;
            this.strikeButton.Click += new System.EventHandler(this.strikeButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(363, 195);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(90, 35);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // CreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 242);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.strikeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.bottomRightComboBox);
            this.Controls.Add(this.upperRightComboBox);
            this.Controls.Add(this.bottomLeftComboBox);
            this.Controls.Add(this.upperLeftComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weatherComboBox);
            this.Name = "CreationForm";
            this.Text = "KTANE Bot by Hawker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox weatherComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox upperLeftComboBox;
        private System.Windows.Forms.ComboBox bottomLeftComboBox;
        private System.Windows.Forms.ComboBox upperRightComboBox;
        private System.Windows.Forms.ComboBox bottomRightComboBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button strikeButton;
        private System.Windows.Forms.Button submitButton;
    }
}
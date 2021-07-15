
namespace KTANE_Solver
{
    partial class RubixCubeForm
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
            this.topFace = new System.Windows.Forms.Label();
            this.leftFace = new System.Windows.Forms.Label();
            this.frontFace = new System.Windows.Forms.Label();
            this.rightFace = new System.Windows.Forms.Label();
            this.bottomFace = new System.Windows.Forms.Label();
            this.topComboBox = new System.Windows.Forms.ComboBox();
            this.leftComboBox = new System.Windows.Forms.ComboBox();
            this.frontComboBox = new System.Windows.Forms.ComboBox();
            this.rightComboBox = new System.Windows.Forms.ComboBox();
            this.bottomComboBox = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.strikeButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topFace
            // 
            this.topFace.AutoSize = true;
            this.topFace.Location = new System.Drawing.Point(161, 40);
            this.topFace.Name = "topFace";
            this.topFace.Size = new System.Drawing.Size(56, 13);
            this.topFace.TabIndex = 0;
            this.topFace.Text = "Top Face:";
            // 
            // leftFace
            // 
            this.leftFace.AutoSize = true;
            this.leftFace.Location = new System.Drawing.Point(161, 99);
            this.leftFace.Name = "leftFace";
            this.leftFace.Size = new System.Drawing.Size(55, 13);
            this.leftFace.TabIndex = 1;
            this.leftFace.Text = "Left Face:";
            // 
            // frontFace
            // 
            this.frontFace.AutoSize = true;
            this.frontFace.Location = new System.Drawing.Point(161, 168);
            this.frontFace.Name = "frontFace";
            this.frontFace.Size = new System.Drawing.Size(61, 13);
            this.frontFace.TabIndex = 2;
            this.frontFace.Text = "Front Face:";
            // 
            // rightFace
            // 
            this.rightFace.AutoSize = true;
            this.rightFace.Location = new System.Drawing.Point(161, 230);
            this.rightFace.Name = "rightFace";
            this.rightFace.Size = new System.Drawing.Size(62, 13);
            this.rightFace.TabIndex = 3;
            this.rightFace.Text = "Right Face:";
            // 
            // bottomFace
            // 
            this.bottomFace.AutoSize = true;
            this.bottomFace.Location = new System.Drawing.Point(161, 297);
            this.bottomFace.Name = "bottomFace";
            this.bottomFace.Size = new System.Drawing.Size(70, 13);
            this.bottomFace.TabIndex = 4;
            this.bottomFace.Text = "Bottom Face:";
            // 
            // topComboBox
            // 
            this.topComboBox.FormattingEnabled = true;
            this.topComboBox.Location = new System.Drawing.Point(297, 37);
            this.topComboBox.Name = "topComboBox";
            this.topComboBox.Size = new System.Drawing.Size(121, 21);
            this.topComboBox.TabIndex = 5;
            // 
            // leftComboBox
            // 
            this.leftComboBox.FormattingEnabled = true;
            this.leftComboBox.Location = new System.Drawing.Point(297, 96);
            this.leftComboBox.Name = "leftComboBox";
            this.leftComboBox.Size = new System.Drawing.Size(121, 21);
            this.leftComboBox.TabIndex = 6;
            // 
            // frontComboBox
            // 
            this.frontComboBox.FormattingEnabled = true;
            this.frontComboBox.Location = new System.Drawing.Point(297, 165);
            this.frontComboBox.Name = "frontComboBox";
            this.frontComboBox.Size = new System.Drawing.Size(121, 21);
            this.frontComboBox.TabIndex = 7;
            // 
            // rightComboBox
            // 
            this.rightComboBox.FormattingEnabled = true;
            this.rightComboBox.Location = new System.Drawing.Point(297, 227);
            this.rightComboBox.Name = "rightComboBox";
            this.rightComboBox.Size = new System.Drawing.Size(121, 21);
            this.rightComboBox.TabIndex = 8;
            // 
            // bottomComboBox
            // 
            this.bottomComboBox.FormattingEnabled = true;
            this.bottomComboBox.Location = new System.Drawing.Point(297, 294);
            this.bottomComboBox.Name = "bottomComboBox";
            this.bottomComboBox.Size = new System.Drawing.Size(121, 21);
            this.bottomComboBox.TabIndex = 9;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(27, 395);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(106, 43);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // strikeButton
            // 
            this.strikeButton.Location = new System.Drawing.Point(214, 395);
            this.strikeButton.Name = "strikeButton";
            this.strikeButton.Size = new System.Drawing.Size(106, 43);
            this.strikeButton.TabIndex = 11;
            this.strikeButton.Text = "Strike";
            this.strikeButton.UseVisualStyleBackColor = true;
            this.strikeButton.Click += new System.EventHandler(this.strikeButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(399, 395);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(106, 43);
            this.submitButton.TabIndex = 12;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // RubixCubeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.strikeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.bottomComboBox);
            this.Controls.Add(this.rightComboBox);
            this.Controls.Add(this.frontComboBox);
            this.Controls.Add(this.leftComboBox);
            this.Controls.Add(this.topComboBox);
            this.Controls.Add(this.bottomFace);
            this.Controls.Add(this.rightFace);
            this.Controls.Add(this.frontFace);
            this.Controls.Add(this.leftFace);
            this.Controls.Add(this.topFace);
            this.Name = "RubixCubeForm";
            this.Text = "RubixCubeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topFace;
        private System.Windows.Forms.Label leftFace;
        private System.Windows.Forms.Label frontFace;
        private System.Windows.Forms.Label rightFace;
        private System.Windows.Forms.Label bottomFace;
        private System.Windows.Forms.ComboBox topComboBox;
        private System.Windows.Forms.ComboBox leftComboBox;
        private System.Windows.Forms.ComboBox frontComboBox;
        private System.Windows.Forms.ComboBox rightComboBox;
        private System.Windows.Forms.ComboBox bottomComboBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button strikeButton;
        private System.Windows.Forms.Button submitButton;
    }
}
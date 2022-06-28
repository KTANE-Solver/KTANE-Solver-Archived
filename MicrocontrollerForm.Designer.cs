
namespace KTANE_Solver
{
    partial class MicrocontrollerForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.secondNumTextBox = new System.Windows.Forms.TextBox();
            this.LastNumTextBox = new System.Windows.Forms.TextBox();
            this.pinNumTextBox = new System.Windows.Forms.TextBox();
            this.controllerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.whiteDotComboBox = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.strikeButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "# of Pins:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Controller\'s Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Corner of white dot:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Module Serial Num Digit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Second Module Serial Num Digit: ";
            // 
            // secondNumTextBox
            // 
            this.secondNumTextBox.Location = new System.Drawing.Point(192, 165);
            this.secondNumTextBox.Name = "secondNumTextBox";
            this.secondNumTextBox.Size = new System.Drawing.Size(125, 20);
            this.secondNumTextBox.TabIndex = 5;
            // 
            // LastNumTextBox
            // 
            this.LastNumTextBox.Location = new System.Drawing.Point(192, 203);
            this.LastNumTextBox.Name = "LastNumTextBox";
            this.LastNumTextBox.Size = new System.Drawing.Size(125, 20);
            this.LastNumTextBox.TabIndex = 6;
            // 
            // pinNumTextBox
            // 
            this.pinNumTextBox.Location = new System.Drawing.Point(192, 21);
            this.pinNumTextBox.Name = "pinNumTextBox";
            this.pinNumTextBox.Size = new System.Drawing.Size(125, 20);
            this.pinNumTextBox.TabIndex = 7;
            // 
            // controllerTypeComboBox
            // 
            this.controllerTypeComboBox.FormattingEnabled = true;
            this.controllerTypeComboBox.Location = new System.Drawing.Point(192, 73);
            this.controllerTypeComboBox.Name = "controllerTypeComboBox";
            this.controllerTypeComboBox.Size = new System.Drawing.Size(125, 21);
            this.controllerTypeComboBox.TabIndex = 8;
            // 
            // whiteDotComboBox
            // 
            this.whiteDotComboBox.FormattingEnabled = true;
            this.whiteDotComboBox.Location = new System.Drawing.Point(192, 120);
            this.whiteDotComboBox.Name = "whiteDotComboBox";
            this.whiteDotComboBox.Size = new System.Drawing.Size(125, 21);
            this.whiteDotComboBox.TabIndex = 9;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 246);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(89, 37);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // strikeButton
            // 
            this.strikeButton.Location = new System.Drawing.Point(165, 246);
            this.strikeButton.Name = "strikeButton";
            this.strikeButton.Size = new System.Drawing.Size(89, 37);
            this.strikeButton.TabIndex = 11;
            this.strikeButton.Text = "Strike";
            this.strikeButton.UseVisualStyleBackColor = true;
            this.strikeButton.Click += new System.EventHandler(this.strikeButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(326, 246);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(89, 37);
            this.submitButton.TabIndex = 12;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // MicrocontrollerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 295);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.strikeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.whiteDotComboBox);
            this.Controls.Add(this.controllerTypeComboBox);
            this.Controls.Add(this.pinNumTextBox);
            this.Controls.Add(this.LastNumTextBox);
            this.Controls.Add(this.secondNumTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MicrocontrollerForm";
            this.Text = "MicrocontrollerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox secondNumTextBox;
        private System.Windows.Forms.TextBox LastNumTextBox;
        private System.Windows.Forms.TextBox pinNumTextBox;
        private System.Windows.Forms.ComboBox controllerTypeComboBox;
        private System.Windows.Forms.ComboBox whiteDotComboBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button strikeButton;
        private System.Windows.Forms.Button submitButton;
    }
}
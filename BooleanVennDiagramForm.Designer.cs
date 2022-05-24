
namespace KTANE_Solver
{
    partial class BooleanVennDiagramForm
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
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.operationChoiceBox1 = new System.Windows.Forms.ComboBox();
            this.operationChoiceBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.strikeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operation 1:";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(58, 123);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(162, 17);
            this.checkBox.TabIndex = 1;
            this.checkBox.Text = "Parentheses around A and B";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // operationChoiceBox1
            // 
            this.operationChoiceBox1.FormattingEnabled = true;
            this.operationChoiceBox1.Location = new System.Drawing.Point(119, 34);
            this.operationChoiceBox1.Name = "operationChoiceBox1";
            this.operationChoiceBox1.Size = new System.Drawing.Size(121, 21);
            this.operationChoiceBox1.TabIndex = 2;
            // 
            // operationChoiceBox2
            // 
            this.operationChoiceBox2.FormattingEnabled = true;
            this.operationChoiceBox2.Location = new System.Drawing.Point(119, 79);
            this.operationChoiceBox2.Name = "operationChoiceBox2";
            this.operationChoiceBox2.Size = new System.Drawing.Size(121, 21);
            this.operationChoiceBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Operation 2:";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 165);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 31);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(211, 165);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 31);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // strikeButton
            // 
            this.strikeButton.Location = new System.Drawing.Point(110, 165);
            this.strikeButton.Name = "strikeButton";
            this.strikeButton.Size = new System.Drawing.Size(75, 31);
            this.strikeButton.TabIndex = 7;
            this.strikeButton.Text = "Strike";
            this.strikeButton.UseVisualStyleBackColor = true;
            this.strikeButton.Click += new System.EventHandler(this.strikeButton_Click);
            // 
            // BooleanVennDiagramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 208);
            this.Controls.Add(this.strikeButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.operationChoiceBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.operationChoiceBox1);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.label1);
            this.Name = "BooleanVennDiagramForm";
            this.Text = "BooleanVennDiagramForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.ComboBox operationChoiceBox1;
        private System.Windows.Forms.ComboBox operationChoiceBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button strikeButton;
    }
}
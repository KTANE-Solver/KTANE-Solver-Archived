
namespace KTANE_Solver
{
    partial class TicTacToeInputForm
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
            this.symbolComboBox = new System.Windows.Forms.ComboBox();
            this.topLeftButton = new System.Windows.Forms.Button();
            this.topMiddleButton = new System.Windows.Forms.Button();
            this.topRightButton = new System.Windows.Forms.Button();
            this.middleRightButton = new System.Windows.Forms.Button();
            this.middleButton = new System.Windows.Forms.Button();
            this.middleLeftButton = new System.Windows.Forms.Button();
            this.bottomRightButton = new System.Windows.Forms.Button();
            this.bottomMiddleButton = new System.Windows.Forms.Button();
            this.bottomLeftButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What is the symbol?";
            // 
            // symbolComboBox
            // 
            this.symbolComboBox.FormattingEnabled = true;
            this.symbolComboBox.Location = new System.Drawing.Point(69, 41);
            this.symbolComboBox.Name = "symbolComboBox";
            this.symbolComboBox.Size = new System.Drawing.Size(121, 21);
            this.symbolComboBox.TabIndex = 1;
            // 
            // topLeftButton
            // 
            this.topLeftButton.Location = new System.Drawing.Point(33, 78);
            this.topLeftButton.Name = "topLeftButton";
            this.topLeftButton.Size = new System.Drawing.Size(63, 63);
            this.topLeftButton.TabIndex = 2;
            this.topLeftButton.UseVisualStyleBackColor = true;
            // 
            // topMiddleButton
            // 
            this.topMiddleButton.Location = new System.Drawing.Point(102, 78);
            this.topMiddleButton.Name = "topMiddleButton";
            this.topMiddleButton.Size = new System.Drawing.Size(63, 63);
            this.topMiddleButton.TabIndex = 2;
            this.topMiddleButton.UseVisualStyleBackColor = true;
            // 
            // topRightButton
            // 
            this.topRightButton.Location = new System.Drawing.Point(171, 78);
            this.topRightButton.Name = "topRightButton";
            this.topRightButton.Size = new System.Drawing.Size(63, 63);
            this.topRightButton.TabIndex = 3;
            this.topRightButton.UseVisualStyleBackColor = true;
            // 
            // middleRightButton
            // 
            this.middleRightButton.Location = new System.Drawing.Point(171, 147);
            this.middleRightButton.Name = "middleRightButton";
            this.middleRightButton.Size = new System.Drawing.Size(63, 63);
            this.middleRightButton.TabIndex = 6;
            this.middleRightButton.UseVisualStyleBackColor = true;
            // 
            // middleButton
            // 
            this.middleButton.Location = new System.Drawing.Point(102, 147);
            this.middleButton.Name = "middleButton";
            this.middleButton.Size = new System.Drawing.Size(63, 63);
            this.middleButton.TabIndex = 4;
            this.middleButton.UseVisualStyleBackColor = true;
            // 
            // middleLeftButton
            // 
            this.middleLeftButton.Location = new System.Drawing.Point(33, 147);
            this.middleLeftButton.Name = "middleLeftButton";
            this.middleLeftButton.Size = new System.Drawing.Size(63, 63);
            this.middleLeftButton.TabIndex = 5;
            this.middleLeftButton.UseVisualStyleBackColor = true;
            // 
            // bottomRightButton
            // 
            this.bottomRightButton.Location = new System.Drawing.Point(171, 216);
            this.bottomRightButton.Name = "bottomRightButton";
            this.bottomRightButton.Size = new System.Drawing.Size(63, 63);
            this.bottomRightButton.TabIndex = 9;
            this.bottomRightButton.UseVisualStyleBackColor = true;
            // 
            // bottomMiddleButton
            // 
            this.bottomMiddleButton.Location = new System.Drawing.Point(102, 216);
            this.bottomMiddleButton.Name = "bottomMiddleButton";
            this.bottomMiddleButton.Size = new System.Drawing.Size(63, 63);
            this.bottomMiddleButton.TabIndex = 7;
            this.bottomMiddleButton.UseVisualStyleBackColor = true;
            // 
            // bottomLeftButton
            // 
            this.bottomLeftButton.Location = new System.Drawing.Point(33, 216);
            this.bottomLeftButton.Name = "bottomLeftButton";
            this.bottomLeftButton.Size = new System.Drawing.Size(63, 63);
            this.bottomLeftButton.TabIndex = 8;
            this.bottomLeftButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(96, 290);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "OK";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // TicTacToeInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 325);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.bottomRightButton);
            this.Controls.Add(this.bottomMiddleButton);
            this.Controls.Add(this.bottomLeftButton);
            this.Controls.Add(this.middleRightButton);
            this.Controls.Add(this.middleButton);
            this.Controls.Add(this.middleLeftButton);
            this.Controls.Add(this.topRightButton);
            this.Controls.Add(this.topMiddleButton);
            this.Controls.Add(this.topLeftButton);
            this.Controls.Add(this.symbolComboBox);
            this.Controls.Add(this.label1);
            this.Name = "TicTacToeInputForm";
            this.Text = "TicTacToeInputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox symbolComboBox;
        private System.Windows.Forms.Button topLeftButton;
        private System.Windows.Forms.Button topMiddleButton;
        private System.Windows.Forms.Button topRightButton;
        private System.Windows.Forms.Button middleRightButton;
        private System.Windows.Forms.Button middleButton;
        private System.Windows.Forms.Button middleLeftButton;
        private System.Windows.Forms.Button bottomRightButton;
        private System.Windows.Forms.Button bottomMiddleButton;
        private System.Windows.Forms.Button bottomLeftButton;
        private System.Windows.Forms.Button submitButton;
    }
}
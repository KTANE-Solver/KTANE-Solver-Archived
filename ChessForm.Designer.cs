
namespace KTANE_Solver
{
    partial class ChessForm
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
            this.peice1Label = new System.Windows.Forms.Label();
            this.peice2Label = new System.Windows.Forms.Label();
            this.peice3Label = new System.Windows.Forms.Label();
            this.peice4Label = new System.Windows.Forms.Label();
            this.peice5Label = new System.Windows.Forms.Label();
            this.peice6Label = new System.Windows.Forms.Label();
            this.piece2TextBox = new System.Windows.Forms.TextBox();
            this.piece1TextBox = new System.Windows.Forms.TextBox();
            this.piece3TextBox = new System.Windows.Forms.TextBox();
            this.piece4TextBox = new System.Windows.Forms.TextBox();
            this.piece5TextBox = new System.Windows.Forms.TextBox();
            this.piece6TextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.strikeButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peice1Label
            // 
            this.peice1Label.AutoSize = true;
            this.peice1Label.Location = new System.Drawing.Point(28, 27);
            this.peice1Label.Name = "peice1Label";
            this.peice1Label.Size = new System.Drawing.Size(46, 13);
            this.peice1Label.TabIndex = 0;
            this.peice1Label.Text = "Piece 1:";
            // 
            // peice2Label
            // 
            this.peice2Label.AutoSize = true;
            this.peice2Label.Location = new System.Drawing.Point(28, 78);
            this.peice2Label.Name = "peice2Label";
            this.peice2Label.Size = new System.Drawing.Size(46, 13);
            this.peice2Label.TabIndex = 1;
            this.peice2Label.Text = "Piece 2:";
            // 
            // peice3Label
            // 
            this.peice3Label.AutoSize = true;
            this.peice3Label.Location = new System.Drawing.Point(28, 128);
            this.peice3Label.Name = "peice3Label";
            this.peice3Label.Size = new System.Drawing.Size(46, 13);
            this.peice3Label.TabIndex = 2;
            this.peice3Label.Text = "Piece 3:";
            // 
            // peice4Label
            // 
            this.peice4Label.AutoSize = true;
            this.peice4Label.Location = new System.Drawing.Point(28, 181);
            this.peice4Label.Name = "peice4Label";
            this.peice4Label.Size = new System.Drawing.Size(46, 13);
            this.peice4Label.TabIndex = 3;
            this.peice4Label.Text = "Piece 4:";
            // 
            // peice5Label
            // 
            this.peice5Label.AutoSize = true;
            this.peice5Label.Location = new System.Drawing.Point(28, 234);
            this.peice5Label.Name = "peice5Label";
            this.peice5Label.Size = new System.Drawing.Size(46, 13);
            this.peice5Label.TabIndex = 4;
            this.peice5Label.Text = "Piece 5:";
            // 
            // peice6Label
            // 
            this.peice6Label.AutoSize = true;
            this.peice6Label.Location = new System.Drawing.Point(28, 285);
            this.peice6Label.Name = "peice6Label";
            this.peice6Label.Size = new System.Drawing.Size(46, 13);
            this.peice6Label.TabIndex = 5;
            this.peice6Label.Text = "Piece 6:";
            // 
            // piece2TextBox
            // 
            this.piece2TextBox.Location = new System.Drawing.Point(162, 75);
            this.piece2TextBox.Name = "piece2TextBox";
            this.piece2TextBox.Size = new System.Drawing.Size(100, 20);
            this.piece2TextBox.TabIndex = 1;
            // 
            // piece1TextBox
            // 
            this.piece1TextBox.Location = new System.Drawing.Point(162, 24);
            this.piece1TextBox.Name = "piece1TextBox";
            this.piece1TextBox.Size = new System.Drawing.Size(100, 20);
            this.piece1TextBox.TabIndex = 0;
            // 
            // piece3TextBox
            // 
            this.piece3TextBox.Location = new System.Drawing.Point(162, 125);
            this.piece3TextBox.Name = "piece3TextBox";
            this.piece3TextBox.Size = new System.Drawing.Size(100, 20);
            this.piece3TextBox.TabIndex = 2;
            // 
            // piece4TextBox
            // 
            this.piece4TextBox.Location = new System.Drawing.Point(162, 178);
            this.piece4TextBox.Name = "piece4TextBox";
            this.piece4TextBox.Size = new System.Drawing.Size(100, 20);
            this.piece4TextBox.TabIndex = 3;
            // 
            // piece5TextBox
            // 
            this.piece5TextBox.Location = new System.Drawing.Point(162, 231);
            this.piece5TextBox.Name = "piece5TextBox";
            this.piece5TextBox.Size = new System.Drawing.Size(100, 20);
            this.piece5TextBox.TabIndex = 4;
            // 
            // piece6TextBox
            // 
            this.piece6TextBox.Location = new System.Drawing.Point(162, 282);
            this.piece6TextBox.Name = "piece6TextBox";
            this.piece6TextBox.Size = new System.Drawing.Size(100, 20);
            this.piece6TextBox.TabIndex = 5;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(31, 342);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(79, 32);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // strikeButton
            // 
            this.strikeButton.Location = new System.Drawing.Point(141, 342);
            this.strikeButton.Name = "strikeButton";
            this.strikeButton.Size = new System.Drawing.Size(79, 32);
            this.strikeButton.TabIndex = 7;
            this.strikeButton.Text = "Strike";
            this.strikeButton.UseVisualStyleBackColor = true;
            this.strikeButton.Click += new System.EventHandler(this.strikeButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(239, 342);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(79, 32);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // ChessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 406);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.strikeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.piece6TextBox);
            this.Controls.Add(this.piece5TextBox);
            this.Controls.Add(this.piece4TextBox);
            this.Controls.Add(this.piece3TextBox);
            this.Controls.Add(this.piece1TextBox);
            this.Controls.Add(this.piece2TextBox);
            this.Controls.Add(this.peice6Label);
            this.Controls.Add(this.peice5Label);
            this.Controls.Add(this.peice4Label);
            this.Controls.Add(this.peice3Label);
            this.Controls.Add(this.peice2Label);
            this.Controls.Add(this.peice1Label);
            this.Name = "ChessForm";
            this.Text = "ChessForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChessForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label peice1Label;
        private System.Windows.Forms.Label peice2Label;
        private System.Windows.Forms.Label peice3Label;
        private System.Windows.Forms.Label peice4Label;
        private System.Windows.Forms.Label peice5Label;
        private System.Windows.Forms.Label peice6Label;
        private System.Windows.Forms.TextBox piece2TextBox;
        private System.Windows.Forms.TextBox piece1TextBox;
        private System.Windows.Forms.TextBox piece3TextBox;
        private System.Windows.Forms.TextBox piece4TextBox;
        private System.Windows.Forms.TextBox piece5TextBox;
        private System.Windows.Forms.TextBox piece6TextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button strikeButton;
        private System.Windows.Forms.Button submitButton;
    }
}
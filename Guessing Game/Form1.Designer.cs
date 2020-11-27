namespace Guessing_Game
{
    partial class Form1
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
            this.uiLabel = new System.Windows.Forms.Label();
            this.uiLabel2 = new System.Windows.Forms.Label();
            this.numInput = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toDelete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uiLabel
            // 
            this.uiLabel.AutoSize = true;
            this.uiLabel.Font = new System.Drawing.Font("Comic Sans MS", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.uiLabel.Location = new System.Drawing.Point(12, -11);
            this.uiLabel.Name = "uiLabel";
            this.uiLabel.Size = new System.Drawing.Size(493, 90);
            this.uiLabel.TabIndex = 0;
            this.uiLabel.Text = "Guessing Game";
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("Swiss911 XCm BT", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.Red;
            this.uiLabel2.Location = new System.Drawing.Point(66, 89);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(378, 40);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "Enter a number between 1 - 100";
            // 
            // numInput
            // 
            this.numInput.BackColor = System.Drawing.Color.White;
            this.numInput.Location = new System.Drawing.Point(191, 132);
            this.numInput.Name = "numInput";
            this.numInput.Size = new System.Drawing.Size(115, 20);
            this.numInput.TabIndex = 2;
            // 
            // guessButton
            // 
            this.guessButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guessButton.Location = new System.Drawing.Point(58, 172);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(59, 228);
            this.guessButton.TabIndex = 3;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = false;
            this.guessButton.Click += new System.EventHandler(this.GuessButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.outputLabel.Font = new System.Drawing.Font("Vineta BT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(199, 188);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(245, 188);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LimeGreen;
            this.label1.Font = new System.Drawing.Font("Vineta BT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 49);
            this.label1.TabIndex = 5;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toDelete
            // 
            this.toDelete.AutoSize = true;
            this.toDelete.Location = new System.Drawing.Point(397, 139);
            this.toDelete.Name = "toDelete";
            this.toDelete.Size = new System.Drawing.Size(35, 13);
            this.toDelete.TabIndex = 6;
            this.toDelete.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.toDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.numInput);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uiLabel;
        private System.Windows.Forms.Label uiLabel2;
        private System.Windows.Forms.TextBox numInput;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label toDelete;
    }
}


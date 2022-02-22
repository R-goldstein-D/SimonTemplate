namespace SimonSays
{
    partial class GameOverScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOverScreen));
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.patternLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.highscoreLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.scoreLength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.Font = new System.Drawing.Font("Yu Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.White;
            this.gameOverLabel.Location = new System.Drawing.Point(100, 73);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(252, 56);
            this.gameOverLabel.TabIndex = 0;
            this.gameOverLabel.Text = "Game Over";
            // 
            // patternLabel
            // 
            this.patternLabel.AutoSize = true;
            this.patternLabel.BackColor = System.Drawing.Color.Transparent;
            this.patternLabel.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patternLabel.ForeColor = System.Drawing.Color.White;
            this.patternLabel.Location = new System.Drawing.Point(62, 153);
            this.patternLabel.Name = "patternLabel";
            this.patternLabel.Size = new System.Drawing.Size(290, 31);
            this.patternLabel.TabIndex = 1;
            this.patternLabel.Text = "Your pattern length was: ";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLabel.ForeColor = System.Drawing.Color.White;
            this.lengthLabel.Location = new System.Drawing.Point(386, 156);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(0, 28);
            this.lengthLabel.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(68, 355);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(105, 41);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // highscoreLabel
            // 
            this.highscoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.highscoreLabel.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.highscoreLabel.Location = new System.Drawing.Point(51, 194);
            this.highscoreLabel.Name = "highscoreLabel";
            this.highscoreLabel.Size = new System.Drawing.Size(358, 117);
            this.highscoreLabel.TabIndex = 4;
            this.highscoreLabel.Text = "HighScore\r\n0\r\n0\r\n0";
            this.highscoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(281, 355);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(105, 41);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // scoreLength
            // 
            this.scoreLength.BackColor = System.Drawing.Color.Transparent;
            this.scoreLength.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLength.ForeColor = System.Drawing.SystemColors.Control;
            this.scoreLength.Location = new System.Drawing.Point(335, 156);
            this.scoreLength.Name = "scoreLength";
            this.scoreLength.Size = new System.Drawing.Size(45, 28);
            this.scoreLength.TabIndex = 6;
            this.scoreLength.Text = "0";
            this.scoreLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.scoreLength);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.highscoreLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.patternLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(452, 462);
            this.Load += new System.EventHandler(this.GameOverScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label patternLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label highscoreLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label scoreLength;
    }
}

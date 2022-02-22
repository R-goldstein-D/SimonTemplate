namespace SimonSays
{
    partial class GameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.indigoButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.lightoranButton = new System.Windows.Forms.Button();
            this.darktourButton = new System.Windows.Forms.Button();
            this.patternlengthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // indigoButton
            // 
            this.indigoButton.BackColor = System.Drawing.Color.Indigo;
            this.indigoButton.Location = new System.Drawing.Point(60, 229);
            this.indigoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.indigoButton.Name = "indigoButton";
            this.indigoButton.Size = new System.Drawing.Size(165, 169);
            this.indigoButton.TabIndex = 3;
            this.indigoButton.UseVisualStyleBackColor = false;
            this.indigoButton.Click += new System.EventHandler(this.indigoButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.SteelBlue;
            this.blueButton.Location = new System.Drawing.Point(228, 229);
            this.blueButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(165, 169);
            this.blueButton.TabIndex = 2;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // lightoranButton
            // 
            this.lightoranButton.BackColor = System.Drawing.Color.SandyBrown;
            this.lightoranButton.Location = new System.Drawing.Point(228, 57);
            this.lightoranButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lightoranButton.Name = "lightoranButton";
            this.lightoranButton.Size = new System.Drawing.Size(165, 169);
            this.lightoranButton.TabIndex = 1;
            this.lightoranButton.UseVisualStyleBackColor = false;
            this.lightoranButton.Click += new System.EventHandler(this.lightoranButton_Click);
            // 
            // darktourButton
            // 
            this.darktourButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.darktourButton.Location = new System.Drawing.Point(60, 57);
            this.darktourButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.darktourButton.Name = "darktourButton";
            this.darktourButton.Size = new System.Drawing.Size(165, 169);
            this.darktourButton.TabIndex = 0;
            this.darktourButton.UseVisualStyleBackColor = false;
            this.darktourButton.Click += new System.EventHandler(this.darktourButton_Click_1);
            // 
            // patternlengthLabel
            // 
            this.patternlengthLabel.AutoSize = true;
            this.patternlengthLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.patternlengthLabel.Location = new System.Drawing.Point(213, 220);
            this.patternlengthLabel.Name = "patternlengthLabel";
            this.patternlengthLabel.Size = new System.Drawing.Size(0, 20);
            this.patternlengthLabel.TabIndex = 4;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.patternlengthLabel);
            this.Controls.Add(this.indigoButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.lightoranButton);
            this.Controls.Add(this.darktourButton);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(452, 462);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button indigoButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button lightoranButton;
        private System.Windows.Forms.Button darktourButton;
        private System.Windows.Forms.Label patternlengthLabel;
    }
}

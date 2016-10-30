namespace KingDGrizzles_Scammer_Bingo
{
    partial class aboutDialog
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
            this.button1 = new System.Windows.Forms.Button();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::KingDGrizzles_Scammer_Bingo.Properties.Resources.wp;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(184, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.aboutLabel.ForeColor = System.Drawing.Color.Snow;
            this.aboutLabel.Image = global::KingDGrizzles_Scammer_Bingo.Properties.Resources.blank;
            this.aboutLabel.Location = new System.Drawing.Point(26, 72);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(405, 39);
            this.aboutLabel.TabIndex = 4;
            this.aboutLabel.Text = "This program was actually my intention to make a Scammer Bingo for WindowsWorld\r\n" +
    "\r\nBut as he already made one, I decided to make my own.";
            this.aboutLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.ForeColor = System.Drawing.Color.Snow;
            this.versionLabel.Image = global::KingDGrizzles_Scammer_Bingo.Properties.Resources.blank;
            this.versionLabel.Location = new System.Drawing.Point(200, 161);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(41, 13);
            this.versionLabel.TabIndex = 6;
            this.versionLabel.Text = "version";
            this.versionLabel.Click += new System.EventHandler(this.versionLabel_Click);
            // 
            // aboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KingDGrizzles_Scammer_Bingo.Properties.Resources.wp;
            this.ClientSize = new System.Drawing.Size(460, 212);
            this.ControlBox = false;
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aboutLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "aboutDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Label versionLabel;
    }
}
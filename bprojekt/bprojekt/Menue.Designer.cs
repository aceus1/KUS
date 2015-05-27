namespace bprojekt
{
    partial class Menue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menue));
            this.Buchungen = new System.Windows.Forms.Button();
            this.Fahrtenbuch = new System.Windows.Forms.Button();
            this.Anlagenverzeichnis = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Buchungen
            // 
            this.Buchungen.Location = new System.Drawing.Point(55, 53);
            this.Buchungen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Buchungen.Name = "Buchungen";
            this.Buchungen.Size = new System.Drawing.Size(277, 28);
            this.Buchungen.TabIndex = 0;
            this.Buchungen.Text = "Buchungen";
            this.Buchungen.UseVisualStyleBackColor = true;
            this.Buchungen.Click += new System.EventHandler(this.Buchungen_Click);
            // 
            // Fahrtenbuch
            // 
            this.Fahrtenbuch.Location = new System.Drawing.Point(55, 108);
            this.Fahrtenbuch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Fahrtenbuch.Name = "Fahrtenbuch";
            this.Fahrtenbuch.Size = new System.Drawing.Size(277, 30);
            this.Fahrtenbuch.TabIndex = 1;
            this.Fahrtenbuch.Text = "Fahrtenbuch ";
            this.Fahrtenbuch.UseVisualStyleBackColor = true;
            this.Fahrtenbuch.Click += new System.EventHandler(this.Fahrtenbuch_Click);
            // 
            // Anlagenverzeichnis
            // 
            this.Anlagenverzeichnis.Location = new System.Drawing.Point(55, 159);
            this.Anlagenverzeichnis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Anlagenverzeichnis.Name = "Anlagenverzeichnis";
            this.Anlagenverzeichnis.Size = new System.Drawing.Size(277, 28);
            this.Anlagenverzeichnis.TabIndex = 2;
            this.Anlagenverzeichnis.Text = "Anlageverzeichnis";
            this.Anlagenverzeichnis.UseVisualStyleBackColor = true;
            this.Anlagenverzeichnis.Click += new System.EventHandler(this.Anlagenverzeichnis_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(252, 236);
            this.logout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(100, 28);
            this.logout.TabIndex = 3;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Menue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(383, 297);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.Anlagenverzeichnis);
            this.Controls.Add(this.Fahrtenbuch);
            this.Controls.Add(this.Buchungen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menue";
            this.Text = "Menü";
            this.Load += new System.EventHandler(this.Menue_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Buchungen;
        private System.Windows.Forms.Button Fahrtenbuch;
        private System.Windows.Forms.Button Anlagenverzeichnis;
        private System.Windows.Forms.Button logout;
    }
}
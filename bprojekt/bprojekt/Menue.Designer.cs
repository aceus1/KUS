﻿namespace bprojekt
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
            this.Buchungen = new System.Windows.Forms.Button();
            this.Fahrtenbuch = new System.Windows.Forms.Button();
            this.Anlagenverzeichnis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Buchungen
            // 
            this.Buchungen.Location = new System.Drawing.Point(41, 43);
            this.Buchungen.Name = "Buchungen";
            this.Buchungen.Size = new System.Drawing.Size(106, 23);
            this.Buchungen.TabIndex = 0;
            this.Buchungen.Text = "Buchungen";
            this.Buchungen.UseVisualStyleBackColor = true;
            // 
            // Fahrtenbuch
            // 
            this.Fahrtenbuch.Location = new System.Drawing.Point(41, 88);
            this.Fahrtenbuch.Name = "Fahrtenbuch";
            this.Fahrtenbuch.Size = new System.Drawing.Size(106, 24);
            this.Fahrtenbuch.TabIndex = 1;
            this.Fahrtenbuch.Text = "Fahrtenbuch ";
            this.Fahrtenbuch.UseVisualStyleBackColor = true;
            // 
            // Anlagenverzeichnis
            // 
            this.Anlagenverzeichnis.Location = new System.Drawing.Point(41, 129);
            this.Anlagenverzeichnis.Name = "Anlagenverzeichnis";
            this.Anlagenverzeichnis.Size = new System.Drawing.Size(106, 23);
            this.Anlagenverzeichnis.TabIndex = 2;
            this.Anlagenverzeichnis.Text = "Anlageverzeichnis";
            this.Anlagenverzeichnis.UseVisualStyleBackColor = true;
            // 
            // Menue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Anlagenverzeichnis);
            this.Controls.Add(this.Fahrtenbuch);
            this.Controls.Add(this.Buchungen);
            this.Name = "Menue";
            this.Text = "Menü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Buchungen;
        private System.Windows.Forms.Button Fahrtenbuch;
        private System.Windows.Forms.Button Anlagenverzeichnis;
    }
}
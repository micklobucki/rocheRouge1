namespace roche_rouge1
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
            this.mouseOn = new System.Windows.Forms.Button();
            this.mouseOff = new System.Windows.Forms.Button();
            this.spotifyStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.spotifyTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mouseOn
            // 
            this.mouseOn.Location = new System.Drawing.Point(12, 29);
            this.mouseOn.Name = "mouseOn";
            this.mouseOn.Size = new System.Drawing.Size(75, 23);
            this.mouseOn.TabIndex = 0;
            this.mouseOn.Text = "Mouse ON";
            this.mouseOn.UseVisualStyleBackColor = true;
            this.mouseOn.Click += new System.EventHandler(this.mouseOn_Click);
            // 
            // mouseOff
            // 
            this.mouseOff.Location = new System.Drawing.Point(94, 28);
            this.mouseOff.Name = "mouseOff";
            this.mouseOff.Size = new System.Drawing.Size(75, 23);
            this.mouseOff.TabIndex = 1;
            this.mouseOff.Text = "Mouse OFF";
            this.mouseOff.UseVisualStyleBackColor = true;
            this.mouseOff.Click += new System.EventHandler(this.mouseOff_Click);
            // 
            // spotifyStop
            // 
            this.spotifyStop.Location = new System.Drawing.Point(12, 59);
            this.spotifyStop.Name = "spotifyStop";
            this.spotifyStop.Size = new System.Drawing.Size(75, 23);
            this.spotifyStop.TabIndex = 2;
            this.spotifyStop.Text = "Spotify Stop";
            this.spotifyStop.UseVisualStyleBackColor = true;
            this.spotifyStop.Click += new System.EventHandler(this.spotifyStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "min";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // spotifyTime
            // 
            this.spotifyTime.Location = new System.Drawing.Point(93, 62);
            this.spotifyTime.Name = "spotifyTime";
            this.spotifyTime.Size = new System.Drawing.Size(76, 20);
            this.spotifyTime.TabIndex = 4;
            this.spotifyTime.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SpotifyStop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 338);
            this.Controls.Add(this.spotifyTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spotifyStop);
            this.Controls.Add(this.mouseOff);
            this.Controls.Add(this.mouseOn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mouseOn;
        private System.Windows.Forms.Button mouseOff;
        private System.Windows.Forms.Button spotifyStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox spotifyTime;
    }
}


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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shutdown = new System.Windows.Forms.Button();
            this.mouseEnabled = new System.Windows.Forms.CheckBox();
            this.LockDetectOne = new System.Windows.Forms.Button();
            this.LockDetectOff = new System.Windows.Forms.Button();
            this.lockDetectEnabled = new System.Windows.Forms.CheckBox();
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
            this.mouseOff.Location = new System.Drawing.Point(94, 29);
            this.mouseOff.Name = "mouseOff";
            this.mouseOff.Size = new System.Drawing.Size(75, 23);
            this.mouseOff.TabIndex = 1;
            this.mouseOff.Text = "Mouse OFF";
            this.mouseOff.UseVisualStyleBackColor = true;
            this.mouseOff.Click += new System.EventHandler(this.mouseOff_Click);
            // 
            // spotifyStop
            // 
            this.spotifyStop.Location = new System.Drawing.Point(12, 81);
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
            this.label1.Location = new System.Drawing.Point(175, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "min";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // spotifyTime
            // 
            this.spotifyTime.Location = new System.Drawing.Point(93, 84);
            this.spotifyTime.Name = "spotifyTime";
            this.spotifyTime.Size = new System.Drawing.Size(76, 20);
            this.spotifyTime.TabIndex = 4;
            this.spotifyTime.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "min";
            // 
            // shutdown
            // 
            this.shutdown.Location = new System.Drawing.Point(12, 113);
            this.shutdown.Name = "shutdown";
            this.shutdown.Size = new System.Drawing.Size(75, 23);
            this.shutdown.TabIndex = 7;
            this.shutdown.Text = "Shutdown";
            this.shutdown.UseVisualStyleBackColor = true;
            this.shutdown.Click += new System.EventHandler(this.shutdown_Click);
            // 
            // mouseEnabled
            // 
            this.mouseEnabled.AutoSize = true;
            this.mouseEnabled.Enabled = false;
            this.mouseEnabled.Location = new System.Drawing.Point(178, 33);
            this.mouseEnabled.Name = "mouseEnabled";
            this.mouseEnabled.Size = new System.Drawing.Size(15, 14);
            this.mouseEnabled.TabIndex = 8;
            this.mouseEnabled.UseVisualStyleBackColor = true;
            this.mouseEnabled.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LockDetectOne
            // 
            this.LockDetectOne.Location = new System.Drawing.Point(13, 55);
            this.LockDetectOne.Name = "LockDetectOne";
            this.LockDetectOne.Size = new System.Drawing.Size(75, 23);
            this.LockDetectOne.TabIndex = 9;
            this.LockDetectOne.Text = "Lock Detect On";
            this.LockDetectOne.UseVisualStyleBackColor = true;
            this.LockDetectOne.Click += new System.EventHandler(this.LockDetectOne_Click);
            // 
            // LockDetectOff
            // 
            this.LockDetectOff.Location = new System.Drawing.Point(94, 55);
            this.LockDetectOff.Name = "LockDetectOff";
            this.LockDetectOff.Size = new System.Drawing.Size(75, 23);
            this.LockDetectOff.TabIndex = 10;
            this.LockDetectOff.Text = "Lock Detect Off";
            this.LockDetectOff.UseVisualStyleBackColor = true;
            this.LockDetectOff.Click += new System.EventHandler(this.LockDetectOff_Click);
            // 
            // lockDetectEnabled
            // 
            this.lockDetectEnabled.AutoSize = true;
            this.lockDetectEnabled.Enabled = false;
            this.lockDetectEnabled.Location = new System.Drawing.Point(178, 59);
            this.lockDetectEnabled.Name = "lockDetectEnabled";
            this.lockDetectEnabled.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lockDetectEnabled.Size = new System.Drawing.Size(15, 14);
            this.lockDetectEnabled.TabIndex = 11;
            this.lockDetectEnabled.UseVisualStyleBackColor = true;
            this.lockDetectEnabled.CheckedChanged += new System.EventHandler(this.lockDetectEnabled_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 338);
            this.Controls.Add(this.lockDetectEnabled);
            this.Controls.Add(this.LockDetectOff);
            this.Controls.Add(this.LockDetectOne);
            this.Controls.Add(this.mouseEnabled);
            this.Controls.Add(this.shutdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button shutdown;
        private System.Windows.Forms.CheckBox mouseEnabled;
        private System.Windows.Forms.Button LockDetectOne;
        private System.Windows.Forms.Button LockDetectOff;
        private System.Windows.Forms.CheckBox lockDetectEnabled;
    }
}


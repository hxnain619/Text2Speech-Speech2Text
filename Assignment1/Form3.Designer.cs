namespace Assignment1
{
    partial class Form3
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Speak = new System.Windows.Forms.Button();
            this.Resume = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(84, 76);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(626, 210);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Enter here ...";
            // 
            // Speak
            // 
            this.Speak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(193)))), ((int)(((byte)(120)))));
            this.Speak.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(193)))), ((int)(((byte)(120)))));
            this.Speak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Speak.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speak.ForeColor = System.Drawing.Color.White;
            this.Speak.Location = new System.Drawing.Point(84, 324);
            this.Speak.Name = "Speak";
            this.Speak.Size = new System.Drawing.Size(101, 43);
            this.Speak.TabIndex = 2;
            this.Speak.Text = "Speak";
            this.Speak.UseVisualStyleBackColor = false;
            this.Speak.Click += new System.EventHandler(this.Speak_Click);
            // 
            // Resume
            // 
            this.Resume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(193)))), ((int)(((byte)(120)))));
            this.Resume.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Resume.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Resume.ForeColor = System.Drawing.Color.White;
            this.Resume.Location = new System.Drawing.Point(259, 324);
            this.Resume.Name = "Resume";
            this.Resume.Size = new System.Drawing.Size(94, 43);
            this.Resume.TabIndex = 3;
            this.Resume.Text = "Resume";
            this.Resume.UseVisualStyleBackColor = false;
            this.Resume.Click += new System.EventHandler(this.Resume_Click);
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(193)))), ((int)(((byte)(120)))));
            this.Pause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pause.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Pause.ForeColor = System.Drawing.Color.White;
            this.Pause.Location = new System.Drawing.Point(423, 324);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(103, 43);
            this.Pause.TabIndex = 4;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = false;
            this.Pause.Click += new System.EventHandler(this.button3_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(193)))), ((int)(((byte)(120)))));
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Stop.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Stop.ForeColor = System.Drawing.Color.White;
            this.Stop.Location = new System.Drawing.Point(616, 324);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(94, 43);
            this.Stop.TabIndex = 5;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(193)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(78, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Text Below";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(193)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(756, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(193)))), ((int)(((byte)(120)))));
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Back";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Resume);
            this.Controls.Add(this.Speak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Speak;
        private System.Windows.Forms.Button Resume;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
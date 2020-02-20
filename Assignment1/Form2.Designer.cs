namespace Assignment1
{
    partial class Form2
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
            this.ListenBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Speak = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListenBox
            // 
            this.ListenBox.BackColor = System.Drawing.Color.White;
            this.ListenBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListenBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListenBox.Location = new System.Drawing.Point(113, 82);
            this.ListenBox.Name = "ListenBox";
            this.ListenBox.ReadOnly = true;
            this.ListenBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ListenBox.ShowSelectionMargin = true;
            this.ListenBox.Size = new System.Drawing.Size(593, 235);
            this.ListenBox.TabIndex = 0;
            this.ListenBox.Text = "Say Hello ...";
            this.ListenBox.TextChanged += new System.EventHandler(this.ListenBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(193)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(107, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Speak Now ";
            // 
            // Speak
            // 
            this.Speak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(193)))), ((int)(((byte)(120)))));
            this.Speak.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(193)))), ((int)(((byte)(120)))));
            this.Speak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Speak.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speak.ForeColor = System.Drawing.Color.White;
            this.Speak.Location = new System.Drawing.Point(468, 350);
            this.Speak.Name = "Speak";
            this.Speak.Size = new System.Drawing.Size(238, 43);
            this.Speak.TabIndex = 3;
            this.Speak.Text = "Speak";
            this.Speak.UseVisualStyleBackColor = false;
            this.Speak.Click += new System.EventHandler(this.Speak_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(193)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(755, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.label3.TabIndex = 5;
            this.label3.Text = "Back";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Speak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListenBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ListenBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Speak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}
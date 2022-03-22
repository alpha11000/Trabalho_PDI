namespace Trabalho_de_PDI
{
    partial class ConverterCor
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
            this.H = new System.Windows.Forms.TextBox();
            this.Hue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.S = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.V = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.G = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.R = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // H
            // 
            this.H.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.H.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.H.ForeColor = System.Drawing.Color.White;
            this.H.ImeMode = System.Windows.Forms.ImeMode.On;
            this.H.Location = new System.Drawing.Point(33, 9);
            this.H.MaxLength = 6;
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(69, 13);
            this.H.TabIndex = 0;
            this.H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Hue
            // 
            this.Hue.AutoSize = true;
            this.Hue.ForeColor = System.Drawing.Color.White;
            this.Hue.Location = new System.Drawing.Point(12, 9);
            this.Hue.Name = "Hue";
            this.Hue.Size = new System.Drawing.Size(15, 13);
            this.Hue.TabIndex = 1;
            this.Hue.Text = "H";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "S";
            // 
            // S
            // 
            this.S.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.S.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.S.ForeColor = System.Drawing.Color.White;
            this.S.ImeMode = System.Windows.Forms.ImeMode.On;
            this.S.Location = new System.Drawing.Point(33, 28);
            this.S.MaxLength = 6;
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(69, 13);
            this.S.TabIndex = 2;
            this.S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "V";
            // 
            // V
            // 
            this.V.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.V.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.V.ForeColor = System.Drawing.Color.White;
            this.V.ImeMode = System.Windows.Forms.ImeMode.On;
            this.V.Location = new System.Drawing.Point(33, 47);
            this.V.MaxLength = 3;
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(69, 13);
            this.V.TabIndex = 4;
            this.V.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Para RGB";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.paraRGB_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(108, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1, 51);
            this.label3.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(115, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "Para HSV";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.paraHSV_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(190, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "B";
            // 
            // B
            // 
            this.B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.B.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.B.ForeColor = System.Drawing.Color.White;
            this.B.Location = new System.Drawing.Point(115, 47);
            this.B.MaxLength = 3;
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(69, 13);
            this.B.TabIndex = 12;
            this.B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(190, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "G";
            // 
            // G
            // 
            this.G.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.G.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.G.ForeColor = System.Drawing.Color.White;
            this.G.Location = new System.Drawing.Point(115, 28);
            this.G.MaxLength = 3;
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(69, 13);
            this.G.TabIndex = 10;
            this.G.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(190, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "R";
            // 
            // R
            // 
            this.R.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.R.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.R.ForeColor = System.Drawing.Color.White;
            this.R.Location = new System.Drawing.Point(115, 9);
            this.R.MaxLength = 3;
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(69, 13);
            this.R.TabIndex = 8;
            this.R.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConverterCor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(215, 98);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.B);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.G);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.R);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.V);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.S);
            this.Controls.Add(this.Hue);
            this.Controls.Add(this.H);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConverterCor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ColorConversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox H;
        private System.Windows.Forms.Label Hue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox S;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox V;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox G;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox R;
    }
}
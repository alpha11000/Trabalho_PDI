namespace Trabalho_de_PDI
{
    partial class principal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AbrirButton = new System.Windows.Forms.Button();
            this.PBbutton = new System.Windows.Forms.Button();
            this.CanaisButton = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.EqualizarButton = new System.Windows.Forms.Button();
            this.ExibirHistogramaButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.especificarButton = new System.Windows.Forms.Button();
            this.converterButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.compararButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arquivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelos de Cor";
            // 
            // AbrirButton
            // 
            this.AbrirButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(165)))), ((int)(((byte)(93)))));
            this.AbrirButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AbrirButton.FlatAppearance.BorderSize = 0;
            this.AbrirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AbrirButton.Location = new System.Drawing.Point(13, 31);
            this.AbrirButton.Name = "AbrirButton";
            this.AbrirButton.Size = new System.Drawing.Size(91, 23);
            this.AbrirButton.TabIndex = 1;
            this.AbrirButton.Text = "Abrir Imagem";
            this.AbrirButton.UseVisualStyleBackColor = false;
            this.AbrirButton.Click += new System.EventHandler(this.AbrirButton_Click);
            // 
            // PBbutton
            // 
            this.PBbutton.BackColor = System.Drawing.Color.White;
            this.PBbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBbutton.Enabled = false;
            this.PBbutton.FlatAppearance.BorderSize = 0;
            this.PBbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PBbutton.Location = new System.Drawing.Point(13, 109);
            this.PBbutton.Name = "PBbutton";
            this.PBbutton.Size = new System.Drawing.Size(91, 23);
            this.PBbutton.TabIndex = 3;
            this.PBbutton.Text = "Preto e Branco";
            this.PBbutton.UseVisualStyleBackColor = false;
            this.PBbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CanaisButton
            // 
            this.CanaisButton.BackColor = System.Drawing.Color.White;
            this.CanaisButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CanaisButton.Enabled = false;
            this.CanaisButton.FlatAppearance.BorderSize = 0;
            this.CanaisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CanaisButton.Location = new System.Drawing.Point(122, 109);
            this.CanaisButton.Name = "CanaisButton";
            this.CanaisButton.Size = new System.Drawing.Size(91, 23);
            this.CanaisButton.TabIndex = 4;
            this.CanaisButton.Text = "Exibir Canais";
            this.CanaisButton.UseVisualStyleBackColor = false;
            this.CanaisButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.ForeColor = System.Drawing.Color.White;
            this.fileNameLabel.Location = new System.Drawing.Point(109, 31);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(0, 13);
            this.fileNameLabel.TabIndex = 5;
            // 
            // EqualizarButton
            // 
            this.EqualizarButton.BackColor = System.Drawing.Color.White;
            this.EqualizarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EqualizarButton.Enabled = false;
            this.EqualizarButton.FlatAppearance.BorderSize = 0;
            this.EqualizarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EqualizarButton.Location = new System.Drawing.Point(122, 179);
            this.EqualizarButton.Name = "EqualizarButton";
            this.EqualizarButton.Size = new System.Drawing.Size(91, 23);
            this.EqualizarButton.TabIndex = 8;
            this.EqualizarButton.Text = "Equalizar";
            this.EqualizarButton.UseVisualStyleBackColor = false;
            this.EqualizarButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // ExibirHistogramaButton
            // 
            this.ExibirHistogramaButton.BackColor = System.Drawing.Color.White;
            this.ExibirHistogramaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExibirHistogramaButton.Enabled = false;
            this.ExibirHistogramaButton.FlatAppearance.BorderSize = 0;
            this.ExibirHistogramaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExibirHistogramaButton.Location = new System.Drawing.Point(13, 179);
            this.ExibirHistogramaButton.Name = "ExibirHistogramaButton";
            this.ExibirHistogramaButton.Size = new System.Drawing.Size(91, 23);
            this.ExibirHistogramaButton.TabIndex = 7;
            this.ExibirHistogramaButton.Text = "Exibir";
            this.ExibirHistogramaButton.UseVisualStyleBackColor = false;
            this.ExibirHistogramaButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Histograma";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // especificarButton
            // 
            this.especificarButton.BackColor = System.Drawing.Color.White;
            this.especificarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.especificarButton.Enabled = false;
            this.especificarButton.FlatAppearance.BorderSize = 0;
            this.especificarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.especificarButton.Location = new System.Drawing.Point(233, 179);
            this.especificarButton.Name = "especificarButton";
            this.especificarButton.Size = new System.Drawing.Size(91, 23);
            this.especificarButton.TabIndex = 10;
            this.especificarButton.Text = "Especificar";
            this.especificarButton.UseVisualStyleBackColor = false;
            this.especificarButton.Click += new System.EventHandler(this.especificarButton_Click);
            // 
            // converterButton
            // 
            this.converterButton.BackColor = System.Drawing.Color.White;
            this.converterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.converterButton.Enabled = false;
            this.converterButton.FlatAppearance.BorderSize = 0;
            this.converterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.converterButton.Location = new System.Drawing.Point(233, 109);
            this.converterButton.Name = "converterButton";
            this.converterButton.Size = new System.Drawing.Size(91, 23);
            this.converterButton.TabIndex = 11;
            this.converterButton.Text = "Converter Cor";
            this.converterButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(59, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 1);
            this.label4.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(97, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 1);
            this.label5.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(76, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 1);
            this.label6.TabIndex = 14;
            // 
            // compararButton
            // 
            this.compararButton.BackColor = System.Drawing.Color.White;
            this.compararButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compararButton.Enabled = false;
            this.compararButton.FlatAppearance.BorderSize = 0;
            this.compararButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compararButton.Location = new System.Drawing.Point(13, 220);
            this.compararButton.Name = "compararButton";
            this.compararButton.Size = new System.Drawing.Size(311, 24);
            this.compararButton.TabIndex = 15;
            this.compararButton.Text = "Comparar Histogramas";
            this.compararButton.UseVisualStyleBackColor = false;
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(337, 312);
            this.Controls.Add(this.compararButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.converterButton);
            this.Controls.Add(this.especificarButton);
            this.Controls.Add(this.EqualizarButton);
            this.Controls.Add(this.ExibirHistogramaButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.CanaisButton);
            this.Controls.Add(this.PBbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AbrirButton);
            this.Controls.Add(this.label1);
            this.Name = "principal";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "principal";
            this.Load += new System.EventHandler(this.principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AbrirButton;
        private System.Windows.Forms.Button PBbutton;
        private System.Windows.Forms.Button CanaisButton;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Button EqualizarButton;
        private System.Windows.Forms.Button ExibirHistogramaButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button especificarButton;
        private System.Windows.Forms.Button converterButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button compararButton;
    }
}
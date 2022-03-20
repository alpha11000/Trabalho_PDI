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
            this.testeLabel = new System.Windows.Forms.Label();
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
            this.label2.Location = new System.Drawing.Point(10, 85);
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
            this.AbrirButton.Location = new System.Drawing.Point(12, 26);
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
            this.PBbutton.Location = new System.Drawing.Point(13, 101);
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
            this.CanaisButton.Location = new System.Drawing.Point(122, 101);
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
            this.EqualizarButton.Location = new System.Drawing.Point(122, 162);
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
            this.ExibirHistogramaButton.Location = new System.Drawing.Point(13, 162);
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
            this.label3.Location = new System.Drawing.Point(10, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Histograma";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // testeLabel
            // 
            this.testeLabel.AutoSize = true;
            this.testeLabel.BackColor = System.Drawing.Color.White;
            this.testeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testeLabel.Location = new System.Drawing.Point(18, 244);
            this.testeLabel.Name = "testeLabel";
            this.testeLabel.Size = new System.Drawing.Size(53, 17);
            this.testeLabel.TabIndex = 9;
            this.testeLabel.Text = "TESTE";
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(490, 422);
            this.Controls.Add(this.testeLabel);
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
        private System.Windows.Forms.Label testeLabel;
    }
}
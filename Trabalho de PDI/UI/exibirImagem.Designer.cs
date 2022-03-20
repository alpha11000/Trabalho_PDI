namespace Trabalho_de_PDI
{
    partial class exibirImagem
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
            this.ExportarButton = new System.Windows.Forms.Button();
            this.imagem = new System.Windows.Forms.PictureBox();
            this.saturacaoPanel = new System.Windows.Forms.Panel();
            this.saturacaoText = new System.Windows.Forms.Label();
            this.saturacaoTrack = new System.Windows.Forms.TrackBar();
            this.saturacaoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).BeginInit();
            this.saturacaoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saturacaoTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // ExportarButton
            // 
            this.ExportarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportarButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExportarButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ExportarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportarButton.ForeColor = System.Drawing.Color.White;
            this.ExportarButton.Location = new System.Drawing.Point(0, 362);
            this.ExportarButton.Name = "ExportarButton";
            this.ExportarButton.Size = new System.Drawing.Size(384, 22);
            this.ExportarButton.TabIndex = 1;
            this.ExportarButton.Text = "Exportar";
            this.ExportarButton.UseVisualStyleBackColor = true;
            this.ExportarButton.Click += new System.EventHandler(this.ExportarButton_Click);
            // 
            // imagem
            // 
            this.imagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagem.Location = new System.Drawing.Point(0, 0);
            this.imagem.Name = "imagem";
            this.imagem.Size = new System.Drawing.Size(384, 384);
            this.imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagem.TabIndex = 0;
            this.imagem.TabStop = false;
            // 
            // saturacaoPanel
            // 
            this.saturacaoPanel.Controls.Add(this.saturacaoButton);
            this.saturacaoPanel.Controls.Add(this.saturacaoTrack);
            this.saturacaoPanel.Controls.Add(this.saturacaoText);
            this.saturacaoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saturacaoPanel.Location = new System.Drawing.Point(0, 334);
            this.saturacaoPanel.Name = "saturacaoPanel";
            this.saturacaoPanel.Padding = new System.Windows.Forms.Padding(4);
            this.saturacaoPanel.Size = new System.Drawing.Size(384, 28);
            this.saturacaoPanel.TabIndex = 2;
            this.saturacaoPanel.Visible = false;
            // 
            // saturacaoText
            // 
            this.saturacaoText.AutoSize = true;
            this.saturacaoText.Dock = System.Windows.Forms.DockStyle.Left;
            this.saturacaoText.ForeColor = System.Drawing.Color.White;
            this.saturacaoText.Location = new System.Drawing.Point(4, 4);
            this.saturacaoText.Name = "saturacaoText";
            this.saturacaoText.Size = new System.Drawing.Size(121, 13);
            this.saturacaoText.TabIndex = 0;
            this.saturacaoText.Text = "Incrementar Saturação  ";
            // 
            // saturacaoTrack
            // 
            this.saturacaoTrack.Dock = System.Windows.Forms.DockStyle.Left;
            this.saturacaoTrack.LargeChange = 10;
            this.saturacaoTrack.Location = new System.Drawing.Point(125, 4);
            this.saturacaoTrack.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.saturacaoTrack.Maximum = 100;
            this.saturacaoTrack.Name = "saturacaoTrack";
            this.saturacaoTrack.Size = new System.Drawing.Size(178, 20);
            this.saturacaoTrack.TabIndex = 1;
            this.saturacaoTrack.TickFrequency = 25;
            // 
            // saturacaoButton
            // 
            this.saturacaoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saturacaoButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.saturacaoButton.Location = new System.Drawing.Point(305, 4);
            this.saturacaoButton.Name = "saturacaoButton";
            this.saturacaoButton.Size = new System.Drawing.Size(75, 20);
            this.saturacaoButton.TabIndex = 2;
            this.saturacaoButton.Text = "Ajustar";
            this.saturacaoButton.UseVisualStyleBackColor = true;
            this.saturacaoButton.Click += new System.EventHandler(this.saturacaoButton_Click);
            // 
            // exibirImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(384, 384);
            this.Controls.Add(this.saturacaoPanel);
            this.Controls.Add(this.ExportarButton);
            this.Controls.Add(this.imagem);
            this.Name = "exibirImagem";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "exibirImagem";
            this.Load += new System.EventHandler(this.exibirImagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).EndInit();
            this.saturacaoPanel.ResumeLayout(false);
            this.saturacaoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saturacaoTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagem;
        private System.Windows.Forms.Button ExportarButton;
        private System.Windows.Forms.Panel saturacaoPanel;
        private System.Windows.Forms.TrackBar saturacaoTrack;
        private System.Windows.Forms.Label saturacaoText;
        private System.Windows.Forms.Button saturacaoButton;
    }
}
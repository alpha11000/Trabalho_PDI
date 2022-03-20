namespace Trabalho_de_PDI
{
    partial class InterfacePDI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfacePDI));
            this.avancar_button = new MetroFramework.Controls.MetroButton();
            this.imagem_escolhida = new System.Windows.Forms.PictureBox();
            this.escolher_imagem_button = new MetroFramework.Controls.MetroButton();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imagem_escolhida)).BeginInit();
            this.SuspendLayout();
            // 
            // avancar_button
            // 
            resources.ApplyResources(this.avancar_button, "avancar_button");
            this.avancar_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.avancar_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avancar_button.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.avancar_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.avancar_button.Name = "avancar_button";
            this.avancar_button.Style = MetroFramework.MetroColorStyle.White;
            this.avancar_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.avancar_button.UseCustomBackColor = true;
            this.avancar_button.UseMnemonic = false;
            this.avancar_button.UseSelectable = true;
            this.avancar_button.UseStyleColors = true;
            this.avancar_button.Click += new System.EventHandler(this.avancar_Click);
            // 
            // imagem_escolhida
            // 
            this.imagem_escolhida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.imagem_escolhida, "imagem_escolhida");
            this.imagem_escolhida.Name = "imagem_escolhida";
            this.imagem_escolhida.TabStop = false;
            // 
            // escolher_imagem_button
            // 
            resources.ApplyResources(this.escolher_imagem_button, "escolher_imagem_button");
            this.escolher_imagem_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.escolher_imagem_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.escolher_imagem_button.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.escolher_imagem_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.escolher_imagem_button.Name = "escolher_imagem_button";
            this.escolher_imagem_button.Style = MetroFramework.MetroColorStyle.White;
            this.escolher_imagem_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.escolher_imagem_button.UseCustomBackColor = true;
            this.escolher_imagem_button.UseMnemonic = false;
            this.escolher_imagem_button.UseSelectable = true;
            this.escolher_imagem_button.UseStyleColors = true;
            this.escolher_imagem_button.Click += new System.EventHandler(this.escolher_imagem_button_Click);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Name = "metroContextMenu1";
            resources.ApplyResources(this.metroContextMenu1, "metroContextMenu1");
            // 
            // InterfacePDI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.escolher_imagem_button);
            this.Controls.Add(this.imagem_escolhida);
            this.Controls.Add(this.avancar_button);
            this.HelpButton = true;
            this.Name = "InterfacePDI";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.InterfacePDI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagem_escolhida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton avancar_button;
        private System.Windows.Forms.PictureBox imagem_escolhida;
        private MetroFramework.Controls.MetroButton escolher_imagem_button;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
    }
}
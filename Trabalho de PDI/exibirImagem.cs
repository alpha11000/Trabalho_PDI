using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_de_PDI
{
    public partial class exibirImagem : Form
    {

        public exibirImagem(Image image,  String imageName = "imagem")
        {
            InitializeComponent();
            this.Text = imageName;
            imagem.Image = image;
        }

        private void ExportarButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "output.png";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagem.Image.Save(saveFileDialog.FileName, ImageFormat.Png);
            }
        }
    }
}

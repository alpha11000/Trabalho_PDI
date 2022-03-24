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
        HSV[,] hsvMatrix = null;
        Bitmap bitmapImage = null;

        public exibirImagem(Bitmap image,  String imageName = "imagem", bool increaseSaturation = false)
        {
            InitializeComponent();
            this.Text = imageName;
            imagem.Image = image;
            bitmapImage = image;

            if (increaseSaturation) saturacaoPanel.Visible = true;
        }

        public exibirImagem(HSV[,] hsvMatrix, String imageName = "imagem")
        {
            InitializeComponent();
            this.Text = imageName;
            this.hsvMatrix = hsvMatrix;
            saturacaoPanel.Visible = true;
            imagem.Image = ColorProcessing.convertHsvMatrixToBitmap(hsvMatrix);
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

        private void exibirImagem_Load(object sender, EventArgs e)
        {

        }

        private void saturacaoButton_Click(object sender, EventArgs e)
        {
            if(hsvMatrix == null)
            {
                if(bitmapImage != null)
                {
                    hsvMatrix = ColorProcessing.convertBitmapToHsvMatrix(bitmapImage);
                }
                else
                {
                    return;
                }
            }

            double saturationIncrease = saturacaoTrack.Value / 100.0;
            HSV[,] saturationIncreased = ColorProcessing.increaseHsvMatrixSaturation(hsvMatrix, saturationIncrease);
            imagem.Image = ColorProcessing.convertHsvMatrixToBitmap(saturationIncreased);
        }
    }
}

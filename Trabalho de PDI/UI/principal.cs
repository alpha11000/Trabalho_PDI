using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Trabalho_de_PDI
{
    public partial class principal : Form
    {
        private OpenFileDialog OpenFileDialog;
        private String fileName;
        private Image image = null;
        private Bitmap bitmapImage = null;
        private HSV[,] hsvMatrix = null;
        SortedDictionary<double, int> histogram = null;
        HSV[,] equalizedHsvMatrix = null;
        SortedDictionary<double, int> equalizedHistogram = null;
        Dictionary<double, double> equalizedValuesMap = null;

        public principal()
        {
            OpenFileDialog = new OpenFileDialog();
            InitializeComponent();
        }

        private void enableButtons()
        {
            PBbutton.Enabled = true;
            CanaisButton.Enabled = true;
            ExibirHistogramaButton.Enabled = true;
            EqualizarButton.Enabled = true;
            EspecificarButton.Enabled = true;
            ExibirImagemButton.Visible = true;
        }

        private void AbrirButton_Click(object sender, EventArgs e)
        {
            if( OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String tempfileName = OpenFileDialog.FileName;
                    
                    image = Image.FromFile(tempfileName);
                    bitmapImage = new Bitmap(image);
                    hsvMatrix = ColorProcessing.convertBitmapToHsvMatrix(bitmapImage);

                    histogram = null;
                    equalizedHsvMatrix = null;
                    equalizedHistogram = null;

                    fileName = tempfileName.Substring(tempfileName.LastIndexOf('\\') + 1);
                    fileNameLabel.Text = tempfileName;

                    enableButtons();
                }
                catch (Exception)
                {
                    MessageBox.Show("Escolha um arquivo válido!", "Erro ao abrir", 0,  MessageBoxIcon.Error);
                }
            }
        }

        private void PBButtonClick(object sender, EventArgs e)
        {
            Bitmap blackAndWhite = ColorProcessing.ConvertToBlackWhite(bitmapImage);
            new exibirImagem(blackAndWhite, fileName + " (preto e branco)").Show();
        }

        private void channelsButtonClick(object sender, EventArgs e)
        {
            Bitmap redC = ColorProcessing.getEspecificColorChanel(bitmapImage, 0);
            new exibirImagem(redC, fileName + " (vermelho)").Show();

            Bitmap greenC = ColorProcessing.getEspecificColorChanel(bitmapImage, 1);
            new exibirImagem(greenC, fileName + " (verde)").Show();

            Bitmap blueC = ColorProcessing.getEspecificColorChanel(bitmapImage, 2);
            new exibirImagem(blueC, fileName + " (azul)").Show();
        }

        private void equalizarHistogramaButtonClick(object sender, EventArgs e)
        {
            if(equalizedHsvMatrix == null)
            {
                equalizedValuesMap = HistogramProcessing.getNewValuesToHistogramEqualize(hsvMatrix, histogram);

                equalizedHsvMatrix = HistogramProcessing.getMappedHsvMatrix(hsvMatrix, equalizedValuesMap);
                equalizedHistogram = HistogramProcessing.getHistogramFromHsvMatrix(equalizedHsvMatrix);

            }

            new exibirHistograma(equalizedHistogram, 2, "Histograma Equalizado (valor, quantidade)").Show();
            new exibirImagem(equalizedHsvMatrix, fileName + "(equalized)").Show();
        }

        private void exibirHistogramaButtonClick(object sender, EventArgs e)
        {
            if(histogram == null) histogram = HistogramProcessing.getHistogramFromHsvMatrix(hsvMatrix);
            
            new exibirHistograma(histogram, 0).Show();
        }

        private void especificarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Escolha uma imagem com a distribuição desejada", "Especificar histograma", MessageBoxButtons.OK);

            if(OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap especified;
                try
                {
                    especified = new Bitmap(Image.FromFile(OpenFileDialog.FileName));
                }
                catch (Exception) { return; }

                HSV[,] especifiedHsvMatrix = ColorProcessing.convertBitmapToHsvMatrix(especified);
                Dictionary<double, double> especifiedEqualized = HistogramProcessing.getNewValuesToHistogramEqualize(especifiedHsvMatrix);

                if(equalizedValuesMap == null)
                {
                    equalizedValuesMap = HistogramProcessing.getNewValuesToHistogramEqualize(hsvMatrix);
                }

                

                Dictionary<double, double> mappedValues = HistogramProcessing.getNewValuesToHistogramEspecification(equalizedValuesMap, especifiedEqualized);
                
                HSV[,] especifiedOutput = HistogramProcessing.getMappedHsvMatrix(hsvMatrix, mappedValues);
                SortedDictionary<double, int> newHistogram = HistogramProcessing.getHistogramFromHsvMatrix(especifiedOutput);

                new exibirHistograma(newHistogram, 3, "Histograma especificado (valor, quantidade)").Show();
                new exibirImagem(especifiedOutput, fileName + "(Especificada").Show();
            
            }
        }

        private void exibirImagemButtonClick(object sender, EventArgs e)
        {
            new exibirImagem(image, fileName).Show();
        }
    }
}

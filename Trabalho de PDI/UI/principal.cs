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
        SortedDictionary<double, int> especifiedOutputHistogram = null;

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
            CompararButton.Enabled = true;
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

                    histogram = HistogramProcessing.getHistogramFromHsvMatrix(hsvMatrix);

                    equalizedHsvMatrix = null;
                    equalizedHistogram = null;
                    especifiedOutputHistogram = null;

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

            SortedDictionary<double, int> redH = HistogramProcessing.getHistogramFromImage(bitmapImage);
            new exibirHistograma(redH, 1, "RED");

            Bitmap greenC = ColorProcessing.getEspecificColorChanel(bitmapImage, 1);
            new exibirImagem(greenC, fileName + " (verde)").Show();

            SortedDictionary<double, int> greenH = HistogramProcessing.getHistogramFromImage(bitmapImage);
            new exibirHistograma(greenH, 1, "GREEN");

            Bitmap blueC = ColorProcessing.getEspecificColorChanel(bitmapImage, 2);
            new exibirImagem(blueC, fileName + " (azul)").Show();

            
        }

        private void equalizarHistogramaButtonClick(object sender, EventArgs e)
        {
            /*
            //para estudo de caso:
            SortedDictionary<double, int> redEq = HistogramProcessing.getHistogramFromImage(bitmapImage, 0);
            Bitmap red = ColorProcessing.getEspecificColorChanel(bitmapImage, 0);
            Bitmap bw = ColorProcessing.ConvertToBlackWhite(red);

            Dictionary<double, double> eqRed = HistogramProcessing.getNewValuesToHistogramEqualize(ColorProcessing.convertBitmapToHsvMatrix(bw));
            HSV[,] eqRedHSV = HistogramProcessing.getMappedHsvMatrix(ColorProcessing.convertBitmapToHsvMatrix(bw), eqRed);
            SortedDictionary<double, int> hist = HistogramProcessing.getHistogramFromHsvMatrix(eqRedHSV);
            new exibirHistograma(hist, 0, "Histograma Equalizado (valor, quantidade)").Show();
            Bitmap outp = ColorProcessing.convertHsvMatrixToBitmap(eqRedHSV);
            new exibirImagem(ColorProcessing.getEspecificColorChanel(outp, 0), fileName + "(equalized)").Show();
            */
            
            if(equalizedHsvMatrix == null)
            {
                equalizedValuesMap = HistogramProcessing.getNewValuesToHistogramEqualize(hsvMatrix, histogram);

                equalizedHsvMatrix = HistogramProcessing.getMappedHsvMatrix(hsvMatrix, equalizedValuesMap);
                equalizedHistogram = HistogramProcessing.getHistogramFromHsvMatrix(equalizedHsvMatrix);

            }

            new exibirHistograma(equalizedHistogram, 0, "Histograma Equalizado (valor, quantidade)").Show();
            new exibirImagem(equalizedHsvMatrix, fileName + "(equalized)").Show();
        }

        private void exibirHistogramaButtonClick(object sender, EventArgs e)
        {
            new EscolherCanalDeCor("Distribuição de frequencia", bitmapImage, histogram).ShowDialog();
            //new exibirHistograma(histogram, 4).Show();
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

                if(equalizedHistogram == null)
                {
                    equalizedValuesMap = HistogramProcessing.getNewValuesToHistogramEqualize(hsvMatrix);
                    equalizedHsvMatrix = HistogramProcessing.getMappedHsvMatrix(hsvMatrix, equalizedValuesMap);
                    equalizedHistogram = HistogramProcessing.getHistogramFromHsvMatrix(equalizedHsvMatrix);
                }
                Dictionary<double, double> mappedValues = HistogramProcessing.getNewValuesToHistogramEspecification(equalizedValuesMap, especifiedEqualized);
                
                HSV[,] especifiedOutput = HistogramProcessing.getMappedHsvMatrix(hsvMatrix, mappedValues);
                especifiedOutputHistogram = HistogramProcessing.getHistogramFromHsvMatrix(especifiedOutput);

                new exibirHistograma(especifiedOutputHistogram, 0, "Histograma especificado (valor, quantidade)").Show();
                new exibirImagem(especifiedOutput, fileName + "(Especificada").Show();
            
            }
        }

        private void exibirImagemButtonClick(object sender, EventArgs e)
        {
            new exibirImagem(image, fileName).Show();
        }

        private void compararButton_Click(object sender, EventArgs e)
        {
            //exibe os três histogramas lado a lado
            /*if(especifiedOutputHistogram == null || equalizedHistogram == null)
            {
                MessageBox.Show("Você deve especificar o histograma primeiro!", "Erro", 0, MessageBoxIcon.Error);
                return;
            }

            exibirHistograma showOriginalHistogram = new exibirHistograma(histogram, 4, "Histograma original (valor, quantidade)", new Point[] { new Point(0, 0) });
            showOriginalHistogram.Show();

            Point equalized = new Point(showOriginalHistogram.Right - 200,showOriginalHistogram.Location.Y);
            exibirHistograma showEqualizedHistogram = new exibirHistograma(equalizedHistogram, 4, "Histograma equalizado (valor, quantidade)", new Point[] {equalized});
            showEqualizedHistogram.Show();

            Point especified = new Point(showEqualizedHistogram.Right - 200,
                                            showOriginalHistogram.Location.Y);
            exibirHistograma showEspecifiedHistogram = new exibirHistograma(especifiedOutputHistogram, 4, "Histograma especificado (valor, quantidade)", new Point[] { especified });
            showEspecifiedHistogram.Show();*/
            new exibirComparacao(histogram, equalizedHistogram, especifiedOutputHistogram).Show();
        }

        private void converterButton_Click(object sender, EventArgs e)
        {
            new ConverterCor().ShowDialog();
        }
    }
}

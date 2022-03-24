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
            /////////////

            //versão sem suporte a canais separados
            /*
            if(equalizedHsvMatrix == null)
            {
                equalizedValuesMap = HistogramProcessing.getNewValuesToHistogramEqualize(hsvMatrix, histogram);

                equalizedHsvMatrix = HistogramProcessing.getMappedHsvMatrix(hsvMatrix, equalizedValuesMap);
                equalizedHistogram = HistogramProcessing.getHistogramFromHsvMatrix(equalizedHsvMatrix);

            }

            new exibirHistograma(equalizedHistogram, 0, "Histograma Equalizado (valor, quantidade)").Show();
            new exibirImagem(equalizedHsvMatrix, fileName + "(equalized)").Show();
            */

            SortedDictionary<double, int> tempEqualizedHist = null;
            int MN = bitmapImage.Width * bitmapImage.Height;

            int[] choice = {0};
            new EscolherCanalDeCor("escolha o canal de cor para equalizar", ref choice).ShowDialog();
            Bitmap eqResult = null;

            bool ignoreOtherChannels = (MessageBox.Show("Mostrar apenas o canal selecionado?", "Exibir", MessageBoxButtons.YesNo) == DialogResult.Yes) ? true : false;

            switch (choice[0])
            {
                case 0:
                    //intensidade
                    if (equalizedHsvMatrix == null)
                    {
                        equalizedValuesMap = HistogramProcessing.getNewValuesToHistogramEqualize(hsvMatrix, histogram);

                        equalizedHsvMatrix = HistogramProcessing.getMappedHsvMatrix(hsvMatrix, equalizedValuesMap);
                        equalizedHistogram = HistogramProcessing.getHistogramFromHsvMatrix(equalizedHsvMatrix);

                    }

                    tempEqualizedHist = equalizedHistogram;
                    new exibirImagem(equalizedHsvMatrix, fileName + "(equalized)").Show();
                    new exibirHistograma(tempEqualizedHist, 0, "Histograma Equalizado (valor, quantidade)").Show();
                    break;
                case 1:
                    //vermelho
                    SortedDictionary<double, int> tempHistR = HistogramProcessing.getHistogramFromImage(bitmapImage, 0);
                    Dictionary<double, double> eqHistR = HistogramProcessing.getNewValuesToHistogramEqualize(null, tempHistR, MN);
                    eqResult = HistogramProcessing.getMappedBitmap(bitmapImage, redC: eqHistR, ignoreNonSeteChannels : ignoreOtherChannels);
                    tempEqualizedHist = HistogramProcessing.getHistogramFromImage(eqResult, 0);

                    new exibirImagem(eqResult).Show();
                    new exibirHistograma(tempEqualizedHist, 1, "Histograma Equalizado (Vermelho)").Show();
                    break;

                case 2:
                    //verde
                    SortedDictionary<double, int> tempHistG = HistogramProcessing.getHistogramFromImage(bitmapImage, 1);
                    Dictionary<double, double> eqHistG = HistogramProcessing.getNewValuesToHistogramEqualize(null, tempHistG, MN);
                    eqResult = HistogramProcessing.getMappedBitmap(bitmapImage, greenC: eqHistG, ignoreNonSeteChannels: ignoreOtherChannels);
                    tempEqualizedHist = HistogramProcessing.getHistogramFromImage(eqResult, 1);

                    new exibirHistograma(tempEqualizedHist, 2, "Histograma Equalizado (Verde)").Show();
                    new exibirImagem(eqResult).Show();
                    break;

                case 3:
                    //azul
                    SortedDictionary<double, int> tempHistB = HistogramProcessing.getHistogramFromImage(bitmapImage, 2);
                    Dictionary<double, double> eqHistB = HistogramProcessing.getNewValuesToHistogramEqualize(null, tempHistB, MN);
                    eqResult = HistogramProcessing.getMappedBitmap(bitmapImage, blueC: eqHistB, ignoreNonSeteChannels: ignoreOtherChannels);
                    tempEqualizedHist = HistogramProcessing.getHistogramFromImage(eqResult, 2);

                    new exibirHistograma(tempEqualizedHist, 3, "Histograma Equalizado (Azul)").Show();
                    new exibirImagem(eqResult).Show();
                    break;

                case 4:
                    //todos
                    SortedDictionary<double, int> tempHistRf = HistogramProcessing.getHistogramFromImage(bitmapImage, 0);
                    Dictionary<double, double> eqHistRf = HistogramProcessing.getNewValuesToHistogramEqualize(null, tempHistRf, MN);

                    SortedDictionary<double, int> tempHistGf = HistogramProcessing.getHistogramFromImage(bitmapImage, 1);
                    Dictionary<double, double> eqHistGf = HistogramProcessing.getNewValuesToHistogramEqualize(null, tempHistGf, MN);

                    SortedDictionary<double, int> tempHistBf = HistogramProcessing.getHistogramFromImage(bitmapImage, 2);
                    Dictionary<double, double> eqHistBf = HistogramProcessing.getNewValuesToHistogramEqualize(null, tempHistBf, MN);

                    eqResult = HistogramProcessing.getMappedBitmap(bitmapImage, eqHistRf, eqHistGf, eqHistBf);
                    new exibirImagem(eqResult, "Todos os canais", true).Show();

                    tempEqualizedHist = HistogramProcessing.getHistogramFromImage(eqResult, 0);
                    new exibirHistograma(tempEqualizedHist, 1, "Histograma Equalizado (Vermelho)").Show();

                    tempEqualizedHist = HistogramProcessing.getHistogramFromImage(eqResult, 1);
                    new exibirHistograma(tempEqualizedHist, 2, "Histograma Equalizado (Verde)").Show();

                    tempEqualizedHist = HistogramProcessing.getHistogramFromImage(eqResult, 2);
                    new exibirHistograma(tempEqualizedHist, 3, "Histograma Equalizado (Azul)").Show();

                    break;
            }

            if(choice[0] > 0)
            {
                HSV[,] hsvResult = ColorProcessing.convertBitmapToHsvMatrix(eqResult);
                SortedDictionary<double, int> hsvHist = HistogramProcessing.getHistogramFromHsvMatrix(hsvResult);

                new exibirHistograma(hsvHist, 0, "Histograma Equalizado (HSV - intensidade)").Show();
            }

        }

        private void exibirHistogramaButtonClick(object sender, EventArgs e)
        {
            new EscolherCanalDeCor("Distribuição de frequencia", bitmapImage, histogram).ShowDialog();
            //new exibirHistograma(histogram, 4).Show();
        }

        private void especificarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Escolha uma imagem com a distribuição desejada", "Especificar histograma", MessageBoxButtons.OK);
            Bitmap especified;

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try{
                    especified = new Bitmap(Image.FromFile(OpenFileDialog.FileName));
                }catch (Exception) { return; }
            }
            else { return; }

            int[] choice = { 0 };
            new EscolherCanalDeCor("escolha o canal de cor para especificar", ref choice).ShowDialog();
            Bitmap espResult = null;
            SortedDictionary<double, int> tempEspecifiedHist;

            int MN = bitmapImage.Width * bitmapImage.Height;
            int espMN = especified.Width * especified.Height;

            bool ignoreOtherChannels = (MessageBox.Show("Mostrar apenas o canal selecionado?", "Exibir", MessageBoxButtons.YesNo) == DialogResult.Yes) ? true : false;

            SortedDictionary<double, int> especifiedHist = HistogramProcessing.getHistogramFromImage(especified);
            Dictionary<double, double> especifiedEqualized = HistogramProcessing.getNewValuesToHistogramEqualize(null, especifiedHist, espMN);

            switch (choice[0])
            {
                case 0:
                    //intensidade
                    HSV[,] especifiedHsvMatrix = ColorProcessing.convertBitmapToHsvMatrix(especified);
                    especifiedEqualized = HistogramProcessing.getNewValuesToHistogramEqualize(especifiedHsvMatrix);

                    if (equalizedHistogram == null)
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

                    break;

                case 1:
                    //vermelho
                    SortedDictionary<double, int> tempHistR = HistogramProcessing.getHistogramFromImage(bitmapImage, 0);
                    Dictionary<double, double> eqHistR = HistogramProcessing.getNewValuesToHistogramEqualize(null, tempHistR, MN);
                    Dictionary<double, double> espHistR = HistogramProcessing.getNewValuesToHistogramEspecification(eqHistR, especifiedEqualized);
                    espResult = HistogramProcessing.getMappedBitmap(bitmapImage, redC: espHistR, ignoreNonSeteChannels: ignoreOtherChannels);
                    tempEspecifiedHist = HistogramProcessing.getHistogramFromImage(espResult, 0);

                    new exibirImagem(espResult).Show();
                    new exibirHistograma(tempEspecifiedHist, 1, "Histograma Especificado (Vermelho)").Show();
                    break;

                case 2:
                    //verde
                    SortedDictionary<double, int> tempHistG = HistogramProcessing.getHistogramFromImage(bitmapImage, 1);
                    Dictionary<double, double> eqHistG = HistogramProcessing.getNewValuesToHistogramEqualize(null, tempHistG, MN);
                    Dictionary<double, double> espHistG = HistogramProcessing.getNewValuesToHistogramEspecification(eqHistG, especifiedEqualized);
                    espResult = HistogramProcessing.getMappedBitmap(bitmapImage, greenC: espHistG, ignoreNonSeteChannels: ignoreOtherChannels);
                    tempEspecifiedHist = HistogramProcessing.getHistogramFromImage(espResult, 1);

                    new exibirImagem(espResult).Show();
                    new exibirHistograma(tempEspecifiedHist, 2, "Histograma Especificado (Verde)").Show();
                    break;

                case 3:
                    //azul
                    SortedDictionary<double, int> tempHistB = HistogramProcessing.getHistogramFromImage(bitmapImage, 2);
                    Dictionary<double, double> eqHistB = HistogramProcessing.getNewValuesToHistogramEqualize(null, tempHistB, MN);
                    Dictionary<double, double> espHistB = HistogramProcessing.getNewValuesToHistogramEspecification(eqHistB, especifiedEqualized);
                    espResult = HistogramProcessing.getMappedBitmap(bitmapImage, blueC: espHistB, ignoreNonSeteChannels: ignoreOtherChannels);
                    tempEspecifiedHist = HistogramProcessing.getHistogramFromImage(espResult, 2);

                    new exibirImagem(espResult).Show();
                    new exibirHistograma(tempEspecifiedHist, 3, "Histograma Especificado (Azul)").Show();
                    break;

                case 4:
                    //todos
                    SortedDictionary<double, int> tempHistRf = HistogramProcessing.getHistogramFromImage(bitmapImage, 0);
                    Dictionary<double, double> eqHistRf = HistogramProcessing.getNewValuesToHistogramEqualize(null, tempHistRf, MN);
                    Dictionary<double, double> espHistRf = HistogramProcessing.getNewValuesToHistogramEspecification(eqHistRf, especifiedEqualized);

                    SortedDictionary<double, int> tempHistGf = HistogramProcessing.getHistogramFromImage(bitmapImage, 1);
                    Dictionary<double, double> eqHistGf = HistogramProcessing.getNewValuesToHistogramEqualize(null, tempHistGf, MN);
                    Dictionary<double, double> espHistGf = HistogramProcessing.getNewValuesToHistogramEspecification(eqHistGf, especifiedEqualized);

                    SortedDictionary<double, int> tempHistBf = HistogramProcessing.getHistogramFromImage(bitmapImage, 2);
                    Dictionary<double, double> eqHistBf = HistogramProcessing.getNewValuesToHistogramEqualize(null, tempHistBf, MN);
                    Dictionary<double, double> espHistBf = HistogramProcessing.getNewValuesToHistogramEspecification(eqHistBf, especifiedEqualized);

                    espResult = HistogramProcessing.getMappedBitmap(bitmapImage, espHistRf, espHistGf, espHistBf);
                    new exibirImagem(espResult, "Todos os canais", true).Show();

                    tempEspecifiedHist = HistogramProcessing.getHistogramFromImage(espResult, 0);
                    new exibirHistograma(tempEspecifiedHist, 1, "Histograma Especificado (Vermelho)").Show();

                    tempEspecifiedHist = HistogramProcessing.getHistogramFromImage(espResult, 1);
                    new exibirHistograma(tempEspecifiedHist, 2, "Histograma Especificado (Verde)").Show();

                    tempEspecifiedHist = HistogramProcessing.getHistogramFromImage(espResult, 2);
                    new exibirHistograma(tempEspecifiedHist, 3, "Histograma Especificado (Azul)").Show();

                    break;
            }

            if (choice[0] > 0)
            {
                HSV[,] hsvResult = ColorProcessing.convertBitmapToHsvMatrix(espResult);
                SortedDictionary<double, int> hsvHist = HistogramProcessing.getHistogramFromHsvMatrix(hsvResult);

                new exibirHistograma(hsvHist, 0, "Histograma Equalizado (HSV - intensidade)").Show();
            }

        }

        private void exibirImagemButtonClick(object sender, EventArgs e)
        {
            new exibirImagem(bitmapImage, fileName).Show();
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

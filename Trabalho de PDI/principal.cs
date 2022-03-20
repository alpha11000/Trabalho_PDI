﻿using System;
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

        public principal()
        {
            OpenFileDialog = new OpenFileDialog();
            InitializeComponent();
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

                    fileName = tempfileName.Substring(tempfileName.LastIndexOf('\\') + 1);
                    fileNameLabel.Text = tempfileName;

                    new exibirImagem(image, fileName).Show();
                    enableButtons();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Escolha um arquivo válido!");
                }
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap blackAndWhite = ColorProcessing.ConvertToBlackWhite(bitmapImage);
            new exibirImagem(blackAndWhite, fileName + " (preto e branco)").Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Bitmap redC = ColorProcessing.getEspecificColorChanel(bitmapImage, 0);
            new exibirImagem(redC, fileName + " (vermelho)").Show();

            Bitmap greenC = ColorProcessing.getEspecificColorChanel(bitmapImage, 1);
            new exibirImagem(greenC, fileName + " (verde)").Show();

            Bitmap blueC = ColorProcessing.getEspecificColorChanel(bitmapImage, 2);
            new exibirImagem(blueC, fileName + " (azul)").Show();
        }

        private void enableButtons()
        {
            PBbutton.Enabled = true;
            CanaisButton.Enabled = true;
            ExibirHistogramaButton.Enabled = true;
            EqualizarButton.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            HSV[,] hsvMatrix = ColorProcessing.convertBitmapToHsvMatrix(bitmapImage);
            HSV[,] equalizedHsvMatrix = HistogramProcessing.getEqualizedHsvMatrix(hsvMatrix);
            SortedDictionary<double, int> equalizedHistogram = HistogramProcessing.getHistogramFromHsvMatrix(equalizedHsvMatrix);

            new exibirHistograma(equalizedHistogram, 2, "Histograma Equalizado (valor, quantidade)").Show();

            Bitmap equalizedImage = ColorProcessing.convertHsvMatrixToBitmap(equalizedHsvMatrix);

            new exibirImagem(equalizedImage).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SortedDictionary<int,int> histogram = HistogramProcessing.getHistogramFromImage(ImageProcessing.ConvertToBlackWhite(bitmapImage));

            // new exibirHistograma(histogram).Show();
            //EscolherCanalDeCor escolher =  new EscolherCanalDeCor("gerar histograma a partir de qual canal?", bitmapImage);
            //escolher.Owner = this;
            //escolher.ShowDialog();


            HSV[,] hsvMatrix = ColorProcessing.convertBitmapToHsvMatrix(bitmapImage);
            //Bitmap bitmap = ColorProcessing.convertHsvMatrixToBitmap(hsvMatrix);

            //new exibirImagem(bitmap).Show();

            
            SortedDictionary<double, int> histogram = HistogramProcessing.getHistogramFromHsvMatrix(hsvMatrix);
            new exibirHistograma(histogram, 0).Show();

            /*HSV[,] equalizedHsv = HistogramProcessing.getEqualizedHsvMatrix(hsvMatrix);
            SortedDictionary<double, int> equalizedHistogram = HistogramProcessing.getHistogramFromHsvMatrix(equalizedHsv);
            Bitmap equalizedBitmap = ColorProcessing.convertHsvMatrixToBitmap(equalizedHsv);


            new exibirHistograma(equalizedHistogram, 1).Show();
            new exibirImagem(equalizedBitmap).Show();*/
        }

        private void principal_Load(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(10, 235, 184);
            //Color color = Color.FromArgb(255, 10, 255);
            HSV hsv = ColorProcessing.convertRgbToHsv(color);

            testeLabel.Text = "H -> " + hsv.H + " S-> " + hsv.S + " V -> " + hsv.V;
        }
    }
}
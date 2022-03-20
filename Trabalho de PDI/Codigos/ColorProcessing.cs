using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_de_PDI
{
    internal class ColorProcessing
    {
        //realiza a conversão de RGB para HSV
        public static HSV convertRgbToHsv(Color rgb)
        {
            double r = rgb.R/255.0, g = rgb.G/255.0, b = rgb.B/255.0; //normaliza os canais de cor

            double h, s, v;
            
            double maxValue = Math.Max(r, Math.Max(g, b)); //valor máximo entre os três canais
            double minValue = Math.Min(r, Math.Min(g, b)); //valor minimo entre os três canais
            double dif = maxValue - minValue;


            if (dif == 0)
            {
                h = 0;
            }
            else if (maxValue == r)
            {
                if (g >= b)
                {
                    h = (60 * (g - b)) / dif;
                }
                else
                {
                    h = ((60 * (g - b)) / dif) + 360;
                }
            }
            else if (maxValue == g)
            {
                h = ((60 * (b - r)) / dif) + 120;
            }
            else
            {
                h = ((60 * (r - g)) / dif) + 240;
            }

            v = maxValue;
            s = (v == 0)? 0 : dif / v;

            return new HSV(h, s, v);
        }

        //realiza a conversão de HSV para RGB
        public static Color convertHsvToRgb(HSV hsv){

            double h = hsv.H, s = hsv.S, v = hsv.V;

            Color output;
            double r = 0, g = 0, b = 0;
            int R, G, B;

            if(s <= 0)
            {
                R = G = B = (int)Math.Round(v * 255);
                output = Color.FromArgb(R, G, B);
                return output;
            }

            if (v <= 0)
            {
                R = G = B = 0;
                output = Color.FromArgb(R, G, B);
                return output;
            }

            //while (h < 0) { h += 360; };
            //while (h >= 360) { h -= 360; };

            h = h % 360;

            //double Hi = (h / 60) % 6;
            double hf = (h / 60);
            int i = (int)Math.Floor(hf);
            double f = hf - i;
            double p = v * (1 - s);
            double q = v * (1 - (f * s));
            double t = v * (1 - (s * (1 - f)));

            switch(i){
                case 0:
                    r = v;
                    g = t;
                    b = p;
                    break;
                case 1:
                    r = q;
                    g = v;
                    b = p;
                    break;
                case 2:
                    r = p;
                    g = v;
                    b = t;
                    break;
                case 3:
                    r = p;
                    g = q;
                    b = v;
                    break;
                case 4:
                    r = t;
                    g = p;
                    b = v;
                    break;
                case 5:
                    r = v;
                    g = p;
                    b = q;
                    break;
                default:
                    r = g = b = v;
                    break;
            }

            R = (int)Math.Round(r * 255);
            G = (int)Math.Round(g * 255);
            B = (int)Math.Round(b * 255);

            output = Color.FromArgb(R, G, B);
            return output;
        }

        //converte uma matriz de HSV para um Bitmap
        public static Bitmap convertHsvMatrixToBitmap(HSV[,] hsvMatrix)
        {
            Bitmap output = new Bitmap(hsvMatrix.GetLength(0), hsvMatrix.GetLength(1));
            
            //converte cada elemento HSV em um RGB e o coloca em uma imagem de saida
            for(int i = 0; i < hsvMatrix.GetLength(0); i++)
            {
                for(int j = 0; j < hsvMatrix.GetLength(1); j++)
                {
                    Color rgb = convertHsvToRgb(hsvMatrix[i, j]);
                    output.SetPixel(i, j, rgb);
                }
            }

            return output;
        }

        //converte um bitmap em uma matriz de HSV's
        public static HSV[,] convertBitmapToHsvMatrix(Bitmap originalImage)
        {
            HSV[,] output = new HSV[originalImage.Width, originalImage.Height];

            for(int i = 0; i < originalImage.Width; i++)
            {
                for(int j = 0; j < originalImage.Height; j++)
                {
                    output[i, j] = convertRgbToHsv(originalImage.GetPixel(i, j));
                }
            }

            return output;
        }

        public static Bitmap ConvertToBlackWhite(Bitmap originalImage)
        {
            if (originalImage == null) return null;

            Bitmap outputImage = new Bitmap(originalImage.Width, originalImage.Height); //novo bitmap com o mesmo tamanho do bitmap original


            for (int i = 0; i < originalImage.Width; i++)
            {
                for (int j = 0; j < originalImage.Height; j++) //percorrendo todos os pixeis da imagem original
                {
                    Color pixelColor = originalImage.GetPixel(i, j); //obtem a cor do pixel atual
                    int gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3; //obtem a escala de cinza a partir da media aritmética entre os três canais de cores do pixel original

                    Color grayScaleColor = Color.FromArgb(pixelColor.A, gray, gray, gray); //atribui o valor da média aos três canai da nova cor, a qual resultará em uma escala de cinza
                    outputImage.SetPixel(i, j, grayScaleColor); //atribui a cor em escala de cinza ao pixel da imagem de saída
                }
            }

            return outputImage;
        }

        public static Bitmap getEspecificColorChanel(Bitmap image, int channel)
        {
            if (channel < 0 || channel >= 3) return null; //caso o canal especificado esteja fora do intervalo de canais da imagem, retorna um valor nulo

            Bitmap separatedColorChannel = new Bitmap(image.Width, image.Height);

            int[] channelsFators = new int[3];
            channelsFators.Initialize();
            channelsFators[channel] = 1;

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color pixelColor = image.GetPixel(i, j);
                    int r = pixelColor.R * channelsFators[0];
                    int g = pixelColor.G * channelsFators[1];
                    int b = pixelColor.B * channelsFators[2];

                    Color separatedChannel = Color.FromArgb(pixelColor.A, r, g, b);
                    separatedColorChannel.SetPixel(i, j, separatedChannel);
                }
            }

            return separatedColorChannel;
        }
    }
}

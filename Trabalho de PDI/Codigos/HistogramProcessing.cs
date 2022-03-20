﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace Trabalho_de_PDI
{
    internal class HistogramProcessing
    {
        public static SortedDictionary<int,int> getHistogramFromImage(Bitmap originalImage, int channel = 0)
        {
            Dictionary<int, int> histogram = new Dictionary<int, int>();


            for (int i = 0; i < originalImage.Width; i++)
            {
                for (int j = 0; j < originalImage.Height; j++)
                {
                    Color color = originalImage.GetPixel(i, j);
                    int colorIntensity = (channel == 0) ? color.R : (channel == 1) ? color.G : color.B;

                    if (histogram.ContainsKey(colorIntensity))
                    {
                        histogram[colorIntensity]++;
                    }
                    else
                    {
                        histogram.Add(colorIntensity, 1);
                    }
                }
            }

            return new SortedDictionary<int,int>(histogram);
        }

        //gera o histograma a partir dos valores V de cada elemento da matriz de HSV's
        public static SortedDictionary<double, int> getHistogramFromHsvMatrix(HSV[,] hsvMatrix)
        {
            Dictionary<double, int> histogram = new Dictionary<double, int>();

            //percorre todos os elementos da matriz
            for (int i = 0; i < hsvMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < hsvMatrix.GetLength(1); j++)
                {
                    double v = hsvMatrix[i, j].V;

                    if (histogram.ContainsKey(v))
                    {
                        histogram[v]++; //caso o valor já esteja contido no dicionario, a quantidade é incrementada
                    }
                    else
                    {
                        histogram.Add(v, 1); //adiciona o valor atual ao dicionário caso este ainda ñ esteja contido no mesmo
                    }
                }
            }

            return new SortedDictionary<double, int>(histogram);
        }

        //retorna uma matriz equalizada a partir da matriz original de HSV's
        public static HSV[,] getMappedHsvMatrix(HSV[,] originalHsvMatrix, Dictionary<double, double> valuesMap)
        {
            if(valuesMap == null)
            {
                return null;
            }

            HSV[,] output = new HSV[originalHsvMatrix.GetLength(0), originalHsvMatrix.GetLength(1)];

            //percorre todos os elementos da matriz HSV
            for(int i = 0; i < originalHsvMatrix.GetLength(0); i++)
            {
                for(int j = 0; j < originalHsvMatrix.GetLength(1); j++)
                {
                    HSV atualHSV = originalHsvMatrix[i, j];

                    //define o novo valor de V a partir do elemento atual
                    if (valuesMap.ContainsKey(atualHSV.V))
                    {
                        output[i, j] = new HSV(atualHSV.H, atualHSV.S, valuesMap[atualHSV.V]);
                    }
                    else
                    {
                        output[i, j] = atualHSV;
                    }
                }
            }

            return output;
        }

        public static Dictionary<double, double> getNewValuesToHistogramEspecification
            (Dictionary<double, double> equalizedValues, Dictionary<double, double> targetEqualizedValues)
        {
            Dictionary<double, double> output = new Dictionary<double, double>();

            foreach (var peer in equalizedValues)
            {
                var leftCloserValues = targetEqualizedValues.Where(i => i.Value <= peer.Value);
                var rightCloserValues = targetEqualizedValues.Where(i => i.Value > peer.Value);

                var leftCloser =  (leftCloserValues  != null && leftCloserValues.Count()  > 0) ? leftCloserValues.Last() : new KeyValuePair<double, double>(-1, -1);
                var rightCloser = (rightCloserValues != null && rightCloserValues.Count() > 0) ? rightCloserValues.First() : new KeyValuePair<double, double>(-1, -1);


                KeyValuePair<double, double> closer;

                if (leftCloser.Key == -1)
                {
                    if(rightCloser.Key == -1)
                    {
                        closer = peer; //caso haja erro na especificação
                    }
                    else
                    {
                        closer = rightCloser;
                    }
                }
                else
                {
                    if(rightCloser.Value == -1)
                    {
                        closer = leftCloser;
                    }
                    else
                    {
                        if ((peer.Value - leftCloser.Value) <= (rightCloser.Value - peer.Value))
                        {
                            closer = leftCloser;
                        }
                        else
                        {
                            closer = rightCloser;
                        }
                    }
                }

                output.Add(peer.Key, closer.Key);

            }

            return output;
        }

        //retorna o mapeamento dos valores da matriz equalizada
        public static Dictionary<double, double> getNewValuesToHistogramEqualize(HSV[,] hsvMatrix, SortedDictionary<double, int> histogram = null){ //MN = image width * height

            if(histogram == null) { 
                histogram = getHistogramFromHsvMatrix(hsvMatrix); 
            }

            Dictionary<double, double> output = new Dictionary<double, double>();

            SortedDictionary<double, double> normalizedHistogram = new SortedDictionary<double, double>();

            double MN = hsvMatrix.GetLength(0) * hsvMatrix.GetLength(1); //total de elementos da matriz

            //normaliza as quantidades dos elementos (quantidade/MN)
            foreach(var peer in histogram)
            {
                double pr = peer.Value / MN;
                normalizedHistogram.Add(peer.Key, pr);
            }

            double prSum = 0;

            //realiza a equalização do histograma
            foreach(var peer in normalizedHistogram)
            {
                prSum += peer.Value;
                output.Add(peer.Key, prSum);

            }

            return output;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_de_PDI
{
    public partial class exibirComparacao : Form
    {
        private Point[] location;
        private SortedDictionary<double, int> original;
        SortedDictionary<double, int> equalized;
        SortedDictionary<double, int> especified;

        public exibirComparacao(SortedDictionary<double, int> original, SortedDictionary<double, int> equalized,
            SortedDictionary<double, int> especified, Point[] location = null)
        {
            this.location = location;
            this.original = original;
            this.equalized = equalized;
            this.especified = especified;
            InitializeComponent();
        }

        private void exibirComparacao_Load(object sender, EventArgs e)
        {
            histogramaChart.ChartAreas[0].Axes[0].MajorGrid.LineColor = Color.FromArgb(60, 60, 60);
            histogramaChart.ChartAreas[0].Axes[1].MajorGrid.LineColor = Color.FromArgb(60, 60, 60);
            histogramaChart.ChartAreas[0].Axes[0].LineColor = Color.White;
            histogramaChart.ChartAreas[0].Axes[1].LineColor = Color.White;
            histogramaChart.ChartAreas[0].Axes[0].LabelStyle.ForeColor = Color.White;
            histogramaChart.ChartAreas[0].Axes[1].LabelStyle.ForeColor = Color.White;
            histogramaChart.ChartAreas[0].Axes[0].Maximum = 255;
            histogramaChart.ChartAreas[0].Axes[0].Minimum = 0;

            double maxValue = Math.Max(original.Values.Max(), Math.Max(equalized.Values.Max(), especified.Values.Max()));


            /*plot(0, original, Color.FromArgb(234, 193, 242));
            plot(1, equalized, Color.FromArgb(164, 205, 218));
            plot(2, especified, Color.FromArgb(210, 238, 179)); */

            plot(0, original, Color.Purple);
            plot(1, equalized, Color.Orange);
            plot(2, especified, Color.ForestGreen); 

            plot(3, original, Color.FromArgb(100, 100, 110), true, maxValue);
            plot(4, equalized, Color.FromArgb(140, 140, 140),true, maxValue);
            plot(5, especified, Color.FromArgb(210, 210, 210),true, maxValue);

        }

        private void plot(int index, SortedDictionary<double, int> histogram, Color color, bool cumulated = false, double max = 0)
        {
            if (location != null) { this.Location = location[0]; }

            //histogramaChart.Titles["maintitle"].Text = name;    //atualiza o titulo do histograma
            histogramaChart.Series.ElementAt(index).Color = color; //atualiza a cor das colunas do histograma

            SortedDictionary<int, int> intHistogram = new SortedDictionary<int, int>();


            //preenche as áreas pendentes do histograma
            for (int i = 0; i < 256; i++)
            {
                intHistogram.Add(i, 0);
            }
            foreach (var peer in histogram)
            {
                intHistogram[(int)Math.Round(peer.Key * 255)] += peer.Value;
            }

            double acumulada = 0;
            int total = histogram.Values.Sum();

            //atualiza os dados do gráfico
            foreach (var peer in intHistogram)
            {
                if (!cumulated)
                {
                    histogramaChart.Series.ElementAt(index).Points.AddXY(peer.Key, peer.Value);
                }
                else
                {
                    acumulada += (peer.Value / (double)total);
                    histogramaChart.Series.ElementAt(index).Points.AddXY(peer.Key, acumulada * max);
                }
            }

        }
    }
}

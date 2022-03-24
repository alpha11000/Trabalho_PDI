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
    public partial class exibirHistograma : Form
    {
        private String name;
        private SortedDictionary<double, int> histogram; //value,count
        private static Color[] colors = {Color.White, Color.Red, Color.Green, Color.Blue, Color.FromArgb(100,100,100)};
        private Color color;
        private Point[] location;

        public exibirHistograma(SortedDictionary<double,int> histogram, int color, String name = "Distribuição de Intensidade (valor, quantidade)", Point[] location = null)
        {
            this.histogram = histogram;
            this.color = colors[color];
            this.name = name;
            this.location = location;
            InitializeComponent();
        }

        private void exibirHistograma_Load(object sender, EventArgs e)
        {
            histogramaChart.ChartAreas[0].Axes[0].MajorGrid.LineColor = Color.FromArgb(60, 60, 60);
            histogramaChart.ChartAreas[0].Axes[1].MajorGrid.LineColor = Color.FromArgb(60, 60, 60);
            histogramaChart.ChartAreas[0].Axes[0].LineColor = Color.White;
            histogramaChart.ChartAreas[0].Axes[1].LineColor = Color.White;
            histogramaChart.ChartAreas[0].Axes[0].LabelStyle.ForeColor = Color.White;
            histogramaChart.ChartAreas[0].Axes[1].LabelStyle.ForeColor = Color.White;
            histogramaChart.ChartAreas[0].Axes[0].Maximum = 255;
            histogramaChart.ChartAreas[0].Axes[0].Minimum = 0;

            if (location != null) { this.Location = location[0]; }

            histogramaChart.Titles["maintitle"].Text = name;    //atualiza o titulo do histograma
            histogramaChart.Series["Quantidade"].Color = color; //atualiza a cor das colunas do histograma

            SortedDictionary<int, int> intHistogram = new SortedDictionary<int, int>();

           
            //preenche as áreas pendentes do histograma
            for (int i = 0; i < 256; i++)
            {
                intHistogram.Add(i, 0);
            }
            foreach(var peer in histogram)
            {
                intHistogram[(int)Math.Round(peer.Key * 255)] += peer.Value;
            }

            //atualiza os dados do gráfico
            foreach(var peer in intHistogram)
            {
                addValueOnHistogram(peer.Key, peer.Value);
            }
        }

        private void addValueOnHistogram(double X, double Y)
        {
            histogramaChart.Series["Quantidade"].Points.AddXY(X, Y);
        }
    }

   
}

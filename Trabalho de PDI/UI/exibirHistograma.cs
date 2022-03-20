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
        private static Color[] colors = {Color.White, Color.Red, Color.Green, Color.Blue};
        private Color color;

        public exibirHistograma(SortedDictionary<double,int> histogram, int color, String name = "Distribuição de Intensidade (valor, quantidade)")
        {
            this.histogram = histogram;
            this.color = colors[color];
            this.name = name;
            InitializeComponent();
        }

        private void exibirHistograma_Load(object sender, EventArgs e)
        {
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

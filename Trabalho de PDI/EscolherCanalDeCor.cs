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
    public partial class EscolherCanalDeCor : Form
    {
        private Bitmap originalImageBitmap;
        bool exibirHistograma;

        public EscolherCanalDeCor(String title, Bitmap image, bool exibirHistograma = true)
        {
            InitializeComponent();
            textLabel.Text = title;
            this.exibirHistograma = exibirHistograma;
            originalImageBitmap = image;
        }

        private void EscolherCanalDeCor_Load(object sender, EventArgs e)
        {
            String[] channels = { "Escala de cinza", "Vermelho", "Verde", "Azul", "Todos" };

            foreach (String s in channels)
            {
                comboBox1.Items.Add(s);
            }

            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void escolherButton_Click(object sender, EventArgs e)
        {
            SortedDictionary<int, int> histogram;
            int choose = comboBox1.SelectedIndex;

            if(choose == 0)
            {
                Bitmap BWImage = ColorProcessing.ConvertToBlackWhite(originalImageBitmap);
                histogram = HistogramProcessing.getHistogramFromImage(BWImage);
                //new exibirHistograma(histogram, 0).Show();
            }
            else if (choose < 4)
            {
                histogram = HistogramProcessing.getHistogramFromImage(originalImageBitmap, choose);
                //new exibirHistograma(histogram, choose).Show();
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    histogram = HistogramProcessing.getHistogramFromImage(originalImageBitmap, i);
                   // new exibirHistograma(histogram, i + 1).Show();
                }
            }

            Close();
            
        }
    }
}

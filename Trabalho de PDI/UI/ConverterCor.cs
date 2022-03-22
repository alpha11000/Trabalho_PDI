using System;
using System.Drawing;
using System.Windows.Forms;

namespace Trabalho_de_PDI
{
    public partial class ConverterCor : Form
    {
        public ConverterCor()
        {
            InitializeComponent();
        }

        private void paraRGB_Click(object sender, EventArgs e)
        {
            HSV hsv = new HSV(Double.Parse(H.Text), Double.Parse(S.Text), Double.Parse(V.Text));
            Color rgb = ColorProcessing.convertHsvToRgb(hsv);
            R.Text = rgb.R.ToString();
            G.Text = rgb.G.ToString();
            B.Text = rgb.B.ToString();
        }

        private void paraHSV_Click(object sender, EventArgs e)
        {
            Color rgb = Color.FromArgb(int.Parse(R.Text), int.Parse(G.Text), int.Parse(B.Text));
            HSV hsv = ColorProcessing.convertRgbToHsv(rgb);

            H.Text = (Math.Round(hsv.H)).ToString();
            S.Text = (Math.Round(hsv.S * 100)/100).ToString();
            V.Text = (Math.Round(hsv.V * 100)/100).ToString();
        }
    }
}

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
    public partial class TelaInicio : Form
    {
        private OpenFileDialog openFileDialog;
        private Bitmap BlackWhiteOutput = null;
        private Image originalImage;
        private Bitmap originalBitmapImage;
        PictureBox originalPicture = null;
        private TelaDeEspera waitScreen;

        public TelaInicio()
        {
            openFileDialog = new OpenFileDialog();
            waitScreen = new TelaDeEspera();
            // originalPBP1.Dock = DockStyle.Fill;
            // tableLayoutPanel1.Dock = DockStyle.None;
            InitializeComponent();
            panel2.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                showWait();
                originalImage = Image.FromFile(openFileDialog.FileName);
                originalBitmapImage = new Bitmap(originalImage);
                OriginalPB.Image = originalImage;
                originalPBP1.Image = originalImage;
                hideWait();

            }

            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openDividedImagePanel();
        }

        private void onePanel_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = false;
            tableLayoutPanel1.Dock = DockStyle.None;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

            panel2.Visible = true;

            showWait();

            BlackWhiteOutput = ColorProcessing.ConvertToBlackWhite(originalBitmapImage);
            outputPB.Image = BlackWhiteOutput;

            hideWait();


            openDividedImagePanel();

        }

        private void openDividedImagePanel()
        {
            mainPanel.Visible = false;
            mainPanel.Dock = DockStyle.None;
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Visible = true;
        }

        private void showWait()
        {
            waitScreen.Show();
            
        }

        private void hideWait()
        {
            waitScreen.Hide();
        }
    }
}

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
    public partial class inicio : Form
    {
        private OpenFileDialog ofd;

        public inicio()
        {
            ofd = new OpenFileDialog();
            InitializeComponent();
        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            //ImagemOriginalPB.Image = Image.FromFile(ofd.FileName);
            pictureBox2.Dock = DockStyle.Bottom;
            pictureBox2.Parent = panel1;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

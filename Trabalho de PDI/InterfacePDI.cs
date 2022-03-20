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
    public partial class InterfacePDI : MetroFramework.Forms.MetroForm
    {
        private OpenFileDialog ofd;
        private Image imagemEscolhida = null;

        public InterfacePDI()
        {
            InitializeComponent();
        }

        private void InterfacePDI_Load(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
        }

        private void avancar_Click(object sender, EventArgs e)
        {
            if(imagemEscolhida == null)
            {
                MessageBox.Show("Você deve escolher uma imagem primeiro");
            }
            else
            {
                Form3 form3 = new Form3(imagemEscolhida);
                this.Hide();
                form3.ShowDialog();
                this.Close();

            }
        }

        private void escolher_imagem_button_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imagemEscolhida = Image.FromFile(ofd.FileName);
                    imagem_escolhida.Image = imagemEscolhida;
                }catch(Exception ex) {
                    MessageBox.Show("Formato de arquivo não suportado");
                };

            }

        }
    }
}

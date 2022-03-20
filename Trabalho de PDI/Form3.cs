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
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        Image image;

        public Form3(Image image)
        {
            this.image = image;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            imageTest.Image = image;
        }
    }
}

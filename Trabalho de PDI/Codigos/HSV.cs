using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_de_PDI
{
    internal class HSV
    {
        public double H { get; set; }
        public double S { get; set; }
        public double V { get; set; }

        public HSV(double H, double S, double V)
        {
            this.H = H;
            this.S = S;
            this.V = V;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjRetanguloGrafico.modelo
{
    class RetanguloMatematico
    {
        public double L1 { get; set; }
        public double L2 { get; set; }
        public RetanguloMatematico(double L1, double L2)
        {
            this.L1 = L1;
            this.L2 = L2;
        }
        public RetanguloMatematico():this(0f,0f)
        {

        }
        public double Area()
        {
            return L1 * L2;
        }
        public double Perimetro()
        {
            return 2 * L1 + 2 * L2;
        }

    }
}

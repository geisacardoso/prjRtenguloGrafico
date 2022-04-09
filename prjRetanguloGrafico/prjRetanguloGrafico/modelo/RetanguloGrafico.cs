using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjRetanguloGrafico.modelo
{
    class RetanguloGrafico
    {
        public Graphics Desenho { get; set; }

        public int Comprimento { get; set; }
        public int Altura { get; set; }

        public int X { get; set; }
        public int Y { get; set; }


        public RetanguloGrafico(Graphics Desenho)
        {
            this.Desenho = Desenho;
            X = 0; 
            Y = 0;
            Comprimento = 0;
            Altura = 0;
        }
        public void Desenhar()
        {
            Pen lapis = new Pen(Color.White, 4);
            Desenho.DrawRectangle(lapis,X, Y, Comprimento*10, Altura*10);
        }

        public void Apagar()
        {
            Desenho.Clear(Color.Black);
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjRetanguloGrafico.visao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        modelo.RetanguloMatematico retangulo;
        modelo.RetanguloGrafico sprite;

        private void Form1_Load(object sender, EventArgs e)
        {
            retangulo = new modelo.RetanguloMatematico()
            {
                L1 = 5,
                L2 = 5
            };

            lbTamanho.Text =
                String.Format("Tamanho: {0:N2} x {1:N2}", retangulo.L1,
                retangulo.L2);

            lbArea.Text =
                String.Format("Área: {0:N2}", retangulo.Area());
            lbPerimetro.Text =
                String.Format("Perimetro: {0:N2}",
                retangulo.Perimetro());

            sprite = new modelo.RetanguloGrafico(pbRetangulo.CreateGraphics());

            sprite.Comprimento = (int)retangulo.L1;
            sprite.Altura = (int)retangulo.L2;

            sprite.X = (int) (retangulo.L1 *10) / 2;
            sprite.Y = (int) (retangulo.L2 * 10) / 2;

        }

        private void hbL1_Scroll(object sender, ScrollEventArgs e)
        {
            retangulo.L1 = hbL1.Value;
            lbTamanho.Text =
               String.Format("Tamanho: {0:N2} x {1:N2}", retangulo.L1,
               retangulo.L2);

            lbArea.Text =
                String.Format("Área: {0:N2}", retangulo.Area());
            lbPerimetro.Text =
                String.Format("Perimetro: {0:N2}",
                retangulo.Perimetro());

            sprite.Comprimento = (int)retangulo.L1;
            sprite.Altura = (int)retangulo.L2;
            sprite.Apagar();
            sprite.Desenhar();
        }

        private void hbL2_Scroll(object sender, ScrollEventArgs e)
        {
            retangulo.L2 = hbL2.Value;
            lbTamanho.Text =

               String.Format("Tamanho: {0:N2} x {1:N2}", retangulo.L1,
               retangulo.L2);

            lbArea.Text =
                String.Format("Área: {0:N2}", retangulo.Area());
            lbPerimetro.Text =
                String.Format("Perimetro: {0:N2}",
                retangulo.Perimetro());

            sprite.Comprimento = (int)retangulo.L1;
            sprite.Altura = (int)retangulo.L2;

            sprite.Apagar();
            sprite.Desenhar();
        }

        private void pbRetangulo_MouseClick(object sender, MouseEventArgs e)
        {
            sprite.X = e.X;
            sprite.Y = e.Y;

            sprite.Apagar();
            sprite.Desenhar();

        }
    }
}


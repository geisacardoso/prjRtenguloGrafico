
namespace prjRetanguloGrafico.visao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.hbL1 = new System.Windows.Forms.HScrollBar();
            this.hbL2 = new System.Windows.Forms.VScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTamanho = new System.Windows.Forms.Label();
            this.lbArea = new System.Windows.Forms.Label();
            this.lbPerimetro = new System.Windows.Forms.Label();
            this.pbRetangulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetangulo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "L1";
            // 
            // hbL1
            // 
            this.hbL1.LargeChange = 1;
            this.hbL1.Location = new System.Drawing.Point(38, 460);
            this.hbL1.Maximum = 50;
            this.hbL1.Minimum = 1;
            this.hbL1.Name = "hbL1";
            this.hbL1.Size = new System.Drawing.Size(573, 15);
            this.hbL1.TabIndex = 1;
            this.hbL1.Value = 1;
            this.hbL1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hbL1_Scroll);
            // 
            // hbL2
            // 
            this.hbL2.LargeChange = 1;
            this.hbL2.Location = new System.Drawing.Point(592, 40);
            this.hbL2.Maximum = 50;
            this.hbL2.Minimum = 1;
            this.hbL2.Name = "hbL2";
            this.hbL2.Size = new System.Drawing.Size(19, 398);
            this.hbL2.TabIndex = 2;
            this.hbL2.Value = 1;
            this.hbL2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hbL2_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "L2";
            // 
            // lbTamanho
            // 
            this.lbTamanho.AutoSize = true;
            this.lbTamanho.Location = new System.Drawing.Point(231, 14);
            this.lbTamanho.Name = "lbTamanho";
            this.lbTamanho.Size = new System.Drawing.Size(104, 14);
            this.lbTamanho.TabIndex = 3;
            this.lbTamanho.Text = "Tamanho: 0 x 0";
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Location = new System.Drawing.Point(146, 424);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(53, 14);
            this.lbArea.TabIndex = 3;
            this.lbArea.Text = "Area: 0";
            // 
            // lbPerimetro
            // 
            this.lbPerimetro.AutoSize = true;
            this.lbPerimetro.Location = new System.Drawing.Point(356, 424);
            this.lbPerimetro.Name = "lbPerimetro";
            this.lbPerimetro.Size = new System.Drawing.Size(85, 14);
            this.lbPerimetro.TabIndex = 3;
            this.lbPerimetro.Text = "Perimetro: 0";
            // 
            // pbRetangulo
            // 
            this.pbRetangulo.BackColor = System.Drawing.SystemColors.Desktop;
            this.pbRetangulo.Location = new System.Drawing.Point(38, 40);
            this.pbRetangulo.Name = "pbRetangulo";
            this.pbRetangulo.Size = new System.Drawing.Size(533, 364);
            this.pbRetangulo.TabIndex = 4;
            this.pbRetangulo.TabStop = false;
            this.pbRetangulo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbRetangulo_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 484);
            this.Controls.Add(this.pbRetangulo);
            this.Controls.Add(this.lbPerimetro);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.lbTamanho);
            this.Controls.Add(this.hbL2);
            this.Controls.Add(this.hbL1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROJETO RETANGULO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRetangulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar hbL1;
        private System.Windows.Forms.VScrollBar hbL2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTamanho;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.Label lbPerimetro;
        private System.Windows.Forms.PictureBox pbRetangulo;
    }
}


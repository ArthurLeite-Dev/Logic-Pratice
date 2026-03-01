using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrabalhoLogP
{
    public class Exercício3 : Form
    {
        private RadioButton rdbCorAzul, rdbCorAmarelo, rdbCorVermelho;
        private Button btnMudaCorDeFundo;

        public Exercício3() { InitializeComponent(); }

        private void InitializeComponent()
        {
            this.rdbCorAzul = new RadioButton { Text = "Azul", Location = new Point(182, 173) };
            this.rdbCorAmarelo = new RadioButton { Text = "Amarelo", Location = new Point(365, 173) };
            this.rdbCorVermelho = new RadioButton { Text = "Vermelho", Location = new Point(578, 173) };
            this.btnMudaCorDeFundo = new Button { Text = "Trocar cor de fundo", Location = new Point(258, 282), Size = new Size(284, 86) };

            this.btnMudaCorDeFundo.Click += (s, e) => {
                if (rdbCorAmarelo.Checked) BackColor = Color.Yellow;
                if (rdbCorAzul.Checked) BackColor = Color.Blue;
                if (rdbCorVermelho.Checked) BackColor = Color.Red;
            };

            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.AddRange(new Control[] { rdbCorAzul, rdbCorAmarelo, rdbCorVermelho, btnMudaCorDeFundo });
            this.Text = "Exercício 3";
        }
    }
}
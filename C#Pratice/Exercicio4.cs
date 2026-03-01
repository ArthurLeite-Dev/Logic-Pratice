using System;
using System.Windows.Forms;

namespace TrabalhoLogP
{
    public class Exercício4 : Form
    {
        private CheckBox chkdoritos, chkkinderovo, chkRedBull, chkCocaCola, chkOlho, chkLingua, chkRabo, chkCasco;
        private Label lblpreco;
        private Button btncalculo;

        public Exercício4() { InitializeComponent(); }

        private void InitializeComponent()
        {
            this.chkdoritos = new CheckBox { Text = "Doritos", Location = new System.Drawing.Point(188, 92) };
            this.chkkinderovo = new CheckBox { Text = "KinderOvo", Location = new System.Drawing.Point(188, 140) };
            this.chkRedBull = new CheckBox { Text = "RedBull", Location = new System.Drawing.Point(188, 189) };
            this.chkCocaCola = new CheckBox { Text = "Coca Cola", Location = new System.Drawing.Point(188, 236) };
            this.chkOlho = new CheckBox { Text = "Olho de peixe", Location = new System.Drawing.Point(435, 92) };
            this.chkLingua = new CheckBox { Text = "Língua de Boi", Location = new System.Drawing.Point(435, 140) };
            this.chkRabo = new CheckBox { Text = "Rabo de Jacaré", Location = new System.Drawing.Point(435, 189) };
            this.chkCasco = new CheckBox { Text = "Casco de Boi", Location = new System.Drawing.Point(435, 236) };
            this.btncalculo = new Button { Text = "Calcular preço", Location = new System.Drawing.Point(184, 332), Size = new System.Drawing.Size(204, 68) };
            this.lblpreco = new Label { Text = "0,00", Location = new System.Drawing.Point(463, 349), Size = new System.Drawing.Size(110, 39) };

            this.btncalculo.Click += (s, e) => {
                double total = 0;
                if (chkdoritos.Checked) total += 17.5;
                if (chkkinderovo.Checked) total += 10.0;
                if (chkRedBull.Checked) total += 7.25;
                if (chkCocaCola.Checked) total += 6.0;
                if (chkOlho.Checked) total += 12.0;
                if (chkLingua.Checked) total += 30.0;
                if (chkRabo.Checked) total += 25.2;
                if (chkCasco.Checked) total += 18.0;
                lblpreco.Text = total.ToString("N2");
            };

            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.AddRange(new Control[] { chkdoritos, chkkinderovo, chkRedBull, chkCocaCola, chkOlho, chkLingua, chkRabo, chkCasco, btncalculo, lblpreco });
            this.Text = "Exercício 4";
        }
    }
}
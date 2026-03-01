using System;
using System.Windows.Forms;

namespace TrabalhoLogP
{
    public class Exercício2 : Form
    {
        private Label lblinstrucao;
        private TextBox textBox1;
        private Label lblCaixaAlta;

        public Exercício2() { InitializeComponent(); }

        private void InitializeComponent()
        {
            this.lblinstrucao = new Label();
            this.textBox1 = new TextBox();
            this.lblCaixaAlta = new Label();
            this.SuspendLayout();

            this.lblinstrucao.Text = "Digite algo para que o texto seja exibido em maiúsculo:";
            this.lblinstrucao.Location = new System.Drawing.Point(175, 9);
            this.lblinstrucao.AutoSize = true;

            this.textBox1.Location = new System.Drawing.Point(5, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Size = new System.Drawing.Size(791, 169);
            this.textBox1.KeyUp += (s, e) => lblCaixaAlta.Text = textBox1.Text.ToUpper();

            this.lblCaixaAlta.Text = "Seu texto aparecerá aqui";
            this.lblCaixaAlta.Location = new System.Drawing.Point(9, 234);
            this.lblCaixaAlta.AutoSize = true;

            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCaixaAlta);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblinstrucao);
            this.Text = "Exercício 2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
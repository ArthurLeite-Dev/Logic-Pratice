using System;
using System.Windows.Forms;

namespace TrabalhoLogP
{
    public class Exercício1 : Form
    {
        private ComboBox cmbInicio;
        private ComboBox cmbFim;
        private ListBox lstNumeros;

        public Exercício1()
        {
            InitializeComponent();
        }

        private void Exercício1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++) cmbInicio.Items.Add(i);
            for (int j = 1; j <= 10; j++) cmbFim.Items.Add(j);
        }

        private void AtualizarLista()
        {
            if (cmbInicio.SelectedItem == null || cmbFim.SelectedItem == null) return;
            int num = (int)cmbInicio.SelectedItem;
            int num2 = (int)cmbFim.SelectedItem;
            lstNumeros.Items.Clear();
            if (num <= num2)
                for (int i = num; i <= num2; i++) lstNumeros.Items.Add(i);
            else
                for (int i = num; i >= num2; i--) lstNumeros.Items.Add(i);
        }

        private void InitializeComponent()
        {
            this.cmbInicio = new ComboBox();
            this.cmbFim = new ComboBox();
            this.lstNumeros = new ListBox();
            this.SuspendLayout();

            this.cmbInicio.Location = new System.Drawing.Point(89, 50);
            this.cmbInicio.Size = new System.Drawing.Size(121, 21);
            this.cmbInicio.SelectedIndexChanged += (s, e) => AtualizarLista();

            this.cmbFim.Location = new System.Drawing.Point(570, 50);
            this.cmbFim.Size = new System.Drawing.Size(121, 21);
            this.cmbFim.SelectedIndexChanged += (s, e) => AtualizarLista();

            this.lstNumeros.Location = new System.Drawing.Point(1, 120);
            this.lstNumeros.Size = new System.Drawing.Size(799, 329);

            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.cmbFim);
            this.Controls.Add(this.cmbInicio);
            this.Text = "Exercício 1";
            this.Load += new EventHandler(Exercício1_Load);
            this.ResumeLayout(false);
        }
    }
}
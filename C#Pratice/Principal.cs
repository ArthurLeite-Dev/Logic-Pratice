using System;
using System.Windows.Forms;

namespace TrabalhoLogP
{
    public class Principal : Form
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem atividadeArthurToolStripMenuItem;
        private ToolStripMenuItem exercício1ToolStripMenuItem;
        private ToolStripMenuItem exercício2ToolStripMenuItem;
        private ToolStripMenuItem exercício3ToolStripMenuItem;
        private ToolStripMenuItem exercício4ToolStripMenuItem;

        public Principal()
        {
            InitializeComponent();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercício1 exercício = new Exercício1();
            exercício.ShowDialog();
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercício2 exercício = new Exercício2();
            exercício.ShowDialog();
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercício3 exercício = new Exercício3();
            exercício.ShowDialog();
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercício4 exercício = new Exercício4();
            exercício.ShowDialog();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new MenuStrip();
            this.atividadeArthurToolStripMenuItem = new ToolStripMenuItem();
            this.exercício1ToolStripMenuItem = new ToolStripMenuItem();
            this.exercício2ToolStripMenuItem = new ToolStripMenuItem();
            this.exercício3ToolStripMenuItem = new ToolStripMenuItem();
            this.exercício4ToolStripMenuItem = new ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

            this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.atividadeArthurToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);

            this.atividadeArthurToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.exercício1ToolStripMenuItem, this.exercício2ToolStripMenuItem, this.exercício3ToolStripMenuItem, this.exercício4ToolStripMenuItem });
            this.atividadeArthurToolStripMenuItem.Text = "Atividades - Arthur";

            this.exercício1ToolStripMenuItem.Text = "Exercício 1";
            this.exercício1ToolStripMenuItem.Click += new EventHandler(exercício1ToolStripMenuItem_Click);

            this.exercício2ToolStripMenuItem.Text = "Exercício 2";
            this.exercício2ToolStripMenuItem.Click += new EventHandler(exercício2ToolStripMenuItem_Click);

            this.exercício3ToolStripMenuItem.Text = "Exercício 3";
            this.exercício3ToolStripMenuItem.Click += new EventHandler(exercício3ToolStripMenuItem_Click);

            this.exercício4ToolStripMenuItem.Text = "Exercício 4";
            this.exercício4ToolStripMenuItem.Click += new EventHandler(exercício4ToolStripMenuItem_Click);

            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Text = "Arthur da Silva Leite - 2ºetapa";
            this.WindowState = FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
using System;
using System.Drawing;
using System.Windows.Forms;
using TramontiniSciacaluga_GestorAlumnos.Models;
using TramontiniSciacaluga_GestorAlumnos.src;

namespace TramontiniSciacaluga_GestorAlumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Inicializa los componentes visuales definidos en el Designer
            InitializeComponent();

            // Configuración extra de la ventana
            this.Text = "Gestor de Alumnos - Trabajo Final";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            // IMPORTANTE: Dejamos esto en false para que las ventanas se abran independientes
            this.IsMdiContainer = false;
        }

        private void crearNuevoArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCrear formCrear = new FormCrear();
            formCrear.Show();
        }

        private void leerArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLeer formLeer = new FormLeer();
            formLeer.Show();
        }

        private void modificarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificar formModif = new FormModificar();
            formModif.Show();
        }

        private void eliminarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEliminar formElim = new FormEliminar();
            formElim.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void convertirFormatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConversor conversor = new FormConversor();
            conversor.Show();
        }

        private void generarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportes reportes = new FormReportes();
            reportes.Show();
        }

    }
}
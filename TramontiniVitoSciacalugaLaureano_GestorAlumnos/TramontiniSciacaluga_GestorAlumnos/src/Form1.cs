using System;
using System.Drawing;
using System.Windows.Forms;
using TramontiniSciacaluga_GestorAlumnos.Models;

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

        // ==========================================
        //    EVENTOS DEL MENÚ (Conectados por el Designer)
        // ==========================================

        private void crearNuevoArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirCrear();
        }

        private void leerArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirLeer();
        }

        private void modificarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirModificar();
        }

        private void eliminarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccionEliminar();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void convertirFormatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccionConvertir();
        }

        private void generarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccionReporte();
        }

        // ==========================================
        //           LÓGICA DE NEGOCIO
        // ==========================================

        private void AbrirCrear()
        {
            // Abre el formulario de creación
            FormCrear form = new FormCrear();
            form.Show();
        }

        private void AbrirLeer()
        {
            // Abre el formulario de lectura
            FormLeer form = new FormLeer();
            form.Show();
        }

        private void AbrirModificar()
        {
            MessageBox.Show("Aquí se abrirá la ventana de MODIFICAR.\n(Necesitamos crear el FormModificar.cs)", "En construcción");
        }

        private void AccionEliminar()
        {
            // Usamos InputBox de VB.NET o un cuadro de diálogo simple si no tienes la referencia
            // Para simplificar ahora, usamos un MessageBox simulado
            MessageBox.Show("Funcionalidad pendiente: Eliminar Archivo", "En construcción");
        }

        private void AccionConvertir()
        {
            MessageBox.Show("Funcionalidad de conversión pendiente.", "En construcción");
        }

        private void AccionReporte()
        {
            MessageBox.Show("Funcionalidad de reporte pendiente.", "En construcción");
        }
    }
}
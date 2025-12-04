using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using TramontiniSciacaluga_GestorAlumnos.Models;

namespace TramontiniSciacaluga_GestorAlumnos
{
    public partial class FormLeer : Form
    {
        // Instancia del gestor
        private GestorArchivos gestor = new GestorArchivos();

        public FormLeer()
        {
            // Inicializa los componentes definidos en el Designer
            InitializeComponent();
        }

        // --- EVENTO DEL BOTÓN BUSCAR (Conectado desde el Designer) ---
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreArchivo.Text;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor, ingrese un nombre de archivo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validamos existencia antes de intentar leer
            if (!gestor.ValidarExistencia(nombre))
            {
                MessageBox.Show($"El archivo '{nombre}' no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Preparamos los datos
                string ruta = Path.IsPathRooted(nombre) ? nombre : Path.Combine(Environment.CurrentDirectory, nombre);
                string extension = Path.GetExtension(nombre).ToLower();

                // Delegamos la lectura al gestor
                List<Alumno> lista = gestor.LeerAlumnosDesdeArchivo(extension, ruta);

                // Actualizamos la interfaz
                CargarGrilla(lista);

                MessageBox.Show($"Se leyeron {lista.Count} registros correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo: {ex.Message}", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- MÉTODOS AUXILIARES ---
        private void CargarGrilla(List<Alumno> lista)
        {
            // Limpiamos la fuente de datos anterior
            dgvAlumnos.DataSource = null;
            // Asignamos la nueva lista (la grilla genera las columnas automáticamente)
            dgvAlumnos.DataSource = lista;

            // Actualizamos la etiqueta de total
            lblTotal.Text = $"Total de alumnos: {lista.Count}";
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TramontiniSciacaluga_GestorAlumnos.src
{
    public partial class FormEliminar : Form
    {
        private GestorArchivos gestor = new GestorArchivos();
        private string archivoAConsultar = string.Empty;
        private string rutaCompleta = string.Empty;

        public FormEliminar()
        {
            InitializeComponent();
            LimpiarInformacion();
        }

        private void LimpiarInformacion()
        {
            lblInfoNombre.Text = "Nombre completo: -";
            lblInfoTamaño.Text = "Tamaño (KB): -";
            lblInfoCreacion.Text = "Fecha de creación: -";
            lblInfoModificacion.Text = "Última modificación (Mod): -";
            btnEliminar.Enabled = false;
        }


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            LimpiarInformacion(); // Limpiar datos de busquedas anteriores

            archivoAConsultar = txtNombreArchivo.Text.Trim();

            if (string.IsNullOrWhiteSpace(archivoAConsultar))
            {
                MessageBox.Show("Ingrese el nombre completo del archivo (con extensión).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreArchivo.Focus();
                return;
            }

            rutaCompleta = Path.Combine(Environment.CurrentDirectory, archivoAConsultar);

            try
            {
                if (!gestor.ValidarExistencia(archivoAConsultar))
                {
                    MessageBox.Show($"ERROR: El archivo \"{archivoAConsultar}\" no existe en el directorio actual.", "Error de Existencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // si existe, obtener y mostrar la informacion del archivo 
                FileInfo fileInfo = new FileInfo(rutaCompleta);
                double tamañoKB = Math.Round((double)fileInfo.Length / 1024, 2);

                lblInfoNombre.Text = $"Nombre completo: {archivoAConsultar}";
                lblInfoTamaño.Text = $"Tamaño (KB): {tamañoKB}";
                lblInfoCreacion.Text = $"Fecha de creación: {fileInfo.CreationTime:dd/MM/yyyy HH:mm}";
                lblInfoModificacion.Text = $"Última modificación (Mod): {fileInfo.LastWriteTime:dd/MM/yyyy HH:mm}";

                // habilita el botón de eliminar, ya que el archivo ya fue encontrado
                btnEliminar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar acceder a la información del archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarInformacion();
            }
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rutaCompleta) || !File.Exists(rutaCompleta))
            {
                MessageBox.Show("Primero debe buscar y validar un archivo existente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // solicita confirmación 
            DialogResult result = MessageBox.Show($"¿Está seguro que desea eliminar PERMANENTEMENTE el archivo: {archivoAConsultar}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    gestor.EliminarArchivo(rutaCompleta);

                    MessageBox.Show($"Archivo '{archivoAConsultar}' eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Resetea el estado de la ventana del formEliminar
                    txtNombreArchivo.Clear();
                    LimpiarInformacion();
                    txtNombreArchivo.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // si se cancela, vuelve a la ventana sin eliminar
                MessageBox.Show("Eliminación cancelada", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

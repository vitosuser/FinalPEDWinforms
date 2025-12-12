using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TramontiniSciacaluga_GestorAlumnos.Models;

namespace TramontiniSciacaluga_GestorAlumnos.src
{
    public partial class FormReportes : Form
    {
        private GestorArchivos gestor = new GestorArchivos();
        private GeneradorReportes generador = new GeneradorReportes();
        private List<Alumno>? listaAlumnos = null;
        private string reporteGenerado = string.Empty;

        public FormReportes()
        {
            InitializeComponent();
            LimpiarEstado();
        }

        private void LimpiarEstado()
        {
            listaAlumnos = null;
            reporteGenerado = string.Empty;
            lblInfoCarga.Text = "Esperando la carga de un archivo";
            txtReporte.Text = "Aquí se mostrará el reporte agrupado por apellido, subtotales y resumen general";
            txtNombreGuardar.Clear();
            txtNombreGuardar.Enabled = false;
            btnGuardarTxt.Enabled = false;
        }

        private void BtnCargarGenerar_Click(object sender, EventArgs e)
        {
            LimpiarEstado();

            string archivo = txtNombreArchivo.Text.Trim();

            if (string.IsNullOrWhiteSpace(archivo))
            {
                MessageBox.Show("Ingrese el nombre completo del archivo fuente (con extensión).", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreArchivo.Focus();
                return;
            }

            if (!gestor.ValidarExistencia(archivo))
            {
                MessageBox.Show($"ERROR: El archivo \"{archivo}\" no existe en el directorio actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string rutaOrigen = Path.Combine(Environment.CurrentDirectory, archivo);
            string extOrigen = Path.GetExtension(rutaOrigen).ToLowerInvariant();

            var formatosSoportados = new List<string> { ".txt", ".csv", ".json", ".xml" };

            if (!formatosSoportados.Contains(extOrigen))
            {
                MessageBox.Show($"ERROR: Extensión de origen '{extOrigen}' no soportada para la lectura.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cargar datos
            try
            {
                listaAlumnos = gestor.LeerAlumnosDesdeArchivo(extOrigen, rutaOrigen);

                if (listaAlumnos == null || listaAlumnos.Count == 0)
                {
                    MessageBox.Show("El archivo no contiene registros válidos o está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (listaAlumnos.Count > 0)
                {
                    reporteGenerado = generador.GenerarReporte(listaAlumnos);

                    // Mostrar reporte en el textbox multiline
                    txtReporte.Text = reporteGenerado;
                    lblInfoCarga.Text = $"Reporte generado. Registros procesados: {listaAlumnos.Count}";

                    // Habilita opción de guardar
                    txtNombreGuardar.Enabled = true;
                    btnGuardarTxt.Enabled = true;
                    txtNombreGuardar.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar el archivo o generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarEstado();
            }
        }


        private void BtnGuardarTxt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(reporteGenerado))
            {
                MessageBox.Show("Primero debe generar el reporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombreReporte = txtNombreGuardar.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombreReporte))
            {
                MessageBox.Show("Ingrese un nombre para el archivo de reporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreGuardar.Focus();
                return;
            }

            string rutaReporte = Path.Combine(Environment.CurrentDirectory, $"{nombreReporte}.txt");

            try
            {
                // Escribe el contenido del TextBox multilinea al archivo TXT
                File.WriteAllText(rutaReporte, reporteGenerado, Encoding.UTF8);

                MessageBox.Show($"Reporte guardado con éxito en:\n{rutaReporte}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarEstado();
                txtNombreArchivo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


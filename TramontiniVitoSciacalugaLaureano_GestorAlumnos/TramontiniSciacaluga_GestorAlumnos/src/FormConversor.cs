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
    public partial class FormConversor : Form
    {
        private GestorArchivos gestor = new GestorArchivos();
        private List<Alumno> listaAlumnos = null;
        private string extOrigen = string.Empty;
        private string rutaOrigen = string.Empty;

        public FormConversor()
        {
            InitializeComponent();

            cmbDestino.Enabled = false;
            txtNombreDestino.Enabled = false;
            btnConvertir.Enabled = false;

            lblOrigenInfo.Text = "Esperando la carga de un archivo...";
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            LimpiarEstado(); // Resetear variables antes de intentar cargar

            string archivo = txtNombreArchivoOrigen.Text.Trim();

            if (string.IsNullOrWhiteSpace(archivo))
            {
                MessageBox.Show("Ingrese el nombre completo del archivo de origen (Ej: alumnos.txt).", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreArchivoOrigen.Focus();
                return;
            }

            // Construir la ruta completa 
            rutaOrigen = Path.Combine(Environment.CurrentDirectory, archivo);

            if (!gestor.ValidarExistencia(archivo))
            {
                MessageBox.Show($"ERROR: El archivo \"{archivo}\" no existe en la ruta:\n{rutaOrigen}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Detecta formato de origen automáticamente
            extOrigen = Path.GetExtension(rutaOrigen).ToLowerInvariant();

            var formatosSoportados = new List<string> { ".txt", ".csv", ".json", ".xml" };

            //verifica compatibilidad de formato
            if (!formatosSoportados.Contains(extOrigen))
            {
                MessageBox.Show($"ERROR: La extensión de origen '{extOrigen}' no es soportada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Carga todos los registros (para leer y parsear el archivo)
            try
            {
                listaAlumnos = gestor.LeerAlumnosDesdeArchivo(extOrigen, rutaOrigen);

                if (listaAlumnos == null || listaAlumnos.Count == 0)
                {
                    // Si el archivo existe pero no tiene datos que se puedan parsear
                    throw new Exception("El archivo fue encontrado, pero no contiene registros válidos o está vacío.");
                }

                // Actualiza label para mostrar el exito al leer
                lblOrigenInfo.Text = $"Archivo cargado. Formato: {extOrigen.ToUpper()} | Registros: {listaAlumnos.Count}";

                // Habilita la configuración del destino
                ActualizarFormatosDestino();
                cmbDestino.Enabled = true;
                txtNombreDestino.Enabled = true;
                btnConvertir.Enabled = true;
                txtNombreDestino.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer/parsear el contenido del archivo: " + ex.Message, "Error de Lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarEstado(); // Falló la lectura, resetear.
            }
        }

        private void ActualizarFormatosDestino()
        {
            cmbDestino.Items.Clear();
            var formatosDestino = new List<string>();

            switch (extOrigen.ToLowerInvariant())
            {
                case ".txt":

                    formatosDestino.AddRange(new[] { "CSV"});
                    break;

                case ".csv":

                    formatosDestino.AddRange(new[] { "TXT", "JSON"});
                    break;

                case ".json":

                    formatosDestino.AddRange(new[] { "CSV", "XML" });
                    break;

                case ".xml":

                    formatosDestino.AddRange(new[] { "JSON" });
                    break;
            }

            // Agrega los formatos disponibles al ComboBox
            foreach (var formatos in formatosDestino)
            {
                cmbDestino.Items.Add(formatos);
            }

            if (cmbDestino.Items.Count > 0)
            {
                cmbDestino.SelectedIndex = 0;
            }
        }


        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            // Validaciones finales
            if (listaAlumnos == null || listaAlumnos.Count == 0)
            {
                MessageBox.Show("Debe cargar un archivo de origen válido primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string nombreDestino = txtNombreDestino.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombreDestino))
            {
                MessageBox.Show("Ingrese un nombre para el archivo de destino.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreDestino.Focus();
                return;
            }

            if (cmbDestino.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un formato de destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string extDestino = "." + cmbDestino.SelectedItem.ToString().ToLower();
            string rutaDestino = Path.Combine(Environment.CurrentDirectory, nombreDestino + extDestino);

            // Evita sobrescribir el archivo de origen con el mismo nombre y extensión
            if (rutaDestino.Equals(rutaOrigen, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("El archivo de destino no puede ser idéntico al de origen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombreOrigen = txtNombreArchivoOrigen.Text;
            //extOrigen = Path.GetExtension(rutaOrigen).ToLowerInvariant();

            // Escritura / Serializacion
            try
            {
                gestor.GuardarArchivo(rutaDestino, extDestino, listaAlumnos);

                MessageBox.Show($"Conversión Exitosa: Resumen\nArchivo origen: {nombreOrigen}\nArchivo destino: {nombreDestino}{extDestino}\nRegistros: {listaAlumnos.Count}","Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarEstado();
                txtNombreArchivoOrigen.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la conversión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarEstado()
        {
            listaAlumnos = null;
            extOrigen = string.Empty;
            rutaOrigen = string.Empty;

            lblOrigenInfo.Text = "Esperando la carga de un archivo...";

            cmbDestino.Items.Clear();
            cmbDestino.Enabled = false;

            txtNombreDestino.Clear();
            txtNombreDestino.Enabled = false;

            btnConvertir.Enabled = false;
        }

        private void CmbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDestino.SelectedIndex != -1)
            {
                string ext = cmbDestino.SelectedItem.ToString().ToLower();

                // Obtenemos el nombre base del archivo de origen para sugerir un nombre de destino
                string nombreBaseOrigen = Path.GetFileNameWithoutExtension(txtNombreArchivoOrigen.Text.Trim());

                txtNombreDestino.PlaceholderText = $"Ej: {nombreBaseOrigen}_convertido (sin extensión)";

                // Asegurar que el TextBox de destino tenga foco si se acaba de habilitar
                if (txtNombreDestino.Enabled)
                {
                    txtNombreDestino.Focus();
                }
            }
        }
    }
}


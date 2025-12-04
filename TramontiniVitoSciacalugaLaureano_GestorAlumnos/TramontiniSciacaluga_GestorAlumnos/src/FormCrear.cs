using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
// CORRECCIÓN: Usamos el namespace exacto que tiene tu Alumno.cs (sin .src)
using TramontiniSciacaluga_GestorAlumnos.Models;

namespace TramontiniSciacaluga_GestorAlumnos
{
    public partial class FormCrear : Form
    {
        private GestorArchivos gestor = new GestorArchivos();
        private List<Alumno> listaTemporal = new List<Alumno>();

        // NOTA: Ya no definimos los controles aquí (TextBox, Button, etc.) 
        // porque ahora están definidos automáticamente en FormCrear.Designer.cs

        public FormCrear()
        {
            // ESTO ES CLAVE: Inicializa los componentes que están en el Designer.cs
            InitializeComponent();

            // Configuraciones visuales iniciales
            cmbFormato.SelectedIndex = 2; // Selecciona JSON por defecto
        }

        // --- LÓGICA DEL BOTÓN AGREGAR ---
        // Este método se conecta automáticamente gracias al Designer.cs
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // 1. Validaciones
            if (!Regex.IsMatch(txtLegajo.Text, @"^\d+$")) { MsgError("Legajo debe ser numérico."); return; }
            if (string.IsNullOrWhiteSpace(txtApellido.Text)) { MsgError("Apellido requerido."); return; }
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) { MsgError("Nombre requerido."); return; }
            if (!Regex.IsMatch(txtDoc.Text, @"^\d+$")) { MsgError("Documento debe ser numérico."); return; }
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) { MsgError("Email inválido."); return; }
            if (!Regex.IsMatch(txtTel.Text, @"^\d+$")) { MsgError("Teléfono debe ser numérico."); return; }

            // 2. Crear objeto y agregar a la lista temporal
            Alumno alu = new Alumno(txtLegajo.Text, txtApellido.Text, txtNombre.Text, txtDoc.Text, txtEmail.Text, txtTel.Text);
            listaTemporal.Add(alu);

            // 3. Feedback visual en la lista
            lstAlumnosCargados.Items.Add($"{alu.Legajo} - {alu.Apellido}, {alu.Nombre}");

            // 4. Limpiar campos para el siguiente
            LimpiarCamposAlumno();
        }

        // --- LÓGICA DEL BOTÓN GUARDAR ---
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (listaTemporal.Count == 0) { MsgError("La lista está vacía. Agregue alumnos primero."); return; }
            if (string.IsNullOrWhiteSpace(txtNombreArchivo.Text)) { MsgError("Ingrese un nombre para el archivo."); return; }

            try
            {
                string nombre = txtNombreArchivo.Text;
                string ext = "." + cmbFormato.SelectedItem.ToString().ToLower();
                string ruta = Path.Combine(Environment.CurrentDirectory, nombre + ext);

                // Llamamos al gestor para que guarde en disco
                gestor.GuardarArchivo(ruta, ext, listaTemporal);

                MessageBox.Show($"✅ Archivo guardado con éxito en:\n{ruta}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cerramos la ventana al terminar
            }
            catch (Exception ex)
            {
                MsgError("Error al guardar: " + ex.Message);
            }
        }

        // --- MÉTODOS AUXILIARES ---
        private void LimpiarCamposAlumno()
        {
            txtLegajo.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtDoc.Clear();
            txtEmail.Clear();
            txtTel.Clear();
            txtLegajo.Focus();
        }

        private void MsgError(string msg) => MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
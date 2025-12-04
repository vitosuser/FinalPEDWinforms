using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
// CORRECCIÓN: Quitamos el ".src" para que coincida con tu Alumno.cs
using TramontiniSciacaluga_GestorAlumnos.Models;

namespace TramontiniSciacaluga_GestorAlumnos
{
    public partial class FormCrear : Form
    {
        private GestorArchivos gestor = new GestorArchivos();
        private List<Alumno> listaTemporal = new List<Alumno>();

        // Controles
        private TextBox txtNombreArchivo;
        private ComboBox cmbFormato;
        private TextBox txtLegajo, txtApellido, txtNombre, txtDoc, txtEmail, txtTel;
        private ListBox lstAlumnosCargados;

        public FormCrear()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Crear Nuevo Archivo";
            this.Size = new Size(600, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            // 1. SECCIÓN ARCHIVO
            Label lblTitulo = new Label { Text = "1. Configuración del Archivo", Location = new Point(20, 20), AutoSize = true, Font = new Font(this.Font, FontStyle.Bold) };

            Label lblNombre = new Label { Text = "Nombre (sin ext):", Location = new Point(20, 50), AutoSize = true };
            txtNombreArchivo = new TextBox { Location = new Point(130, 47), Width = 200 };

            Label lblFormato = new Label { Text = "Formato:", Location = new Point(350, 50), AutoSize = true };
            cmbFormato = new ComboBox { Location = new Point(410, 47), Width = 100, DropDownStyle = ComboBoxStyle.DropDownList };
            cmbFormato.Items.AddRange(new string[] { "TXT", "CSV", "JSON", "XML" });
            cmbFormato.SelectedIndex = 2; // Default JSON

            // 2. SECCIÓN ALUMNO
            int startY = 100;
            Label lblTitulo2 = new Label { Text = "2. Cargar Alumno", Location = new Point(20, startY), AutoSize = true, Font = new Font(this.Font, FontStyle.Bold) };

            // Campos del alumno
            txtLegajo = CrearCampo("Legajo:", 20, startY + 30);
            txtApellido = CrearCampo("Apellido:", 20, startY + 60);
            txtNombre = CrearCampo("Nombre:", 20, startY + 90);
            txtDoc = CrearCampo("Documento:", 300, startY + 30);
            txtEmail = CrearCampo("Email:", 300, startY + 60);
            txtTel = CrearCampo("Teléfono:", 300, startY + 90);

            // Botón Agregar
            Button btnAgregar = new Button { Text = "Agregar Alumno a la Lista", Location = new Point(20, startY + 130), Width = 540, Height = 30, BackColor = Color.LightBlue };
            btnAgregar.Click += BtnAgregar_Click;

            // 3. LISTA VISUAL
            lstAlumnosCargados = new ListBox { Location = new Point(20, startY + 180), Width = 540, Height = 100 };

            // 4. BOTÓN GUARDAR FINAL
            Button btnGuardar = new Button { Text = "💾 GUARDAR ARCHIVO EN DISCO", Location = new Point(20, startY + 300), Width = 540, Height = 40, BackColor = Color.LightGreen, Font = new Font(this.Font, FontStyle.Bold) };
            btnGuardar.Click += BtnGuardar_Click;

            // Agregar todo al form
            this.Controls.AddRange(new Control[] {
                lblTitulo, lblNombre, txtNombreArchivo, lblFormato, cmbFormato,
                lblTitulo2, btnAgregar, lstAlumnosCargados, btnGuardar,
                txtLegajo, txtApellido, txtNombre, txtDoc, txtEmail, txtTel
            });
        }

        private TextBox CrearCampo(string labelText, int x, int y)
        {
            Label l = new Label { Text = labelText, Location = new Point(x, y + 3), AutoSize = true };
            TextBox t = new TextBox { Location = new Point(x + 70, y), Width = 180 };
            this.Controls.Add(l);
            this.Controls.Add(t);
            return t;
        }

        // --- LÓGICA DE BOTONES ---

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Validaciones con MessageBox
            if (!Regex.IsMatch(txtLegajo.Text, @"^\d+$")) { MsgError("Legajo debe ser numérico."); return; }
            if (string.IsNullOrWhiteSpace(txtApellido.Text)) { MsgError("Apellido requerido."); return; }
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) { MsgError("Nombre requerido."); return; }
            if (!Regex.IsMatch(txtDoc.Text, @"^\d+$")) { MsgError("Documento debe ser numérico."); return; }
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) { MsgError("Email inválido."); return; }
            if (!Regex.IsMatch(txtTel.Text, @"^\d+$")) { MsgError("Teléfono debe ser numérico."); return; }

            // Crear objeto
            Alumno alu = new Alumno(txtLegajo.Text, txtApellido.Text, txtNombre.Text, txtDoc.Text, txtEmail.Text, txtTel.Text);
            listaTemporal.Add(alu);

            // Feedback visual
            lstAlumnosCargados.Items.Add($"{alu.Legajo} - {alu.Apellido}, {alu.Nombre}");
            LimpiarCamposAlumno();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (listaTemporal.Count == 0) { MsgError("La lista está vacía. Agregue alumnos primero."); return; }
            if (string.IsNullOrWhiteSpace(txtNombreArchivo.Text)) { MsgError("Ingrese un nombre para el archivo."); return; }

            try
            {
                string nombre = txtNombreArchivo.Text;
                string ext = "." + cmbFormato.SelectedItem.ToString().ToLower();
                string ruta = Path.Combine(Environment.CurrentDirectory, nombre + ext);

                gestor.GuardarArchivo(ruta, ext, listaTemporal);

                MessageBox.Show($"✅ Archivo guardado con éxito en:\n{ruta}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MsgError("Error al guardar: " + ex.Message);
            }
        }

        private void LimpiarCamposAlumno()
        {
            txtLegajo.Clear(); txtApellido.Clear(); txtNombre.Clear();
            txtDoc.Clear(); txtEmail.Clear(); txtTel.Clear();
            txtLegajo.Focus();
        }

        private void MsgError(string msg) => MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
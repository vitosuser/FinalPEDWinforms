using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TramontiniSciacaluga_GestorAlumnos.Models;

namespace TramontiniSciacaluga_GestorAlumnos
{
    public partial class FormCrear : Form
    {
        private GestorArchivos gestor = new GestorArchivos();
        private List<Alumno> listaTemporal = new List<Alumno>();

        public FormCrear()
        {
            
            InitializeComponent();
            cmbFormato.SelectedIndex = 1; // Selecciona txt por defecto
        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (!Regex.IsMatch(txtLegajo.Text, @"^\d+$")) 
            {
                MessageBox.Show("Legajo debe ser numérico.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text)) 
            {
                MessageBox.Show("Apellido requerido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) 
            {
                MessageBox.Show("Nombre requerido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }
            if (!Regex.IsMatch(txtDoc.Text, @"^\d+$")) 
            {
                MessageBox.Show("Documento debe ser numérico.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) 
            {
                MessageBox.Show("Email inválido. \nEjemplo Email: hola@gmail.com", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }
            if (!Regex.IsMatch(txtTel.Text, @"^\d+$")) 
            {
                MessageBox.Show("Teléfono debe ser numérico.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }

            // crear objeto y agregar a la lista temporal
            Alumno alu = new Alumno(txtLegajo.Text, txtApellido.Text, txtNombre.Text, txtDoc.Text, txtEmail.Text, txtTel.Text);
            listaTemporal.Add(alu);

            // vista en la lista
            lstAlumnosCargados.Items.Add($"{alu.Legajo} - {alu.Apellido}, {alu.Nombre}");

            // limpiar campos para el siguiente alumno
            LimpiarCamposAlumno();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (listaTemporal.Count == 0) 
            { 
                MessageBox.Show("La lista está vacía. Agregue alumnos primero.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }
            if (string.IsNullOrWhiteSpace(txtNombreArchivo.Text)) 
            {
                MessageBox.Show("Ingrese un nombre para el archivo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }

            try
            {
                string nombre = txtNombreArchivo.Text;
                string ext = "." + cmbFormato.SelectedItem!.ToString()!.ToLower();
                string ruta = Path.Combine(Environment.CurrentDirectory, nombre + ext);

                // Llamamos al gestor para que guarde en disco
                gestor.GuardarArchivo(ruta, ext, listaTemporal);

                MessageBox.Show($"Archivo guardado con éxito en:\n{ruta}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cerramos la ventana cuando terminamos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
    }
}
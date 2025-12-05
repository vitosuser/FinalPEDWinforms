using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TramontiniSciacaluga_GestorAlumnos.Models;

namespace TramontiniSciacaluga_GestorAlumnos
{
    public partial class FormModificar : Form
    {
        private GestorArchivos gestor = new GestorArchivos();
        private List<Alumno> listaMemoria = new List<Alumno>();
        private string rutaArchivoActual = "";
        private string extensionActual = "";

        public FormModificar()
        {
            InitializeComponent();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            string nombre = txtArchivo.Text;

            if (!gestor.ValidarExistencia(nombre))
            {
                MessageBox.Show("Archivo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                rutaArchivoActual = Path.IsPathRooted(nombre) ? nombre : Path.Combine(Environment.CurrentDirectory, nombre);
                extensionActual = Path.GetExtension(nombre).ToLower();

                listaMemoria = gestor.LeerAlumnosDesdeArchivo(extensionActual, rutaArchivoActual);

                ActualizarListaVisual();

                // Habilitamos controles
                grpEdicion.Enabled = true;
                btnGuardarTodo.Enabled = true;
                MessageBox.Show($"Se cargaron {listaMemoria.Count} alumnos", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LstAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAlumnos.SelectedIndex != -1)
            {
                // Cargamos los datos del alumno seleccionado en los textbox
                Alumno alu = listaMemoria[lstAlumnos.SelectedIndex];
                txtLegajo.Text = alu.Legajo;
                txtApellido.Text = alu.Apellido;
                txtNombre.Text = alu.Nombre;
                txtDoc.Text = alu.Documento;
                txtEmail.Text = alu.Email;
                txtTel.Text = alu.Telefono;
            }
        }


        private void BtnAgregarNuevo_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;

            }

            // Validar legajo único
            if (listaMemoria.Any(a => a.Legajo == txtLegajo.Text))
            {
                MessageBox.Show("Ya existe un alumno con ese legajo", "Error");
                return;
            }

            Alumno nuevo = new Alumno(txtLegajo.Text, txtApellido.Text, txtNombre.Text, txtDoc.Text, txtEmail.Text, txtTel.Text);
            listaMemoria.Add(nuevo);

            ActualizarListaVisual();
            LimpiarCampos();

            MessageBox.Show("Alumno agregado a la lista temporal");
        }

        private void BtnAplicarCambios_Click(object sender, EventArgs e)
        {
            int index = lstAlumnos.SelectedIndex;

            if (index == -1) 
            { 
                MessageBox.Show("Seleccione un alumno de la lista para editar"); 
                return; 
            }

            if (!ValidarCampos())
            {
                return;

            }

            // actualizamos el objeto en memoria
            Alumno alu = listaMemoria[index];

            alu.Legajo = txtLegajo.Text;
            alu.Apellido = txtApellido.Text;
            alu.Nombre = txtNombre.Text;
            alu.Documento = txtDoc.Text;
            alu.Email = txtEmail.Text;
            alu.Telefono = txtTel.Text;

            ActualizarListaVisual();
            // Mantenemos la selección
            lstAlumnos.SelectedIndex = index;
            MessageBox.Show("Cambios aplicados en memoria.");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int index = lstAlumnos.SelectedIndex;

            if (index == -1) 
            { 
                MessageBox.Show("Seleccione un alumno para eliminar."); 
                return;

            }

            var confirmar = MessageBox.Show("¿Seguro desea eliminar este alumno?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (confirmar == DialogResult.Yes)
            {
                //eliminamos por indice
                listaMemoria.RemoveAt(index);
                ActualizarListaVisual();
                LimpiarCampos();
            }
        }

        private void BtnGuardarTodo_Click(object sender, EventArgs e)
        {
            try
            {
                // crea un Backup
                gestor.CrearBackup(rutaArchivoActual);

                // sobrescribe Original
                gestor.GuardarArchivo(rutaArchivoActual, extensionActual, listaMemoria);

                MessageBox.Show($"Cambios guardados correctamente.\nSe creó un backup en: {rutaArchivoActual}.bak", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }


        private void ActualizarListaVisual()
        {
            lstAlumnos.Items.Clear();

            foreach (var alu in listaMemoria)
            {
                lstAlumnos.Items.Add($"{alu.Legajo} - {alu.Apellido}, {alu.Nombre}");
            }

        }

        private void LimpiarCampos()
        {
            txtLegajo.Clear(); txtApellido.Clear(); txtNombre.Clear();
            txtDoc.Clear(); txtEmail.Clear(); txtTel.Clear();
        }

        private bool ValidarCampos()
        {
            if (!Regex.IsMatch(txtLegajo.Text, @"^\d+$")) 
            { 
                MessageBox.Show("Legajo numérico requerido."); 
                return false; 
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text)) 
            { 
                MessageBox.Show("Apellido requerido."); 
                return false; 
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text)) 
            { 
                MessageBox.Show("Nombre requerido."); 
                return false; 
            }

            if (!Regex.IsMatch(txtDoc.Text, @"^\d+$")) 
            { 
                MessageBox.Show("Documento numérico requerido."); 
                return false; 
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) 
            { 
                MessageBox.Show("Email inválido."); 
                return false; 
            }

            if (!Regex.IsMatch(txtTel.Text, @"^\d+$")) 
            {
                MessageBox.Show("Teléfono numérico requerido."); 
                return false; 
            }

            return true;
        }
    }
}
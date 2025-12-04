using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
// Referencia clave: Conecta con tu clase Alumno
using TramontiniSciacaluga_GestorAlumnos.Models;

namespace TramontiniSciacaluga_GestorAlumnos
{
    public partial class FormLeer : Form
    {
        // Instancia del gestor (al estar en el mismo namespace base, no requiere using extra)
        private GestorArchivos gestor = new GestorArchivos();

        // Controles de la pantalla
        private TextBox txtNombreArchivo;
        private DataGridView dgvAlumnos;
        private Label lblTotal;

        public FormLeer()
        {
            InitializeComponent(); // Llama al código del Designer
            ConfigurarFormulario(); // Carga nuestros controles extra y diseño
        }

        private void ConfigurarFormulario()
        {
            // Configuración visual de la ventana
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Leer Archivo de Alumnos";

            // 1. BARRA DE BÚSQUEDA (Panel superior)
            Label lblNombre = new Label { Text = "Nombre del archivo (con extensión):", Location = new Point(20, 25), AutoSize = true };
            txtNombreArchivo = new TextBox { Location = new Point(230, 22), Width = 300, Text = "ejemplo.json" };

            Button btnBuscar = new Button { Text = "🔍 Buscar y Leer", Location = new Point(540, 20), Width = 120, BackColor = Color.LightBlue };
            btnBuscar.Click += BtnBuscar_Click;

            // 2. TABLA DE DATOS (Centro)
            dgvAlumnos = new DataGridView();
            dgvAlumnos.Location = new Point(20, 70);
            dgvAlumnos.Size = new Size(740, 430);
            dgvAlumnos.ReadOnly = true; // El usuario no puede editar directamente la celda
            dgvAlumnos.AllowUserToAddRows = false; // Quitar fila vacía del final
            dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleccionar toda la fila
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajustar ancho
            // Anclas para que si agrandan la ventana, la tabla crezca
            dgvAlumnos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // 3. PIE DE PÁGINA (Abajo)
            lblTotal = new Label { Text = "Total de alumnos: 0", Location = new Point(20, 520), AutoSize = true, Font = new Font(this.Font, FontStyle.Bold) };
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            // Agregamos todos los controles al formulario
            this.Controls.Add(lblNombre);
            this.Controls.Add(txtNombreArchivo);
            this.Controls.Add(btnBuscar);
            this.Controls.Add(dgvAlumnos);
            this.Controls.Add(lblTotal);
        }

        // --- LÓGICA DEL BOTÓN BUSCAR ---
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreArchivo.Text;

            // Validación básica visual
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor, ingrese un nombre de archivo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validación de existencia usando el Gestor
            if (!gestor.ValidarExistencia(nombre))
            {
                MessageBox.Show($"El archivo '{nombre}' no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Preparamos ruta y extensión
                string ruta = Path.IsPathRooted(nombre) ? nombre : Path.Combine(Environment.CurrentDirectory, nombre);
                string extension = Path.GetExtension(nombre).ToLower();

                // Llamamos al método de lectura del Gestor
                List<Alumno> lista = gestor.LeerAlumnosDesdeArchivo(extension, ruta);

                // Cargamos la grilla visual
                CargarGrilla(lista);

                MessageBox.Show($"Se leyeron {lista.Count} registros correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo: {ex.Message}", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGrilla(List<Alumno> lista)
        {
            // DataGridView es inteligente: al pasarle la lista, crea las columnas automáticamente
            dgvAlumnos.DataSource = null; // Limpiamos datos anteriores
            dgvAlumnos.DataSource = lista;

            // Actualizamos el contador visual
            lblTotal.Text = $"Total de alumnos: {lista.Count}";
        }
    }
}
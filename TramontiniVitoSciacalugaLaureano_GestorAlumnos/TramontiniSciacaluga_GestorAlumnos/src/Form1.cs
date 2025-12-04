using System;
using System.Drawing; // Necesario para diseño
using System.Windows.Forms;

namespace TramontiniSciacaluga_GestorAlumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Configuración básica de la ventana principal
            this.Text = "Gestor de Alumnos - Trabajo Final";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            // IMPORTANTE: Esto permite que las otras ventanas se abran "adentro" de esta
            this.IsMdiContainer = false;

            // Construimos el menú visualmente
            InicializarMenu();
        }

        private void InicializarMenu()
        {
            MenuStrip menuStrip = new MenuStrip();

            // 1. MENÚ ARCHIVO
            ToolStripMenuItem menuArchivo = new ToolStripMenuItem("Archivo");

            // Conectamos el botón con la función AbrirCrear
            ToolStripMenuItem itemCrear = new ToolStripMenuItem("Crear Nuevo Archivo", null, (s, e) => AbrirCrear());
            itemCrear.ShortcutKeys = Keys.Control | Keys.N; // Atajo Ctrl+N

            ToolStripMenuItem itemLeer = new ToolStripMenuItem("Leer Archivo", null, (s, e) => AbrirLeer());
            itemLeer.ShortcutKeys = Keys.Control | Keys.O; // Atajo Ctrl+O

            ToolStripMenuItem itemModificar = new ToolStripMenuItem("Modificar Archivo", null, (s, e) => AbrirModificar());

            ToolStripMenuItem itemEliminar = new ToolStripMenuItem("Eliminar Archivo", null, (s, e) => AccionEliminar());

            ToolStripMenuItem itemSalir = new ToolStripMenuItem("Salir", null, (s, e) => Application.Exit());

            // Agregamos los items al menú desplegable
            menuArchivo.DropDownItems.Add(itemCrear);
            menuArchivo.DropDownItems.Add(itemLeer);
            menuArchivo.DropDownItems.Add(new ToolStripSeparator());
            menuArchivo.DropDownItems.Add(itemModificar);
            menuArchivo.DropDownItems.Add(itemEliminar);
            menuArchivo.DropDownItems.Add(new ToolStripSeparator());
            menuArchivo.DropDownItems.Add(itemSalir);

            // 2. MENÚ HERRAMIENTAS
            ToolStripMenuItem menuHerramientas = new ToolStripMenuItem("Herramientas");
            ToolStripMenuItem itemConvertir = new ToolStripMenuItem("Convertir Formatos", null, (s, e) => AccionConvertir());
            menuHerramientas.DropDownItems.Add(itemConvertir);

            // 3. MENÚ REPORTES
            ToolStripMenuItem menuReportes = new ToolStripMenuItem("Reportes");
            ToolStripMenuItem itemReporte = new ToolStripMenuItem("Generar Reporte", null, (s, e) => AccionReporte());
            menuReportes.DropDownItems.Add(itemReporte);

            // Agregamos los menús a la barra superior
            menuStrip.Items.Add(menuArchivo);
            menuStrip.Items.Add(menuHerramientas);
            menuStrip.Items.Add(menuReportes);

            // Asignamos el menú al formulario
            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
        }

        // ==========================================
        //        ACCIONES DE LOS BOTONES
        // ==========================================

        private void AbrirCrear()
        {
            // PASO 3: AQUÍ ESTÁ LA CONEXIÓN
            // Creamos una nueva instancia del formulario de carga
            FormCrear form = new FormCrear();

            // Lo mostramos
            form.Show();
        }

        private void AbrirLeer()
        {
            FormLeer form = new FormLeer();


            form.Show();
        }

        private void AbrirModificar()
        {
            MessageBox.Show("Aquí se abrirá la ventana de MODIFICAR.\n(Necesitamos crear el FormModificar.cs)", "En construcción");
        }

        private void AccionEliminar()
        {
            string archivo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del archivo a eliminar:", "Eliminar Archivo", "ejemplo.txt");
            if (!string.IsNullOrWhiteSpace(archivo))
            {
                MessageBox.Show($"Funcionalidad pendiente: Eliminar {archivo}");
            }
        }

        private void AccionConvertir()
        {
            MessageBox.Show("Funcionalidad de conversión pendiente.");
        }

        private void AccionReporte()
        {
            MessageBox.Show("Funcionalidad de reporte pendiente.");
        }
    }
}
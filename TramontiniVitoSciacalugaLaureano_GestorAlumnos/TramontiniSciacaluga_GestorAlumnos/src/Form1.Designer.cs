namespace TramontiniSciacaluga_GestorAlumnos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            crearNuevoArchivoToolStripMenuItem = new ToolStripMenuItem();
            leerArchivoToolStripMenuItem = new ToolStripMenuItem();
            modificarArchivoToolStripMenuItem = new ToolStripMenuItem();
            eliminarArchivoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            herramientasToolStripMenuItem = new ToolStripMenuItem();
            convertirFormatosToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            generarReporteToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, herramientasToolStripMenuItem, reportesToolStripMenuItem, acercaDeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearNuevoArchivoToolStripMenuItem, leerArchivoToolStripMenuItem, modificarArchivoToolStripMenuItem, eliminarArchivoToolStripMenuItem, toolStripSeparator2, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // crearNuevoArchivoToolStripMenuItem
            // 
            crearNuevoArchivoToolStripMenuItem.AutoToolTip = true;
            crearNuevoArchivoToolStripMenuItem.Name = "crearNuevoArchivoToolStripMenuItem";
            crearNuevoArchivoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            crearNuevoArchivoToolStripMenuItem.Size = new Size(227, 22);
            crearNuevoArchivoToolStripMenuItem.Text = "Crear Nuevo Archivo";
            crearNuevoArchivoToolStripMenuItem.ToolTipText = "Permite crear un nuevo archivo en el formato seleccionado y cargar registros de alumnos.";
            crearNuevoArchivoToolStripMenuItem.Click += crearNuevoArchivoToolStripMenuItem_Click;
            // 
            // leerArchivoToolStripMenuItem
            // 
            leerArchivoToolStripMenuItem.AutoToolTip = true;
            leerArchivoToolStripMenuItem.Name = "leerArchivoToolStripMenuItem";
            leerArchivoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            leerArchivoToolStripMenuItem.Size = new Size(227, 22);
            leerArchivoToolStripMenuItem.Text = "Leer Archivo";
            leerArchivoToolStripMenuItem.ToolTipText = "Permite visualizar el contenido de un archivo existente de forma formateada.";
            leerArchivoToolStripMenuItem.Click += leerArchivoToolStripMenuItem_Click;
            // 
            // modificarArchivoToolStripMenuItem
            // 
            modificarArchivoToolStripMenuItem.AutoToolTip = true;
            modificarArchivoToolStripMenuItem.Name = "modificarArchivoToolStripMenuItem";
            modificarArchivoToolStripMenuItem.Size = new Size(227, 22);
            modificarArchivoToolStripMenuItem.Text = "Modificar Archivo";
            modificarArchivoToolStripMenuItem.ToolTipText = "Permite editar registros existentes, agregar nuevos o eliminar alumnos del archivo.";
            modificarArchivoToolStripMenuItem.Click += modificarArchivoToolStripMenuItem_Click;
            // 
            // eliminarArchivoToolStripMenuItem
            // 
            eliminarArchivoToolStripMenuItem.AutoToolTip = true;
            eliminarArchivoToolStripMenuItem.Name = "eliminarArchivoToolStripMenuItem";
            eliminarArchivoToolStripMenuItem.Size = new Size(227, 22);
            eliminarArchivoToolStripMenuItem.Text = "Eliminar Archivo";
            eliminarArchivoToolStripMenuItem.ToolTipText = "Permite eliminar físicamente un archivo del sistema.";
            eliminarArchivoToolStripMenuItem.Click += eliminarArchivoToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(224, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(227, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // herramientasToolStripMenuItem
            // 
            herramientasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { convertirFormatosToolStripMenuItem });
            herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            herramientasToolStripMenuItem.Size = new Size(90, 20);
            herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // convertirFormatosToolStripMenuItem
            // 
            convertirFormatosToolStripMenuItem.AutoToolTip = true;
            convertirFormatosToolStripMenuItem.Name = "convertirFormatosToolStripMenuItem";
            convertirFormatosToolStripMenuItem.Size = new Size(206, 22);
            convertirFormatosToolStripMenuItem.Text = "Convertir Entre Formatos";
            convertirFormatosToolStripMenuItem.ToolTipText = "Permite convertir un archivo de alumnos de un formato a otro manteniendo la integridad de los datos.";
            convertirFormatosToolStripMenuItem.Click += convertirFormatosToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generarReporteToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(65, 20);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // generarReporteToolStripMenuItem
            // 
            generarReporteToolStripMenuItem.AutoToolTip = true;
            generarReporteToolStripMenuItem.Name = "generarReporteToolStripMenuItem";
            generarReporteToolStripMenuItem.Size = new Size(180, 22);
            generarReporteToolStripMenuItem.Text = "Generar Reporte";
            generarReporteToolStripMenuItem.ToolTipText = "Genera un reporte agrupado por un campo específico (Apellido) con subtotales y formato profesional.";
            generarReporteToolStripMenuItem.Click += generarReporteToolStripMenuItem_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.RightToLeft = RightToLeft.No;
            acercaDeToolStripMenuItem.Size = new Size(72, 20);
            acercaDeToolStripMenuItem.Text = "Acerca De";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor de Alumnos - Trabajo Final";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNuevoArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leerArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertirFormatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarReporteToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}
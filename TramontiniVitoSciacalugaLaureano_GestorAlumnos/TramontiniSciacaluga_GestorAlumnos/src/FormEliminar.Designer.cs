namespace TramontiniSciacaluga_GestorAlumnos.src
{
    partial class FormEliminar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblNombreArchivo = new Label();
            txtNombreArchivo = new TextBox();
            btnBuscar = new Button();
            lblTituloInfo = new Label();
            lblInfoNombre = new Label();
            lblInfoTamaño = new Label();
            lblInfoCreacion = new Label();
            lblInfoModificacion = new Label();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(184, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "1. Archivo a Eliminar (Búsqueda)";
            // 
            // lblNombreArchivo
            // 
            lblNombreArchivo.AutoSize = true;
            lblNombreArchivo.Location = new Point(20, 50);
            lblNombreArchivo.Name = "lblNombreArchivo";
            lblNombreArchivo.Size = new Size(108, 15);
            lblNombreArchivo.TabIndex = 1;
            lblNombreArchivo.Text = "Nombre completo:";
            // 
            // txtNombreArchivo
            // 
            txtNombreArchivo.Location = new Point(130, 47);
            txtNombreArchivo.Name = "txtNombreArchivo";
            txtNombreArchivo.PlaceholderText = "Ej: alumnos_ejemplo.csv";
            txtNombreArchivo.Size = new Size(300, 23);
            txtNombreArchivo.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.LightBlue;
            btnBuscar.Location = new Point(440, 46);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(130, 25);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar y Mostrar Info";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += BtnBuscar_Click;
            // 
            // lblTituloInfo
            // 
            lblTituloInfo.AutoSize = true;
            lblTituloInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTituloInfo.Location = new Point(20, 110);
            lblTituloInfo.Name = "lblTituloInfo";
            lblTituloInfo.Size = new Size(131, 15);
            lblTituloInfo.TabIndex = 4;
            lblTituloInfo.Text = "2. Información Detalle";
            // 
            // lblInfoNombre
            // 
            lblInfoNombre.AutoSize = true;
            lblInfoNombre.Location = new Point(30, 140);
            lblInfoNombre.Name = "lblInfoNombre";
            lblInfoNombre.Size = new Size(116, 15);
            lblInfoNombre.TabIndex = 5;
            lblInfoNombre.Text = "Nombre completo: -";
            // 
            // lblInfoTamaño
            // 
            lblInfoTamaño.AutoSize = true;
            lblInfoTamaño.Location = new Point(30, 165);
            lblInfoTamaño.Name = "lblInfoTamaño";
            lblInfoTamaño.Size = new Size(85, 15);
            lblInfoTamaño.TabIndex = 6;
            lblInfoTamaño.Text = "Tamaño (KB): -";
            // 
            // lblInfoCreacion
            // 
            lblInfoCreacion.AutoSize = true;
            lblInfoCreacion.Location = new Point(30, 190);
            lblInfoCreacion.Name = "lblInfoCreacion";
            lblInfoCreacion.Size = new Size(113, 15);
            lblInfoCreacion.TabIndex = 7;
            lblInfoCreacion.Text = "Fecha de creación: -";
            // 
            // lblInfoModificacion
            // 
            lblInfoModificacion.AutoSize = true;
            lblInfoModificacion.Location = new Point(30, 215);
            lblInfoModificacion.Name = "lblInfoModificacion";
            lblInfoModificacion.Size = new Size(162, 15);
            lblInfoModificacion.TabIndex = 8;
            lblInfoModificacion.Text = "Última modificación (Mod): -";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.LightCoral;
            btnEliminar.Enabled = false;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminar.Location = new Point(20, 270);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(550, 40);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "🗑️ CONFIRMAR ELIMINACIÓN";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += BtnEliminar_Click;
            // 
            // FormEliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(590, 350);
            Controls.Add(btnEliminar);
            Controls.Add(lblInfoModificacion);
            Controls.Add(lblInfoCreacion);
            Controls.Add(lblInfoTamaño);
            Controls.Add(lblInfoNombre);
            Controls.Add(lblTituloInfo);
            Controls.Add(btnBuscar);
            Controls.Add(txtNombreArchivo);
            Controls.Add(lblNombreArchivo);
            Controls.Add(lblTitulo);
            Name = "FormEliminar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eliminar Archivo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombreArchivo;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTituloInfo;
        private System.Windows.Forms.Label lblInfoNombre;
        private System.Windows.Forms.Label lblInfoTamaño;
        private System.Windows.Forms.Label lblInfoCreacion;
        private System.Windows.Forms.Label lblInfoModificacion;
        private System.Windows.Forms.Button btnEliminar;
    }
}
    

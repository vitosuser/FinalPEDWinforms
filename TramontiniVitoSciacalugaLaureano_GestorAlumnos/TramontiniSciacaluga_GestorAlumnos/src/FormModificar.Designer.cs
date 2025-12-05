namespace TramontiniSciacaluga_GestorAlumnos
{
    partial class FormModificar
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lstAlumnos = new System.Windows.Forms.ListBox();
            this.grpEdicion = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAplicarCambios = new System.Windows.Forms.Button();
            this.btnAgregarNuevo = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.lblDoc = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.btnGuardarTodo = new System.Windows.Forms.Button();
            this.grpEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(217, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Modificar Archivo Existente";
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(20, 50);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(126, 15);
            this.lblArchivo.TabIndex = 1;
            this.lblArchivo.Text = "Nombre (con ext):";
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(150, 47);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(430, 23);
            this.txtArchivo.TabIndex = 2;
            this.txtArchivo.Text = "ejemplo.json";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.LightBlue;
            this.btnCargar.Location = new System.Drawing.Point(590, 45);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(180, 26);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "📥 Cargar en Memoria";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // lstAlumnos
            // 
            this.lstAlumnos.FormattingEnabled = true;
            this.lstAlumnos.ItemHeight = 15;
            this.lstAlumnos.Location = new System.Drawing.Point(20, 90);
            this.lstAlumnos.Name = "lstAlumnos";
            this.lstAlumnos.Size = new System.Drawing.Size(300, 394);
            this.lstAlumnos.TabIndex = 4;
            this.lstAlumnos.SelectedIndexChanged += new System.EventHandler(this.LstAlumnos_SelectedIndexChanged);
            // 
            // grpEdicion
            // 
            this.grpEdicion.Controls.Add(this.btnEliminar);
            this.grpEdicion.Controls.Add(this.btnAplicarCambios);
            this.grpEdicion.Controls.Add(this.btnAgregarNuevo);
            this.grpEdicion.Controls.Add(this.txtTel);
            this.grpEdicion.Controls.Add(this.lblTel);
            this.grpEdicion.Controls.Add(this.txtEmail);
            this.grpEdicion.Controls.Add(this.lblEmail);
            this.grpEdicion.Controls.Add(this.txtDoc);
            this.grpEdicion.Controls.Add(this.lblDoc);
            this.grpEdicion.Controls.Add(this.txtNombre);
            this.grpEdicion.Controls.Add(this.lblNombre);
            this.grpEdicion.Controls.Add(this.txtApellido);
            this.grpEdicion.Controls.Add(this.lblApellido);
            this.grpEdicion.Controls.Add(this.txtLegajo);
            this.grpEdicion.Controls.Add(this.lblLegajo);
            this.grpEdicion.Enabled = false;
            this.grpEdicion.Location = new System.Drawing.Point(340, 85);
            this.grpEdicion.Name = "grpEdicion";
            this.grpEdicion.Size = new System.Drawing.Size(430, 399);
            this.grpEdicion.TabIndex = 5;
            this.grpEdicion.TabStop = false;
            this.grpEdicion.Text = "Detalles del Alumno";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(290, 340);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 35);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "🗑 Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnAplicarCambios
            // 
            this.btnAplicarCambios.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnAplicarCambios.Location = new System.Drawing.Point(150, 340);
            this.btnAplicarCambios.Name = "btnAplicarCambios";
            this.btnAplicarCambios.Size = new System.Drawing.Size(130, 35);
            this.btnAplicarCambios.TabIndex = 13;
            this.btnAplicarCambios.Text = "✏ Actualizar";
            this.btnAplicarCambios.UseVisualStyleBackColor = false;
            this.btnAplicarCambios.Click += new System.EventHandler(this.BtnAplicarCambios_Click);
            // 
            // btnAgregarNuevo
            // 
            this.btnAgregarNuevo.BackColor = System.Drawing.Color.LightGreen;
            this.btnAgregarNuevo.Location = new System.Drawing.Point(15, 340);
            this.btnAgregarNuevo.Name = "btnAgregarNuevo";
            this.btnAgregarNuevo.Size = new System.Drawing.Size(120, 35);
            this.btnAgregarNuevo.TabIndex = 12;
            this.btnAgregarNuevo.Text = "➕ Agregar Nuevo";
            this.btnAgregarNuevo.UseVisualStyleBackColor = false;
            this.btnAgregarNuevo.Click += new System.EventHandler(this.BtnAgregarNuevo_Click);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(100, 250);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(300, 23);
            this.txtTel.TabIndex = 11;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(20, 253);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(55, 15);
            this.lblTel.TabIndex = 10;
            this.lblTel.Text = "Teléfono:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(100, 210);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 23);
            this.txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 213);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(100, 170);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(300, 23);
            this.txtDoc.TabIndex = 7;
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Location = new System.Drawing.Point(20, 173);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(73, 15);
            this.lblDoc.TabIndex = 6;
            this.lblDoc.Text = "Documento:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 130);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 23);
            this.txtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 133);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(100, 90);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(300, 23);
            this.txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(20, 93);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 15);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(100, 50);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(300, 23);
            this.txtLegajo.TabIndex = 1;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(20, 53);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(45, 15);
            this.lblLegajo.TabIndex = 0;
            this.lblLegajo.Text = "Legajo:";
            // 
            // btnGuardarTodo
            // 
            this.btnGuardarTodo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardarTodo.Enabled = false;
            this.btnGuardarTodo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarTodo.ForeColor = System.Drawing.Color.White;
            this.btnGuardarTodo.Location = new System.Drawing.Point(20, 500);
            this.btnGuardarTodo.Name = "btnGuardarTodo";
            this.btnGuardarTodo.Size = new System.Drawing.Size(750, 45);
            this.btnGuardarTodo.TabIndex = 6;
            this.btnGuardarTodo.Text = "💾 GUARDAR CAMBIOS Y CREAR BACKUP";
            this.btnGuardarTodo.UseVisualStyleBackColor = false;
            this.btnGuardarTodo.Click += new System.EventHandler(this.BtnGuardarTodo_Click);
            // 
            // FormModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.btnGuardarTodo);
            this.Controls.Add(this.grpEdicion);
            this.Controls.Add(this.lstAlumnos);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.lblArchivo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Archivo";
            this.grpEdicion.ResumeLayout(false);
            this.grpEdicion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ListBox lstAlumnos;
        private System.Windows.Forms.GroupBox grpEdicion;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAplicarCambios;
        private System.Windows.Forms.Button btnAgregarNuevo;
        private System.Windows.Forms.Button btnGuardarTodo;
    }
}
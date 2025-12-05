namespace TramontiniSciacaluga_GestorAlumnos.src
{
    partial class FormReportes
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
            btnCargarGenerar = new Button();
            lblInfoCarga = new Label();
            lblTitulo2 = new Label();
            txtReporte = new RichTextBox();
            btnGuardarTxt = new Button();
            lblNombreGuardar = new Label();
            txtNombreGuardar = new TextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(108, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "1. Archivo Fuente ";
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
            txtNombreArchivo.PlaceholderText = "Ej: datos_alumnos.csv";
            txtNombreArchivo.Size = new Size(300, 23);
            txtNombreArchivo.TabIndex = 2;
            // 
            // btnCargarGenerar
            // 
            btnCargarGenerar.BackColor = Color.LightBlue;
            btnCargarGenerar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCargarGenerar.Location = new Point(440, 46);
            btnCargarGenerar.Name = "btnCargarGenerar";
            btnCargarGenerar.Size = new Size(170, 25);
            btnCargarGenerar.TabIndex = 3;
            btnCargarGenerar.Text = "Cargar Datos y Generar Reporte";
            btnCargarGenerar.UseVisualStyleBackColor = false;
            btnCargarGenerar.Click += BtnCargarGenerar_Click;
            // 
            // lblInfoCarga
            // 
            lblInfoCarga.AutoSize = true;
            lblInfoCarga.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblInfoCarga.Location = new Point(20, 80);
            lblInfoCarga.Name = "lblInfoCarga";
            lblInfoCarga.Size = new Size(135, 15);
            lblInfoCarga.TabIndex = 4;
            lblInfoCarga.Text = "No hay archivo cargado.";
            // 
            // lblTitulo2
            // 
            lblTitulo2.AutoSize = true;
            lblTitulo2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitulo2.Location = new Point(20, 120);
            lblTitulo2.Name = "lblTitulo2";
            lblTitulo2.Size = new Size(88, 15);
            lblTitulo2.TabIndex = 5;
            lblTitulo2.Text = "2. Vista Previa ";
            // 
            // txtReporte
            // 
            txtReporte.Font = new Font("Consolas", 9F);
            txtReporte.Location = new Point(20, 145);
            txtReporte.Name = "txtReporte";
            txtReporte.ReadOnly = true;
            txtReporte.Size = new Size(590, 250);
            txtReporte.TabIndex = 6;
            txtReporte.Text = "Aquí se mostrará el reporte agrupado por apellido, subtotales y resumen general.";
            // 
            // btnGuardarTxt
            // 
            btnGuardarTxt.BackColor = Color.LightGreen;
            btnGuardarTxt.Enabled = false;
            btnGuardarTxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardarTxt.Location = new Point(340, 415);
            btnGuardarTxt.Name = "btnGuardarTxt";
            btnGuardarTxt.Size = new Size(270, 30);
            btnGuardarTxt.TabIndex = 7;
            btnGuardarTxt.Text = "Guardar Reporte como .TXT";
            btnGuardarTxt.UseVisualStyleBackColor = false;
            btnGuardarTxt.Click += BtnGuardarTxt_Click;
            // 
            // lblNombreGuardar
            // 
            lblNombreGuardar.AutoSize = true;
            lblNombreGuardar.Location = new Point(20, 422);
            lblNombreGuardar.Name = "lblNombreGuardar";
            lblNombreGuardar.Size = new Size(100, 15);
            lblNombreGuardar.TabIndex = 8;
            lblNombreGuardar.Text = "Nombre (sin .txt):";
            // 
            // txtNombreGuardar
            // 
            txtNombreGuardar.Enabled = false;
            txtNombreGuardar.Location = new Point(130, 419);
            txtNombreGuardar.Name = "txtNombreGuardar";
            txtNombreGuardar.PlaceholderText = "Ej: reporte_alumnos";
            txtNombreGuardar.Size = new Size(190, 23);
            txtNombreGuardar.TabIndex = 9;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(630, 470);
            Controls.Add(txtNombreGuardar);
            Controls.Add(lblNombreGuardar);
            Controls.Add(btnGuardarTxt);
            Controls.Add(txtReporte);
            Controls.Add(lblTitulo2);
            Controls.Add(lblInfoCarga);
            Controls.Add(btnCargarGenerar);
            Controls.Add(txtNombreArchivo);
            Controls.Add(lblNombreArchivo);
            Controls.Add(lblTitulo);
            Name = "FormReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear Reporte con Corte de Control";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombreArchivo;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.Button btnCargarGenerar;
        private System.Windows.Forms.Label lblInfoCarga;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.RichTextBox txtReporte;
        private System.Windows.Forms.Button btnGuardarTxt;
        private System.Windows.Forms.Label lblNombreGuardar;
        private System.Windows.Forms.TextBox txtNombreGuardar;
    }
}

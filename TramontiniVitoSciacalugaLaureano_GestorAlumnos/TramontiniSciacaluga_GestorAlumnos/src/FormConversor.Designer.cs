namespace TramontiniSciacaluga_GestorAlumnos.src
{
    partial class FormConversor
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
            lblNombreOrigen = new Label();
            txtNombreArchivoOrigen = new TextBox();
            btnCargar = new Button();
            lblOrigenInfo = new Label();
            lblTitulo2 = new Label();
            lblFormatoDestino = new Label();
            cmbDestino = new ComboBox();
            lblNombreDestino = new Label();
            txtNombreDestino = new TextBox();
            btnConvertir = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(121, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "1. Archivo de Origen";
            // 
            // lblNombreOrigen
            // 
            lblNombreOrigen.AutoSize = true;
            lblNombreOrigen.Location = new Point(20, 50);
            lblNombreOrigen.Name = "lblNombreOrigen";
            lblNombreOrigen.Size = new Size(108, 15);
            lblNombreOrigen.TabIndex = 1;
            lblNombreOrigen.Text = "Nombre completo:";
            // 
            // txtNombreArchivoOrigen
            // 
            txtNombreArchivoOrigen.Location = new Point(130, 47);
            txtNombreArchivoOrigen.Name = "txtNombreArchivoOrigen";
            txtNombreArchivoOrigen.PlaceholderText = "Ej: alumnos_prueba.csv";
            txtNombreArchivoOrigen.Size = new Size(300, 23);
            txtNombreArchivoOrigen.TabIndex = 2;
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.LightBlue;
            btnCargar.Location = new Point(440, 46);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(130, 25);
            btnCargar.TabIndex = 3;
            btnCargar.Text = "Cargar y Validar";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += BtnCargar_Click;
            // 
            // lblOrigenInfo
            // 
            lblOrigenInfo.AutoSize = true;
            lblOrigenInfo.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblOrigenInfo.Location = new Point(20, 80);
            lblOrigenInfo.Name = "lblOrigenInfo";
            lblOrigenInfo.Size = new Size(135, 15);
            lblOrigenInfo.TabIndex = 4;
            lblOrigenInfo.Text = "No hay archivo cargado.";
            // 
            // lblTitulo2
            // 
            lblTitulo2.AutoSize = true;
            lblTitulo2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitulo2.Location = new Point(20, 140);
            lblTitulo2.Name = "lblTitulo2";
            lblTitulo2.Size = new Size(179, 15);
            lblTitulo2.TabIndex = 5;
            lblTitulo2.Text = "2. Configuración de Conversión";
            // 
            // lblFormatoDestino
            // 
            lblFormatoDestino.AutoSize = true;
            lblFormatoDestino.Location = new Point(20, 175);
            lblFormatoDestino.Name = "lblFormatoDestino";
            lblFormatoDestino.Size = new Size(98, 15);
            lblFormatoDestino.TabIndex = 6;
            lblFormatoDestino.Text = "Formato Destino:";
            // 
            // cmbDestino
            // 
            cmbDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestino.Enabled = false;
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Location = new Point(130, 172);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(100, 23);
            cmbDestino.TabIndex = 7;
            cmbDestino.SelectedIndexChanged += CmbDestino_SelectedIndexChanged;
            // 
            // lblNombreDestino
            // 
            lblNombreDestino.AutoSize = true;
            lblNombreDestino.Location = new Point(260, 175);
            lblNombreDestino.Name = "lblNombreDestino";
            lblNombreDestino.Size = new Size(98, 15);
            lblNombreDestino.TabIndex = 8;
            lblNombreDestino.Text = "Nombre Archivo:";
            // 
            // txtNombreDestino
            // 
            txtNombreDestino.Enabled = false;
            txtNombreDestino.Location = new Point(360, 172);
            txtNombreDestino.Name = "txtNombreDestino";
            txtNombreDestino.PlaceholderText = "Ej: archivo_convertido (sin extensión)";
            txtNombreDestino.Size = new Size(210, 23);
            txtNombreDestino.TabIndex = 9;
            // 
            // btnConvertir
            // 
            btnConvertir.BackColor = Color.LightGreen;
            btnConvertir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConvertir.Location = new Point(20, 250);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(550, 40);
            btnConvertir.TabIndex = 10;
            btnConvertir.Text = "🔁 CONVERTIR Y GUARDAR ARCHIVO";
            btnConvertir.UseVisualStyleBackColor = false;
            btnConvertir.Click += BtnConvertir_Click;
            // 
            // FormConversor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(590, 320);
            Controls.Add(btnConvertir);
            Controls.Add(txtNombreDestino);
            Controls.Add(lblNombreDestino);
            Controls.Add(cmbDestino);
            Controls.Add(lblFormatoDestino);
            Controls.Add(lblTitulo2);
            Controls.Add(lblOrigenInfo);
            Controls.Add(btnCargar);
            Controls.Add(txtNombreArchivoOrigen);
            Controls.Add(lblNombreOrigen);
            Controls.Add(lblTitulo);
            Name = "FormConversor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Convertir Entre Formatos";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombreOrigen;
        private System.Windows.Forms.TextBox txtNombreArchivoOrigen;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblOrigenInfo;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Label lblFormatoDestino;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label lblNombreDestino;
        private System.Windows.Forms.TextBox txtNombreDestino;
        private System.Windows.Forms.Button btnConvertir;
    }
}

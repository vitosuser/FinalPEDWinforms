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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.txtRutaOrigen = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lblOrigenInfo = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.lblFormatoDestino = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.lblNombreDestino = new System.Windows.Forms.Label();
            this.txtNombreDestino = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(167, 15);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "1. Archivo de Origen (Fuente)";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(20, 50);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(51, 15);
            this.lblOrigen.TabIndex = 1;
            this.lblOrigen.Text = "Archivo:";
            // 
            // txtRutaOrigen
            // 
            this.txtRutaOrigen.Enabled = false;
            this.txtRutaOrigen.Location = new System.Drawing.Point(80, 47);
            this.txtRutaOrigen.Name = "txtRutaOrigen";
            this.txtRutaOrigen.ReadOnly = true;
            this.txtRutaOrigen.Size = new System.Drawing.Size(350, 23);
            this.txtRutaOrigen.TabIndex = 2;
            this.txtRutaOrigen.Text = "No hay archivo seleccionado...";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.LightBlue;
            this.btnSeleccionar.Location = new System.Drawing.Point(440, 46);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(130, 25);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar Archivo";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
//            this.btnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // lblOrigenInfo
            // 
            this.lblOrigenInfo.AutoSize = true;
            this.lblOrigenInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblOrigenInfo.Location = new System.Drawing.Point(20, 80);
            this.lblOrigenInfo.Name = "lblOrigenInfo";
            this.lblOrigenInfo.Size = new System.Drawing.Size(121, 15);
            this.lblOrigenInfo.TabIndex = 4;
            this.lblOrigenInfo.Text = "No hay archivo cargado.";
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo2.Location = new System.Drawing.Point(20, 140);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(137, 15);
            this.lblTitulo2.TabIndex = 5;
            this.lblTitulo2.Text = "2. Configuración Final";
            // 
            // lblFormatoDestino
            // 
            this.lblFormatoDestino.AutoSize = true;
            this.lblFormatoDestino.Location = new System.Drawing.Point(20, 175);
            this.lblFormatoDestino.Name = "lblFormatoDestino";
            this.lblFormatoDestino.Size = new System.Drawing.Size(103, 15);
            this.lblFormatoDestino.TabIndex = 6;
            this.lblFormatoDestino.Text = "Formato Destino:";
            // 
            // cmbDestino
            // 
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.Enabled = false;
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(130, 172);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(100, 23);
            this.cmbDestino.TabIndex = 7;
            //this.cmbDestino.SelectedIndexChanged += new System.EventHandler(this.CmbDestino_SelectedIndexChanged);
            // 
            // lblNombreDestino
            // 
            this.lblNombreDestino.AutoSize = true;
            this.lblNombreDestino.Location = new System.Drawing.Point(260, 175);
            this.lblNombreDestino.Name = "lblNombreDestino";
            this.lblNombreDestino.Size = new System.Drawing.Size(95, 15);
            this.lblNombreDestino.TabIndex = 8;
            this.lblNombreDestino.Text = "Nombre Archivo:";
            // 
            // txtNombreDestino
            // 
            this.txtNombreDestino.Enabled = false;
            this.txtNombreDestino.Location = new System.Drawing.Point(360, 172);
            this.txtNombreDestino.Name = "txtNombreDestino";
            this.txtNombreDestino.Size = new System.Drawing.Size(210, 23);
            this.txtNombreDestino.TabIndex = 9;
            this.txtNombreDestino.PlaceholderText = "Ej: nuevos_datos";
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.Color.LightGreen;
            this.btnConvertir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvertir.Location = new System.Drawing.Point(20, 250);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(550, 40);
            this.btnConvertir.TabIndex = 10;
            this.btnConvertir.Text = "🔁 CONVERTIR Y GUARDAR ARCHIVO";
            this.btnConvertir.UseVisualStyleBackColor = false;
            //this.btnConvertir.Click += new System.EventHandler(this.BtnConvertir_Click);
            // 
            // FormConvertir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 320);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtNombreDestino);
            this.Controls.Add(this.lblNombreDestino);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.lblFormatoDestino);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.lblOrigenInfo);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.txtRutaOrigen);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormConvertir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "5. Convertir Entre Formatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.TextBox txtRutaOrigen;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lblOrigenInfo;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Label lblFormatoDestino;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label lblNombreDestino;
        private System.Windows.Forms.TextBox txtNombreDestino;
        private System.Windows.Forms.Button btnConvertir;
    }
}

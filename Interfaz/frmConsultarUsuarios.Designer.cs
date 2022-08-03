
namespace Interfaz
{
    partial class frmConsultarUsuarios
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
            this.grpConsultar = new System.Windows.Forms.GroupBox();
            this.btnRuta = new System.Windows.Forms.Button();
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtUsuarioBuscar = new System.Windows.Forms.TextBox();
            this.lblUsuarioBuscar = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grpConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // grpConsultar
            // 
            this.grpConsultar.Controls.Add(this.btnRuta);
            this.grpConsultar.Controls.Add(this.txtRutaArchivo);
            this.grpConsultar.Controls.Add(this.lblRuta);
            this.grpConsultar.Controls.Add(this.btnBuscar);
            this.grpConsultar.Controls.Add(this.txtUsuarioBuscar);
            this.grpConsultar.Controls.Add(this.lblUsuarioBuscar);
            this.grpConsultar.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpConsultar.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConsultar.Location = new System.Drawing.Point(0, 0);
            this.grpConsultar.Name = "grpConsultar";
            this.grpConsultar.Size = new System.Drawing.Size(800, 182);
            this.grpConsultar.TabIndex = 3;
            this.grpConsultar.TabStop = false;
            // 
            // btnRuta
            // 
            this.btnRuta.Location = new System.Drawing.Point(495, 21);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(63, 37);
            this.btnRuta.TabIndex = 18;
            this.btnRuta.Text = "...";
            this.btnRuta.UseVisualStyleBackColor = true;
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Location = new System.Drawing.Point(183, 21);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.ReadOnly = true;
            this.txtRutaArchivo.Size = new System.Drawing.Size(291, 30);
            this.txtRutaArchivo.TabIndex = 16;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(12, 26);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(167, 22);
            this.lblRuta.TabIndex = 17;
            this.lblRuta.Text = "Ruta del Archivo:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(355, 123);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(170, 43);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtUsuarioBuscar
            // 
            this.txtUsuarioBuscar.Location = new System.Drawing.Point(300, 73);
            this.txtUsuarioBuscar.Name = "txtUsuarioBuscar";
            this.txtUsuarioBuscar.Size = new System.Drawing.Size(250, 30);
            this.txtUsuarioBuscar.TabIndex = 1;
            // 
            // lblUsuarioBuscar
            // 
            this.lblUsuarioBuscar.AutoSize = true;
            this.lblUsuarioBuscar.Location = new System.Drawing.Point(6, 73);
            this.lblUsuarioBuscar.Name = "lblUsuarioBuscar";
            this.lblUsuarioBuscar.Size = new System.Drawing.Size(277, 24);
            this.lblUsuarioBuscar.TabIndex = 0;
            this.lblUsuarioBuscar.Text = "Ingrese el Usuario a Buscar:";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 182);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(800, 268);
            this.dgvUsuarios.TabIndex = 4;
            // 
            // frmConsultarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.grpConsultar);
            this.Name = "frmConsultarUsuarios";
            this.Text = "Consultar Usuarios";
            this.grpConsultar.ResumeLayout(false);
            this.grpConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConsultar;
        private System.Windows.Forms.Button btnRuta;
        public System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtUsuarioBuscar;
        private System.Windows.Forms.Label lblUsuarioBuscar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
    }
}
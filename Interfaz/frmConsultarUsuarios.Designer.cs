
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
            this.grpConsultar.Controls.Add(this.btnBuscar);
            this.grpConsultar.Controls.Add(this.txtUsuarioBuscar);
            this.grpConsultar.Controls.Add(this.lblUsuarioBuscar);
            this.grpConsultar.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpConsultar.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConsultar.Location = new System.Drawing.Point(0, 0);
            this.grpConsultar.Name = "grpConsultar";
            this.grpConsultar.Size = new System.Drawing.Size(800, 160);
            this.grpConsultar.TabIndex = 3;
            this.grpConsultar.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(374, 86);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(170, 43);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtUsuarioBuscar
            // 
            this.txtUsuarioBuscar.Location = new System.Drawing.Point(319, 36);
            this.txtUsuarioBuscar.Name = "txtUsuarioBuscar";
            this.txtUsuarioBuscar.Size = new System.Drawing.Size(250, 30);
            this.txtUsuarioBuscar.TabIndex = 1;
            // 
            // lblUsuarioBuscar
            // 
            this.lblUsuarioBuscar.AutoSize = true;
            this.lblUsuarioBuscar.Location = new System.Drawing.Point(25, 36);
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
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 160);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(800, 290);
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
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtUsuarioBuscar;
        private System.Windows.Forms.Label lblUsuarioBuscar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
    }
}

namespace Interfaz
{
    partial class frmCambiarEstado
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
            this.grpCambioDeEstado = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarEstado = new System.Windows.Forms.Button();
            this.cmbNuevoEstado = new System.Windows.Forms.ComboBox();
            this.lblNUevoEstado = new System.Windows.Forms.Label();
            this.cmblistaUsuarios = new System.Windows.Forms.ComboBox();
            this.lblSelectUsuario = new System.Windows.Forms.Label();
            this.txtUserModif = new System.Windows.Forms.TextBox();
            this.lblIDUsuarioModi = new System.Windows.Forms.Label();
            this.grpCambioDeEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCambioDeEstado
            // 
            this.grpCambioDeEstado.Controls.Add(this.txtUserModif);
            this.grpCambioDeEstado.Controls.Add(this.lblIDUsuarioModi);
            this.grpCambioDeEstado.Controls.Add(this.btnCancelar);
            this.grpCambioDeEstado.Controls.Add(this.btnGuardarEstado);
            this.grpCambioDeEstado.Controls.Add(this.cmbNuevoEstado);
            this.grpCambioDeEstado.Controls.Add(this.lblNUevoEstado);
            this.grpCambioDeEstado.Controls.Add(this.cmblistaUsuarios);
            this.grpCambioDeEstado.Controls.Add(this.lblSelectUsuario);
            this.grpCambioDeEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCambioDeEstado.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCambioDeEstado.Location = new System.Drawing.Point(0, 0);
            this.grpCambioDeEstado.Name = "grpCambioDeEstado";
            this.grpCambioDeEstado.Size = new System.Drawing.Size(674, 370);
            this.grpCambioDeEstado.TabIndex = 2;
            this.grpCambioDeEstado.TabStop = false;
            this.grpCambioDeEstado.Text = "Cambio de Estado";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(378, 255);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(224, 53);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarEstado
            // 
            this.btnGuardarEstado.Location = new System.Drawing.Point(97, 245);
            this.btnGuardarEstado.Name = "btnGuardarEstado";
            this.btnGuardarEstado.Size = new System.Drawing.Size(174, 63);
            this.btnGuardarEstado.TabIndex = 4;
            this.btnGuardarEstado.Text = "Guardar Estado";
            this.btnGuardarEstado.UseVisualStyleBackColor = true;
            this.btnGuardarEstado.Click += new System.EventHandler(this.btnGuardarEstado_Click);
            // 
            // cmbNuevoEstado
            // 
            this.cmbNuevoEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNuevoEstado.FormattingEnabled = true;
            this.cmbNuevoEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbNuevoEstado.Location = new System.Drawing.Point(345, 153);
            this.cmbNuevoEstado.Name = "cmbNuevoEstado";
            this.cmbNuevoEstado.Size = new System.Drawing.Size(276, 29);
            this.cmbNuevoEstado.TabIndex = 3;
            // 
            // lblNUevoEstado
            // 
            this.lblNUevoEstado.AutoSize = true;
            this.lblNUevoEstado.Location = new System.Drawing.Point(15, 153);
            this.lblNUevoEstado.Name = "lblNUevoEstado";
            this.lblNUevoEstado.Size = new System.Drawing.Size(146, 22);
            this.lblNUevoEstado.TabIndex = 2;
            this.lblNUevoEstado.Text = "Nuevo Estado:";
            // 
            // cmblistaUsuarios
            // 
            this.cmblistaUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmblistaUsuarios.FormattingEnabled = true;
            this.cmblistaUsuarios.Location = new System.Drawing.Point(345, 38);
            this.cmblistaUsuarios.Name = "cmblistaUsuarios";
            this.cmblistaUsuarios.Size = new System.Drawing.Size(276, 29);
            this.cmblistaUsuarios.TabIndex = 1;
            this.cmblistaUsuarios.SelectedIndexChanged += new System.EventHandler(this.cmblistaUsuarios_SelectedIndexChanged);
            // 
            // lblSelectUsuario
            // 
            this.lblSelectUsuario.AutoSize = true;
            this.lblSelectUsuario.Location = new System.Drawing.Point(15, 41);
            this.lblSelectUsuario.Name = "lblSelectUsuario";
            this.lblSelectUsuario.Size = new System.Drawing.Size(324, 22);
            this.lblSelectUsuario.TabIndex = 0;
            this.lblSelectUsuario.Text = "Seleccione el usuario a Modificar:";
            // 
            // txtUserModif
            // 
            this.txtUserModif.Location = new System.Drawing.Point(345, 98);
            this.txtUserModif.Name = "txtUserModif";
            this.txtUserModif.ReadOnly = true;
            this.txtUserModif.Size = new System.Drawing.Size(276, 28);
            this.txtUserModif.TabIndex = 18;
            this.txtUserModif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIDUsuarioModi
            // 
            this.lblIDUsuarioModi.AutoSize = true;
            this.lblIDUsuarioModi.Location = new System.Drawing.Point(15, 101);
            this.lblIDUsuarioModi.Name = "lblIDUsuarioModi";
            this.lblIDUsuarioModi.Size = new System.Drawing.Size(253, 22);
            this.lblIDUsuarioModi.TabIndex = 17;
            this.lblIDUsuarioModi.Text = "ID del usuario a Modificar:";
            // 
            // frmCambiarEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 370);
            this.Controls.Add(this.grpCambioDeEstado);
            this.Name = "frmCambiarEstado";
            this.Text = "Cambiar Estado";
            this.Load += new System.EventHandler(this.frmCambiarEstado_Load);
            this.grpCambioDeEstado.ResumeLayout(false);
            this.grpCambioDeEstado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCambioDeEstado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarEstado;
        private System.Windows.Forms.ComboBox cmbNuevoEstado;
        private System.Windows.Forms.Label lblNUevoEstado;
        private System.Windows.Forms.ComboBox cmblistaUsuarios;
        private System.Windows.Forms.Label lblSelectUsuario;
        private System.Windows.Forms.TextBox txtUserModif;
        private System.Windows.Forms.Label lblIDUsuarioModi;
    }
}
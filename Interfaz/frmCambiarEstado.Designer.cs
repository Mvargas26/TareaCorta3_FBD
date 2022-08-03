
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
            this.grpCambioPassword = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chkConfirmar = new System.Windows.Forms.CheckBox();
            this.chkNuevoPass = new System.Windows.Forms.CheckBox();
            this.chkMostrarAnterior = new System.Windows.Forms.CheckBox();
            this.txtConfirmarPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.txtPasswordNuevo = new System.Windows.Forms.TextBox();
            this.lblPasswordNuevo = new System.Windows.Forms.Label();
            this.txtPasswordAnterior = new System.Windows.Forms.TextBox();
            this.btnCambioPassword = new System.Windows.Forms.Button();
            this.lblPasswordAnterior = new System.Windows.Forms.Label();
            this.cmblistaUsuarios = new System.Windows.Forms.ComboBox();
            this.lblSelectUsuario = new System.Windows.Forms.Label();
            this.grpCambioPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCambioPassword
            // 
            this.grpCambioPassword.Controls.Add(this.btnCancelar);
            this.grpCambioPassword.Controls.Add(this.chkConfirmar);
            this.grpCambioPassword.Controls.Add(this.chkNuevoPass);
            this.grpCambioPassword.Controls.Add(this.chkMostrarAnterior);
            this.grpCambioPassword.Controls.Add(this.txtConfirmarPassword);
            this.grpCambioPassword.Controls.Add(this.lblConfirmar);
            this.grpCambioPassword.Controls.Add(this.txtPasswordNuevo);
            this.grpCambioPassword.Controls.Add(this.lblPasswordNuevo);
            this.grpCambioPassword.Controls.Add(this.txtPasswordAnterior);
            this.grpCambioPassword.Controls.Add(this.btnCambioPassword);
            this.grpCambioPassword.Controls.Add(this.lblPasswordAnterior);
            this.grpCambioPassword.Controls.Add(this.cmblistaUsuarios);
            this.grpCambioPassword.Controls.Add(this.lblSelectUsuario);
            this.grpCambioPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCambioPassword.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCambioPassword.Location = new System.Drawing.Point(0, 0);
            this.grpCambioPassword.Name = "grpCambioPassword";
            this.grpCambioPassword.Size = new System.Drawing.Size(802, 386);
            this.grpCambioPassword.TabIndex = 3;
            this.grpCambioPassword.TabStop = false;
            this.grpCambioPassword.Text = "Cambio de Password";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(487, 304);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(224, 53);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // chkConfirmar
            // 
            this.chkConfirmar.AutoSize = true;
            this.chkConfirmar.Location = new System.Drawing.Point(668, 218);
            this.chkConfirmar.Name = "chkConfirmar";
            this.chkConfirmar.Size = new System.Drawing.Size(105, 26);
            this.chkConfirmar.TabIndex = 12;
            this.chkConfirmar.Text = "Mostrar";
            this.chkConfirmar.UseVisualStyleBackColor = true;
            // 
            // chkNuevoPass
            // 
            this.chkNuevoPass.AutoSize = true;
            this.chkNuevoPass.Location = new System.Drawing.Point(668, 158);
            this.chkNuevoPass.Name = "chkNuevoPass";
            this.chkNuevoPass.Size = new System.Drawing.Size(105, 26);
            this.chkNuevoPass.TabIndex = 11;
            this.chkNuevoPass.Text = "Mostrar";
            this.chkNuevoPass.UseVisualStyleBackColor = true;
            // 
            // chkMostrarAnterior
            // 
            this.chkMostrarAnterior.AutoSize = true;
            this.chkMostrarAnterior.Location = new System.Drawing.Point(668, 105);
            this.chkMostrarAnterior.Name = "chkMostrarAnterior";
            this.chkMostrarAnterior.Size = new System.Drawing.Size(105, 26);
            this.chkMostrarAnterior.TabIndex = 10;
            this.chkMostrarAnterior.Text = "Mostrar";
            this.chkMostrarAnterior.UseVisualStyleBackColor = true;
            // 
            // txtConfirmarPassword
            // 
            this.txtConfirmarPassword.Location = new System.Drawing.Point(369, 216);
            this.txtConfirmarPassword.Name = "txtConfirmarPassword";
            this.txtConfirmarPassword.Size = new System.Drawing.Size(276, 28);
            this.txtConfirmarPassword.TabIndex = 9;
            this.txtConfirmarPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Location = new System.Drawing.Point(15, 216);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(284, 22);
            this.lblConfirmar.TabIndex = 8;
            this.lblConfirmar.Text = "Confirme el nuevo Password:";
            // 
            // txtPasswordNuevo
            // 
            this.txtPasswordNuevo.Location = new System.Drawing.Point(369, 156);
            this.txtPasswordNuevo.Name = "txtPasswordNuevo";
            this.txtPasswordNuevo.Size = new System.Drawing.Size(276, 28);
            this.txtPasswordNuevo.TabIndex = 7;
            this.txtPasswordNuevo.UseSystemPasswordChar = true;
            // 
            // lblPasswordNuevo
            // 
            this.lblPasswordNuevo.AutoSize = true;
            this.lblPasswordNuevo.Location = new System.Drawing.Point(15, 156);
            this.lblPasswordNuevo.Name = "lblPasswordNuevo";
            this.lblPasswordNuevo.Size = new System.Drawing.Size(274, 22);
            this.lblPasswordNuevo.TabIndex = 6;
            this.lblPasswordNuevo.Text = "Ingrese el nuevo Password :";
            // 
            // txtPasswordAnterior
            // 
            this.txtPasswordAnterior.Location = new System.Drawing.Point(369, 99);
            this.txtPasswordAnterior.Name = "txtPasswordAnterior";
            this.txtPasswordAnterior.Size = new System.Drawing.Size(276, 28);
            this.txtPasswordAnterior.TabIndex = 5;
            this.txtPasswordAnterior.UseSystemPasswordChar = true;
            // 
            // btnCambioPassword
            // 
            this.btnCambioPassword.Location = new System.Drawing.Point(165, 294);
            this.btnCambioPassword.Name = "btnCambioPassword";
            this.btnCambioPassword.Size = new System.Drawing.Size(246, 63);
            this.btnCambioPassword.TabIndex = 4;
            this.btnCambioPassword.Text = "Cambiar Password";
            this.btnCambioPassword.UseVisualStyleBackColor = true;
            // 
            // lblPasswordAnterior
            // 
            this.lblPasswordAnterior.AutoSize = true;
            this.lblPasswordAnterior.Location = new System.Drawing.Point(15, 99);
            this.lblPasswordAnterior.Name = "lblPasswordAnterior";
            this.lblPasswordAnterior.Size = new System.Drawing.Size(287, 22);
            this.lblPasswordAnterior.TabIndex = 2;
            this.lblPasswordAnterior.Text = "Ingrese El Password Anterior:";
            // 
            // cmblistaUsuarios
            // 
            this.cmblistaUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmblistaUsuarios.FormattingEnabled = true;
            this.cmblistaUsuarios.Location = new System.Drawing.Point(369, 41);
            this.cmblistaUsuarios.Name = "cmblistaUsuarios";
            this.cmblistaUsuarios.Size = new System.Drawing.Size(276, 29);
            this.cmblistaUsuarios.TabIndex = 1;
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
            // frmCambiarEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 386);
            this.Controls.Add(this.grpCambioPassword);
            this.Name = "frmCambiarEstado";
            this.Text = "frmCambiarEstado";
            this.grpCambioPassword.ResumeLayout(false);
            this.grpCambioPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCambioPassword;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chkConfirmar;
        private System.Windows.Forms.CheckBox chkNuevoPass;
        private System.Windows.Forms.CheckBox chkMostrarAnterior;
        private System.Windows.Forms.TextBox txtConfirmarPassword;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.TextBox txtPasswordNuevo;
        private System.Windows.Forms.Label lblPasswordNuevo;
        private System.Windows.Forms.TextBox txtPasswordAnterior;
        private System.Windows.Forms.Button btnCambioPassword;
        private System.Windows.Forms.Label lblPasswordAnterior;
        private System.Windows.Forms.ComboBox cmblistaUsuarios;
        private System.Windows.Forms.Label lblSelectUsuario;
    }
}
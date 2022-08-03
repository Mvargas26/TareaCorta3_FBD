
namespace Interfaz
{
    partial class frmCrearUsuario
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
            this.btnAgregarU = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblNUsu = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarU
            // 
            this.btnAgregarU.Location = new System.Drawing.Point(158, 304);
            this.btnAgregarU.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarU.Name = "btnAgregarU";
            this.btnAgregarU.Size = new System.Drawing.Size(111, 50);
            this.btnAgregarU.TabIndex = 26;
            this.btnAgregarU.Text = "Crear Usuario";
            this.btnAgregarU.UseVisualStyleBackColor = true;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(158, 227);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(281, 22);
            this.txtContrasena.TabIndex = 25;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(158, 159);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(281, 22);
            this.txtUsuario.TabIndex = 24;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(158, 90);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(281, 22);
            this.txtApellidos.TabIndex = 23;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(158, 30);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(281, 22);
            this.txtNombre.TabIndex = 22;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(30, 235);
            this.lblContrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(81, 17);
            this.lblContrasena.TabIndex = 21;
            this.lblContrasena.Text = "Contraseña";
            // 
            // lblNUsu
            // 
            this.lblNUsu.AutoSize = true;
            this.lblNUsu.Location = new System.Drawing.Point(30, 159);
            this.lblNUsu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNUsu.Name = "lblNUsu";
            this.lblNUsu.Size = new System.Drawing.Size(57, 17);
            this.lblNUsu.TabIndex = 20;
            this.lblNUsu.Text = "Usuario";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(30, 99);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 17);
            this.lblApellido.TabIndex = 19;
            this.lblApellido.Text = "Apellidos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 33);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre";
            // 
            // frmCrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 396);
            this.Controls.Add(this.btnAgregarU);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblNUsu);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmCrearUsuario";
            this.Text = "frmCrearUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarU;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblNUsu;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
    }
}
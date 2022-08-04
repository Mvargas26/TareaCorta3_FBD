
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfContra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregarU
            // 
            this.btnAgregarU.Location = new System.Drawing.Point(166, 292);
            this.btnAgregarU.Name = "btnAgregarU";
            this.btnAgregarU.Size = new System.Drawing.Size(83, 41);
            this.btnAgregarU.TabIndex = 26;
            this.btnAgregarU.Text = "Crear Usuario";
            this.btnAgregarU.UseVisualStyleBackColor = true;
            this.btnAgregarU.Click += new System.EventHandler(this.btnAgregarU_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(166, 184);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(212, 20);
            this.txtContrasena.TabIndex = 25;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(166, 129);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(212, 20);
            this.txtUsuario.TabIndex = 24;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(166, 73);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(212, 20);
            this.txtApellidos.TabIndex = 23;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(166, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(212, 20);
            this.txtNombre.TabIndex = 22;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(22, 191);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(61, 13);
            this.lblContrasena.TabIndex = 21;
            this.lblContrasena.Text = "Contraseña";
            // 
            // lblNUsu
            // 
            this.lblNUsu.AutoSize = true;
            this.lblNUsu.Location = new System.Drawing.Point(22, 129);
            this.lblNUsu.Name = "lblNUsu";
            this.lblNUsu.Size = new System.Drawing.Size(43, 13);
            this.lblNUsu.TabIndex = 20;
            this.lblNUsu.Text = "Usuario";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(22, 80);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(49, 13);
            this.lblApellido.TabIndex = 19;
            this.lblApellido.Text = "Apellidos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Confirmacion Contraseña";
            // 
            // txtConfContra
            // 
            this.txtConfContra.Location = new System.Drawing.Point(166, 232);
            this.txtConfContra.Name = "txtConfContra";
            this.txtConfContra.PasswordChar = '*';
            this.txtConfContra.Size = new System.Drawing.Size(212, 20);
            this.txtConfContra.TabIndex = 28;
            // 
            // frmCrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 345);
            this.Controls.Add(this.txtConfContra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarU);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblNUsu);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfContra;
    }
}
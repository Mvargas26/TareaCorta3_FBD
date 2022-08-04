
namespace Interfaz
{
    partial class frmLoguin
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
            this.LlblCrearUsu = new System.Windows.Forms.LinkLabel();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblUsu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LlblCrearUsu
            // 
            this.LlblCrearUsu.AutoSize = true;
            this.LlblCrearUsu.Location = new System.Drawing.Point(130, 217);
            this.LlblCrearUsu.Name = "LlblCrearUsu";
            this.LlblCrearUsu.Size = new System.Drawing.Size(106, 13);
            this.LlblCrearUsu.TabIndex = 17;
            this.LlblCrearUsu.TabStop = true;
            this.LlblCrearUsu.Text = "Crear Nuevo Usuario";
            this.LlblCrearUsu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlblCrearUsu_LinkClicked);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(133, 159);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(81, 33);
            this.btnIngresar.TabIndex = 16;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(133, 103);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(193, 20);
            this.txtContrasena.TabIndex = 15;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(133, 28);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(193, 20);
            this.txtusuario.TabIndex = 14;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(36, 110);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(61, 13);
            this.lblContrasena.TabIndex = 13;
            this.lblContrasena.Text = "Contraseña";
            // 
            // lblUsu
            // 
            this.lblUsu.AutoSize = true;
            this.lblUsu.Location = new System.Drawing.Point(36, 34);
            this.lblUsu.Name = "lblUsu";
            this.lblUsu.Size = new System.Drawing.Size(43, 13);
            this.lblUsu.TabIndex = 12;
            this.lblUsu.Text = "Usuario";
            // 
            // frmLoguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 262);
            this.Controls.Add(this.LlblCrearUsu);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblUsu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLoguin";
            this.Text = "frmLoguin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LlblCrearUsu;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblUsu;
    }
}
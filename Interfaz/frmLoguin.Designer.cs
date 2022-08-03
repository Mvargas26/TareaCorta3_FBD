
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
            this.LlblCrearUsu.Location = new System.Drawing.Point(173, 267);
            this.LlblCrearUsu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LlblCrearUsu.Name = "LlblCrearUsu";
            this.LlblCrearUsu.Size = new System.Drawing.Size(141, 17);
            this.LlblCrearUsu.TabIndex = 17;
            this.LlblCrearUsu.TabStop = true;
            this.LlblCrearUsu.Text = "Crear Nuevo Usuario";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(177, 196);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(108, 41);
            this.btnIngresar.TabIndex = 16;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(177, 127);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(256, 22);
            this.txtContrasena.TabIndex = 15;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(177, 34);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(256, 22);
            this.txtusuario.TabIndex = 14;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(48, 136);
            this.lblContrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(81, 17);
            this.lblContrasena.TabIndex = 13;
            this.lblContrasena.Text = "Contraseña";
            // 
            // lblUsu
            // 
            this.lblUsu.AutoSize = true;
            this.lblUsu.Location = new System.Drawing.Point(48, 42);
            this.lblUsu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsu.Name = "lblUsu";
            this.lblUsu.Size = new System.Drawing.Size(57, 17);
            this.lblUsu.TabIndex = 12;
            this.lblUsu.Text = "Usuario";
            // 
            // frmLoguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 322);
            this.Controls.Add(this.LlblCrearUsu);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblUsu);
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
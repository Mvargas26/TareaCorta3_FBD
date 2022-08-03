
namespace Interfaz
{
    partial class frmPrincipal
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
            this.mnMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.verUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnMenuPrincipal
            // 
            this.mnMenuPrincipal.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnMenuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnUsuarios,
            this.mnSalir});
            this.mnMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnMenuPrincipal.Name = "mnMenuPrincipal";
            this.mnMenuPrincipal.Size = new System.Drawing.Size(1079, 38);
            this.mnMenuPrincipal.TabIndex = 2;
            this.mnMenuPrincipal.Text = "menuStrip1";
            // 
            // mnUsuarios
            // 
            this.mnUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verUsuariosToolStripMenuItem,
            this.crearUsuarioToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem,
            this.cambiarEstadoToolStripMenuItem});
            this.mnUsuarios.Name = "mnUsuarios";
            this.mnUsuarios.Size = new System.Drawing.Size(149, 34);
            this.mnUsuarios.Text = "Usuarios";
            // 
            // verUsuariosToolStripMenuItem
            // 
            this.verUsuariosToolStripMenuItem.Name = "verUsuariosToolStripMenuItem";
            this.verUsuariosToolStripMenuItem.Size = new System.Drawing.Size(376, 34);
            this.verUsuariosToolStripMenuItem.Text = "Ver Usuarios";
            this.verUsuariosToolStripMenuItem.Click += new System.EventHandler(this.verUsuariosToolStripMenuItem_Click);
            // 
            // crearUsuarioToolStripMenuItem
            // 
            this.crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            this.crearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(376, 34);
            this.crearUsuarioToolStripMenuItem.Text = "Crear Usuario";
            this.crearUsuarioToolStripMenuItem.Click += new System.EventHandler(this.crearUsuarioToolStripMenuItem_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(376, 34);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // cambiarEstadoToolStripMenuItem
            // 
            this.cambiarEstadoToolStripMenuItem.Name = "cambiarEstadoToolStripMenuItem";
            this.cambiarEstadoToolStripMenuItem.Size = new System.Drawing.Size(376, 34);
            this.cambiarEstadoToolStripMenuItem.Text = "Cambiar estado";
            this.cambiarEstadoToolStripMenuItem.Click += new System.EventHandler(this.cambiarEstadoToolStripMenuItem_Click);
            // 
            // mnSalir
            // 
            this.mnSalir.Name = "mnSalir";
            this.mnSalir.Size = new System.Drawing.Size(96, 34);
            this.mnSalir.Text = "salir";
            this.mnSalir.Click += new System.EventHandler(this.mnSalir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 737);
            this.Controls.Add(this.mnMenuPrincipal);
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "Ventana Principal";
            this.mnMenuPrincipal.ResumeLayout(false);
            this.mnMenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnUsuarios;
        private System.Windows.Forms.ToolStripMenuItem verUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarEstadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnSalir;
    }
}


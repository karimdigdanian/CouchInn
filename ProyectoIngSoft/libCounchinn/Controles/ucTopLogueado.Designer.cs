namespace libCounchinn.Controles
{
    partial class ucTopLogueado
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTopLogueado));
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.opcionMiCuenta = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.misToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeHospedajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLink1
            // 
            this.metroLink1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLink1.Image = ((System.Drawing.Image)(resources.GetObject("metroLink1.Image")));
            this.metroLink1.ImageSize = 150;
            this.metroLink1.Location = new System.Drawing.Point(0, 0);
            this.metroLink1.Margin = new System.Windows.Forms.Padding(4);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(200, 185);
            this.metroLink1.TabIndex = 0;
            this.metroLink1.Text = "metroLink1";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.OliveDrab;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionMiCuenta,
            this.administrarToolStripMenuItem1,
            this.opcionCerrarSesion});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 110);
            // 
            // opcionMiCuenta
            // 
            this.opcionMiCuenta.Name = "opcionMiCuenta";
            this.opcionMiCuenta.Size = new System.Drawing.Size(181, 26);
            this.opcionMiCuenta.Text = "Mi cuenta";
            this.opcionMiCuenta.Click += new System.EventHandler(this.opcionMiCuenta_Click);
            // 
            // administrarToolStripMenuItem1
            // 
            this.administrarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.misToolStripMenuItem});
            this.administrarToolStripMenuItem1.Name = "administrarToolStripMenuItem1";
            this.administrarToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.administrarToolStripMenuItem1.Text = "Administrar";
            // 
            // misToolStripMenuItem
            // 
            this.misToolStripMenuItem.BackColor = System.Drawing.Color.OliveDrab;
            this.misToolStripMenuItem.Name = "misToolStripMenuItem";
            this.misToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.misToolStripMenuItem.Text = "Mis hospedajes";
            this.misToolStripMenuItem.Click += new System.EventHandler(this.misToolStripMenuItem_Click);
            // 
            // opcionCerrarSesion
            // 
            this.opcionCerrarSesion.Name = "opcionCerrarSesion";
            this.opcionCerrarSesion.Size = new System.Drawing.Size(181, 26);
            this.opcionCerrarSesion.Text = "Cerrar Sesión";
            this.opcionCerrarSesion.Click += new System.EventHandler(this.opcionCerrarSesion_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCuentaToolStripMenuItem,
            this.administrarToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(172, 82);
            // 
            // miCuentaToolStripMenuItem
            // 
            this.miCuentaToolStripMenuItem.BackColor = System.Drawing.Color.OliveDrab;
            this.miCuentaToolStripMenuItem.Name = "miCuentaToolStripMenuItem";
            this.miCuentaToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.miCuentaToolStripMenuItem.Text = "Mi Cuenta";
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.BackColor = System.Drawing.Color.OliveDrab;
            this.administrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposDeHospedajeToolStripMenuItem});
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.administrarToolStripMenuItem.Text = "Administrar";
            // 
            // tiposDeHospedajeToolStripMenuItem
            // 
            this.tiposDeHospedajeToolStripMenuItem.BackColor = System.Drawing.Color.OliveDrab;
            this.tiposDeHospedajeToolStripMenuItem.Name = "tiposDeHospedajeToolStripMenuItem";
            this.tiposDeHospedajeToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.tiposDeHospedajeToolStripMenuItem.Text = "Tipos de hospedaje";
            this.tiposDeHospedajeToolStripMenuItem.Click += new System.EventHandler(this.tiposDeHospedajeToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.BackColor = System.Drawing.Color.OliveDrab;
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.opcionCerrarSesion_Click);
            // 
            // ucTopLogueado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroLink1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucTopLogueado";
            this.Size = new System.Drawing.Size(200, 185);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem opcionMiCuenta;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem miCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeHospedajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem misToolStripMenuItem;
    }
}

namespace libCounchinn.Controles
{
    partial class ucPestanias
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.ucListarHospedajes1 = new libCounchinn.Controles.ucListarHospedajes();
            this.ucVerDetalleHospedaje1 = new libCounchinn.Controles.ucVerDetalleHospedaje();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1211, 643);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseCustomBackColor = true;
            this.metroTabControl1.UseCustomForeColor = true;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.ucListarHospedajes1);
            this.metroTabPage1.Controls.Add(this.ucVerDetalleHospedaje1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 12;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1203, 601);
            this.metroTabPage1.TabIndex = 2;
            this.metroTabPage1.Text = "Inicio";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 13;
            // 
            // ucListarHospedajes1
            // 
            this.ucListarHospedajes1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucListarHospedajes1.Location = new System.Drawing.Point(-1, 3);
            this.ucListarHospedajes1.Name = "ucListarHospedajes1";
            this.ucListarHospedajes1.Size = new System.Drawing.Size(1201, 595);
            this.ucListarHospedajes1.TabIndex = 4;
            this.ucListarHospedajes1.VerDetalle += new libCounchinn.Clases.DelegadoVerDetalle(this.ucListarHospedajes1_VerDetalle);
            // 
            // ucVerDetalleHospedaje1
            // 
            this.ucVerDetalleHospedaje1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucVerDetalleHospedaje1.Location = new System.Drawing.Point(-1, 3);
            this.ucVerDetalleHospedaje1.Name = "ucVerDetalleHospedaje1";
            this.ucVerDetalleHospedaje1.Size = new System.Drawing.Size(1204, 598);
            this.ucVerDetalleHospedaje1.TabIndex = 3;
            this.ucVerDetalleHospedaje1.Load += new System.EventHandler(this.ucVerDetalleHospedaje1_Load);
            // 
            // ucPestanias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucPestanias";
            this.Size = new System.Drawing.Size(1211, 643);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private ucVerDetalleHospedaje ucVerDetalleHospedaje1;
        private ucListarHospedajes ucListarHospedajes1;
    }
}

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
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.ucMisHospedajes1 = new libCounchinn.Controles.ucMisHospedajes();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.ucAltaPublicacion1 = new libCounchinn.Controles.ucAltaPublicacion();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.ucVerDetalleHospedaje1 = new libCounchinn.Controles.ucVerDetalleHospedaje();
            this.ucListarHospedajes1 = new libCounchinn.Controles.ucListarHospedajes();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage3.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.ucMisHospedajes1);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1203, 600);
            this.metroTabPage3.TabIndex = 4;
            this.metroTabPage3.Text = "Mis hospedajes";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // ucMisHospedajes1
            // 
            this.ucMisHospedajes1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucMisHospedajes1.BackColor = System.Drawing.SystemColors.Control;
            this.ucMisHospedajes1.Location = new System.Drawing.Point(0, 3);
            this.ucMisHospedajes1.Name = "ucMisHospedajes1";
            this.ucMisHospedajes1.Size = new System.Drawing.Size(1200, 598);
            this.ucMisHospedajes1.TabIndex = 2;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.ucAltaPublicacion1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1203, 600);
            this.metroTabPage2.TabIndex = 3;
            this.metroTabPage2.Text = "Nueva publicacion";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // ucAltaPublicacion1
            // 
            this.ucAltaPublicacion1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucAltaPublicacion1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ucAltaPublicacion1.Location = new System.Drawing.Point(3, 7);
            this.ucAltaPublicacion1.Name = "ucAltaPublicacion1";
            this.ucAltaPublicacion1.Size = new System.Drawing.Size(1197, 590);
            this.ucAltaPublicacion1.TabIndex = 2;
            this.ucAltaPublicacion1.UseSelectable = true;
            this.ucAltaPublicacion1.AltadePublicacionRealizada += new libCounchinn.Clases.DelegadoLogin(this.ucAltaPublicacion1_AltadePublicacionRealizada);
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
            // ucVerDetalleHospedaje1
            // 
            this.ucVerDetalleHospedaje1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucVerDetalleHospedaje1.Location = new System.Drawing.Point(-1, 3);
            this.ucVerDetalleHospedaje1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucVerDetalleHospedaje1.Name = "ucVerDetalleHospedaje1";
            this.ucVerDetalleHospedaje1.Size = new System.Drawing.Size(1204, 598);
            this.ucVerDetalleHospedaje1.TabIndex = 3;
            this.ucVerDetalleHospedaje1.Load += new System.EventHandler(this.ucVerDetalleHospedaje1_Load);
            // 
            // ucListarHospedajes1
            // 
            this.ucListarHospedajes1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucListarHospedajes1.Location = new System.Drawing.Point(-1, 3);
            this.ucListarHospedajes1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucListarHospedajes1.Name = "ucListarHospedajes1";
            this.ucListarHospedajes1.Size = new System.Drawing.Size(1201, 595);
            this.ucListarHospedajes1.TabIndex = 4;
            this.ucListarHospedajes1.VerDetalle += new libCounchinn.Clases.DelegadoVerDetalle(this.ucListarHospedajes1_VerDetalle);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
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
            // ucPestanias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucPestanias";
            this.Size = new System.Drawing.Size(1211, 643);
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private ucMisHospedajes ucMisHospedajes1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private ucAltaPublicacion ucAltaPublicacion1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private ucListarHospedajes ucListarHospedajes1;
        private ucVerDetalleHospedaje ucVerDetalleHospedaje1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
    }
}

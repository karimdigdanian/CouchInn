namespace TestLib2
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.usContribucion1 = new libCouch2.Controles.usContribucion();
            this.ucAltadeUsuario1 = new libCouch2.Controles.ucAltadeUsuario();
            this.SuspendLayout();
            // 
            // usContribucion1
            // 
            this.usContribucion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usContribucion1.Location = new System.Drawing.Point(15, 49);
            this.usContribucion1.Margin = new System.Windows.Forms.Padding(2);
            this.usContribucion1.Name = "usContribucion1";
            this.usContribucion1.Size = new System.Drawing.Size(955, 497);
            this.usContribucion1.TabIndex = 1;
            // 
            // ucAltadeUsuario1
            // 
            this.ucAltadeUsuario1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAltadeUsuario1.Location = new System.Drawing.Point(15, 49);
            this.ucAltadeUsuario1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucAltadeUsuario1.Name = "ucAltadeUsuario1";
            this.ucAltadeUsuario1.Size = new System.Drawing.Size(955, 497);
            this.ucAltadeUsuario1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 562);
            this.Controls.Add(this.usContribucion1);
            this.Controls.Add(this.ucAltadeUsuario1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "Contribucion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private libCouch2.Controles.ucAltadeUsuario ucAltadeUsuario1;
        private libCouch2.Controles.usContribucion usContribucion1;
    }
}


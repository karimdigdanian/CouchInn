namespace ProyectoIngSoft
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
            this.ucCuerpo1 = new libCounchinn.Controles.ucCuerpo();
            this.SuspendLayout();
            // 
            // ucCuerpo1
            // 
            this.ucCuerpo1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ucCuerpo1.Location = new System.Drawing.Point(29, 18);
            this.ucCuerpo1.Modo = libCounchinn.Clases.Modo_Pantalla.NoLogeado;
            this.ucCuerpo1.Name = "ucCuerpo1";
            this.ucCuerpo1.Size = new System.Drawing.Size(924, 644);
            this.ucCuerpo1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 557);
            this.Controls.Add(this.ucCuerpo1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private libCounchinn.Controles.ucCuerpo ucCuerpo1;
    }
}


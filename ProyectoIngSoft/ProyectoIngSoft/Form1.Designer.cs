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
            this.ucVerMisReservas1 = new libCounchinn.Controles.ucVerMisReservas();
            this.SuspendLayout();
            // 
            // ucCuerpo1
            // 
            this.ucCuerpo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucCuerpo1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ucCuerpo1.Location = new System.Drawing.Point(5, 34);
            this.ucCuerpo1.Margin = new System.Windows.Forms.Padding(5);
            this.ucCuerpo1.Modo = libCounchinn.Clases.Modo_Pantalla.NoLogeado;
            this.ucCuerpo1.Name = "ucCuerpo1";
            this.ucCuerpo1.Size = new System.Drawing.Size(1339, 646);
            this.ucCuerpo1.TabIndex = 0;
            // 
            // ucVerMisReservas1
            // 
            this.ucVerMisReservas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucVerMisReservas1.Location = new System.Drawing.Point(20, 74);
            this.ucVerMisReservas1.Name = "ucVerMisReservas1";
            this.ucVerMisReservas1.Size = new System.Drawing.Size(1312, 592);
            this.ucVerMisReservas1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 686);
            this.Controls.Add(this.ucVerMisReservas1);
            this.Controls.Add(this.ucCuerpo1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private libCounchinn.Controles.ucCuerpo ucCuerpo1;
        private libCounchinn.Controles.ucVerMisReservas ucVerMisReservas1;
    }
}


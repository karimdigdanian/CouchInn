namespace libCounchinn.Controles
{
    partial class ucOlvideContraseña
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Mail = new MetroFramework.Controls.MetroLabel();
            this.mTxtOlvide = new MetroFramework.Controls.MetroTextBox();
            this.mbtEnviarNuevaContreseña = new MetroFramework.Controls.MetroButton();
            this.bindingSourceActualizaContraseña = new System.Windows.Forms.BindingSource(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActualizaContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.metroLabel2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(700, 438);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.Black;
            this.metroLabel2.Location = new System.Drawing.Point(115, 61);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(469, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Ingrese su nombre de usuario para que le enviemos la contraseña a su mail";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.OliveDrab;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.metroLabel1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(176, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(347, 42);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(84, 8);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(179, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Olvide mi contraseña";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanel1.Controls.Add(this.metroButton1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Mail, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mTxtOlvide, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.mbtEnviarNuevaContreseña, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(176, 96);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(347, 78);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Mail
            // 
            this.Mail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Mail.AutoSize = true;
            this.Mail.Location = new System.Drawing.Point(5, 13);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(56, 19);
            this.Mail.TabIndex = 0;
            this.Mail.Text = "Usuario:";
            this.Mail.UseCustomBackColor = true;
            this.Mail.UseCustomForeColor = true;
            // 
            // mTxtOlvide
            // 
            this.mTxtOlvide.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.mTxtOlvide.CustomButton.Image = null;
            this.mTxtOlvide.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.mTxtOlvide.CustomButton.Name = "";
            this.mTxtOlvide.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.mTxtOlvide.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtOlvide.CustomButton.TabIndex = 1;
            this.mTxtOlvide.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtOlvide.CustomButton.UseSelectable = true;
            this.mTxtOlvide.CustomButton.Visible = false;
            this.mTxtOlvide.Lines = new string[0];
            this.mTxtOlvide.Location = new System.Drawing.Point(70, 11);
            this.mTxtOlvide.MaxLength = 32767;
            this.mTxtOlvide.Name = "mTxtOlvide";
            this.mTxtOlvide.PasswordChar = '\0';
            this.mTxtOlvide.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtOlvide.SelectedText = "";
            this.mTxtOlvide.SelectionLength = 0;
            this.mTxtOlvide.SelectionStart = 0;
            this.mTxtOlvide.Size = new System.Drawing.Size(274, 23);
            this.mTxtOlvide.TabIndex = 3;
            this.mTxtOlvide.UseSelectable = true;
            this.mTxtOlvide.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtOlvide.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbtEnviarNuevaContreseña
            // 
            this.mbtEnviarNuevaContreseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtEnviarNuevaContreseña.BackColor = System.Drawing.Color.OliveDrab;
            this.mbtEnviarNuevaContreseña.ForeColor = System.Drawing.Color.Black;
            this.mbtEnviarNuevaContreseña.Location = new System.Drawing.Point(152, 53);
            this.mbtEnviarNuevaContreseña.Name = "mbtEnviarNuevaContreseña";
            this.mbtEnviarNuevaContreseña.Size = new System.Drawing.Size(110, 23);
            this.mbtEnviarNuevaContreseña.TabIndex = 6;
            this.mbtEnviarNuevaContreseña.Text = "Enviar";
            this.mbtEnviarNuevaContreseña.UseCustomBackColor = true;
            this.mbtEnviarNuevaContreseña.UseCustomForeColor = true;
            this.mbtEnviarNuevaContreseña.UseSelectable = true;
            this.mbtEnviarNuevaContreseña.Click += new System.EventHandler(this.mbtEnviarNuevaContreseña_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton1.BackColor = System.Drawing.Color.OliveDrab;
            this.metroButton1.ForeColor = System.Drawing.Color.Black;
            this.metroButton1.Location = new System.Drawing.Point(3, 53);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(61, 23);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Volver";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // ucOlvideContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "ucOlvideContraseña";
            this.Size = new System.Drawing.Size(700, 438);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActualizaContraseña)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel Mail;
        private MetroFramework.Controls.MetroTextBox mTxtOlvide;
        private MetroFramework.Controls.MetroButton mbtEnviarNuevaContreseña;
        private System.Windows.Forms.BindingSource bindingSourceActualizaContraseña;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

namespace libCounchinn.Controles
{
    partial class ucListarHospedajes
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataRepeater1 = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.mlbIdPublicacion = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.bindingSourceListarHospedajes = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.dataRepeater1.ItemTemplate.SuspendLayout();
            this.dataRepeater1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceListarHospedajes)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dataRepeater1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.093995F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.90601F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1461, 772);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataRepeater1
            // 
            this.dataRepeater1.AllowUserToAddItems = false;
            this.dataRepeater1.AllowUserToDeleteItems = false;
            this.dataRepeater1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataRepeater1.DataSource = this.bindingSourceListarHospedajes;
            this.dataRepeater1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // dataRepeater1.ItemTemplate
            // 
            this.dataRepeater1.ItemTemplate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataRepeater1.ItemTemplate.Controls.Add(this.pictureBox1);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.metroLink1);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.mlbIdPublicacion);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.groupBox1);
            this.dataRepeater1.ItemTemplate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataRepeater1.ItemTemplate.Size = new System.Drawing.Size(1447, 396);
            this.dataRepeater1.Location = new System.Drawing.Point(3, 64);
            this.dataRepeater1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataRepeater1.Name = "dataRepeater1";
            this.dataRepeater1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataRepeater1.Size = new System.Drawing.Size(1455, 706);
            this.dataRepeater1.TabIndex = 0;
            this.dataRepeater1.Text = "Ubicacion:";
            this.dataRepeater1.DrawItem += new Microsoft.VisualBasic.PowerPacks.DataRepeaterItemEventHandler(this.dataRepeater1_DrawItem);
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bindingSourceListarHospedajes, "IMAGEN", true));
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(645, 369);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            // 
            // metroLink1
            // 
            this.metroLink1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLink1.AutoSize = true;
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.metroLink1.Location = new System.Drawing.Point(1160, 311);
            this.metroLink1.Margin = new System.Windows.Forms.Padding(4);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(226, 68);
            this.metroLink1.TabIndex = 12;
            this.metroLink1.Text = "Ver detalles publicacion";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.dataRepeater1_ItemTemplate_Click);
            // 
            // mlbIdPublicacion
            // 
            this.mlbIdPublicacion.AutoSize = true;
            this.mlbIdPublicacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceListarHospedajes, "ID_PUBLICACION", true));
            this.mlbIdPublicacion.Location = new System.Drawing.Point(1243, 22);
            this.mlbIdPublicacion.Name = "mlbIdPublicacion";
            this.mlbIdPublicacion.Size = new System.Drawing.Size(87, 20);
            this.mlbIdPublicacion.TabIndex = 8;
            this.mlbIdPublicacion.Text = "metroLabel4";
            this.mlbIdPublicacion.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(712, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(423, 297);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(15, 182);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(76, 20);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Capacidad:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceListarHospedajes, "tipo_hospedaje", true));
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(169, 129);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 20);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "metroLabel2";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceListarHospedajes, "CANT_PERSONAS", true));
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(169, 182);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 20);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "metroLabel3";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 129);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(39, 20);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Tipo:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceListarHospedajes, "CUIDAD", true));
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(169, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 20);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 71);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 20);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Ubicacion";
            // 
            // bindingSourceListarHospedajes
            // 
            this.bindingSourceListarHospedajes.DataSource = typeof(libCounchinn.Modelo.SEL_IMAGENESPUBLICACION_Result);
            // 
            // ucListarHospedajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucListarHospedajes";
            this.Size = new System.Drawing.Size(1461, 772);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.dataRepeater1.ItemTemplate.ResumeLayout(false);
            this.dataRepeater1.ItemTemplate.PerformLayout();
            this.dataRepeater1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceListarHospedajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Microsoft.VisualBasic.PowerPacks.DataRepeater dataRepeater1;
        private System.Windows.Forms.BindingSource bindingSourceListarHospedajes;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel mlbIdPublicacion;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

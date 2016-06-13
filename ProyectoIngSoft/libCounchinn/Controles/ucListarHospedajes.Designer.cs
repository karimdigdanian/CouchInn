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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.mLabelBuscarPor = new MetroFramework.Controls.MetroLabel();
            this.mCBFiltro = new MetroFramework.Controls.MetroComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.mLabelCapacidad = new MetroFramework.Controls.MetroLabel();
            this.mLabelLugar = new MetroFramework.Controls.MetroLabel();
            this.mTBCapacidad = new MetroFramework.Controls.MetroTextBox();
            this.mLabelTipo = new MetroFramework.Controls.MetroLabel();
            this.mCBLugar = new MetroFramework.Controls.MetroComboBox();
            this.mLabelTitulo = new MetroFramework.Controls.MetroLabel();
            this.mCBTipo = new MetroFramework.Controls.MetroComboBox();
            this.mTBTitulo = new MetroFramework.Controls.MetroTextBox();
            this.mLabelFechaInicio = new MetroFramework.Controls.MetroLabel();
            this.mTBFechaInicio = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.mLabelCiudad = new MetroFramework.Controls.MetroLabel();
            this.mTBCiudad = new MetroFramework.Controls.MetroTextBox();
            this.mLabelFechaFin = new MetroFramework.Controls.MetroLabel();
            this.mTBFechaFin = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.mBtnBuscar = new MetroFramework.Controls.MetroButton();
            this.bindingSourceListarHospedajes = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.dataRepeater1.ItemTemplate.SuspendLayout();
            this.dataRepeater1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.0829F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.9171F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
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
            this.dataRepeater1.Location = new System.Drawing.Point(3, 102);
            this.dataRepeater1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataRepeater1.Name = "dataRepeater1";
            this.dataRepeater1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataRepeater1.Size = new System.Drawing.Size(1455, 668);
            this.dataRepeater1.TabIndex = 0;
            this.dataRepeater1.Text = "Ubicacion:";
            this.dataRepeater1.DrawItem += new Microsoft.VisualBasic.PowerPacks.DataRepeaterItemEventHandler(this.dataRepeater1_DrawItem);
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bindingSourceListarHospedajes, "FOTO_PRINCIPAL", true));
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.metroLink1.Location = new System.Drawing.Point(1171, 311);
            this.metroLink1.Margin = new System.Windows.Forms.Padding(4);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(227, 68);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1453, 92);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.96053F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.03947F));
            this.tableLayoutPanel3.Controls.Add(this.mLabelBuscarPor, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.mCBFiltro, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(405, 60);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // mLabelBuscarPor
            // 
            this.mLabelBuscarPor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mLabelBuscarPor.AutoSize = true;
            this.mLabelBuscarPor.Location = new System.Drawing.Point(17, 26);
            this.mLabelBuscarPor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelBuscarPor.Name = "mLabelBuscarPor";
            this.mLabelBuscarPor.Size = new System.Drawing.Size(79, 20);
            this.mLabelBuscarPor.TabIndex = 0;
            this.mLabelBuscarPor.Text = "Buscar por:";
            this.mLabelBuscarPor.Visible = false;
            // 
            // mCBFiltro
            // 
            this.mCBFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mCBFiltro.FormattingEnabled = true;
            this.mCBFiltro.ItemHeight = 24;
            this.mCBFiltro.Items.AddRange(new object[] {
            "Seleccionar",
            "Titulo de publicacion",
            "Tipo de hospedaje",
            "Lugar",
            "Capacidad de personas",
            "Fecha inicio y fin"});
            this.mCBFiltro.Location = new System.Drawing.Point(119, 21);
            this.mCBFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.mCBFiltro.Name = "mCBFiltro";
            this.mCBFiltro.Size = new System.Drawing.Size(279, 30);
            this.mCBFiltro.TabIndex = 1;
            this.mCBFiltro.UseSelectable = true;
            this.mCBFiltro.Visible = false;
            this.mCBFiltro.SelectedIndexChanged += new System.EventHandler(this.mCBFiltro_SelectedIndexChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.mLabelCapacidad, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.mLabelLugar, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.mTBCapacidad, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.mLabelTipo, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.mCBLugar, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.mLabelTitulo, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.mCBTipo, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.mTBTitulo, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.mLabelFechaInicio, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.mTBFechaInicio, 1, 5);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(417, 4);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(504, 228);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // mLabelCapacidad
            // 
            this.mLabelCapacidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mLabelCapacidad.AutoSize = true;
            this.mLabelCapacidad.Location = new System.Drawing.Point(29, 144);
            this.mLabelCapacidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelCapacidad.Name = "mLabelCapacidad";
            this.mLabelCapacidad.Size = new System.Drawing.Size(76, 20);
            this.mLabelCapacidad.TabIndex = 4;
            this.mLabelCapacidad.Text = "Capacidad:";
            this.mLabelCapacidad.Visible = false;
            // 
            // mLabelLugar
            // 
            this.mLabelLugar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mLabelLugar.AutoSize = true;
            this.mLabelLugar.Location = new System.Drawing.Point(33, 103);
            this.mLabelLugar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelLugar.Name = "mLabelLugar";
            this.mLabelLugar.Size = new System.Drawing.Size(68, 20);
            this.mLabelLugar.TabIndex = 3;
            this.mLabelLugar.Text = "Provincia:";
            this.mLabelLugar.Visible = false;
            // 
            // mTBCapacidad
            // 
            this.mTBCapacidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.mTBCapacidad.CustomButton.Image = null;
            this.mTBCapacidad.CustomButton.Location = new System.Drawing.Point(70, 2);
            this.mTBCapacidad.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.mTBCapacidad.CustomButton.Name = "";
            this.mTBCapacidad.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.mTBCapacidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTBCapacidad.CustomButton.TabIndex = 1;
            this.mTBCapacidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTBCapacidad.CustomButton.UseSelectable = true;
            this.mTBCapacidad.CustomButton.Visible = false;
            this.mTBCapacidad.Lines = new string[0];
            this.mTBCapacidad.Location = new System.Drawing.Point(139, 136);
            this.mTBCapacidad.Margin = new System.Windows.Forms.Padding(4);
            this.mTBCapacidad.MaxLength = 32767;
            this.mTBCapacidad.Name = "mTBCapacidad";
            this.mTBCapacidad.PasswordChar = '\0';
            this.mTBCapacidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTBCapacidad.SelectedText = "";
            this.mTBCapacidad.SelectionLength = 0;
            this.mTBCapacidad.SelectionStart = 0;
            this.mTBCapacidad.Size = new System.Drawing.Size(104, 36);
            this.mTBCapacidad.TabIndex = 12;
            this.mTBCapacidad.UseSelectable = true;
            this.mTBCapacidad.Visible = false;
            this.mTBCapacidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTBCapacidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLabelTipo
            // 
            this.mLabelTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mLabelTipo.AutoSize = true;
            this.mLabelTipo.Location = new System.Drawing.Point(4, 65);
            this.mLabelTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelTipo.Name = "mLabelTipo";
            this.mLabelTipo.Size = new System.Drawing.Size(127, 20);
            this.mLabelTipo.TabIndex = 2;
            this.mLabelTipo.Text = "Tipo de hospedaje:";
            this.mLabelTipo.Visible = false;
            // 
            // mCBLugar
            // 
            this.mCBLugar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mCBLugar.FormattingEnabled = true;
            this.mCBLugar.ItemHeight = 24;
            this.mCBLugar.Location = new System.Drawing.Point(139, 98);
            this.mCBLugar.Margin = new System.Windows.Forms.Padding(4);
            this.mCBLugar.Name = "mCBLugar";
            this.mCBLugar.Size = new System.Drawing.Size(317, 30);
            this.mCBLugar.TabIndex = 10;
            this.mCBLugar.UseSelectable = true;
            this.mCBLugar.Visible = false;
            // 
            // mLabelTitulo
            // 
            this.mLabelTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mLabelTitulo.AutoSize = true;
            this.mLabelTitulo.Location = new System.Drawing.Point(44, 24);
            this.mLabelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelTitulo.Name = "mLabelTitulo";
            this.mLabelTitulo.Size = new System.Drawing.Size(46, 20);
            this.mLabelTitulo.TabIndex = 1;
            this.mLabelTitulo.Text = "Titulo:";
            this.mLabelTitulo.Visible = false;
            // 
            // mCBTipo
            // 
            this.mCBTipo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mCBTipo.FormattingEnabled = true;
            this.mCBTipo.ItemHeight = 24;
            this.mCBTipo.Location = new System.Drawing.Point(139, 60);
            this.mCBTipo.Margin = new System.Windows.Forms.Padding(4);
            this.mCBTipo.Name = "mCBTipo";
            this.mCBTipo.Size = new System.Drawing.Size(317, 30);
            this.mCBTipo.TabIndex = 9;
            this.mCBTipo.UseSelectable = true;
            this.mCBTipo.Visible = false;
            // 
            // mTBTitulo
            // 
            this.mTBTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.mTBTitulo.CustomButton.Image = null;
            this.mTBTitulo.CustomButton.Location = new System.Drawing.Point(287, 2);
            this.mTBTitulo.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.mTBTitulo.CustomButton.Name = "";
            this.mTBTitulo.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.mTBTitulo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTBTitulo.CustomButton.TabIndex = 1;
            this.mTBTitulo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTBTitulo.CustomButton.UseSelectable = true;
            this.mTBTitulo.CustomButton.Visible = false;
            this.mTBTitulo.Lines = new string[0];
            this.mTBTitulo.Location = new System.Drawing.Point(139, 16);
            this.mTBTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.mTBTitulo.MaxLength = 32767;
            this.mTBTitulo.Name = "mTBTitulo";
            this.mTBTitulo.PasswordChar = '\0';
            this.mTBTitulo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTBTitulo.SelectedText = "";
            this.mTBTitulo.SelectionLength = 0;
            this.mTBTitulo.SelectionStart = 0;
            this.mTBTitulo.Size = new System.Drawing.Size(321, 36);
            this.mTBTitulo.TabIndex = 8;
            this.mTBTitulo.UseSelectable = true;
            this.mTBTitulo.Visible = false;
            this.mTBTitulo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTBTitulo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLabelFechaInicio
            // 
            this.mLabelFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mLabelFechaInicio.AutoSize = true;
            this.mLabelFechaInicio.Location = new System.Drawing.Point(15, 188);
            this.mLabelFechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelFechaInicio.Name = "mLabelFechaInicio";
            this.mLabelFechaInicio.Size = new System.Drawing.Size(105, 20);
            this.mLabelFechaInicio.TabIndex = 5;
            this.mLabelFechaInicio.Text = "Fecha de inicio:";
            this.mLabelFechaInicio.Visible = false;
            // 
            // mTBFechaInicio
            // 
            this.mTBFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.mTBFechaInicio.CustomButton.Image = null;
            this.mTBFechaInicio.CustomButton.Location = new System.Drawing.Point(138, 2);
            this.mTBFechaInicio.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.mTBFechaInicio.CustomButton.Name = "";
            this.mTBFechaInicio.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.mTBFechaInicio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTBFechaInicio.CustomButton.TabIndex = 1;
            this.mTBFechaInicio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTBFechaInicio.CustomButton.UseSelectable = true;
            this.mTBFechaInicio.CustomButton.Visible = false;
            this.mTBFechaInicio.Lines = new string[0];
            this.mTBFechaInicio.Location = new System.Drawing.Point(139, 180);
            this.mTBFechaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.mTBFechaInicio.MaxLength = 32767;
            this.mTBFechaInicio.Name = "mTBFechaInicio";
            this.mTBFechaInicio.PasswordChar = '\0';
            this.mTBFechaInicio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTBFechaInicio.SelectedText = "";
            this.mTBFechaInicio.SelectionLength = 0;
            this.mTBFechaInicio.SelectionStart = 0;
            this.mTBFechaInicio.Size = new System.Drawing.Size(172, 36);
            this.mTBFechaInicio.TabIndex = 13;
            this.mTBFechaInicio.UseSelectable = true;
            this.mTBFechaInicio.Visible = false;
            this.mTBFechaInicio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTBFechaInicio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel5.Controls.Add(this.mLabelCiudad, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.mTBCiudad, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.mLabelFechaFin, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.mTBFechaFin, 1, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(929, 4);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(359, 110);
            this.tableLayoutPanel5.TabIndex = 2;
            this.tableLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel5_Paint);
            // 
            // mLabelCiudad
            // 
            this.mLabelCiudad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mLabelCiudad.AutoSize = true;
            this.mLabelCiudad.Location = new System.Drawing.Point(20, 24);
            this.mLabelCiudad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelCiudad.Name = "mLabelCiudad";
            this.mLabelCiudad.Size = new System.Drawing.Size(55, 20);
            this.mLabelCiudad.TabIndex = 2;
            this.mLabelCiudad.Text = "Ciudad:";
            this.mLabelCiudad.Visible = false;
            // 
            // mTBCiudad
            // 
            this.mTBCiudad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.mTBCiudad.CustomButton.Image = null;
            this.mTBCiudad.CustomButton.Location = new System.Drawing.Point(197, 2);
            this.mTBCiudad.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.mTBCiudad.CustomButton.Name = "";
            this.mTBCiudad.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.mTBCiudad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTBCiudad.CustomButton.TabIndex = 1;
            this.mTBCiudad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTBCiudad.CustomButton.UseSelectable = true;
            this.mTBCiudad.CustomButton.Visible = false;
            this.mTBCiudad.Lines = new string[0];
            this.mTBCiudad.Location = new System.Drawing.Point(100, 16);
            this.mTBCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.mTBCiudad.MaxLength = 32767;
            this.mTBCiudad.Name = "mTBCiudad";
            this.mTBCiudad.PasswordChar = '\0';
            this.mTBCiudad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTBCiudad.SelectedText = "";
            this.mTBCiudad.SelectionLength = 0;
            this.mTBCiudad.SelectionStart = 0;
            this.mTBCiudad.Size = new System.Drawing.Size(231, 36);
            this.mTBCiudad.TabIndex = 9;
            this.mTBCiudad.UseSelectable = true;
            this.mTBCiudad.Visible = false;
            this.mTBCiudad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTBCiudad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLabelFechaFin
            // 
            this.mLabelFechaFin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mLabelFechaFin.AutoSize = true;
            this.mLabelFechaFin.Location = new System.Drawing.Point(4, 68);
            this.mLabelFechaFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelFechaFin.Name = "mLabelFechaFin";
            this.mLabelFechaFin.Size = new System.Drawing.Size(88, 20);
            this.mLabelFechaFin.TabIndex = 10;
            this.mLabelFechaFin.Text = "Fecha de fin:";
            this.mLabelFechaFin.Visible = false;
            this.mLabelFechaFin.Click += new System.EventHandler(this.mLabelFechaFin_Click);
            // 
            // mTBFechaFin
            // 
            this.mTBFechaFin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.mTBFechaFin.CustomButton.Image = null;
            this.mTBFechaFin.CustomButton.Location = new System.Drawing.Point(138, 2);
            this.mTBFechaFin.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.mTBFechaFin.CustomButton.Name = "";
            this.mTBFechaFin.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.mTBFechaFin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTBFechaFin.CustomButton.TabIndex = 1;
            this.mTBFechaFin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTBFechaFin.CustomButton.UseSelectable = true;
            this.mTBFechaFin.CustomButton.Visible = false;
            this.mTBFechaFin.Lines = new string[0];
            this.mTBFechaFin.Location = new System.Drawing.Point(100, 60);
            this.mTBFechaFin.Margin = new System.Windows.Forms.Padding(4);
            this.mTBFechaFin.MaxLength = 32767;
            this.mTBFechaFin.Name = "mTBFechaFin";
            this.mTBFechaFin.PasswordChar = '\0';
            this.mTBFechaFin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTBFechaFin.SelectedText = "";
            this.mTBFechaFin.SelectionLength = 0;
            this.mTBFechaFin.SelectionStart = 0;
            this.mTBFechaFin.Size = new System.Drawing.Size(172, 36);
            this.mTBFechaFin.TabIndex = 14;
            this.mTBFechaFin.UseSelectable = true;
            this.mTBFechaFin.Visible = false;
            this.mTBFechaFin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTBFechaFin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel6.Controls.Add(this.mBtnBuscar, 0, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(1296, 4);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(136, 84);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // mBtnBuscar
            // 
            this.mBtnBuscar.BackColor = System.Drawing.Color.OliveDrab;
            this.mBtnBuscar.Location = new System.Drawing.Point(4, 16);
            this.mBtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.mBtnBuscar.Name = "mBtnBuscar";
            this.mBtnBuscar.Size = new System.Drawing.Size(128, 52);
            this.mBtnBuscar.TabIndex = 4;
            this.mBtnBuscar.Text = "Buscar";
            this.mBtnBuscar.UseCustomBackColor = true;
            this.mBtnBuscar.UseCustomForeColor = true;
            this.mBtnBuscar.UseSelectable = true;
            this.mBtnBuscar.Visible = false;
            this.mBtnBuscar.Click += new System.EventHandler(this.mBtnBuscar_Click);
            // 
            // bindingSourceListarHospedajes
            // 
            this.bindingSourceListarHospedajes.DataSource = typeof(libCounchinn.Modelo.SEL_PUBLICACIONES_LISTAR_ResultAndando);
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceListarHospedajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Microsoft.VisualBasic.PowerPacks.DataRepeater dataRepeater1;
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
        private System.Windows.Forms.BindingSource bindingSourceListarHospedajes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroLabel mLabelBuscarPor;
        private MetroFramework.Controls.MetroComboBox mCBFiltro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MetroFramework.Controls.MetroComboBox mCBLugar;
        private MetroFramework.Controls.MetroLabel mLabelTitulo;
        private MetroFramework.Controls.MetroLabel mLabelTipo;
        private MetroFramework.Controls.MetroLabel mLabelLugar;
        private MetroFramework.Controls.MetroTextBox mTBTitulo;
        private MetroFramework.Controls.MetroComboBox mCBTipo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private MetroFramework.Controls.MetroLabel mLabelCiudad;
        private MetroFramework.Controls.MetroTextBox mTBCiudad;
        private MetroFramework.Controls.MetroLabel mLabelFechaFin;
        private MetroFramework.Controls.MetroLabel mLabelCapacidad;
        private MetroFramework.Controls.MetroLabel mLabelFechaInicio;
        private MetroFramework.Controls.MetroTextBox mTBCapacidad;
        private MetroFramework.Controls.MetroTextBox mTBFechaInicio;
        private MetroFramework.Controls.MetroTextBox mTBFechaFin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private MetroFramework.Controls.MetroButton mBtnBuscar;
    }
}

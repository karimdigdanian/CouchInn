﻿namespace libCounchinn.Controles
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.mLabelBuscarPor = new MetroFramework.Controls.MetroLabel();
            this.mCBFiltro = new MetroFramework.Controls.MetroComboBox();
            this.mBtnBuscar = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.mTBCapacidad = new MetroFramework.Controls.MetroTextBox();
            this.mCBLugar = new MetroFramework.Controls.MetroComboBox();
            this.mLabelTitulo = new MetroFramework.Controls.MetroLabel();
            this.mLabelTipo = new MetroFramework.Controls.MetroLabel();
            this.mLabelLugar = new MetroFramework.Controls.MetroLabel();
            this.mLabelCapacidad = new MetroFramework.Controls.MetroLabel();
            this.mLabelFechaInicio = new MetroFramework.Controls.MetroLabel();
            this.mTBTitulo = new MetroFramework.Controls.MetroTextBox();
            this.mCBTipo = new MetroFramework.Controls.MetroComboBox();
            this.mCBFechaInicio = new MetroFramework.Controls.MetroComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.mCBFechaFin = new MetroFramework.Controls.MetroComboBox();
            this.mLabelCiudad = new MetroFramework.Controls.MetroLabel();
            this.mTBCiudad = new MetroFramework.Controls.MetroTextBox();
            this.mLabelFechaFin = new MetroFramework.Controls.MetroLabel();
            this.dataRepeater1 = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.bindingSourceListarHospedajes = new System.Windows.Forms.BindingSource(this.components);
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
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.dataRepeater1.ItemTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceListarHospedajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataRepeater1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.53722F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.46278F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1461, 772);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1453, 178);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.Controls.Add(this.mLabelBuscarPor, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.mCBFiltro, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.mBtnBuscar, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.70588F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.29412F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(349, 144);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // mLabelBuscarPor
            // 
            this.mLabelBuscarPor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mLabelBuscarPor.AutoSize = true;
            this.mLabelBuscarPor.Location = new System.Drawing.Point(135, 6);
            this.mLabelBuscarPor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelBuscarPor.Name = "mLabelBuscarPor";
            this.mLabelBuscarPor.Size = new System.Drawing.Size(79, 20);
            this.mLabelBuscarPor.TabIndex = 0;
            this.mLabelBuscarPor.Text = "Buscar por:";
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
            this.mCBFiltro.Location = new System.Drawing.Point(35, 44);
            this.mCBFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mCBFiltro.Name = "mCBFiltro";
            this.mCBFiltro.Size = new System.Drawing.Size(279, 30);
            this.mCBFiltro.TabIndex = 1;
            this.mCBFiltro.UseSelectable = true;
            this.mCBFiltro.SelectedIndexChanged += new System.EventHandler(this.mCBFiltro_SelectedIndexChanged);
            // 
            // mBtnBuscar
            // 
            this.mBtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mBtnBuscar.BackColor = System.Drawing.Color.OliveDrab;
            this.mBtnBuscar.Location = new System.Drawing.Point(124, 100);
            this.mBtnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mBtnBuscar.Name = "mBtnBuscar";
            this.mBtnBuscar.Size = new System.Drawing.Size(100, 28);
            this.mBtnBuscar.TabIndex = 3;
            this.mBtnBuscar.Text = "Buscar";
            this.mBtnBuscar.UseCustomBackColor = true;
            this.mBtnBuscar.UseCustomForeColor = true;
            this.mBtnBuscar.UseSelectable = true;
            this.mBtnBuscar.Click += new System.EventHandler(this.mBtnBuscar_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.mTBCapacidad, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.mCBLugar, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.mLabelTitulo, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.mLabelTipo, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.mLabelLugar, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.mLabelCapacidad, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.mLabelFechaInicio, 0, 8);
            this.tableLayoutPanel4.Controls.Add(this.mTBTitulo, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.mCBTipo, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.mCBFechaInicio, 0, 9);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(361, 4);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 10;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(329, 170);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // mTBCapacidad
            // 
            this.mTBCapacidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.mTBCapacidad.CustomButton.Image = null;
            this.mTBCapacidad.CustomButton.Location = new System.Drawing.Point(104, 2);
            this.mTBCapacidad.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mTBCapacidad.CustomButton.Name = "";
            this.mTBCapacidad.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.mTBCapacidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTBCapacidad.CustomButton.TabIndex = 1;
            this.mTBCapacidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTBCapacidad.CustomButton.UseSelectable = true;
            this.mTBCapacidad.CustomButton.Visible = false;
            this.mTBCapacidad.Lines = new string[0];
            this.mTBCapacidad.Location = new System.Drawing.Point(112, 194);
            this.mTBCapacidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mTBCapacidad.MaxLength = 32767;
            this.mTBCapacidad.Name = "mTBCapacidad";
            this.mTBCapacidad.PasswordChar = '\0';
            this.mTBCapacidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTBCapacidad.SelectedText = "";
            this.mTBCapacidad.SelectionLength = 0;
            this.mTBCapacidad.SelectionStart = 0;
            this.mTBCapacidad.Size = new System.Drawing.Size(104, 28);
            this.mTBCapacidad.TabIndex = 12;
            this.mTBCapacidad.UseSelectable = true;
            this.mTBCapacidad.Visible = false;
            this.mTBCapacidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTBCapacidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mCBLugar
            // 
            this.mCBLugar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mCBLugar.FormattingEnabled = true;
            this.mCBLugar.ItemHeight = 24;
            this.mCBLugar.Location = new System.Drawing.Point(6, 137);
            this.mCBLugar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.mLabelTitulo.Location = new System.Drawing.Point(141, 0);
            this.mLabelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelTitulo.Name = "mLabelTitulo";
            this.mLabelTitulo.Size = new System.Drawing.Size(46, 20);
            this.mLabelTitulo.TabIndex = 1;
            this.mLabelTitulo.Text = "Titulo:";
            this.mLabelTitulo.Visible = false;
            // 
            // mLabelTipo
            // 
            this.mLabelTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mLabelTipo.AutoSize = true;
            this.mLabelTipo.Location = new System.Drawing.Point(101, 56);
            this.mLabelTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelTipo.Name = "mLabelTipo";
            this.mLabelTipo.Size = new System.Drawing.Size(127, 20);
            this.mLabelTipo.TabIndex = 2;
            this.mLabelTipo.Text = "Tipo de hospedaje:";
            this.mLabelTipo.Visible = false;
            // 
            // mLabelLugar
            // 
            this.mLabelLugar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mLabelLugar.AutoSize = true;
            this.mLabelLugar.Location = new System.Drawing.Point(130, 113);
            this.mLabelLugar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelLugar.Name = "mLabelLugar";
            this.mLabelLugar.Size = new System.Drawing.Size(68, 20);
            this.mLabelLugar.TabIndex = 3;
            this.mLabelLugar.Text = "Provincia:";
            this.mLabelLugar.Visible = false;
            // 
            // mLabelCapacidad
            // 
            this.mLabelCapacidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mLabelCapacidad.AutoSize = true;
            this.mLabelCapacidad.Location = new System.Drawing.Point(126, 170);
            this.mLabelCapacidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelCapacidad.Name = "mLabelCapacidad";
            this.mLabelCapacidad.Size = new System.Drawing.Size(76, 20);
            this.mLabelCapacidad.TabIndex = 4;
            this.mLabelCapacidad.Text = "Capacidad:";
            this.mLabelCapacidad.Visible = false;
            // 
            // mLabelFechaInicio
            // 
            this.mLabelFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mLabelFechaInicio.AutoSize = true;
            this.mLabelFechaInicio.Location = new System.Drawing.Point(112, 226);
            this.mLabelFechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelFechaInicio.Name = "mLabelFechaInicio";
            this.mLabelFechaInicio.Size = new System.Drawing.Size(105, 20);
            this.mLabelFechaInicio.TabIndex = 5;
            this.mLabelFechaInicio.Text = "Fecha de inicio:";
            this.mLabelFechaInicio.Visible = false;
            // 
            // mTBTitulo
            // 
            this.mTBTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.mTBTitulo.CustomButton.Image = null;
            this.mTBTitulo.CustomButton.Location = new System.Drawing.Point(393, 2);
            this.mTBTitulo.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mTBTitulo.CustomButton.Name = "";
            this.mTBTitulo.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.mTBTitulo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTBTitulo.CustomButton.TabIndex = 1;
            this.mTBTitulo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTBTitulo.CustomButton.UseSelectable = true;
            this.mTBTitulo.CustomButton.Visible = false;
            this.mTBTitulo.Lines = new string[0];
            this.mTBTitulo.Location = new System.Drawing.Point(4, 24);
            this.mTBTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mTBTitulo.MaxLength = 32767;
            this.mTBTitulo.Name = "mTBTitulo";
            this.mTBTitulo.PasswordChar = '\0';
            this.mTBTitulo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTBTitulo.SelectedText = "";
            this.mTBTitulo.SelectionLength = 0;
            this.mTBTitulo.SelectionStart = 0;
            this.mTBTitulo.Size = new System.Drawing.Size(321, 28);
            this.mTBTitulo.TabIndex = 8;
            this.mTBTitulo.UseSelectable = true;
            this.mTBTitulo.Visible = false;
            this.mTBTitulo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTBTitulo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mCBTipo
            // 
            this.mCBTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mCBTipo.FormattingEnabled = true;
            this.mCBTipo.ItemHeight = 24;
            this.mCBTipo.Location = new System.Drawing.Point(6, 80);
            this.mCBTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mCBTipo.Name = "mCBTipo";
            this.mCBTipo.Size = new System.Drawing.Size(317, 30);
            this.mCBTipo.TabIndex = 9;
            this.mCBTipo.UseSelectable = true;
            this.mCBTipo.Visible = false;
            // 
            // mCBFechaInicio
            // 
            this.mCBFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mCBFechaInicio.FormattingEnabled = true;
            this.mCBFechaInicio.ItemHeight = 23;
            this.mCBFechaInicio.Location = new System.Drawing.Point(6, 250);
            this.mCBFechaInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mCBFechaInicio.Name = "mCBFechaInicio";
            this.mCBFechaInicio.Size = new System.Drawing.Size(317, 29);
            this.mCBFechaInicio.TabIndex = 11;
            this.mCBFechaInicio.UseSelectable = true;
            this.mCBFechaInicio.Visible = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.mCBFechaFin, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.mLabelCiudad, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.mTBCiudad, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.mLabelFechaFin, 0, 2);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(698, 23);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(343, 132);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // mCBFechaFin
            // 
            this.mCBFechaFin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mCBFechaFin.FormattingEnabled = true;
            this.mCBFechaFin.ItemHeight = 24;
            this.mCBFechaFin.Location = new System.Drawing.Point(13, 89);
            this.mCBFechaFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mCBFechaFin.Name = "mCBFechaFin";
            this.mCBFechaFin.Size = new System.Drawing.Size(317, 30);
            this.mCBFechaFin.TabIndex = 12;
            this.mCBFechaFin.UseSelectable = true;
            this.mCBFechaFin.Visible = false;
            // 
            // mLabelCiudad
            // 
            this.mLabelCiudad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mLabelCiudad.AutoSize = true;
            this.mLabelCiudad.Location = new System.Drawing.Point(144, 0);
            this.mLabelCiudad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelCiudad.Name = "mLabelCiudad";
            this.mLabelCiudad.Size = new System.Drawing.Size(55, 20);
            this.mLabelCiudad.TabIndex = 2;
            this.mLabelCiudad.Text = "Ciudad:";
            this.mLabelCiudad.Visible = false;
            // 
            // mTBCiudad
            // 
            this.mTBCiudad.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.mTBCiudad.CustomButton.Image = null;
            this.mTBCiudad.CustomButton.Location = new System.Drawing.Point(393, 2);
            this.mTBCiudad.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mTBCiudad.CustomButton.Name = "";
            this.mTBCiudad.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.mTBCiudad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTBCiudad.CustomButton.TabIndex = 1;
            this.mTBCiudad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTBCiudad.CustomButton.UseSelectable = true;
            this.mTBCiudad.CustomButton.Visible = false;
            this.mTBCiudad.Lines = new string[0];
            this.mTBCiudad.Location = new System.Drawing.Point(11, 24);
            this.mTBCiudad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mTBCiudad.MaxLength = 32767;
            this.mTBCiudad.Name = "mTBCiudad";
            this.mTBCiudad.PasswordChar = '\0';
            this.mTBCiudad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTBCiudad.SelectedText = "";
            this.mTBCiudad.SelectionLength = 0;
            this.mTBCiudad.SelectionStart = 0;
            this.mTBCiudad.Size = new System.Drawing.Size(321, 28);
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
            this.mLabelFechaFin.Location = new System.Drawing.Point(127, 56);
            this.mLabelFechaFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mLabelFechaFin.Name = "mLabelFechaFin";
            this.mLabelFechaFin.Size = new System.Drawing.Size(88, 20);
            this.mLabelFechaFin.TabIndex = 10;
            this.mLabelFechaFin.Text = "Fecha de fin:";
            this.mLabelFechaFin.Visible = false;
            // 
            // dataRepeater1
            // 
            this.dataRepeater1.AllowUserToAddItems = false;
            this.dataRepeater1.AllowUserToDeleteItems = false;
            this.dataRepeater1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataRepeater1.Controls.Add(this.dataRepeater1.ItemTemplate);
            this.dataRepeater1.DataSource = this.bindingSourceListarHospedajes;
            this.dataRepeater1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataRepeater1.Location = new System.Drawing.Point(3, 204);
            this.dataRepeater1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataRepeater1.Name = "dataRepeater1";
            this.dataRepeater1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataRepeater1.Size = new System.Drawing.Size(1455, 555);
            this.dataRepeater1.TabIndex = 0;
            this.dataRepeater1.Text = "Ubicacion:";
            this.dataRepeater1.DrawItem += new Microsoft.VisualBasic.PowerPacks.DataRepeaterItemEventHandler(this.dataRepeater1_DrawItem);
            // 
            // bindingSourceListarHospedajes
            // 
            this.bindingSourceListarHospedajes.DataSource = typeof(libCounchinn.Modelo.SEL_IMAGENESPUBLICACION_Result);
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bindingSourceListarHospedajes, "IMAGEN", true));
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
            this.metroLink1.Location = new System.Drawing.Point(1125, 309);
            this.metroLink1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // ucListarHospedajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucListarHospedajes";
            this.Size = new System.Drawing.Size(1461, 772);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.dataRepeater1.ItemTemplate.ResumeLayout(false);
            this.dataRepeater1.ItemTemplate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceListarHospedajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroLabel mLabelBuscarPor;
        private MetroFramework.Controls.MetroComboBox mCBFiltro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MetroFramework.Controls.MetroTextBox mTBCapacidad;
        private MetroFramework.Controls.MetroComboBox mCBLugar;
        private MetroFramework.Controls.MetroLabel mLabelTitulo;
        private MetroFramework.Controls.MetroLabel mLabelTipo;
        private MetroFramework.Controls.MetroLabel mLabelLugar;
        private MetroFramework.Controls.MetroLabel mLabelCapacidad;
        private MetroFramework.Controls.MetroLabel mLabelFechaInicio;
        private MetroFramework.Controls.MetroTextBox mTBTitulo;
        private MetroFramework.Controls.MetroComboBox mCBTipo;
        private MetroFramework.Controls.MetroComboBox mCBFechaInicio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private MetroFramework.Controls.MetroComboBox mCBFechaFin;
        private MetroFramework.Controls.MetroLabel mLabelCiudad;
        private MetroFramework.Controls.MetroTextBox mTBCiudad;
        private MetroFramework.Controls.MetroLabel mLabelFechaFin;
        private MetroFramework.Controls.MetroButton mBtnBuscar;
    }
}

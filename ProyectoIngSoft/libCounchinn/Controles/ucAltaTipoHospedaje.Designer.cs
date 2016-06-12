namespace libCounchinn.Controles
{
    partial class ucAltaTipoHospedaje
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Mail = new MetroFramework.Controls.MetroLabel();
            this.mTxtHospedaje = new MetroFramework.Controls.MetroTextBox();
            this.mbtCancelarHospedaje = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.metroGridAltaHospedaje = new MetroFramework.Controls.MetroGrid();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.mbtEliminar = new MetroFramework.Controls.MetroButton();
            this.mbtModificar = new MetroFramework.Controls.MetroButton();
            this.mbtCargarHospedaje = new MetroFramework.Controls.MetroButton();
            this.bindingSourceINSERT_Hosp = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceUDPTipoHospedaje = new System.Windows.Forms.BindingSource(this.components);
            this.dESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTIPOHOSPEDAJEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceSelTiposHospedajes = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridAltaHospedaje)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceINSERT_Hosp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUDPTipoHospedaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSelTiposHospedajes)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.metroLabel2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 338F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1156, 665);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.Black;
            this.metroLabel2.Location = new System.Drawing.Point(435, 94);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(286, 20);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Ingrese el tipo de hospedaje a dar de alta";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.OliveDrab;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Controls.Add(this.metroLabel1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(185, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(785, 69);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(255, 22);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(275, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Carga nuevo tipo de hospedaje";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 569F));
            this.tableLayoutPanel1.Controls.Add(this.Mail, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mTxtHospedaje, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.mbtCancelarHospedaje, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(185, 136);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 122);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Mail
            // 
            this.Mail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Mail.AutoSize = true;
            this.Mail.Location = new System.Drawing.Point(69, 20);
            this.Mail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(78, 20);
            this.Mail.TabIndex = 0;
            this.Mail.Text = "Hospedaje:";
            this.Mail.UseCustomBackColor = true;
            this.Mail.UseCustomForeColor = true;
            // 
            // mTxtHospedaje
            // 
            this.mTxtHospedaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.mTxtHospedaje.CustomButton.Image = null;
            this.mTxtHospedaje.CustomButton.Location = new System.Drawing.Point(471, 2);
            this.mTxtHospedaje.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.mTxtHospedaje.CustomButton.Name = "";
            this.mTxtHospedaje.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxtHospedaje.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtHospedaje.CustomButton.TabIndex = 1;
            this.mTxtHospedaje.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtHospedaje.CustomButton.UseSelectable = true;
            this.mTxtHospedaje.CustomButton.Visible = false;
            this.mTxtHospedaje.Lines = new string[0];
            this.mTxtHospedaje.Location = new System.Drawing.Point(252, 16);
            this.mTxtHospedaje.Margin = new System.Windows.Forms.Padding(4);
            this.mTxtHospedaje.MaxLength = 25;
            this.mTxtHospedaje.Name = "mTxtHospedaje";
            this.mTxtHospedaje.PasswordChar = '\0';
            this.mTxtHospedaje.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtHospedaje.SelectedText = "";
            this.mTxtHospedaje.SelectionLength = 0;
            this.mTxtHospedaje.SelectionStart = 0;
            this.mTxtHospedaje.Size = new System.Drawing.Size(497, 28);
            this.mTxtHospedaje.TabIndex = 3;
            this.mTxtHospedaje.UseSelectable = true;
            this.mTxtHospedaje.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtHospedaje.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbtCancelarHospedaje
            // 
            this.mbtCancelarHospedaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtCancelarHospedaje.BackColor = System.Drawing.Color.OliveDrab;
            this.mbtCancelarHospedaje.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbtCancelarHospedaje.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mbtCancelarHospedaje.ForeColor = System.Drawing.Color.Black;
            this.mbtCancelarHospedaje.Location = new System.Drawing.Point(431, 68);
            this.mbtCancelarHospedaje.Margin = new System.Windows.Forms.Padding(4);
            this.mbtCancelarHospedaje.Name = "mbtCancelarHospedaje";
            this.mbtCancelarHospedaje.Size = new System.Drawing.Size(138, 47);
            this.mbtCancelarHospedaje.TabIndex = 5;
            this.mbtCancelarHospedaje.Text = "Cancelar";
            this.mbtCancelarHospedaje.UseCustomBackColor = true;
            this.mbtCancelarHospedaje.UseCustomForeColor = true;
            this.mbtCancelarHospedaje.UseSelectable = true;
            this.mbtCancelarHospedaje.Click += new System.EventHandler(this.mbtCancelarHospedaje_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.06039F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.93961F));
            this.tableLayoutPanel5.Controls.Add(this.metroGridAltaHospedaje, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 266);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1148, 330);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // metroGridAltaHospedaje
            // 
            this.metroGridAltaHospedaje.AllowUserToAddRows = false;
            this.metroGridAltaHospedaje.AllowUserToDeleteRows = false;
            this.metroGridAltaHospedaje.AllowUserToResizeRows = false;
            this.metroGridAltaHospedaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGridAltaHospedaje.AutoGenerateColumns = false;
            this.metroGridAltaHospedaje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGridAltaHospedaje.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridAltaHospedaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridAltaHospedaje.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridAltaHospedaje.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAltaHospedaje.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridAltaHospedaje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dESCRIPCIONDataGridViewTextBoxColumn,
            this.iDTIPOHOSPEDAJEDataGridViewTextBoxColumn,
            this.eSTADODataGridViewTextBoxColumn});
            this.metroGridAltaHospedaje.DataSource = this.bindingSourceSelTiposHospedajes;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridAltaHospedaje.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridAltaHospedaje.EnableHeadersVisualStyles = false;
            this.metroGridAltaHospedaje.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridAltaHospedaje.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridAltaHospedaje.Location = new System.Drawing.Point(5, 4);
            this.metroGridAltaHospedaje.Margin = new System.Windows.Forms.Padding(4);
            this.metroGridAltaHospedaje.MultiSelect = false;
            this.metroGridAltaHospedaje.Name = "metroGridAltaHospedaje";
            this.metroGridAltaHospedaje.ReadOnly = true;
            this.metroGridAltaHospedaje.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAltaHospedaje.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridAltaHospedaje.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridAltaHospedaje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridAltaHospedaje.Size = new System.Drawing.Size(772, 322);
            this.metroGridAltaHospedaje.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroGridAltaHospedaje.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.mbtEliminar, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.mbtModificar, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.mbtCargarHospedaje, 0, 3);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(785, 4);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(359, 322);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // mbtEliminar
            // 
            this.mbtEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtEliminar.BackColor = System.Drawing.Color.OliveDrab;
            this.mbtEliminar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbtEliminar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mbtEliminar.ForeColor = System.Drawing.Color.Black;
            this.mbtEliminar.Location = new System.Drawing.Point(129, 73);
            this.mbtEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.mbtEliminar.Name = "mbtEliminar";
            this.mbtEliminar.Size = new System.Drawing.Size(100, 39);
            this.mbtEliminar.TabIndex = 6;
            this.mbtEliminar.Text = "Eliminar";
            this.mbtEliminar.UseCustomBackColor = true;
            this.mbtEliminar.UseCustomForeColor = true;
            this.mbtEliminar.UseSelectable = true;
            this.mbtEliminar.Click += new System.EventHandler(this.mbtEliminar_Click);
            // 
            // mbtModificar
            // 
            this.mbtModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtModificar.BackColor = System.Drawing.Color.OliveDrab;
            this.mbtModificar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbtModificar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mbtModificar.ForeColor = System.Drawing.Color.Black;
            this.mbtModificar.Location = new System.Drawing.Point(129, 11);
            this.mbtModificar.Margin = new System.Windows.Forms.Padding(4);
            this.mbtModificar.Name = "mbtModificar";
            this.mbtModificar.Size = new System.Drawing.Size(100, 39);
            this.mbtModificar.TabIndex = 7;
            this.mbtModificar.Text = "Modificar";
            this.mbtModificar.UseCustomBackColor = true;
            this.mbtModificar.UseCustomForeColor = true;
            this.mbtModificar.UseSelectable = true;
            this.mbtModificar.Click += new System.EventHandler(this.mbtModificar_Click);
            // 
            // mbtCargarHospedaje
            // 
            this.mbtCargarHospedaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtCargarHospedaje.BackColor = System.Drawing.Color.OliveDrab;
            this.mbtCargarHospedaje.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbtCargarHospedaje.ForeColor = System.Drawing.Color.Black;
            this.mbtCargarHospedaje.Location = new System.Drawing.Point(102, 229);
            this.mbtCargarHospedaje.Margin = new System.Windows.Forms.Padding(4);
            this.mbtCargarHospedaje.Name = "mbtCargarHospedaje";
            this.mbtCargarHospedaje.Size = new System.Drawing.Size(155, 50);
            this.mbtCargarHospedaje.TabIndex = 7;
            this.mbtCargarHospedaje.Text = "Cargar";
            this.mbtCargarHospedaje.UseCustomBackColor = true;
            this.mbtCargarHospedaje.UseCustomForeColor = true;
            this.mbtCargarHospedaje.UseSelectable = true;
            this.mbtCargarHospedaje.Click += new System.EventHandler(this.mbtCargarHospedaje_Click);
            // 
            // dESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.Name = "dESCRIPCIONDataGridViewTextBoxColumn";
            this.dESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDTIPOHOSPEDAJEDataGridViewTextBoxColumn
            // 
            this.iDTIPOHOSPEDAJEDataGridViewTextBoxColumn.DataPropertyName = "ID_TIPO_HOSPEDAJE";
            this.iDTIPOHOSPEDAJEDataGridViewTextBoxColumn.HeaderText = "ID_TIPO_HOSPEDAJE";
            this.iDTIPOHOSPEDAJEDataGridViewTextBoxColumn.Name = "iDTIPOHOSPEDAJEDataGridViewTextBoxColumn";
            this.iDTIPOHOSPEDAJEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDTIPOHOSPEDAJEDataGridViewTextBoxColumn.Visible = false;
            // 
            // eSTADODataGridViewTextBoxColumn
            // 
            this.eSTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.Name = "eSTADODataGridViewTextBoxColumn";
            this.eSTADODataGridViewTextBoxColumn.ReadOnly = true;
            this.eSTADODataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSourceSelTiposHospedajes
            // 
            this.bindingSourceSelTiposHospedajes.DataSource = typeof(libCounchinn.Modelo.SEL_TIPOHOSPEDAJE_Result);
            // 
            // ucAltaTipoHospedaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucAltaTipoHospedaje";
            this.Size = new System.Drawing.Size(1156, 665);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridAltaHospedaje)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceINSERT_Hosp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUDPTipoHospedaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSelTiposHospedajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel Mail;
        private MetroFramework.Controls.MetroTextBox mTxtHospedaje;
        private MetroFramework.Controls.MetroGrid metroGridAltaHospedaje;
        private System.Windows.Forms.BindingSource bindingSourceINSERT_Hosp;
        private MetroFramework.Controls.MetroButton mbtCancelarHospedaje;
        private MetroFramework.Controls.MetroButton mbtModificar;
        private MetroFramework.Controls.MetroButton mbtEliminar;
        private MetroFramework.Controls.MetroButton mbtCargarHospedaje;
        private System.Windows.Forms.BindingSource bindingSourceSelTiposHospedajes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTIPOHOSPEDAJEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceUDPTipoHospedaje;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    }
}

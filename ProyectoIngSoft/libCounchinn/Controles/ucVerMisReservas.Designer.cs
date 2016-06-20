namespace libCounchinn.Controles
{
    partial class ucVerMisReservas
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.mbAtras = new MetroFramework.Controls.MetroButton();
            this.mbVer = new MetroFramework.Controls.MetroButton();
            this.mbModificar = new MetroFramework.Controls.MetroButton();
            this.mbCancelarReserva = new MetroFramework.Controls.MetroButton();
            this.bindingSourceVer_MisReservas = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.iDRESERVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUSUARIOVIAJERODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUSUARIOHOSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPUBLICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tITULOPUBLICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHARESERVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAINICIOVIAJEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAFINVIAJEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADORESERVAVIAJERODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADORESERVAHOSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADOVIGENCIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tureservaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.respuestareservaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoreservaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucAltaPublicacion1 = new libCounchinn.Controles.ucAltaPublicacion();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVer_MisReservas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.60353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.39647F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1328, 623);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 554);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1322, 66);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 328F));
            this.tableLayoutPanel3.Controls.Add(this.mbVer, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.mbAtras, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(655, 60);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.mbCancelarReserva, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.mbModificar, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(664, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(655, 60);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // mbAtras
            // 
            this.mbAtras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbAtras.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbAtras.Location = new System.Drawing.Point(94, 14);
            this.mbAtras.Name = "mbAtras";
            this.mbAtras.Size = new System.Drawing.Size(138, 32);
            this.mbAtras.TabIndex = 0;
            this.mbAtras.Text = "Atras";
            this.mbAtras.UseSelectable = true;
            this.mbAtras.Click += new System.EventHandler(this.mbAtras_Click);
            // 
            // mbVer
            // 
            this.mbVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbVer.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbVer.Location = new System.Drawing.Point(422, 14);
            this.mbVer.Name = "mbVer";
            this.mbVer.Size = new System.Drawing.Size(138, 32);
            this.mbVer.TabIndex = 1;
            this.mbVer.Text = "Ver";
            this.mbVer.UseSelectable = true;
            this.mbVer.Click += new System.EventHandler(this.mbVer_Click);
            // 
            // mbModificar
            // 
            this.mbModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbModificar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbModificar.Location = new System.Drawing.Point(94, 14);
            this.mbModificar.Name = "mbModificar";
            this.mbModificar.Size = new System.Drawing.Size(138, 32);
            this.mbModificar.TabIndex = 1;
            this.mbModificar.Text = "Modificar";
            this.mbModificar.UseSelectable = true;
            // 
            // mbCancelarReserva
            // 
            this.mbCancelarReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbCancelarReserva.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbCancelarReserva.Location = new System.Drawing.Point(422, 14);
            this.mbCancelarReserva.Name = "mbCancelarReserva";
            this.mbCancelarReserva.Size = new System.Drawing.Size(138, 32);
            this.mbCancelarReserva.TabIndex = 3;
            this.mbCancelarReserva.Text = "Cancelar reserva";
            this.mbCancelarReserva.UseSelectable = true;
            // 
            // bindingSourceVer_MisReservas
            // 
            this.bindingSourceVer_MisReservas.DataSource = typeof(libCounchinn.Modelo.SEL_VERMISRESERVAS_Result);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroGrid1);
            this.panel1.Controls.Add(this.ucAltaPublicacion1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1322, 545);
            this.panel1.TabIndex = 1;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDRESERVADataGridViewTextBoxColumn,
            this.iDUSUARIOVIAJERODataGridViewTextBoxColumn,
            this.iDUSUARIOHOSTDataGridViewTextBoxColumn,
            this.iDPUBLICACIONDataGridViewTextBoxColumn,
            this.tITULOPUBLICACIONDataGridViewTextBoxColumn,
            this.fECHARESERVADataGridViewTextBoxColumn,
            this.fECHAINICIOVIAJEDataGridViewTextBoxColumn,
            this.fECHAFINVIAJEDataGridViewTextBoxColumn,
            this.eSTADORESERVAVIAJERODataGridViewTextBoxColumn,
            this.eSTADORESERVAHOSTDataGridViewTextBoxColumn,
            this.eSTADOVIGENCIADataGridViewTextBoxColumn,
            this.tureservaDataGridViewTextBoxColumn,
            this.respuestareservaDataGridViewTextBoxColumn,
            this.estadoreservaDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.bindingSourceVer_MisReservas;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 0);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1322, 545);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroGrid1.TabIndex = 2;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            // 
            // iDRESERVADataGridViewTextBoxColumn
            // 
            this.iDRESERVADataGridViewTextBoxColumn.DataPropertyName = "ID_RESERVA";
            this.iDRESERVADataGridViewTextBoxColumn.HeaderText = "ID_RESERVA";
            this.iDRESERVADataGridViewTextBoxColumn.Name = "iDRESERVADataGridViewTextBoxColumn";
            this.iDRESERVADataGridViewTextBoxColumn.Visible = false;
            // 
            // iDUSUARIOVIAJERODataGridViewTextBoxColumn
            // 
            this.iDUSUARIOVIAJERODataGridViewTextBoxColumn.DataPropertyName = "ID_USUARIO_VIAJERO";
            this.iDUSUARIOVIAJERODataGridViewTextBoxColumn.HeaderText = "ID_USUARIO_VIAJERO";
            this.iDUSUARIOVIAJERODataGridViewTextBoxColumn.Name = "iDUSUARIOVIAJERODataGridViewTextBoxColumn";
            this.iDUSUARIOVIAJERODataGridViewTextBoxColumn.Visible = false;
            // 
            // iDUSUARIOHOSTDataGridViewTextBoxColumn
            // 
            this.iDUSUARIOHOSTDataGridViewTextBoxColumn.DataPropertyName = "ID_USUARIO_HOST";
            this.iDUSUARIOHOSTDataGridViewTextBoxColumn.HeaderText = "ID_USUARIO_HOST";
            this.iDUSUARIOHOSTDataGridViewTextBoxColumn.Name = "iDUSUARIOHOSTDataGridViewTextBoxColumn";
            this.iDUSUARIOHOSTDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDPUBLICACIONDataGridViewTextBoxColumn
            // 
            this.iDPUBLICACIONDataGridViewTextBoxColumn.DataPropertyName = "ID_PUBLICACION";
            this.iDPUBLICACIONDataGridViewTextBoxColumn.HeaderText = "ID_PUBLICACION";
            this.iDPUBLICACIONDataGridViewTextBoxColumn.Name = "iDPUBLICACIONDataGridViewTextBoxColumn";
            this.iDPUBLICACIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // tITULOPUBLICACIONDataGridViewTextBoxColumn
            // 
            this.tITULOPUBLICACIONDataGridViewTextBoxColumn.DataPropertyName = "TITULO_PUBLICACION";
            this.tITULOPUBLICACIONDataGridViewTextBoxColumn.HeaderText = "TITULO DE PUBLICACION";
            this.tITULOPUBLICACIONDataGridViewTextBoxColumn.Name = "tITULOPUBLICACIONDataGridViewTextBoxColumn";
            // 
            // fECHARESERVADataGridViewTextBoxColumn
            // 
            this.fECHARESERVADataGridViewTextBoxColumn.DataPropertyName = "FECHA_RESERVA";
            this.fECHARESERVADataGridViewTextBoxColumn.HeaderText = "FECHA RESERVA";
            this.fECHARESERVADataGridViewTextBoxColumn.Name = "fECHARESERVADataGridViewTextBoxColumn";
            // 
            // fECHAINICIOVIAJEDataGridViewTextBoxColumn
            // 
            this.fECHAINICIOVIAJEDataGridViewTextBoxColumn.DataPropertyName = "FECHA_INICIO_VIAJE";
            this.fECHAINICIOVIAJEDataGridViewTextBoxColumn.HeaderText = "FECHA DE INICIO";
            this.fECHAINICIOVIAJEDataGridViewTextBoxColumn.Name = "fECHAINICIOVIAJEDataGridViewTextBoxColumn";
            // 
            // fECHAFINVIAJEDataGridViewTextBoxColumn
            // 
            this.fECHAFINVIAJEDataGridViewTextBoxColumn.DataPropertyName = "FECHA_FIN_VIAJE";
            this.fECHAFINVIAJEDataGridViewTextBoxColumn.HeaderText = "FECHA DE FIN";
            this.fECHAFINVIAJEDataGridViewTextBoxColumn.Name = "fECHAFINVIAJEDataGridViewTextBoxColumn";
            // 
            // eSTADORESERVAVIAJERODataGridViewTextBoxColumn
            // 
            this.eSTADORESERVAVIAJERODataGridViewTextBoxColumn.DataPropertyName = "ESTADO_RESERVA_VIAJERO";
            this.eSTADORESERVAVIAJERODataGridViewTextBoxColumn.HeaderText = "ESTADO_RESERVA_VIAJERO";
            this.eSTADORESERVAVIAJERODataGridViewTextBoxColumn.Name = "eSTADORESERVAVIAJERODataGridViewTextBoxColumn";
            this.eSTADORESERVAVIAJERODataGridViewTextBoxColumn.Visible = false;
            // 
            // eSTADORESERVAHOSTDataGridViewTextBoxColumn
            // 
            this.eSTADORESERVAHOSTDataGridViewTextBoxColumn.DataPropertyName = "ESTADO_RESERVA_HOST";
            this.eSTADORESERVAHOSTDataGridViewTextBoxColumn.HeaderText = "ESTADO_RESERVA_HOST";
            this.eSTADORESERVAHOSTDataGridViewTextBoxColumn.Name = "eSTADORESERVAHOSTDataGridViewTextBoxColumn";
            this.eSTADORESERVAHOSTDataGridViewTextBoxColumn.Visible = false;
            // 
            // eSTADOVIGENCIADataGridViewTextBoxColumn
            // 
            this.eSTADOVIGENCIADataGridViewTextBoxColumn.DataPropertyName = "ESTADO_VIGENCIA";
            this.eSTADOVIGENCIADataGridViewTextBoxColumn.HeaderText = "ESTADO_VIGENCIA";
            this.eSTADOVIGENCIADataGridViewTextBoxColumn.Name = "eSTADOVIGENCIADataGridViewTextBoxColumn";
            this.eSTADOVIGENCIADataGridViewTextBoxColumn.Visible = false;
            // 
            // tureservaDataGridViewTextBoxColumn
            // 
            this.tureservaDataGridViewTextBoxColumn.DataPropertyName = "Tu_reserva";
            this.tureservaDataGridViewTextBoxColumn.HeaderText = "TU RESERVA";
            this.tureservaDataGridViewTextBoxColumn.Name = "tureservaDataGridViewTextBoxColumn";
            // 
            // respuestareservaDataGridViewTextBoxColumn
            // 
            this.respuestareservaDataGridViewTextBoxColumn.DataPropertyName = "Respuesta_reserva";
            this.respuestareservaDataGridViewTextBoxColumn.HeaderText = "RESPUESTA DE RESERVA";
            this.respuestareservaDataGridViewTextBoxColumn.Name = "respuestareservaDataGridViewTextBoxColumn";
            // 
            // estadoreservaDataGridViewTextBoxColumn
            // 
            this.estadoreservaDataGridViewTextBoxColumn.DataPropertyName = "Estado_reserva";
            this.estadoreservaDataGridViewTextBoxColumn.HeaderText = "ESTADO RESERVA";
            this.estadoreservaDataGridViewTextBoxColumn.Name = "estadoreservaDataGridViewTextBoxColumn";
            // 
            // ucAltaPublicacion1
            // 
            this.ucAltaPublicacion1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ucAltaPublicacion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAltaPublicacion1.Location = new System.Drawing.Point(0, 0);
            this.ucAltaPublicacion1.Name = "ucAltaPublicacion1";
            this.ucAltaPublicacion1.Size = new System.Drawing.Size(1322, 545);
            this.ucAltaPublicacion1.TabIndex = 3;
            this.ucAltaPublicacion1.UseSelectable = true;
            // 
            // ucVerMisReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucVerMisReservas";
            this.Size = new System.Drawing.Size(1328, 623);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVer_MisReservas)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroButton mbVer;
        private MetroFramework.Controls.MetroButton mbAtras;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MetroFramework.Controls.MetroButton mbModificar;
        private System.Windows.Forms.BindingSource bindingSourceVer_MisReservas;
        private MetroFramework.Controls.MetroButton mbCancelarReserva;
        private System.Windows.Forms.Panel panel1;
        private ucAltaPublicacion ucAltaPublicacion1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoreservaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn respuestareservaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tureservaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADOVIGENCIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADORESERVAHOSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADORESERVAVIAJERODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAFINVIAJEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAINICIOVIAJEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHARESERVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tITULOPUBLICACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPUBLICACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUSUARIOHOSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUSUARIOVIAJERODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRESERVADataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroGrid metroGrid1;
    }
}

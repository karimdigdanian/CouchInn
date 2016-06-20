namespace libCounchinn.Controles
{
    partial class ucVerTipoHospedaje
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
            this.mbtAceptar = new MetroFramework.Controls.MetroButton();
            this.gridVerHospedajes = new MetroFramework.Controls.MetroGrid();
            this.dESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSelHospedaje = new System.Windows.Forms.BindingSource(this.components);
            this.sELTIPOHOSPEDAJEResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVerHospedajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSelHospedaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sELTIPOHOSPEDAJEResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.mbtAceptar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gridVerHospedajes, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.76052F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.23948F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(581, 309);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // mbtAceptar
            // 
            this.mbtAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtAceptar.BackColor = System.Drawing.Color.OliveDrab;
            this.mbtAceptar.Location = new System.Drawing.Point(253, 275);
            this.mbtAceptar.Name = "mbtAceptar";
            this.mbtAceptar.Size = new System.Drawing.Size(75, 23);
            this.mbtAceptar.TabIndex = 1;
            this.mbtAceptar.Text = "Aceptar";
            this.mbtAceptar.UseCustomBackColor = true;
            this.mbtAceptar.UseCustomForeColor = true;
            this.mbtAceptar.UseSelectable = true;
            this.mbtAceptar.Click += new System.EventHandler(this.mbtAceptar_Click);
            // 
            // gridVerHospedajes
            // 
            this.gridVerHospedajes.AllowUserToAddRows = false;
            this.gridVerHospedajes.AllowUserToDeleteRows = false;
            this.gridVerHospedajes.AllowUserToResizeRows = false;
            this.gridVerHospedajes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridVerHospedajes.AutoGenerateColumns = false;
            this.gridVerHospedajes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridVerHospedajes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridVerHospedajes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridVerHospedajes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridVerHospedajes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridVerHospedajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVerHospedajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dESCRIPCIONDataGridViewTextBoxColumn});
            this.gridVerHospedajes.DataSource = this.bindingSelHospedaje;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridVerHospedajes.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridVerHospedajes.EnableHeadersVisualStyles = false;
            this.gridVerHospedajes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridVerHospedajes.GridColor = System.Drawing.Color.OliveDrab;
            this.gridVerHospedajes.Location = new System.Drawing.Point(63, 14);
            this.gridVerHospedajes.Name = "gridVerHospedajes";
            this.gridVerHospedajes.ReadOnly = true;
            this.gridVerHospedajes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridVerHospedajes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridVerHospedajes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridVerHospedajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVerHospedajes.Size = new System.Drawing.Size(455, 237);
            this.gridVerHospedajes.TabIndex = 2;
            this.gridVerHospedajes.UseCustomBackColor = true;
            this.gridVerHospedajes.UseCustomForeColor = true;
            // 
            // dESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.Name = "dESCRIPCIONDataGridViewTextBoxColumn";
            this.dESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSelHospedaje
            // 
            this.bindingSelHospedaje.DataSource = typeof(libCounchinn.Modelo.SEL_TIPOHOSPEDAJE_Result);
            // 
            // sELTIPOHOSPEDAJEResultBindingSource
            // 
            this.sELTIPOHOSPEDAJEResultBindingSource.DataSource = typeof(libCounchinn.Modelo.SEL_TIPOHOSPEDAJE_Result);
            // 
            // ucVerTipoHospedaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucVerTipoHospedaje";
            this.Size = new System.Drawing.Size(581, 309);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVerHospedajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSelHospedaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sELTIPOHOSPEDAJEResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroButton mbtAceptar;
        private System.Windows.Forms.BindingSource bindingSelHospedaje;
        private MetroFramework.Controls.MetroGrid gridVerHospedajes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sELTIPOHOSPEDAJEResultBindingSource;
    }
}

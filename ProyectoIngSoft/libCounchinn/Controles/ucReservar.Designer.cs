namespace libCounchinn.Controles
{
    partial class ucReservar
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
            this.mLabelReservar = new MetroFramework.Controls.MetroLabel();
            this.mLabelReservado = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.mLabelDesde = new MetroFramework.Controls.MetroLabel();
            this.mLabelHasta = new MetroFramework.Controls.MetroLabel();
            this.mTBDesde = new MetroFramework.Controls.MetroTextBox();
            this.mTBHasta = new MetroFramework.Controls.MetroTextBox();
            this.mBtnReservar = new MetroFramework.Controls.MetroButton();
            this.mGridReservas = new MetroFramework.Controls.MetroGrid();
            this.bindingInsReserva = new System.Windows.Forms.BindingSource(this.components);
            this.fECHAINICIOVIAJEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAFINVIAJEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSelReservas = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mGridReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingInsReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSelReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.mLabelReservar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mLabelReservado, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.mGridReservas, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.032033F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.81506F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.43988F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.48974F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.158358F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.95601F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 341);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mLabelReservar
            // 
            this.mLabelReservar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mLabelReservar.AutoSize = true;
            this.mLabelReservar.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLabelReservar.Location = new System.Drawing.Point(3, 1);
            this.mLabelReservar.Name = "mLabelReservar";
            this.mLabelReservar.Size = new System.Drawing.Size(138, 25);
            this.mLabelReservar.TabIndex = 0;
            this.mLabelReservar.Text = "Reservar estadía:";
            // 
            // mLabelReservado
            // 
            this.mLabelReservado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mLabelReservado.AutoSize = true;
            this.mLabelReservado.Location = new System.Drawing.Point(3, 29);
            this.mLabelReservado.Name = "mLabelReservado";
            this.mLabelReservado.Size = new System.Drawing.Size(125, 19);
            this.mLabelReservado.TabIndex = 1;
            this.mLabelReservado.Text = "Periodos ocupados:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.83673F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.02041F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.04082F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.69388F));
            this.tableLayoutPanel2.Controls.Add(this.mLabelDesde, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.mLabelHasta, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.mTBDesde, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.mTBHasta, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.mBtnReservar, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 225);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(490, 40);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // mLabelDesde
            // 
            this.mLabelDesde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mLabelDesde.AutoSize = true;
            this.mLabelDesde.Location = new System.Drawing.Point(3, 10);
            this.mLabelDesde.Name = "mLabelDesde";
            this.mLabelDesde.Size = new System.Drawing.Size(101, 19);
            this.mLabelDesde.TabIndex = 0;
            this.mLabelDesde.Text = "Reservar desde:";
            // 
            // mLabelHasta
            // 
            this.mLabelHasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mLabelHasta.AutoSize = true;
            this.mLabelHasta.Location = new System.Drawing.Point(214, 10);
            this.mLabelHasta.Name = "mLabelHasta";
            this.mLabelHasta.Size = new System.Drawing.Size(42, 19);
            this.mLabelHasta.TabIndex = 1;
            this.mLabelHasta.Text = "hasta:";
            // 
            // mTBDesde
            // 
            this.mTBDesde.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.mTBDesde.CustomButton.Image = null;
            this.mTBDesde.CustomButton.Location = new System.Drawing.Point(75, 1);
            this.mTBDesde.CustomButton.Name = "";
            this.mTBDesde.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTBDesde.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTBDesde.CustomButton.TabIndex = 1;
            this.mTBDesde.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTBDesde.CustomButton.UseSelectable = true;
            this.mTBDesde.CustomButton.Visible = false;
            this.mTBDesde.Lines = new string[0];
            this.mTBDesde.Location = new System.Drawing.Point(110, 8);
            this.mTBDesde.MaxLength = 32767;
            this.mTBDesde.Name = "mTBDesde";
            this.mTBDesde.PasswordChar = '\0';
            this.mTBDesde.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTBDesde.SelectedText = "";
            this.mTBDesde.SelectionLength = 0;
            this.mTBDesde.SelectionStart = 0;
            this.mTBDesde.Size = new System.Drawing.Size(97, 23);
            this.mTBDesde.TabIndex = 3;
            this.mTBDesde.UseSelectable = true;
            this.mTBDesde.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTBDesde.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mTBHasta
            // 
            this.mTBHasta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.mTBHasta.CustomButton.Image = null;
            this.mTBHasta.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.mTBHasta.CustomButton.Name = "";
            this.mTBHasta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTBHasta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTBHasta.CustomButton.TabIndex = 1;
            this.mTBHasta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTBHasta.CustomButton.UseSelectable = true;
            this.mTBHasta.CustomButton.Visible = false;
            this.mTBHasta.Lines = new string[0];
            this.mTBHasta.Location = new System.Drawing.Point(263, 8);
            this.mTBHasta.MaxLength = 32767;
            this.mTBHasta.Name = "mTBHasta";
            this.mTBHasta.PasswordChar = '\0';
            this.mTBHasta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTBHasta.SelectedText = "";
            this.mTBHasta.SelectionLength = 0;
            this.mTBHasta.SelectionStart = 0;
            this.mTBHasta.Size = new System.Drawing.Size(95, 23);
            this.mTBHasta.TabIndex = 4;
            this.mTBHasta.UseSelectable = true;
            this.mTBHasta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTBHasta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mBtnReservar
            // 
            this.mBtnReservar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mBtnReservar.BackColor = System.Drawing.Color.OliveDrab;
            this.mBtnReservar.ForeColor = System.Drawing.Color.OliveDrab;
            this.mBtnReservar.Location = new System.Drawing.Point(371, 8);
            this.mBtnReservar.Name = "mBtnReservar";
            this.mBtnReservar.Size = new System.Drawing.Size(75, 23);
            this.mBtnReservar.TabIndex = 5;
            this.mBtnReservar.Text = "Reservar";
            this.mBtnReservar.UseCustomBackColor = true;
            this.mBtnReservar.UseSelectable = true;
            this.mBtnReservar.Click += new System.EventHandler(this.mBtnReservar_Click);
            // 
            // mGridReservas
            // 
            this.mGridReservas.AllowUserToResizeRows = false;
            this.mGridReservas.AutoGenerateColumns = false;
            this.mGridReservas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridReservas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mGridReservas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mGridReservas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mGridReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mGridReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fECHAINICIOVIAJEDataGridViewTextBoxColumn,
            this.fECHAFINVIAJEDataGridViewTextBoxColumn});
            this.mGridReservas.DataSource = this.bindingSelReservas;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGridReservas.DefaultCellStyle = dataGridViewCellStyle2;
            this.mGridReservas.EnableHeadersVisualStyles = false;
            this.mGridReservas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGridReservas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridReservas.Location = new System.Drawing.Point(3, 53);
            this.mGridReservas.Name = "mGridReservas";
            this.mGridReservas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridReservas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mGridReservas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGridReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGridReservas.Size = new System.Drawing.Size(344, 154);
            this.mGridReservas.Style = MetroFramework.MetroColorStyle.Lime;
            this.mGridReservas.TabIndex = 2;
            // 
            // fECHAINICIOVIAJEDataGridViewTextBoxColumn
            // 
            this.fECHAINICIOVIAJEDataGridViewTextBoxColumn.DataPropertyName = "FECHA_INICIO_VIAJE";
            this.fECHAINICIOVIAJEDataGridViewTextBoxColumn.HeaderText = "Fecha de inicio";
            this.fECHAINICIOVIAJEDataGridViewTextBoxColumn.Name = "fECHAINICIOVIAJEDataGridViewTextBoxColumn";
            this.fECHAINICIOVIAJEDataGridViewTextBoxColumn.Width = 150;
            // 
            // fECHAFINVIAJEDataGridViewTextBoxColumn
            // 
            this.fECHAFINVIAJEDataGridViewTextBoxColumn.DataPropertyName = "FECHA_FIN_VIAJE";
            this.fECHAFINVIAJEDataGridViewTextBoxColumn.HeaderText = "Fecha de fin";
            this.fECHAFINVIAJEDataGridViewTextBoxColumn.Name = "fECHAFINVIAJEDataGridViewTextBoxColumn";
            this.fECHAFINVIAJEDataGridViewTextBoxColumn.Width = 150;
            // 
            // bindingSelReservas
            // 
            this.bindingSelReservas.DataSource = typeof(libCounchinn.Modelo.SEL_RESERVAS_Result);
            // 
            // ucReservar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "ucReservar";
            this.Size = new System.Drawing.Size(544, 341);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mGridReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingInsReserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSelReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel mLabelReservar;
        private MetroFramework.Controls.MetroLabel mLabelReservado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroTextBox mTBHasta;
        private MetroFramework.Controls.MetroLabel mLabelDesde;
        private MetroFramework.Controls.MetroLabel mLabelHasta;
        private MetroFramework.Controls.MetroTextBox mTBDesde;
        private MetroFramework.Controls.MetroButton mBtnReservar;
        private MetroFramework.Controls.MetroGrid mGridReservas;
        private System.Windows.Forms.BindingSource bindingSelReservas;
        private System.Windows.Forms.BindingSource bindingInsReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAINICIOVIAJEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAFINVIAJEDataGridViewTextBoxColumn;
    }
}

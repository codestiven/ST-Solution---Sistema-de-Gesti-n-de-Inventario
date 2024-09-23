namespace Práctica_de_acceso_a_Datos.controles
{
    partial class productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gestion_de_InventarioDataSet = new Práctica_de_acceso_a_Datos.Gestion_de_InventarioDataSet();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new Práctica_de_acceso_a_Datos.Gestion_de_InventarioDataSetTableAdapters.ProductosTableAdapter();
            this.buscar = new Guna.UI2.WinForms.Guna2Button();
            this.Modificar = new Guna.UI2.WinForms.Guna2Button();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.productosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_de_InventarioDataSet1 = new Práctica_de_acceso_a_Datos.Gestion_de_InventarioDataSet1();
            this.productosTableAdapter1 = new Práctica_de_acceso_a_Datos.Gestion_de_InventarioDataSet1TableAdapters.ProductosTableAdapter();
            this.fillByToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.actualizarToolStrip = new System.Windows.Forms.ToolStrip();
            this.actualizarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.productosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_de_InventarioDataSet4 = new Práctica_de_acceso_a_Datos.Gestion_de_InventarioDataSet4();
            this.productosTableAdapter2 = new Práctica_de_acceso_a_Datos.Gestion_de_InventarioDataSet4TableAdapters.ProductosTableAdapter();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_de_InventarioDataSet6 = new Práctica_de_acceso_a_Datos.Gestion_de_InventarioDataSet6();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.actualizarToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.actualizarToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.productosTableAdapter3 = new Práctica_de_acceso_a_Datos.Gestion_de_InventarioDataSet6TableAdapters.ProductosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_de_InventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_de_InventarioDataSet1)).BeginInit();
            this.fillByToolStrip1.SuspendLayout();
            this.actualizarToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_de_InventarioDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_de_InventarioDataSet6)).BeginInit();
            this.actualizarToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gestion_de_InventarioDataSet
            // 
            this.gestion_de_InventarioDataSet.DataSetName = "Gestion_de_InventarioDataSet";
            this.gestion_de_InventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.gestion_de_InventarioDataSet;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // buscar
            // 
            this.buscar.BorderRadius = 10;
            this.buscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buscar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.ForeColor = System.Drawing.Color.White;
            this.buscar.Location = new System.Drawing.Point(423, 112);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(196, 45);
            this.buscar.TabIndex = 2;
            this.buscar.Text = "Buscar";
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // Modificar
            // 
            this.Modificar.BorderRadius = 10;
            this.Modificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Modificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Modificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Modificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Modificar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar.ForeColor = System.Drawing.Color.White;
            this.Modificar.Location = new System.Drawing.Point(794, 112);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(193, 45);
            this.Modificar.TabIndex = 3;
            this.Modificar.Text = "Modificar";
            this.Modificar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton,
            this.toolStripButton1});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1119, 25);
            this.fillByToolStrip.TabIndex = 4;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // productosBindingSource1
            // 
            this.productosBindingSource1.DataMember = "Productos";
            this.productosBindingSource1.DataSource = this.gestion_de_InventarioDataSet1;
            // 
            // gestion_de_InventarioDataSet1
            // 
            this.gestion_de_InventarioDataSet1.DataSetName = "Gestion_de_InventarioDataSet1";
            this.gestion_de_InventarioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosTableAdapter1
            // 
            this.productosTableAdapter1.ClearBeforeFill = true;
            // 
            // fillByToolStrip1
            // 
            this.fillByToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton1});
            this.fillByToolStrip1.Location = new System.Drawing.Point(0, 25);
            this.fillByToolStrip1.Name = "fillByToolStrip1";
            this.fillByToolStrip1.Size = new System.Drawing.Size(1119, 25);
            this.fillByToolStrip1.TabIndex = 6;
            this.fillByToolStrip1.Text = "fillByToolStrip1";
            // 
            // fillByToolStripButton1
            // 
            this.fillByToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton1.Name = "fillByToolStripButton1";
            this.fillByToolStripButton1.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton1.Text = "FillBy";
            this.fillByToolStripButton1.Click += new System.EventHandler(this.fillByToolStripButton1_Click);
            // 
            // actualizarToolStrip
            // 
            this.actualizarToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarToolStripButton});
            this.actualizarToolStrip.Location = new System.Drawing.Point(0, 50);
            this.actualizarToolStrip.Name = "actualizarToolStrip";
            this.actualizarToolStrip.Size = new System.Drawing.Size(1119, 25);
            this.actualizarToolStrip.TabIndex = 7;
            this.actualizarToolStrip.Text = "actualizarToolStrip";
            // 
            // actualizarToolStripButton
            // 
            this.actualizarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.actualizarToolStripButton.Name = "actualizarToolStripButton";
            this.actualizarToolStripButton.Size = new System.Drawing.Size(61, 22);
            this.actualizarToolStripButton.Text = "actualizar";
            this.actualizarToolStripButton.Click += new System.EventHandler(this.actualizarToolStripButton_Click);
            // 
            // productosBindingSource2
            // 
            this.productosBindingSource2.DataMember = "Productos";
            this.productosBindingSource2.DataSource = this.gestion_de_InventarioDataSet4;
            // 
            // gestion_de_InventarioDataSet4
            // 
            this.gestion_de_InventarioDataSet4.DataSetName = "Gestion_de_InventarioDataSet4";
            this.gestion_de_InventarioDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosTableAdapter2
            // 
            this.productosTableAdapter2.ClearBeforeFill = true;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 27;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.productosBindingSource3;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(67, 199);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.Size = new System.Drawing.Size(920, 331);
            this.guna2DataGridView1.TabIndex = 9;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 27;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // productosBindingSource3
            // 
            this.productosBindingSource3.DataMember = "Productos";
            this.productosBindingSource3.DataSource = this.gestion_de_InventarioDataSet6;
            // 
            // gestion_de_InventarioDataSet6
            // 
            this.gestion_de_InventarioDataSet6.DataSetName = "Gestion_de_InventarioDataSet6";
            this.gestion_de_InventarioDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(67, 112);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(196, 45);
            this.guna2Button1.TabIndex = 10;
            this.guna2Button1.Text = "Agregar";
            this.guna2Button1.Click += new System.EventHandler(this.Agregar_producto_Click);
            // 
            // actualizarToolStrip1
            // 
            this.actualizarToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.actualizarToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarToolStripButton1,
            this.toolStripButton2});
            this.actualizarToolStrip1.Location = new System.Drawing.Point(0, 75);
            this.actualizarToolStrip1.Name = "actualizarToolStrip1";
            this.actualizarToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.actualizarToolStrip1.Size = new System.Drawing.Size(1119, 25);
            this.actualizarToolStrip1.TabIndex = 11;
            this.actualizarToolStrip1.Text = "actualizarToolStrip1";
            // 
            // actualizarToolStripButton1
            // 
            this.actualizarToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.actualizarToolStripButton1.Name = "actualizarToolStripButton1";
            this.actualizarToolStripButton1.Size = new System.Drawing.Size(63, 22);
            this.actualizarToolStripButton1.Text = "Actualizar";
            this.actualizarToolStripButton1.Click += new System.EventHandler(this.actualizarToolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // productosTableAdapter3
            // 
            this.productosTableAdapter3.ClearBeforeFill = true;
            // 
            // productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.actualizarToolStrip1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.actualizarToolStrip);
            this.Controls.Add(this.fillByToolStrip1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.buscar);
            this.Name = "productos";
            this.Size = new System.Drawing.Size(1119, 566);
            this.Load += new System.EventHandler(this.productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestion_de_InventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_de_InventarioDataSet1)).EndInit();
            this.fillByToolStrip1.ResumeLayout(false);
            this.fillByToolStrip1.PerformLayout();
            this.actualizarToolStrip.ResumeLayout(false);
            this.actualizarToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_de_InventarioDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_de_InventarioDataSet6)).EndInit();
            this.actualizarToolStrip1.ResumeLayout(false);
            this.actualizarToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource productosBindingSource;
        private Gestion_de_InventarioDataSet gestion_de_InventarioDataSet;
        private Gestion_de_InventarioDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private Guna.UI2.WinForms.Guna2Button buscar;
        private Guna.UI2.WinForms.Guna2Button Modificar;
        private System.Windows.Forms.BindingSource productosBindingSource1;
        private Gestion_de_InventarioDataSet1 gestion_de_InventarioDataSet1;
        private Gestion_de_InventarioDataSet1TableAdapters.ProductosTableAdapter productosTableAdapter1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingSource productosBindingSource2;
        private Gestion_de_InventarioDataSet4 gestion_de_InventarioDataSet4;
        private Gestion_de_InventarioDataSet4TableAdapters.ProductosTableAdapter productosTableAdapter2;
        private System.Windows.Forms.ToolStrip fillByToolStrip1;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton1;
        private System.Windows.Forms.ToolStrip actualizarToolStrip;
        private System.Windows.Forms.ToolStripButton actualizarToolStripButton;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productosBindingSource3;
        private Gestion_de_InventarioDataSet6 gestion_de_InventarioDataSet6;
        private Gestion_de_InventarioDataSet6TableAdapters.ProductosTableAdapter productosTableAdapter3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.ToolStrip actualizarToolStrip1;
        private System.Windows.Forms.ToolStripButton actualizarToolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

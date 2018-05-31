namespace GE
{
    partial class MenuForm
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
            this.components = new System.ComponentModel.Container();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCargaOrdenes = new System.Windows.Forms.Button();
            this.btnRepartirOrden = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.codigoServiciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoServiciosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Códigos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoServiciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoServiciosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(29, 63);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(151, 43);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Cargar Agentes";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCargaOrdenes
            // 
            this.btnCargaOrdenes.Location = new System.Drawing.Point(207, 60);
            this.btnCargaOrdenes.Name = "btnCargaOrdenes";
            this.btnCargaOrdenes.Size = new System.Drawing.Size(151, 46);
            this.btnCargaOrdenes.TabIndex = 5;
            this.btnCargaOrdenes.Text = "Cargar Órdenes";
            this.btnCargaOrdenes.UseVisualStyleBackColor = true;
            this.btnCargaOrdenes.Click += new System.EventHandler(this.btnCargaOrdenes_Click);
            // 
            // btnRepartirOrden
            // 
            this.btnRepartirOrden.Location = new System.Drawing.Point(377, 60);
            this.btnRepartirOrden.Name = "btnRepartirOrden";
            this.btnRepartirOrden.Size = new System.Drawing.Size(151, 43);
            this.btnRepartirOrden.TabIndex = 7;
            this.btnRepartirOrden.Text = "Repartir";
            this.btnRepartirOrden.UseVisualStyleBackColor = true;
            this.btnRepartirOrden.Click += new System.EventHandler(this.btnRepartirOrden_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.Códigos});
            this.dataGridView1.DataSource = this.agenteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(499, 525);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.DataSource = this.agenteBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(542, 123);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(698, 525);
            this.dataGridView2.TabIndex = 10;
            // 
            // codigoServiciosBindingSource
            // 
            this.codigoServiciosBindingSource.DataMember = "Codigo_Servicios";
            this.codigoServiciosBindingSource.DataSource = this.agenteBindingSource;
            // 
            // codigoServiciosBindingSource1
            // 
            this.codigoServiciosBindingSource1.DataMember = "Codigo_Servicios";
            this.codigoServiciosBindingSource1.DataSource = this.agenteBindingSource;
            // 
            // Códigos
            // 
            this.Códigos.DataPropertyName = "Nombre";
            this.Códigos.HeaderText = "Códigos de Servicios";
            this.Códigos.Name = "Códigos";
            this.Códigos.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // agenteBindingSource
            // 
            this.agenteBindingSource.DataSource = typeof(GE.Agente);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRepartirOrden);
            this.Controls.Add(this.btnCargaOrdenes);
            this.Controls.Add(this.btnAgregar);
            this.Name = "MenuForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoServiciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoServiciosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCargaOrdenes;
        private System.Windows.Forms.Button btnRepartirOrden;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource agenteBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource codigoServiciosBindingSource;
        private System.Windows.Forms.BindingSource codigoServiciosBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Códigos;
    }
}


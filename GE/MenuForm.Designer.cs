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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCargaOrdenes = new System.Windows.Forms.Button();
            this.btnRepartirOrden = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Códigos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.codigoServiciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoServiciosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bttnRepartir = new System.Windows.Forms.Button();
            this.bttnAgeOrd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoServiciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoServiciosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btnAgregar.Location = new System.Drawing.Point(66, 74);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(151, 43);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Cargar Agentes";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCargaOrdenes
            // 
            this.btnCargaOrdenes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCargaOrdenes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCargaOrdenes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnCargaOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargaOrdenes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaOrdenes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btnCargaOrdenes.Location = new System.Drawing.Point(223, 74);
            this.btnCargaOrdenes.Name = "btnCargaOrdenes";
            this.btnCargaOrdenes.Size = new System.Drawing.Size(151, 43);
            this.btnCargaOrdenes.TabIndex = 5;
            this.btnCargaOrdenes.Text = "Cargar Órdenes";
            this.btnCargaOrdenes.UseVisualStyleBackColor = true;
            this.btnCargaOrdenes.Click += new System.EventHandler(this.btnCargaOrdenes_Click);
            // 
            // btnRepartirOrden
            // 
            this.btnRepartirOrden.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRepartirOrden.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepartirOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btnRepartirOrden.Location = new System.Drawing.Point(380, 74);
            this.btnRepartirOrden.Name = "btnRepartirOrden";
            this.btnRepartirOrden.Size = new System.Drawing.Size(148, 43);
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
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.Códigos});
            this.dataGridView1.DataSource = this.agenteBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Location = new System.Drawing.Point(66, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(462, 525);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Códigos
            // 
            this.Códigos.DataPropertyName = "Nombre";
            this.Códigos.HeaderText = "Códigos de Servicios";
            this.Códigos.Name = "Códigos";
            this.Códigos.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.clienteDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.ordenBindingSource;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.Location = new System.Drawing.Point(542, 123);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(662, 525);
            this.dataGridView2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.bttnAgeOrd);
            this.panel1.Controls.Add(this.bttnRepartir);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 67);
            this.panel1.TabIndex = 11;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.White;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.labelTitle.Location = new System.Drawing.Point(114, 22);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(155, 22);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "General Electric";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // bttnRepartir
            // 
            this.bttnRepartir.BackColor = System.Drawing.SystemColors.Window;
            this.bttnRepartir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttnRepartir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnRepartir.FlatAppearance.BorderSize = 0;
            this.bttnRepartir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.bttnRepartir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.bttnRepartir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnRepartir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnRepartir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.bttnRepartir.Location = new System.Drawing.Point(967, 8);
            this.bttnRepartir.Name = "bttnRepartir";
            this.bttnRepartir.Size = new System.Drawing.Size(138, 50);
            this.bttnRepartir.TabIndex = 3;
            this.bttnRepartir.Text = "Repartir";
            this.bttnRepartir.UseVisualStyleBackColor = false;
            // 
            // bttnAgeOrd
            // 
            this.bttnAgeOrd.BackColor = System.Drawing.SystemColors.Window;
            this.bttnAgeOrd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttnAgeOrd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnAgeOrd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.bttnAgeOrd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.bttnAgeOrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAgeOrd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAgeOrd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.bttnAgeOrd.Location = new System.Drawing.Point(778, 8);
            this.bttnAgeOrd.Name = "bttnAgeOrd";
            this.bttnAgeOrd.Size = new System.Drawing.Size(183, 50);
            this.bttnAgeOrd.TabIndex = 4;
            this.bttnAgeOrd.Text = "Agentes y Órdenes";
            this.bttnAgeOrd.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.button1.Location = new System.Drawing.Point(1101, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // ordenBindingSource
            // 
            this.ordenBindingSource.DataSource = typeof(GE.Orden);
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
            // agenteBindingSource
            // 
            this.agenteBindingSource.DataSource = typeof(GE.Agente);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRepartirOrden);
            this.Controls.Add(this.btnCargaOrdenes);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoServiciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoServiciosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource codigoServiciosBindingSource;
        private System.Windows.Forms.BindingSource codigoServiciosBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Códigos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ordenBindingSource;
        private System.Windows.Forms.Button bttnAgeOrd;
        private System.Windows.Forms.Button bttnRepartir;
        private System.Windows.Forms.Button button1;
    }
}


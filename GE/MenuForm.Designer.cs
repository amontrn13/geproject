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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.btnCargarAgente = new System.Windows.Forms.Button();
            this.btnCargaOrdenes = new System.Windows.Forms.Button();
            this.btnRepartirOrden = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.bttnAgeOrd = new System.Windows.Forms.Button();
            this.bttnRepartir = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMostrarAgente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarAgente
            // 
            this.btnCargarAgente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCargarAgente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCargarAgente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnCargarAgente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargarAgente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarAgente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btnCargarAgente.Location = new System.Drawing.Point(66, 74);
            this.btnCargarAgente.Name = "btnCargarAgente";
            this.btnCargarAgente.Size = new System.Drawing.Size(143, 43);
            this.btnCargarAgente.TabIndex = 1;
            this.btnCargarAgente.Text = "Cargar Agentes";
            this.btnCargarAgente.UseVisualStyleBackColor = true;
            this.btnCargarAgente.Click += new System.EventHandler(this.btnCargarAgente_Click);
            // 
            // btnCargaOrdenes
            // 
            this.btnCargaOrdenes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCargaOrdenes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCargaOrdenes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnCargaOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargaOrdenes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaOrdenes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btnCargaOrdenes.Location = new System.Drawing.Point(542, 74);
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
            this.btnRepartirOrden.Location = new System.Drawing.Point(374, 74);
            this.btnRepartirOrden.Name = "btnRepartirOrden";
            this.btnRepartirOrden.Size = new System.Drawing.Size(140, 43);
            this.btnRepartirOrden.TabIndex = 7;
            this.btnRepartirOrden.Text = "Repartir";
            this.btnRepartirOrden.UseVisualStyleBackColor = true;
            this.btnRepartirOrden.Click += new System.EventHandler(this.btnRepartirOrden_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.Location = new System.Drawing.Point(542, 123);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(698, 525);
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
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.White;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.labelTitle.Location = new System.Drawing.Point(123, 22);
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
            this.pictureBox1.Location = new System.Drawing.Point(37, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnMostrarAgente
            // 
            this.btnMostrarAgente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMostrarAgente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMostrarAgente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnMostrarAgente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrarAgente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarAgente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btnMostrarAgente.Location = new System.Drawing.Point(220, 74);
            this.btnMostrarAgente.Name = "btnMostrarAgente";
            this.btnMostrarAgente.Size = new System.Drawing.Size(143, 43);
            this.btnMostrarAgente.TabIndex = 12;
            this.btnMostrarAgente.Text = "Mostrar Agentes";
            this.btnMostrarAgente.UseVisualStyleBackColor = true;
            this.btnMostrarAgente.Click += new System.EventHandler(this.btnMostrarAgente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Location = new System.Drawing.Point(66, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 525);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMostrarAgente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnRepartirOrden);
            this.Controls.Add(this.btnCargaOrdenes);
            this.Controls.Add(this.btnCargarAgente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCargarAgente;
        private System.Windows.Forms.Button btnCargaOrdenes;
        private System.Windows.Forms.Button btnRepartirOrden;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button bttnAgeOrd;
        private System.Windows.Forms.Button bttnRepartir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMostrarAgente;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


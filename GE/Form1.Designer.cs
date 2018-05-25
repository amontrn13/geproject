namespace GE_GUI
{
    partial class Form1
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.btnMostrarAgente = new System.Windows.Forms.Button();
            this.btnCargaOrdenes = new System.Windows.Forms.Button();
            this.btnRepartirOrden = new System.Windows.Forms.Button();
            this.btnMostrarOrden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(380, 24);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(151, 42);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear XML";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(380, 84);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(151, 43);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar XML";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.Location = new System.Drawing.Point(23, 24);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.Size = new System.Drawing.Size(300, 373);
            this.rtbMostrar.TabIndex = 2;
            this.rtbMostrar.Text = "";
            // 
            // btnMostrarAgente
            // 
            this.btnMostrarAgente.Location = new System.Drawing.Point(380, 148);
            this.btnMostrarAgente.Name = "btnMostrarAgente";
            this.btnMostrarAgente.Size = new System.Drawing.Size(151, 43);
            this.btnMostrarAgente.TabIndex = 3;
            this.btnMostrarAgente.Text = "Mostrar Agente";
            this.btnMostrarAgente.UseVisualStyleBackColor = true;
            this.btnMostrarAgente.Click += new System.EventHandler(this.btnMostrarAgente_Click);
            // 
            // btnCargaOrdenes
            // 
            this.btnCargaOrdenes.Location = new System.Drawing.Point(380, 210);
            this.btnCargaOrdenes.Name = "btnCargaOrdenes";
            this.btnCargaOrdenes.Size = new System.Drawing.Size(151, 46);
            this.btnCargaOrdenes.TabIndex = 5;
            this.btnCargaOrdenes.Text = "Carga de órdenes de servicio";
            this.btnCargaOrdenes.UseVisualStyleBackColor = true;
            this.btnCargaOrdenes.Click += new System.EventHandler(this.btnCargaOrdenes_Click);
            // 
            // btnRepartirOrden
            // 
            this.btnRepartirOrden.Location = new System.Drawing.Point(380, 335);
            this.btnRepartirOrden.Name = "btnRepartirOrden";
            this.btnRepartirOrden.Size = new System.Drawing.Size(151, 43);
            this.btnRepartirOrden.TabIndex = 7;
            this.btnRepartirOrden.Text = "Repartir órdenes de servicio";
            this.btnRepartirOrden.UseVisualStyleBackColor = true;
            this.btnRepartirOrden.Click += new System.EventHandler(this.btnRepartirOrden_Click);
            // 
            // btnMostrarOrden
            // 
            this.btnMostrarOrden.Location = new System.Drawing.Point(380, 275);
            this.btnMostrarOrden.Name = "btnMostrarOrden";
            this.btnMostrarOrden.Size = new System.Drawing.Size(151, 42);
            this.btnMostrarOrden.TabIndex = 6;
            this.btnMostrarOrden.Text = "Mostrar órdenes de servicio";
            this.btnMostrarOrden.UseVisualStyleBackColor = true;
            this.btnMostrarOrden.Click += new System.EventHandler(this.btnMostrarOrden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRepartirOrden);
            this.Controls.Add(this.btnMostrarOrden);
            this.Controls.Add(this.btnCargaOrdenes);
            this.Controls.Add(this.btnMostrarAgente);
            this.Controls.Add(this.rtbMostrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCrear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RichTextBox rtbMostrar;
        private System.Windows.Forms.Button btnMostrarAgente;
        private System.Windows.Forms.Button btnCargaOrdenes;
        private System.Windows.Forms.Button btnRepartirOrden;
        private System.Windows.Forms.Button btnMostrarOrden;
    }
}


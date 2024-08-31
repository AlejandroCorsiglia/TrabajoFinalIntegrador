namespace ProyectoFinal
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
            this.btnMostrarApi = new System.Windows.Forms.Button();
            this.GrillaApi = new System.Windows.Forms.DataGridView();
            this.btnBuscarID = new System.Windows.Forms.Button();
            this.tbxBuscarID = new System.Windows.Forms.TextBox();
            this.groupBoxBuscarID = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaApi)).BeginInit();
            this.groupBoxBuscarID.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMostrarApi
            // 
            this.btnMostrarApi.Location = new System.Drawing.Point(66, 79);
            this.btnMostrarApi.Name = "btnMostrarApi";
            this.btnMostrarApi.Size = new System.Drawing.Size(171, 55);
            this.btnMostrarApi.TabIndex = 0;
            this.btnMostrarApi.Text = "Productos";
            this.btnMostrarApi.UseVisualStyleBackColor = true;
            this.btnMostrarApi.Click += new System.EventHandler(this.btnMostrarApi_Click);
            // 
            // GrillaApi
            // 
            this.GrillaApi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaApi.Location = new System.Drawing.Point(269, 12);
            this.GrillaApi.Name = "GrillaApi";
            this.GrillaApi.Size = new System.Drawing.Size(566, 215);
            this.GrillaApi.TabIndex = 1;
            // 
            // btnBuscarID
            // 
            this.btnBuscarID.Location = new System.Drawing.Point(212, 59);
            this.btnBuscarID.Name = "btnBuscarID";
            this.btnBuscarID.Size = new System.Drawing.Size(192, 20);
            this.btnBuscarID.TabIndex = 12;
            this.btnBuscarID.Text = "Buscar";
            this.btnBuscarID.UseVisualStyleBackColor = true;
            this.btnBuscarID.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxBuscarID
            // 
            this.tbxBuscarID.Location = new System.Drawing.Point(46, 59);
            this.tbxBuscarID.Name = "tbxBuscarID";
            this.tbxBuscarID.Size = new System.Drawing.Size(160, 20);
            this.tbxBuscarID.TabIndex = 13;
            // 
            // groupBoxBuscarID
            // 
            this.groupBoxBuscarID.Controls.Add(this.btnAgregar);
            this.groupBoxBuscarID.Controls.Add(this.BtnBorrar);
            this.groupBoxBuscarID.Controls.Add(this.BtnModificar);
            this.groupBoxBuscarID.Controls.Add(this.tbxBuscarID);
            this.groupBoxBuscarID.Controls.Add(this.btnBuscarID);
            this.groupBoxBuscarID.Location = new System.Drawing.Point(165, 264);
            this.groupBoxBuscarID.Name = "groupBoxBuscarID";
            this.groupBoxBuscarID.Size = new System.Drawing.Size(455, 289);
            this.groupBoxBuscarID.TabIndex = 14;
            this.groupBoxBuscarID.TabStop = false;
            this.groupBoxBuscarID.Text = "Buscar por ID";
            this.groupBoxBuscarID.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(104, 206);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(184, 31);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Location = new System.Drawing.Point(212, 132);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(183, 39);
            this.BtnBorrar.TabIndex = 15;
            this.BtnBorrar.Text = "Borrar Porducto";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(46, 132);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(151, 39);
            this.BtnModificar.TabIndex = 14;
            this.BtnModificar.Text = "Modificar Producto";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(954, 621);
            this.Controls.Add(this.groupBoxBuscarID);
            this.Controls.Add(this.GrillaApi);
            this.Controls.Add(this.btnMostrarApi);
            this.Name = "Form1";
            this.Text = "Proyecto Final";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaApi)).EndInit();
            this.groupBoxBuscarID.ResumeLayout(false);
            this.groupBoxBuscarID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarApi;
        private System.Windows.Forms.DataGridView GrillaApi;
        private System.Windows.Forms.Button btnBuscarID;
        private System.Windows.Forms.TextBox tbxBuscarID;
        private System.Windows.Forms.GroupBox groupBoxBuscarID;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnModificar;
    }
}


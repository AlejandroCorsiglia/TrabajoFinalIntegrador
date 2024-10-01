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
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.BtnDesc = new System.Windows.Forms.Button();
            this.groupBoxFiltrar = new System.Windows.Forms.GroupBox();
            this.groupBoxOrdenar = new System.Windows.Forms.GroupBox();
            this.btnAsc = new System.Windows.Forms.Button();
            this.groupBoxProductos = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaApi)).BeginInit();
            this.groupBoxBuscarID.SuspendLayout();
            this.groupBoxFiltrar.SuspendLayout();
            this.groupBoxOrdenar.SuspendLayout();
            this.groupBoxProductos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMostrarApi
            // 
            this.btnMostrarApi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarApi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarApi.Location = new System.Drawing.Point(99, 319);
            this.btnMostrarApi.Name = "btnMostrarApi";
            this.btnMostrarApi.Size = new System.Drawing.Size(214, 55);
            this.btnMostrarApi.TabIndex = 0;
            this.btnMostrarApi.Text = "Ver Productos ";
            this.btnMostrarApi.UseVisualStyleBackColor = true;
            this.btnMostrarApi.Click += new System.EventHandler(this.btnMostrarApi_Click);
            // 
            // GrillaApi
            // 
            this.GrillaApi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaApi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GrillaApi.Location = new System.Drawing.Point(20, 30);
            this.GrillaApi.Name = "GrillaApi";
            this.GrillaApi.Size = new System.Drawing.Size(1214, 237);
            this.GrillaApi.TabIndex = 1;
            this.GrillaApi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaApi_CellContentClick);
            this.GrillaApi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaApi_CellDoubleClick);
            this.GrillaApi.Click += new System.EventHandler(this.GrillaApi_Click);
            // 
            // btnBuscarID
            // 
            this.btnBuscarID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarID.Location = new System.Drawing.Point(80, 45);
            this.btnBuscarID.Name = "btnBuscarID";
            this.btnBuscarID.Size = new System.Drawing.Size(105, 26);
            this.btnBuscarID.TabIndex = 12;
            this.btnBuscarID.Text = "Buscar";
            this.btnBuscarID.UseVisualStyleBackColor = true;
            this.btnBuscarID.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxBuscarID
            // 
            this.tbxBuscarID.Location = new System.Drawing.Point(16, 46);
            this.tbxBuscarID.Name = "tbxBuscarID";
            this.tbxBuscarID.Size = new System.Drawing.Size(58, 22);
            this.tbxBuscarID.TabIndex = 13;
            this.tbxBuscarID.TextChanged += new System.EventHandler(this.tbxBuscarID_TextChanged);
            // 
            // groupBoxBuscarID
            // 
            this.groupBoxBuscarID.Controls.Add(this.tbxBuscarID);
            this.groupBoxBuscarID.Controls.Add(this.btnBuscarID);
            this.groupBoxBuscarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBuscarID.Location = new System.Drawing.Point(391, 303);
            this.groupBoxBuscarID.Name = "groupBoxBuscarID";
            this.groupBoxBuscarID.Size = new System.Drawing.Size(200, 100);
            this.groupBoxBuscarID.TabIndex = 14;
            this.groupBoxBuscarID.TabStop = false;
            this.groupBoxBuscarID.Text = "Buscar producto por ID";
            this.groupBoxBuscarID.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(39, 30);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(183, 39);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.Location = new System.Drawing.Point(417, 30);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(183, 39);
            this.BtnBorrar.TabIndex = 15;
            this.BtnBorrar.Text = "Borrar Porducto";
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Location = new System.Drawing.Point(228, 30);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(183, 39);
            this.BtnModificar.TabIndex = 14;
            this.BtnModificar.Text = "Modificar Producto";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // cbxCategory
            // 
            this.cbxCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(28, 43);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(151, 24);
            this.cbxCategory.TabIndex = 15;
            this.cbxCategory.Text = "Category";
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // BtnDesc
            // 
            this.BtnDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDesc.Location = new System.Drawing.Point(49, 50);
            this.BtnDesc.Name = "BtnDesc";
            this.BtnDesc.Size = new System.Drawing.Size(115, 23);
            this.BtnDesc.TabIndex = 17;
            this.BtnDesc.Text = "Descendente";
            this.BtnDesc.UseVisualStyleBackColor = true;
            this.BtnDesc.Click += new System.EventHandler(this.BtnOrdenar_Click);
            // 
            // groupBoxFiltrar
            // 
            this.groupBoxFiltrar.Controls.Add(this.cbxCategory);
            this.groupBoxFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFiltrar.Location = new System.Drawing.Point(628, 303);
            this.groupBoxFiltrar.Name = "groupBoxFiltrar";
            this.groupBoxFiltrar.Size = new System.Drawing.Size(200, 100);
            this.groupBoxFiltrar.TabIndex = 18;
            this.groupBoxFiltrar.TabStop = false;
            this.groupBoxFiltrar.Text = "Filtrar por categoria";
            // 
            // groupBoxOrdenar
            // 
            this.groupBoxOrdenar.Controls.Add(this.btnAsc);
            this.groupBoxOrdenar.Controls.Add(this.BtnDesc);
            this.groupBoxOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOrdenar.Location = new System.Drawing.Point(851, 303);
            this.groupBoxOrdenar.Name = "groupBoxOrdenar";
            this.groupBoxOrdenar.Size = new System.Drawing.Size(212, 100);
            this.groupBoxOrdenar.TabIndex = 19;
            this.groupBoxOrdenar.TabStop = false;
            this.groupBoxOrdenar.Text = "Ordenar";
            // 
            // btnAsc
            // 
            this.btnAsc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsc.Location = new System.Drawing.Point(49, 21);
            this.btnAsc.Name = "btnAsc";
            this.btnAsc.Size = new System.Drawing.Size(115, 23);
            this.btnAsc.TabIndex = 18;
            this.btnAsc.Text = "Ascendente";
            this.btnAsc.UseVisualStyleBackColor = true;
            this.btnAsc.Click += new System.EventHandler(this.btnAsc_Click);
            // 
            // groupBoxProductos
            // 
            this.groupBoxProductos.Controls.Add(this.GrillaApi);
            this.groupBoxProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProductos.Location = new System.Drawing.Point(12, 12);
            this.groupBoxProductos.Name = "groupBoxProductos";
            this.groupBoxProductos.Size = new System.Drawing.Size(1252, 285);
            this.groupBoxProductos.TabIndex = 20;
            this.groupBoxProductos.TabStop = false;
            this.groupBoxProductos.Text = "Productos";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox1.Controls.Add(this.BtnBorrar);
            this.groupBox1.Controls.Add(this.BtnModificar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Location = new System.Drawing.Point(367, 448);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 88);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1286, 605);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxProductos);
            this.Controls.Add(this.groupBoxOrdenar);
            this.Controls.Add(this.groupBoxFiltrar);
            this.Controls.Add(this.groupBoxBuscarID);
            this.Controls.Add(this.btnMostrarApi);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Proyecto Final";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaApi)).EndInit();
            this.groupBoxBuscarID.ResumeLayout(false);
            this.groupBoxBuscarID.PerformLayout();
            this.groupBoxFiltrar.ResumeLayout(false);
            this.groupBoxOrdenar.ResumeLayout(false);
            this.groupBoxProductos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarApi;
        private System.Windows.Forms.DataGridView GrillaApi;
        private System.Windows.Forms.Button btnBuscarID;
        private System.Windows.Forms.TextBox tbxBuscarID;
        private System.Windows.Forms.GroupBox groupBoxBuscarID;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Button BtnDesc;
        private System.Windows.Forms.GroupBox groupBoxFiltrar;
        private System.Windows.Forms.GroupBox groupBoxOrdenar;
        private System.Windows.Forms.Button btnAsc;
        private System.Windows.Forms.GroupBox groupBoxProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregar;
    }
}


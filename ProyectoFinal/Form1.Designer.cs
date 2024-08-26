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
            this.lblID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.tbxCategory = new System.Windows.Forms.TextBox();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.btnBuscarID = new System.Windows.Forms.Button();
            this.tbxBuscarID = new System.Windows.Forms.TextBox();
            this.groupBoxBuscarID = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaApi)).BeginInit();
            this.groupBoxBuscarID.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMostrarApi
            // 
            this.btnMostrarApi.Location = new System.Drawing.Point(290, 103);
            this.btnMostrarApi.Name = "btnMostrarApi";
            this.btnMostrarApi.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarApi.TabIndex = 0;
            this.btnMostrarApi.Text = "Productos";
            this.btnMostrarApi.UseVisualStyleBackColor = true;
            this.btnMostrarApi.Click += new System.EventHandler(this.btnMostrarApi_Click);
            // 
            // GrillaApi
            // 
            this.GrillaApi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaApi.Location = new System.Drawing.Point(376, 12);
            this.GrillaApi.Name = "GrillaApi";
            this.GrillaApi.Size = new System.Drawing.Size(566, 215);
            this.GrillaApi.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(60, 294);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID:";
            this.lblID.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(166, 290);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(610, 290);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(29, 338);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Category:";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(400, 338);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description:";
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(87, 287);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(42, 20);
            this.tbxID.TabIndex = 7;
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(475, 338);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(430, 20);
            this.tbxDescription.TabIndex = 8;
            // 
            // tbxCategory
            // 
            this.tbxCategory.Location = new System.Drawing.Point(87, 335);
            this.tbxCategory.Name = "tbxCategory";
            this.tbxCategory.Size = new System.Drawing.Size(278, 20);
            this.tbxCategory.TabIndex = 9;
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(650, 287);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(42, 20);
            this.txbPrice.TabIndex = 10;
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(202, 287);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(402, 20);
            this.tbxTitle.TabIndex = 11;
            // 
            // btnBuscarID
            // 
            this.btnBuscarID.Location = new System.Drawing.Point(115, 34);
            this.btnBuscarID.Name = "btnBuscarID";
            this.btnBuscarID.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarID.TabIndex = 12;
            this.btnBuscarID.Text = "Buscar";
            this.btnBuscarID.UseVisualStyleBackColor = true;
            this.btnBuscarID.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxBuscarID
            // 
            this.tbxBuscarID.Location = new System.Drawing.Point(6, 36);
            this.tbxBuscarID.Name = "tbxBuscarID";
            this.tbxBuscarID.Size = new System.Drawing.Size(100, 20);
            this.tbxBuscarID.TabIndex = 13;
            // 
            // groupBoxBuscarID
            // 
            this.groupBoxBuscarID.Controls.Add(this.tbxBuscarID);
            this.groupBoxBuscarID.Controls.Add(this.btnBuscarID);
            this.groupBoxBuscarID.Location = new System.Drawing.Point(32, 70);
            this.groupBoxBuscarID.Name = "groupBoxBuscarID";
            this.groupBoxBuscarID.Size = new System.Drawing.Size(200, 100);
            this.groupBoxBuscarID.TabIndex = 14;
            this.groupBoxBuscarID.TabStop = false;
            this.groupBoxBuscarID.Text = "Buscar por ID";
            this.groupBoxBuscarID.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(137, 519);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(954, 621);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBoxBuscarID);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.GrillaApi);
            this.Controls.Add(this.btnMostrarApi);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbxCategory);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCategory);
            this.Name = "Form1";
            this.Text = "Proyecto Final";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaApi)).EndInit();
            this.groupBoxBuscarID.ResumeLayout(false);
            this.groupBoxBuscarID.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarApi;
        private System.Windows.Forms.DataGridView GrillaApi;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.TextBox tbxCategory;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Button btnBuscarID;
        private System.Windows.Forms.TextBox tbxBuscarID;
        private System.Windows.Forms.GroupBox groupBoxBuscarID;
        private System.Windows.Forms.Button btnAgregar;
    }
}


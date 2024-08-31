namespace ProyectoFinal
{
    partial class FormModificarProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbcID = new System.Windows.Forms.TextBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.tbxCategory = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxTItle = new System.Windows.Forms.TextBox();
            this.BtnModificarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(173, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(127, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "MODFICAR PRODUCTO";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(55, 91);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(46, 128);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(24, 184);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(42, 158);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(13, 219);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description:";
            // 
            // tbcID
            // 
            this.tbcID.Location = new System.Drawing.Point(82, 88);
            this.tbcID.Name = "tbcID";
            this.tbcID.Size = new System.Drawing.Size(355, 20);
            this.tbcID.TabIndex = 6;
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(82, 219);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(355, 20);
            this.tbxDescription.TabIndex = 7;
            // 
            // tbxCategory
            // 
            this.tbxCategory.Location = new System.Drawing.Point(82, 184);
            this.tbxCategory.Name = "tbxCategory";
            this.tbxCategory.Size = new System.Drawing.Size(355, 20);
            this.tbxCategory.TabIndex = 8;
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(82, 158);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(355, 20);
            this.tbxPrice.TabIndex = 9;
            // 
            // tbxTItle
            // 
            this.tbxTItle.Location = new System.Drawing.Point(82, 125);
            this.tbxTItle.Name = "tbxTItle";
            this.tbxTItle.Size = new System.Drawing.Size(355, 20);
            this.tbxTItle.TabIndex = 10;
            // 
            // BtnModificarProducto
            // 
            this.BtnModificarProducto.Location = new System.Drawing.Point(156, 282);
            this.BtnModificarProducto.Name = "BtnModificarProducto";
            this.BtnModificarProducto.Size = new System.Drawing.Size(144, 23);
            this.BtnModificarProducto.TabIndex = 11;
            this.BtnModificarProducto.Text = "Modifcar Producto";
            this.BtnModificarProducto.UseVisualStyleBackColor = true;
            // 
            // FormModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(563, 332);
            this.Controls.Add(this.BtnModificarProducto);
            this.Controls.Add(this.tbxTItle);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.tbxCategory);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.tbcID);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormModificarProducto";
            this.Text = "FormModificarProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbcID;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.TextBox tbxCategory;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxTItle;
        private System.Windows.Forms.Button BtnModificarProducto;
    }
}
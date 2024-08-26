namespace ProyectoFinal
{
    partial class FormAgregarProducto
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
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbxCategory = new System.Windows.Forms.TextBox();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(132, 138);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(353, 20);
            this.txbPrice.TabIndex = 20;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(105, 80);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "ID:";
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(132, 77);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(352, 20);
            this.tbxID.TabIndex = 17;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(96, 106);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Title:";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(132, 202);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(352, 20);
            this.tbxDescription.TabIndex = 18;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(92, 141);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "Price:";
            // 
            // tbxCategory
            // 
            this.tbxCategory.Location = new System.Drawing.Point(132, 167);
            this.tbxCategory.Name = "tbxCategory";
            this.tbxCategory.Size = new System.Drawing.Size(352, 20);
            this.tbxCategory.TabIndex = 19;
            this.tbxCategory.TextChanged += new System.EventHandler(this.tbxCategory_TextChanged);
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(132, 103);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(353, 20);
            this.tbxTitle.TabIndex = 21;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(57, 202);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Description:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(74, 170);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 15;
            this.lblCategory.Text = "Category:";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(201, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(165, 13);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "AGREGAR PRODUCTO NUEVO";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.Location = new System.Drawing.Point(204, 237);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(162, 20);
            this.BtnAgregarProducto.TabIndex = 23;
            this.BtnAgregarProducto.Text = "Agregar";
            this.BtnAgregarProducto.UseVisualStyleBackColor = true;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // FormAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 286);
            this.Controls.Add(this.BtnAgregarProducto);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbxCategory);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCategory);
            this.Name = "FormAgregarProducto";
            this.Text = "FormAgregarProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbxCategory;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnAgregarProducto;
    }
}
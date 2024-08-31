namespace ProyectoFinal
{
    partial class FormEliminarProducto
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
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxCategory = new System.Windows.Forms.TextBox();
            this.tbxDesctiption = new System.Windows.Forms.TextBox();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(100, 94);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(433, 20);
            this.tbxTitle.TabIndex = 20;
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(100, 127);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(433, 20);
            this.tbxPrice.TabIndex = 19;
            // 
            // tbxCategory
            // 
            this.tbxCategory.Location = new System.Drawing.Point(100, 153);
            this.tbxCategory.Name = "tbxCategory";
            this.tbxCategory.Size = new System.Drawing.Size(433, 20);
            this.tbxCategory.TabIndex = 18;
            // 
            // tbxDesctiption
            // 
            this.tbxDesctiption.Location = new System.Drawing.Point(100, 188);
            this.tbxDesctiption.Name = "tbxDesctiption";
            this.tbxDesctiption.Size = new System.Drawing.Size(433, 20);
            this.tbxDesctiption.TabIndex = 17;
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(100, 57);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(433, 20);
            this.tbxID.TabIndex = 16;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(31, 191);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "Description:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(60, 134);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "Price:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(42, 160);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 13;
            this.lblCategory.Text = "Category:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(64, 97);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Title:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(73, 60);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "ID:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(181, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(252, 13);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "SEGURO QUIERE ELIMINAR ESTE PRODUCTO?";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(195, 263);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(307, 263);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormEliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(643, 365);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.tbxCategory);
            this.Controls.Add(this.tbxDesctiption);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblID);
            this.Name = "FormEliminarProducto";
            this.Text = "FormEliminarProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxCategory;
        private System.Windows.Forms.TextBox tbxDesctiption;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
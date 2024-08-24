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
            ((System.ComponentModel.ISupportInitialize)(this.GrillaApi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarApi
            // 
            this.btnMostrarApi.Location = new System.Drawing.Point(49, 148);
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
            this.GrillaApi.Location = new System.Drawing.Point(210, 60);
            this.GrillaApi.Name = "GrillaApi";
            this.GrillaApi.Size = new System.Drawing.Size(578, 244);
            this.GrillaApi.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrillaApi);
            this.Controls.Add(this.btnMostrarApi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GrillaApi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarApi;
        private System.Windows.Forms.DataGridView GrillaApi;
    }
}


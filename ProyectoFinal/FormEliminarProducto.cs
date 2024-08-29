using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormEliminarProducto : Form
    {
        public FormEliminarProducto()
        {
            InitializeComponent();
            Dimensionar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dimensionar()
        {
            // Fijar el tamaño del formulario
            this.Size = new Size(475, 350); // Cambia a las dimensiones deseadas

            // Deshabilitar la redimensión
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Deshabilitar el botón de maximizar
            this.MaximizeBox = false;

            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}

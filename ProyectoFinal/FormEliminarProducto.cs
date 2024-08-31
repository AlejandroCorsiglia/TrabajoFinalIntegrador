using Negocios;
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
        private Productos producto;
        // private Productos producto;
        public FormEliminarProducto(Productos producto /*Productos producto*/)
        {
            InitializeComponent();
            Dimensionar();
            this.producto = producto;


            tbxID.Text = producto.Id.ToString();
            tbxTitle.Text = producto.Title;
            tbxPrice.Text = producto.Price.ToString();
            tbxCategory.Text = producto.Category;
            tbxDesctiption.Text = producto.Description;

            ReadOnly();






            // tbxID.Text = producto.Id.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ReadOnly()
        {

            tbxID.ReadOnly = true;
            tbxTitle.ReadOnly = true;
            tbxPrice.ReadOnly = true;
            tbxCategory.ReadOnly = true;
            tbxDesctiption.ReadOnly = true;
        }
        private void Dimensionar()
        {
            // Fijar el tamaño del formulario
            this.Size = new Size(650, 400); // Cambia a las dimensiones deseadas

            // Deshabilitar la redimensión
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Deshabilitar el botón de maximizar
            this.MaximizeBox = false;

            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

           // this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}

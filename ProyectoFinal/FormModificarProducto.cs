﻿using Negocios;
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
    public partial class FormModificarProducto : Form
    {

        private Productos producto;
        public FormModificarProducto(Productos producto)
        {
            InitializeComponent();
            Dimensionar();

            this.producto = producto;

            tbcID.Text = producto.Id.ToString();
            tbcID.ReadOnly = true;
            tbxTItle.Text = producto.Title;
            tbxPrice.Text = producto.Price.ToString();
            tbxCategory.Text = producto.Category;
            tbxDescription.Text = producto.Description;

           

        }

        private void Dimensionar()
        {
            // Fijar el tamaño del formulario
            this.Size = new Size(500, 370); // Cambia a las dimensiones deseadas

            // Deshabilitar la redimensión
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Deshabilitar el botón de maximizar
            this.MaximizeBox = false;

            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
﻿using Negocios;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormAgregarProducto : Form
    {
        public Productos ProductoAgregado { get; private set; }

        private string url;
        public FormAgregarProducto(string apiUrl)
        {
            InitializeComponent();
            url = apiUrl;

            Dimensionar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void tbxCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxTitle.Text) && decimal.TryParse(txbPrice.Text, out decimal price) &&
         int.TryParse(tbxID.Text, out int id))
            {
                try
                {
                    // Crear un nuevo objeto Productos con los valores ingresados
                    var nuevoProducto = new Productos
                    {
                        Id = id,
                        Title = tbxTitle.Text,
                        Price = price,
                        Category = tbxCategory.Text,
                        Description = tbxDescription.Text
                    };

                    Productos product = new Productos();

                  
                    ProductoAgregado = product.PostProducto(nuevoProducto, url);

                    MessageBox.Show("Producto agregado exitosamente.");

                   

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
            }
        }

        private void Dimensionar()
        {
            // Fijar el tamaño del formulario
            this.Size = new Size(500, 300); // Cambia a las dimensiones deseadas

            // Deshabilitar la redimensión
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Deshabilitar el botón de maximizar
            this.MaximizeBox = false;

            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}

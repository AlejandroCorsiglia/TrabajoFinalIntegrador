using Negocios;
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
        public Productos NuevoProducto { get; private set; }

        private string url;
        public FormAgregarProducto(string apiUrl)
        {
            InitializeComponent();
            url = apiUrl;
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
                // Crear un nuevo objeto Productos con los valores ingresados
                var nuevoProducto = new Productos
                {
                    Id = id,
                    Title = tbxTitle.Text,
                    Price = price,
                    Category = tbxCategory.Text,
                    Description = tbxDescription.Text
                };

                // Configurar el cliente RestSharp para realizar la solicitud POST
                var client = new RestClient(url);
                var request = new RestRequest("products", Method.Post);
                request.AddJsonBody(nuevoProducto);

                // Ejecutar la solicitud y obtener la respuesta
                var response = client.Execute<Productos>(request);

                // Verificar si la solicitud fue exitosa
                if (response.IsSuccessful)
                {
                    MessageBox.Show("Producto agregado exitosamente.");

                    // Cerrar el formulario y devolver el control al formulario principal
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar el producto. Inténtalo nuevamente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
            }
        }
    }
}

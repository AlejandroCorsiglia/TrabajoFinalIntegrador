using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using System.Linq.Expressions;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        private string url = "https://fakestoreapi.com";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarApi_Click(object sender, EventArgs e)
        {
            var client = new RestClient(url);
            var request = new RestRequest("products", Method.Get);
            List<Productos> prodcutos = client.Get<List<Productos>>(request);
            GrillaApi.DataSource = prodcutos;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

         
            if (int.TryParse(tbxBuscarID.Text, out int productId))
            {
                var client = new RestClient(url);
                var request = new RestRequest($"products/{productId}", Method.Get);


                var productos = client.Get<Productos>(request);

                
                if (productos != null)
                {
                    List<Productos> prodcutos = new List<Productos> {productos};
                    GrillaApi.DataSource = prodcutos;
                   
                }
                else
                {
                   
                    MessageBox.Show("Producto no encontrado. Por favor ingrese un ID válido.");
                    
                    tbxBuscarID.Clear();
                }



           

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
           

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
         
        }

        private void btnAgregar_Click(object sender, EventArgs e)

            
        {
           // FormAgregarProducto FAgregar = new FormAgregarProducto(url);

//            FAgregar.ShowDialog();


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

            // Obtener la lista actual de productos en la grilla
            var productos = (List<Productos>)GrillaApi.DataSource;

            // Si la lista es null, inicializarla
            if (productos == null)
            {
                productos = new List<Productos>();
            }

            // Agregar el nuevo producto a la lista
            productos.Add(response.Data);

            // Actualizar la grilla para mostrar el nuevo producto
            GrillaApi.DataSource = null;
            GrillaApi.DataSource = productos;

            // Limpiar los campos del formulario
            tbxID.Clear();
            tbxTitle.Clear();
            txbPrice.Clear();
            tbxCategory.Clear();
            tbxDescription.Clear();
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
    
        


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
//        private Productos ProductosSeleccionado;

        public Form1()
        {
            InitializeComponent();
            FormInicial();

           
        }

        private void btnMostrarApi_Click(object sender, EventArgs e)
        {
            List<Productos> productos = Productos.GetProductos(url);
            GrillaApi.DataSource = productos;

            // Deshabilitar botones
            BtnBorrar.Enabled = false;
            BtnModificar.Enabled = false;


            // Limpiar el TextBox de buscar por ID
            tbxBuscarID.Clear();



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
                // Llama al método estático GetProductoByID en la clase Productos
                Productos producto = Productos.GetProductoByID(url, productId);

                if (producto != null)
                {
                    // Si se encuentra el producto, se añade a una lista y se muestra en la grilla
                    List<Productos> productos = new List<Productos> { producto };
                    GrillaApi.DataSource = productos;

                    // Habilitar los botones de eliminar y modificar si no están habilitados
                    BtnBorrar.Enabled = true;
                    BtnModificar.Enabled = true;
                }
                else
                {
                    // Si no se encuentra el producto, muestra un mensaje
                    MessageBox.Show("Producto no encontrado. Por favor ingrese un ID válido.");
                    tbxBuscarID.Clear();

                    // Deshabilitar los botones si no se encuentra el producto
                    BtnBorrar.Enabled = false;
                    BtnModificar.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
                tbxBuscarID.Clear();
            





        }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormInicial();
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

            // Crear una instancia del formulario para agregar productos y pasarle la URL
            FormAgregarProducto formAgregar = new FormAgregarProducto(url);

            // Si el formulario de agregar productos se cierra con OK, entonces agregamos el producto a la grilla
            if (formAgregar.ShowDialog() == DialogResult.OK)
            {
                // Obtener el producto agregado desde el formulario FormAgregarProducto
                var productoAgregado = formAgregar.ProductoAgregado;

                if (productoAgregado != null)
                {
                    // Obtener la lista actual de productos en la grilla
                    var productos = (List<Productos>)GrillaApi.DataSource;

                    // Si la lista es null, inicializarla
                    if (productos == null)
                    {
                        productos = new List<Productos>();
                    }

                    // Agregar el nuevo producto a la lista
                    productos.Add(productoAgregado);

                    // Actualizar la grilla para mostrar el nuevo producto
                    GrillaApi.DataSource = null;
                    GrillaApi.DataSource = productos;
                }
                else
                {
                    MessageBox.Show("El producto no se ha agregado correctamente.");
                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FormModificarProducto FModificar = new FormModificarProducto();
            FModificar.ShowDialog();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            FormEliminarProducto FEliminar = new FormEliminarProducto();
            FEliminar.ShowDialog();
        }

        private void FormInicial()
        {

            // Deshabilitar botones
            BtnBorrar.Enabled = false;
            BtnModificar.Enabled = false;

            // Limpiar la grilla de datos
            GrillaApi.DataSource = null;

            // Limpiar el TextBox de buscar por ID
            tbxBuscarID.Clear();

            // Fijar el tamaño del formulario
            this.Size = new Size(1000, 700); // Cambia a las dimensiones deseadas

            // Deshabilitar la redimensión
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Deshabilitar el botón de maximizar
            this.MaximizeBox = false;
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

        }
    }
}

    
        


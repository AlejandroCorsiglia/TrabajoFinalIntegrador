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
        private Productos producto;
        

        public Form1()
        {
            InitializeComponent();
            FormInicial();

           
        }

        private void btnMostrarApi_Click(object sender, EventArgs e)
        {
            CargarGrilla();

            FormClickMostrarApi();
           

            // Limpiar el TextBox de buscar por ID
            tbxBuscarID.Clear();



        }


        private void CargarGrilla()
        {
            Productos product = new Productos();
            List<Productos> productos = product.GetProductos(url);
            GrillaApi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GrillaApi.DataSource = productos;
            GrillaApi.ReadOnly = true;
            AjustarGrilla();
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
                Productos product = new Productos();

                // Llama al método estático GetProductoByID en la clase Productos
                producto = product.GetProductoByID(url, productId);

                if (producto != null)
                {
                    // Si se encuentra el producto, se añade a una lista y se muestra en la grilla
                    List<Productos> productos = new List<Productos> { producto };
                    GrillaApi.DataSource = productos;


                    cbxCategory.Enabled = false;
                    BtnDesc.Enabled = false;
                    btnAsc.Enabled = false;
                }
                else
                {
                    // Si no se encuentra el producto, muestra un mensaje
                    MessageBox.Show("Producto no encontrado. Por favor ingrese un ID válido.");
                    tbxBuscarID.Clear();

                 
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
            CargarGrilla();
           


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

     /*   private void BtnModificar_Click(object sender, EventArgs e)
        {


            if (int.TryParse(tbxBuscarID.Text, out int productId))
            {
                Productos product = new Productos();
                producto = product.GetProductoByID(url, productId);



                if (producto != null)
                {


                    FormModificarProducto FModificar = new FormModificarProducto(producto, url);

                    FModificar.ShowDialog();
                    RefrescarGrilla();

                }
                else
                {
                    MessageBox.Show("No hay producto seleccionado para modificar.");
                }
            }
         /*   else if (producto != null)
            {
                // Si no hay un ID válido en tbxBuscarID, usa el producto seleccionado en la grilla
                FormModificarProducto FModificar = new FormModificarProducto(producto, url);
                FModificar.ShowDialog();
                RefrescarGrilla();
            }
            else
            {
                MessageBox.Show("No hay producto seleccionado para modificar.");
            }*/

        //}

      /*  private void BtnBorrar_Click(object sender, EventArgs e)


        {

            BorrarProducto();
        }*/

        private void BorrarProducto()
        {
            if (int.TryParse(tbxBuscarID.Text, out int productId))
            {
                Productos product = new Productos();
                producto = product.GetProductoByID(url, productId);



                if (producto != null)
                {



                    FormEliminarProducto FEliminar = new FormEliminarProducto(producto, url);

                    if (FEliminar.ShowDialog() == DialogResult.OK)
                    {

                        RefrescarGrilla2(product.Id);

                    }
                    else
                    {
                        MessageBox.Show("Eliminación cancelada.");
                    }
                }
            }
        }


        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoriaSeleccionada = cbxCategory.SelectedItem.ToString();

            if(categoriaSeleccionada == "All")
            {
                Productos product = new Productos();
                List<Productos> producto = product.GetProductos(url);
                GrillaApi.DataSource = producto;
            }
            else
            {
                List<Productos> productos = Productos.GetProductosPorCategoria(url, categoriaSeleccionada);
                GrillaApi.DataSource = productos;


            }

            
        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();

            productos.ObtenerProductosOrdenadosDesc(url);
            List<Productos> listaProductos = productos.ObtenerProductosOrdenadosDesc(url);

            if (listaProductos != null)
            {
                // Asignar la lista de productos a la grilla
                GrillaApi.DataSource = listaProductos;
            }
            else
            {
                MessageBox.Show("No se pudieron obtener los productos.");
            }
        }

        private void btnAsc_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();

           // productos.ObtenerProductosOrdenadosDesc(url);
            List<Productos> listaProductos = productos.ObtenerProductosOrdenadosAsc(url);

            if (listaProductos != null)
            {
                // Asignar la lista de productos a la grilla
                GrillaApi.DataSource = listaProductos;
            }
            else
            {
                MessageBox.Show("No se pudieron obtener los productos.");
            }
        }

        private void GrillaApi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         

        }

        private void GrillaApi_Click(object sender, EventArgs e)
        {
          

            if (GrillaApi.CurrentRow != null)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow filaSeleccionada = GrillaApi.CurrentRow;

                // Asegúrate de que el DataBoundItem sea un Producto
                Productos productoSeleccionado = filaSeleccionada.DataBoundItem as Productos;

                if (productoSeleccionado != null)
                {
                    // Asigna el ID del producto al tbxBuscarPorId
                    tbxBuscarID.Text = productoSeleccionado.Id.ToString(); // Asegúrate de que 'Id' sea la propiedad correcta
                }

                 btnAsc.Enabled = true;
                  BtnDesc.Enabled = true;
                  cbxCategory.Enabled = true;
          
            }
        }

        private void GrillaApi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxBuscarID_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en la grilla
            if (GrillaApi.SelectedRows.Count > 0)
            {
                // Obtener el producto de la fila seleccionada
                var filaSeleccionada = GrillaApi.SelectedRows[0].DataBoundItem as Productos;

                if (filaSeleccionada != null)
                {
                    // Crear el formulario de confirmación de eliminación
                    FormEliminarProducto FEliminar = new FormEliminarProducto(filaSeleccionada, url);

                    // Mostrar el formulario y si se confirma la eliminación, refrescar la grilla
                    if (FEliminar.ShowDialog() == DialogResult.OK)
                    {
                        RefrescarGrilla2(filaSeleccionada.Id);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el producto de la fila seleccionada.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila.");
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GrillaApi.SelectedRows.Count > 0)
            {
                // Obtener el producto de la fila seleccionada
                var filaSeleccionada = GrillaApi.SelectedRows[0].DataBoundItem as Productos;

                if (filaSeleccionada != null)
                {
                    // Crear el formulario de modificación
                    FormModificarProducto FModificar = new FormModificarProducto(filaSeleccionada, url);

                    // Mostrar el formulario y si se confirman los cambios, refrescar la grilla
                    if (FModificar.ShowDialog() == DialogResult.OK)
                    {
                        RefrescarGrilla();  // Puedes pasar el ID si deseas refrescar solo una fila
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el producto de la fila seleccionada.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila.");
            }
        }


        private void FormInicial()
        {

       

            // Limpiar la grilla de datos
            GrillaApi.DataSource = null;

            // Limpiar el TextBox de buscar por ID
            tbxBuscarID.Clear();

            // Fijar el tamaño del formulario
            //  this.Size = new Size(1000, 700); // Cambia a las dimensiones deseadas

            // Deshabilitar la redimensión
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Deshabilitar el botón de maximizar
            this.MaximizeBox = false;
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            // **Deshabilitar el ComboBox de categorías**
            cbxCategory.Enabled = true;

            Categorias();

        }


        private void FormClickMostrarApi()
        {
            
            btnAgregar.Enabled = true;
            btnBuscarID.Enabled = true;
            tbxBuscarID.ReadOnly = false;
            cbxCategory.Enabled = true;
            BtnDesc.Enabled = true;
            btnAsc.Enabled = true;

            Categorias();

            AjustarGrilla();


        }
        private void RefrescarGrilla()
        {
            // Limpiar y actualizar la grilla con el producto modificado
            GrillaApi.DataSource = null;
            GrillaApi.DataSource = new List<Productos> { producto };
            AjustarGrilla();
        }

        private void RefrescarGrilla2(int productoId)
        {

            try
            {
                // Verificar si la grilla tiene productos cargados
                if (GrillaApi.DataSource is List<Productos> productos)
                {
                    // Eliminar el producto específico de la lista
                    productos.RemoveAll(p => p.Id == productoId);

                    // Actualizar el DataSource de la grilla
                    GrillaApi.DataSource = null; // Limpia la fuente de datos actual
                    GrillaApi.DataSource = productos; // Asigna la lista actualizada

                    // Refrescar la grilla para que los cambios se reflejen
                    GrillaApi.Refresh();


                }
                else
                {
                    MessageBox.Show("No hay productos cargados en la grilla.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al refrescar la grilla: {ex.Message}");
            }

        }
        private void AjustarGrilla()
        {
            GrillaApi.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Modo de selección de fila completa

            GrillaApi.Columns[0].Width = 40;    // Cambiar el tamaño de la columna Nombre

            GrillaApi.Columns[2].Width = 100;  // Cambiar el tamaño de la columna Descripción
            GrillaApi.Columns[3].Width = 150; // Cambiar el tamaño de la columna Categoría
        }

        private void Categorias()
        {
            // Obtener las categorías desde la API
            List<string> categorias = Productos.GetCategorias(url);

            categorias.Insert(0, "All");

            // Llenar el ComboBox con las categorías
            cbxCategory.DataSource = categorias;
        }
    }
    }


    
        


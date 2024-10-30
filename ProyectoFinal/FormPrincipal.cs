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
using System.Configuration;
using System.Web.Configuration;

namespace ProyectoFinal
{
    public partial class FormPrincipal : Form
    {
        private string url = "";
      
        private Productos producto;


        public FormPrincipal()
        {
            InitializeComponent();
            FormInicial();


        }

        private void btnMostrarApi_Click(object sender, EventArgs e)
        {
            CargarGrilla();

            FormClickMostrarApi();


            
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

                producto = product.GetProductoByID(url, productId);

                if (producto != null)
                {
                    List<Productos> productos = new List<Productos> { producto };
                    GrillaApi.DataSource = productos;


                    cbxCategory.Enabled = false;
                    BtnDesc.Enabled = false;
                    btnAsc.Enabled = false;
                    btnLimitar.Enabled = false;
                    tbxLimitar.Enabled = false;
                }
                else
                {
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

          
            FormAgregarProducto formAgregar = new FormAgregarProducto(url);

            if (formAgregar.ShowDialog() == DialogResult.OK)
            {
                var productoAgregado = formAgregar.ProductoAgregado;

                if (productoAgregado != null)
                {
                   
                    var productos = (List<Productos>)GrillaApi.DataSource;

                    if (productos == null)
                    {
                        productos = new List<Productos>();
                    }

                    productos.Add(productoAgregado);

                    GrillaApi.DataSource = null;
                    GrillaApi.DataSource = productos;
                    AjustarGrilla();
                    
                    
                }
                else
                {
                    MessageBox.Show("El producto no se ha agregado correctamente.");
                }
            }
        }


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

            Productos productosApi = new Productos();

            if (categoriaSeleccionada == "All")
            {
                List<Productos> productos = productosApi.GetProductos(url);
                GrillaApi.DataSource = productos; 
            }
            else
            {
                List<Productos> productos = productosApi.GetProductosPorCategoria(url, categoriaSeleccionada);
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

            List<Productos> listaProductos = productos.ObtenerProductosOrdenadosAsc(url);

            if (listaProductos != null)
            {
                GrillaApi.DataSource = listaProductos;
            }
            else
            {
                MessageBox.Show("No se pudieron obtener los productos.");
            }
        }

        private void GrillaApi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (GrillaApi.SelectedRows.Count > 0)
            {
                var filaSeleccionada = GrillaApi.SelectedRows[0].DataBoundItem as Productos;

                if (filaSeleccionada != null)
                {
                    FormModificarProducto FModificar = new FormModificarProducto(filaSeleccionada, url);

                    if (FModificar.ShowDialog() == DialogResult.OK)
                    {
                        RefrescarGrilla();  
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

    private void GrillaApi_Click(object sender, EventArgs e)
        {
          

            if (GrillaApi.CurrentRow != null)
            {
                DataGridViewRow filaSeleccionada = GrillaApi.CurrentRow;

                Productos productoSeleccionado = filaSeleccionada.DataBoundItem as Productos;

                if (productoSeleccionado != null)
                {
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
            if (GrillaApi.SelectedRows.Count > 0)
            {
                var filaSeleccionada = GrillaApi.SelectedRows[0].DataBoundItem as Productos;

                if (filaSeleccionada != null)
                {
                    FormEliminarProducto FEliminar = new FormEliminarProducto(filaSeleccionada, url);

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
                var filaSeleccionada = GrillaApi.SelectedRows[0].DataBoundItem as Productos;

                if (filaSeleccionada != null)
                {
                    FormModificarProducto FModificar = new FormModificarProducto(filaSeleccionada, url);

                    if (FModificar.ShowDialog() == DialogResult.OK)
                    {
                        RefrescarGrilla(); 
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


            
                  url = WebConfigurationManager.AppSettings["urlApi"];

            GrillaApi.DataSource = null;

            tbxBuscarID.Clear();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

       
            this.MaximizeBox = false;
          
            this.StartPosition = FormStartPosition.CenterScreen;

          
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
            btnLimitar.Enabled = true;
            tbxLimitar.Enabled = true;

            Categorias();

            AjustarGrilla();


        }
        private void RefrescarGrilla()
        {
            
            GrillaApi.DataSource = null;
            GrillaApi.DataSource = new List<Productos> { producto };
            AjustarGrilla();
        }

        private void RefrescarGrilla2(int productoId)
        {

            try
            {
                if (GrillaApi.DataSource is List<Productos> productos)
                {
                   
                    productos.RemoveAll(p => p.Id == productoId);

                   
                    GrillaApi.DataSource = null; 
                    GrillaApi.DataSource = productos; 

                    
                    AjustarGrilla();
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
            GrillaApi.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 

            GrillaApi.Columns[0].Width = 40;   
            GrillaApi.Columns[2].Width = 100;  
            GrillaApi.Columns[3].Width = 150; 
        }

        private void Categorias()
        {
           
            Productos productosApi = new Productos(); 

          
            List<string> categorias = productosApi.GetCategorias(url); 

          

            categorias.Insert(0, "All");

            // Llenar el ComboBox con las categorías
            cbxCategory.DataSource = categorias;
        }

        private void btnLimitar_Click(object sender, EventArgs e)
        {
            try
            {
                
                int limite;
                if (int.TryParse(tbxLimitar.Text, out limite))
                {
                    
                    if (limite > 0)
                    {
                       
                        Productos productos = new Productos();
                      

                        
                        List<Productos> listaProductos = productos.GetProductosConLimite(url, limite);

                       
                        GrillaApi.DataSource = listaProductos;
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un número mayor a 0.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
    }


    
        


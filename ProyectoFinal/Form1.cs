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


                var producto = client.Get<Producto>(request);

                
                if (producto != null)
                {
                   
                    tbxID.Text = producto.Id.ToString();
                    tbxTitle.Text = producto.Title;
                    txbPrice.Text = producto.Price.ToString();
                    tbxCategory.Text = producto.Category;
                    tbxDescription.Text = producto.Description;
                }
                else
                {
                   
                    MessageBox.Show("Producto no encontrado. Por favor, ingrese un ID válido.");
                    
                    tbxBuscarID.Clear();
                }



           

            }
        }
    }
}
    
        


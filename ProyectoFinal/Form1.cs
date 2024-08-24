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
            List <Productos> prodcuto =  client.Get <List<Productos>>(request);
            GrillaApi.DataSource = prodcuto;


        }
    }
}

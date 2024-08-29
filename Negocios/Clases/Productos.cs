using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;


namespace Negocios
{
    public class Productos

    {

        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }







        public static List<Productos> GetProductos(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest("products", Method.Get);
            List<Productos> productos = client.Get<List<Productos>>(request);
            return productos;
        }


        public static Productos GetProductoByID(string url, int productId)
        {
            var client = new RestClient(url);
            var request = new RestRequest($"products/{productId}", Method.Get);
            Productos producto = client.Get<Productos>(request);
            return producto;
        }




        public static Productos PostProducto(Productos nuevoProducto, string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest("products", Method.Post);
            request.AddJsonBody(nuevoProducto);

            // Ejecutar la solicitud y obtener la respuesta
            var response = client.Execute<Productos>(request);

            // Verificar si la solicitud fue exitosa y devolver el producto creado
            if (response.IsSuccessful)
            {
                return response.Data;
            }
            else
            {
                throw new Exception("Error al agregar el producto: " + response.ErrorMessage);
            }

        }
    }
}

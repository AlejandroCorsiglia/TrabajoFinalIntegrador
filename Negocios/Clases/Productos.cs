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






        //METODO GET
        public  List<Productos> GetProductos(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest("products", Method.Get);
            List<Productos> productos = client.Get<List<Productos>>(request);
            return productos;
        }

        //METODO GET BY ID
        public  Productos GetProductoByID(string url, int productId)
        {
            var client = new RestClient(url);
            var request = new RestRequest($"products/{productId}", Method.Get);
            Productos producto = client.Get<Productos>(request);
            return producto;
        }



        // METODO POST
        public  Productos PostProducto(Productos nuevoProducto, string url)
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

        // METODO PUT

        public  string ModificarProducto(Productos producto, string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest($"products/{producto.Id}", Method.Put);

            request.AddJsonBody(producto); // Agrega el producto como JSON en el cuerpo de la solicitud

            // Ejecutar la solicitud y obtener la respuesta
            var response = client.Execute<Productos>(request);

            // Verificar si la solicitud fue exitosa
            if (response.IsSuccessful)
            {
                return "Producto modificado exitosamente.";
            }
            else
            {
                throw new Exception("Error al modificar el producto: " + response.ErrorMessage);
            }
        }


        //METODO DELETE

        public  string EliminarProducto(Productos producto, string url)
        {
          
                try
                {
                    var client = new RestClient(url);
                    var request = new RestRequest($"products/{producto.Id}", Method.Delete);

                    // Ejecutar la solicitud y obtener la respuesta
                    var response = client.Execute(request);

                    // Verificar si la solicitud fue exitosa
                    if (response.IsSuccessful)
                    {
                        return "Producto eliminado exitosamente.";
                    }
                    else
                    {
                        return $"Error al eliminar el producto: {response.Content}";
                    }
                }
                catch (Exception ex)
                {
                    return $"Ocurrió un error al intentar eliminar el producto: {ex.Message}";
                }
            }

        public static List<string> GetCategorias(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest("products/categories", Method.Get);

            // Llamada a la API para obtener las categorías
            List<string> categorias = client.Get<List<string>>(request);
            return categorias;
        }

        public static List<Productos> GetProductosPorCategoria(string url, string categoria)
        {
            var client = new RestClient(url);
            var request = new RestRequest($"products/category/{categoria}", Method.Get);

            // Llamada a la API para obtener productos por categoría
            List<Productos> productos = client.Get<List<Productos>>(request);
            return productos;
        }

    }
    }


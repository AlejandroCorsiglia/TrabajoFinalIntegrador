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
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }



        //GET PRODUCTOS
        public List<Productos> GetProductos(string url)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest("products", Method.Get);
                List<Productos> productos = client.Get<List<Productos>>(request);

                return productos;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Error al obtener productos desde la URL: {url}", url); 
                return new List<Productos>(); 
            }
        }


        //METODO GET BY ID

        public Productos GetProductoByID(string url, int productId)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest($"products/{productId}", Method.Get);
                Productos producto = client.Get<Productos>(request);
                return producto;
            }
            catch (Exception ex )
            {
                Logger.Error(ex, "Error al obtener el producto con ID: {productId} desde la URL: {url}", productId, url);
                return null;
                
            }
        }





        // METODO POST
       
        public Productos PostProducto(Productos nuevoProducto, string url)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest("products", Method.Post);
                request.AddJsonBody(nuevoProducto);

               
                var response = client.Execute<Productos>(request);

                
                return response.Data; 
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Error al crear el producto: {producto}", nuevoProducto); 
                return null; 
            }
        }

        // METODO PUT
        
        public string ModificarProducto(Productos producto, string url)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest($"products/{producto.Id}", Method.Put);

                request.AddJsonBody(producto); 

              
                var response = client.Execute<Productos>(request);

               
                return response.IsSuccessful ? "Producto modificado exitosamente." : response.ErrorMessage;
            }
            catch (Exception ex )
            {
                Logger.Error(ex, "Error al modificar el producto: {producto}", producto); 
                return "Ocurrió un error al modificar el producto."; 
               
            }
        }




        //METODO DELETE
       public string EliminarProducto(Productos producto, string url)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest($"products/{producto.Id}", Method.Delete);

                
                var response = client.Execute(request);

                return response.IsSuccessful ? "Producto eliminado exitosamente." : throw new Exception(response.Content);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Error al eliminar el producto: {productoId}", producto.Id); 
                return $"Ocurrió un error al intentar eliminar el producto: {ex.Message}"; 
            }
        }


        // METODO GET ALL CATEGORY
  

        public List<string> GetCategorias(string url)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest("products/categories", Method.Get);

                
                List<string> categorias = client.Get<List<string>>(request);
                return categorias;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Error al obtener categorías"); 
                return null; 
            }
        }


        // METODO GET IN CATEGORY

        public List<Productos> GetProductosPorCategoria(string url, string categoria)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest($"products/category/{categoria}", Method.Get);

                List<Productos> productos = client.Get<List<Productos>>(request);
                return productos;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, $"Error al obtener productos por categoría: {categoria}"); 
                return null; 
            }
        }

        //METODO SORT RESULT DESCENDENTE

        public List<Productos> ObtenerProductosOrdenadosDesc(string url)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest("products?sort=desc", Method.Get);
                var response = client.Execute<List<Productos>>(request);

                
                return response.Data;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Error al obtener productos ordenados de manera descendente"); 
                return null; 
            }
        }

        //METODO SORT RESULT ASCENDENTE
       
        public List<Productos> ObtenerProductosOrdenadosAsc(string url)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest("products?sort=asc", Method.Get);
                var response = client.Execute<List<Productos>>(request);

                
                return response.Data;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Error al obtener productos ordenados de manera ascendente"); 
                return null;  
            }
        }

        // METODO LIMIT RESULT
         public List<Productos> GetProductosConLimite(string url, int limite)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest($"products?limit={limite}", Method.Get);

                
                List<Productos> productos = client.Get<List<Productos>>(request);

                return productos;  
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Error al obtener productos con límite"); 
                return null;  
            }
        }
    }

}
    


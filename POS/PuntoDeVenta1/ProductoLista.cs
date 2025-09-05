using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta1
{
    internal class ProductoLista
    {
        public List<Producto> Listar()
        {
            List<Producto> productos = new List<Producto>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=GonzaPc\\SQLEXPRESS; database=PuntoDeVenta; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Nombre, CodigoSKU, PrecioUnitario, StockDisponible from Producto";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read()) 
                {
                    Producto producto = new Producto();
                    producto.Nombre = (string)lector["Nombre"];
                    producto.CodProducto = (int)lector["CodigoSKU"];
                    producto.PrecioUnitario = (int)lector["PrecioUnitario"];
                    producto.stock = (int)lector["StockDisponible"];
                    productos.Add(producto);
                }
                conexion.Close();
                return productos;
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
        
   
        
    }
}

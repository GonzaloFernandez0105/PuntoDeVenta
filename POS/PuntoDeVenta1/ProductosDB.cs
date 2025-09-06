using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta1
{

public static class ProductosDB
    {
        private static string cadenaConexion = "server=GonzaPc\\SQLEXPRESS; DATABASE=PuntoDeVenta; integrated security=true";

        public static Producto BuscarPorCodigo(long codigo)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            using (SqlCommand comando = new SqlCommand("SELECT * FROM Producto WHERE CodigoSKU = @codigo", conexion))
            {
                comando.Parameters.AddWithValue("@codigo", codigo);
                conexion.Open();
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    return new Producto
                    {
                        Nombre = lector["Nombre"].ToString(),
                        CodProducto = Convert.ToInt64(lector["CodigoSKU"]),
                        PrecioUnitario = Convert.ToInt32(lector["PrecioUnitario"]),
                        stock = Convert.ToInt32(lector["StockDisponible"])
                    };
                }

                return null;
            }
        }

        public static List<Producto> ListarTodos()
        {
            List<Producto> productos = new List<Producto>();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            using (SqlCommand comando = new SqlCommand("SELECT * FROM Productos", conexion))
            {
                conexion.Open();
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    productos.Add(new Producto
                    {
                        Nombre = lector["Nombre"].ToString(),
                        CodProducto = Convert.ToInt64(lector["CodigoSKU"]),
                        PrecioUnitario = Convert.ToInt32(lector["PrecioUnitario"]),
                        stock = Convert.ToInt32(lector["StockDisponible"])
                    });
                }

                return productos;
            }
        }
    }

}


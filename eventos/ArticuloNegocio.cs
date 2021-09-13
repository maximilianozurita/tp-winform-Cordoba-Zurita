using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
	public class ArticuloNegocio
	{
		public List<Articulo> listar()
		{
			List<Articulo> lista = new List<Articulo>();
			AccesoDatos datos = new AccesoDatos();
			/*SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;*/
			try
			{
				datos.SetearConsulta("Select Codigo, Nombre,A.Descripcion,ImagenUrl,M.Descripcion Marca From ARTICULOS A, MARCAS M where M.Id=A.Id");
				datos.EjecutarLectura();
				/*conexion.ConnectionString = "server=.\\SQLEXPRESS;database=CATALOGO_DB; integrated security=true";
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "Select Codigo, Nombre,A.Descripcion,ImagenUrl,M.Descripcion Marca From ARTICULOS A, MARCAS M where M.Id=A.Id";
				comando.Connection=conexion;
				conexion.Open();
				lector = comando.ExecuteReader();*/

				while (datos.Lector.Read())
				{
					Articulo aux = new Articulo();
					aux.CodigoArticulo = (string) datos.Lector["Codigo"];
					aux.Nombre = (string)  datos.Lector ["Nombre"] ;
					aux.Descripción= (string) datos.Lector["Descripcion"];
					aux.Imagen = (string) datos.Lector["ImagenUrl"];
					aux.Marca = new Marca();
					aux.Marca.Descripcion = (string) datos.Lector["Marca"];
					lista.Add(aux);
                }



				//conexion.Close();
					return lista;

			}
			catch (Exception ex)
			{

				throw ex;
			}
            finally
            {
				datos.CerrarConexion();
            }
		}
    }

}

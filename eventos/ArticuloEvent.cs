using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace eventos
{
	public class ArticuloEvent
	{
		public List<Articulo> listar()
		{
			List<Articulo> lista = new List<Articulo>();
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;
			try
			{
				conexion.ConnectionString = "server=.\\SQLEXPRESS;database=CATALOGO_DB; integrated security=true";
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "Select Codigo, Nombre,A.Descripcion,ImagenUrl,M.Descripcion Marca From ARTICULOS A, MARCAS M where M.Id=A.Id";
				comando.Connection=conexion;
				
				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					Articulo aux = new Articulo();
					aux.CodigoArticulo = (string)lector["Codigo"];
					aux.Nombre = (string) lector ["Nombre"] ;
					aux.Descripción= (string) lector["Descripcion"];
					aux.Imagen = (string)lector["ImagenUrl"];
					aux.Marca = new Marca();
					aux.Marca.Descripcion = (string)lector["Marca"];
					lista.Add(aux);

                }



				conexion.Close();
					return lista;

			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
    }

}

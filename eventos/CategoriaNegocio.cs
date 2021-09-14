using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
	{
			public List<Categoria> Listar()
			{
				List<Categoria> lista = new List<Categoria>();
				AccesoDatos datos = new AccesoDatos();

				try
				{
					datos.SetearConsulta("select id, descripcion from CATEGORIAS");
					datos.EjecutarLectura();
					while (datos.Lector.Read())
					{
						Categoria aux = new Categoria();
						aux.ID = (int)datos.Lector["id"];
						aux.Descripcion = (string)datos.Lector["Descripcion"];

						lista.Add(aux);
					}
		
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
			public void Agregar(Categoria nuevo)
			{
				AccesoDatos datos = new AccesoDatos();

				try
				{

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

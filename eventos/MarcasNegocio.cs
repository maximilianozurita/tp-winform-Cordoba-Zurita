using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MarcasNegocio
    {
		public List<Marca> Listar()
		{
			List<Marca> lista = new List<Marca>();
			AccesoDatos datos = new AccesoDatos();

			try
			{
				datos.SetearConsulta("select id, descripcion from MARCAS");
				datos.EjecutarLectura();
				while (datos.Lector.Read())
				{
					Marca aux = new Marca();
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

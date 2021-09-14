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

			try
			{
				datos.SetearConsulta("Select Codigo, Nombre,A.Descripcion,ImagenUrl,M.Descripcion as Marcas,C.Descripcion as Categorias, Precio From ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdMarca=M.Id and A.IdCategoria=C.Id");
				datos.EjecutarLectura();
				while (datos.Lector.Read())
				{
					Articulo aux = new Articulo();
					aux.CodigoArticulo = (string) datos.Lector["Codigo"];
					aux.Nombre = (string)  datos.Lector ["Nombre"] ;
					aux.Descripción= (string) datos.Lector["Descripcion"];
					aux.Imagen = (string) datos.Lector["ImagenUrl"];
                    aux.Marca = new Marca
                    {
                        Descripcion = (string)datos.Lector["Marcas"]
                    };
                    aux.Categoria = new Categoria
                    {
                        Descripcion = (string)datos.Lector["Categorias"]
                    };
                    //aux.Precio = (float)datos.Lector["Precio"];

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
		public void Agregar(Articulo nuevo)
        {
			AccesoDatos datos = new AccesoDatos();

            try
            {
				datos.SetearConsulta("insert into dbo.ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values('" + nuevo.CodigoArticulo + "', '"+ nuevo.Nombre +"', ' "+  nuevo.Descripción +"', @idMarca , @IdCategoria, 'agregarURL', "+ 1234 + ")");
				datos.setearParametros("@IdMarca", nuevo.Marca.ID);
				datos.setearParametros("@IdCategoria", nuevo.Categoria.ID);
				datos.EjecutarAccion();
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

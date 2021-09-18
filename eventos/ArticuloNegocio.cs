﻿using System;
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
				datos.SetearConsulta("Select Codigo, Nombre,A.Descripcion,ImagenUrl,M.Descripcion as Marcas,C.Descripcion as Categorias, Precio, A.IdMarca, A.IdCategoria From ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdMarca=M.Id and A.IdCategoria=C.Id");
				datos.EjecutarLectura();
				while (datos.Lector.Read())
				{
					Articulo aux = new Articulo();
					aux.CodigoArticulo = (string)datos.Lector["Codigo"];
					aux.Nombre = (string)datos.Lector["Nombre"];
					aux.Descripcion = (string)datos.Lector["Descripcion"];

					if (!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("ImagenUrl"))))
					//if (!(datos.Lector["Imagen"] is DBNull))
					
						aux.Imagen = (string)datos.Lector["ImagenUrl"]; 
					
					aux.Marca= new Marca
                   {
						Descripcion = (string)datos.Lector["Marcas"]
                    };
					aux.Marca.ID= (int)datos.Lector["IdMarca"];

                    aux.Categoria = new Categoria
					{
                        Descripcion = (string)datos.Lector["Categorias"]
                    };
					aux.Categoria.ID = (int)datos.Lector["IdCategoria"];

					if (!(datos.Lector["Precio"] is DBNull))
					aux.Precio = (float)(decimal) datos.Lector["Precio"];

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
				datos.SetearConsulta("insert into dbo.ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria,Precio,ImagenUrl) values('" + nuevo.CodigoArticulo + "', '" + nuevo.Nombre + "', ' " + nuevo.Descripcion + "', @idMarca , @IdCategoria,'"+nuevo.Precio+"',@ImagenUrl); ");
			  datos.setearParametros("@IdMarca",nuevo.Marca.ID);
				datos.setearParametros("@IdCategoria", nuevo.Categoria.ID);
				datos.setearParametros("@ImagenUrl", nuevo.Imagen);
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
		public void Modificar(Articulo nuevo)
        {

        }
	}



}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TP_AdminArt_Zurita_Cordoba
{
	class ArticuloEvent
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
				comando.CommandText = "select Codigo, Nombre,Descripcion,ImagenUrl from ARTICULOS";
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

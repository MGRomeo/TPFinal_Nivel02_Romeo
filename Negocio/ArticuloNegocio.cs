using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Datos;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listaArticulo;
        AccesoDatos datos = new AccesoDatos();
       

        public List<Articulo> Listar()
        {
            listaArticulo = new List<Articulo>();
            try
            {
                datos.SetearConsulta("select a.Id, a.Codigo, a.Nombre, a.Descripcion, m.Descripcion Marca, c.Descripcion Categoria, a.ImagenUrl, a.Precio from Articulos a inner join MARCAS m on a.IdMarca = m.Id inner join CATEGORIAS c on a.IdCategoria = c.Id");
                datos.Leer();
                while (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = datos.Lector.GetInt32(0);
                    articulo.Codigo = (string)datos.Lector["Codigo"];
                    articulo.Nombre = (string)datos.Lector["Nombre"];
                    articulo.Descripcion = (string)datos.Lector["Descripcion"];
                    articulo.Marca = (string)datos.Lector["Marca"];
                    articulo.Categoria = (string)datos.Lector["Categoria"];
                    articulo.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    articulo.Precio = datos.Lector.GetDecimal(7);

                    listaArticulo.Add(articulo);
                }

                return listaArticulo;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        

    }
}

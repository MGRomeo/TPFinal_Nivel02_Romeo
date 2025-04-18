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
       
        private List<Articulo> CargarListaArticulo(AccesoDatos datos)
        {
            listaArticulo = new List<Articulo>();
            try
            {
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

        }

        public List<Articulo> Listar()
        {

            try
            {
                datos.SetearConsulta("select a.Id, a.Codigo, a.Nombre, a.Descripcion, m.Descripcion Marca, c.Descripcion Categoria, a.ImagenUrl, a.Precio from Articulos a inner join MARCAS m on a.IdMarca = m.Id inner join CATEGORIAS c on a.IdCategoria = c.Id");
                datos.Leer();

                return CargarListaArticulo(datos);

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
        
        public List<Articulo> BusquedaAvanzada(string campo, string criterio, string filtro)
        {
            string consulta = "select a.Id, a.Codigo, a.Nombre, a.Descripcion, m.Descripcion Marca, c.Descripcion Categoria, a.ImagenUrl, a.Precio from Articulos a inner join MARCAS m on a.IdMarca = m.Id inner join CATEGORIAS c on a.IdCategoria = c.Id where ";
            try
            {
                if (campo == "Id")
                {
                    
                    switch (criterio)
                    {
                        case "Igual a":
                            consulta += "a." + campo + " = " + filtro;
                            break;
                        case "Mayor a":
                            consulta += "a." + campo + " > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "a." + campo + " < " + filtro;
                            break;
                    }
                }
                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Contenga":
                            consulta += "a." + campo + " like '%" + filtro + "%' ";
                            break;
                        case "Empice con":
                            consulta += "a." + campo + " like '" + filtro + "%' ";

                            break;
                        case "Termine con":
                            consulta += "a." + campo + " like '%" + filtro +"'";

                            break;
                    }
                }
                else if (campo == "Marca")
                {
                    switch (criterio)
                    {
                        case "Contenga":
                            consulta += "m.Descripcion like '%" + filtro + "%' ";
                            break;
                        case "Comience con":
                            consulta += "m.Descripcion like '" + filtro + "%' ";

                            break;
                        case "Termine con":
                            consulta += "m.Descripcion like '%" + filtro + "'" ;

                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Contenga":
                            consulta += "c.Descripcion like '%" + filtro + "%' ";
                            break;
                        case "Comience con":
                            consulta += "c.Descripcion like '" + filtro + "%' ";

                            break;
                        case "Termine con":
                            consulta += "c.Descripcion like '%" + filtro + "'" ;

                            break;
                    }
                }
                datos.SetearConsulta(consulta);
                datos.Leer();
                CargarListaArticulo(datos);
            }
            catch (Exception)
            {

                throw;
            }

            return listaArticulo;
        }

        public void Agregar()
        {

        }

    }
}

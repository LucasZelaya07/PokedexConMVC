using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class PokemonNegocio
    {
        //Donde creo los metodos de acceso a DB para los pokemones
        public List<Pokemon> listaPokemon()
        {
            List<Pokemon> lista = new List<Pokemon>();
            //Creo conexión a la DB
            SqlConnection conexion = new SqlConnection();
            //Creo comando a la DB
            SqlCommand comando = new SqlCommand();
            //Creo un lector de data pero NO una instancia del objeto porque el comando
            //devuelve un objeto para que lo lea con "lector"
            SqlDataReader lector;
            //En caso de ejecutarse todo bien, seguira este proceso
            try
            {
                //Configuro la conexión a la DB
                //Digo a donde me voy a conectar, a que base y el ingreso
                conexion.ConnectionString = "server = .\\SQLEXPRESS; database = POKEDEX_DB; integrated security = true;";
                //Digo que voy a leer los datos
                comando.CommandType = System.Data.CommandType.Text;
                //Escribo la consulta a realizar en la base de datos
                comando.CommandText = "Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id From POKEMONS P, ELEMENTOS E, ELEMENTOS D where E.Id = P.IdTipo AND D.Id = P.IdDebilidad And P.Activo = 1";
                //Declaro que los comando que estoy realizando, la quiero ejecutar en "conexion"
                comando.Connection = conexion;
                //Abro la conexion
                conexion.Open();
                //Ya que ExecuteReader devuelve un dato de tipo SQLDataReader, lo guardo en lector
                lector = comando.ExecuteReader();
                //Creo un while para que ".Read()" lea la información que tiene "lector"
                //Y luego empiece a ordenar los datos en las columnas correspondientes
                while (lector.Read())
                {
                    //Creo un pokemon auxiliar
                    //En cada vuelta va a reutilizar la variable pero creara una nueva instancia
                    //Y la lista tendra referencias a distintos objetos
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)lector["Id"];
                    aux.Numero = lector.GetInt32(0);
                    //Le declaro que lo que va a recibir es un string
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    //Creo un if para que en caso de que la url sea nula en la base de datos
                    //la aplicación no la lea y no se rompa
                    if (!(lector.IsDBNull(lector.GetOrdinal("UrlImagen"))))
                        aux.UrlImagen = (string)lector["UrlImagen"];
                    //Genero una instancia para que no tenga un error "null"
                    aux.Tipo = new Elemento();
                    aux.Tipo.Id = (int)lector["IdTipo"];
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    //Repito proceso con "Debilidad"
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Id = (int)lector["IdDebilidad"];
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];
                    //Agrego el pokemon a la lista de pokemones
                    lista.Add(aux);
                }
                return lista;

            }
            //En caso de un error, arroja una excepcion para evitar que la app se rompa
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //Cierro la conexión a DB
                conexion.Close();
            }

        }

        public void Agregar(Pokemon nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetConsulta("Insert into POKEMONS (Numero, Nombre, Descripcion, Activo, IdTipo, IdDebilidad, UrlImagen) values(@Numero, @Nombre, @Descripcion, '1', @IdTipo, @IdDebilidad, @UrlImagen)");
                datos.SetParametros("@Numero", nuevo.Numero);
                datos.SetParametros("@Nombre", nuevo.Nombre);
                datos.SetParametros("Descripcion", nuevo.Descripcion);
                datos.SetParametros("@IdTipo", nuevo.Tipo.Id);
                datos.SetParametros("@IdDebilidad", nuevo.Debilidad.Id);
                datos.SetParametros("@UrlImagen", nuevo.UrlImagen);
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

        public void modificar(Pokemon modificar)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetConsulta("update POKEMONS set Numero = @Numero, Nombre = @Nombre, Descripcion = @Desc, UrlImagen = @Url, IdTipo = @IdTipo, IdDebilidad = @IdDebilidad where Id = @Id");
                datos.SetParametros("@Numero", modificar.Numero);
                datos.SetParametros("@Nombre", modificar.Nombre);
                datos.SetParametros("@Desc", modificar.Descripcion);
                datos.SetParametros("@UrlImagen", modificar.UrlImagen);
                datos.SetParametros("@IdTipo", modificar.Tipo.Id);
                datos.SetParametros("@IdDebilidad", modificar.Debilidad.Id);
                datos.SetParametros("@Id", modificar.Id);
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

        public List<Pokemon> Filtrar(string campo, string criterio, string filtro)
        {
            List<Pokemon> lista = new List<Pokemon>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id From POKEMONS P, ELEMENTOS E, ELEMENTOS D where E.Id = P.IdTipo AND D.Id = P.IdDebilidad And P.Activo = 1 And ";
                if (campo == "Numero")
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "Numero > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "Numero < " + filtro;
                            break;
                        default:
                            consulta += "Numero = " + filtro;
                            break;
                    }
                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Nombre like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "Nombre like '%" + filtro + "' ";
                            break;
                        default:
                            consulta += "Nombre like '%" + filtro + "%' ";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "P.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "P.Descripcion like '%" + filtro + "' ";
                            break;
                        default:
                            consulta += "P.Descripcion like '%" + filtro + "%' ";
                            break;
                    }
                }
                datos.SetConsulta(consulta);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Numero = datos.Lector.GetInt32(0);
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("UrlImagen"))))
                        aux.UrlImagen = (string)datos.Lector["UrlImagen"];
                    aux.Tipo = new Elemento();
                    aux.Tipo.Id = (int)datos.Lector["IdTipo"];
                    aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Id = (int)datos.Lector["IdDebilidad"];
                    aux.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Eliminar(int Id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.SetConsulta("delete from POKEMONS where Id = @Id");
                datos.SetParametros("Id", Id);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void EliminarLogico(int Id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.SetConsulta("update from POKEMONS set Activo = 0 where Id = @Id");
                datos.SetParametros("Id", Id);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

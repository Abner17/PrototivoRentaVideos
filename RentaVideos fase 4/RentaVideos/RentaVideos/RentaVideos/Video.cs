using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace RentaVideos
{
    class Video
    {

        public string Codigo { get; set; }
        public string Titulo { get; set; }
        public string Duracion { get; set; }
        public string Copias { get; set; }
        public string Precio { get; set; }
        public string Anio { get; set; }
        public string Director { get; set; }
        public string Formato { get; set; }
        public string Categoria { get; set; }
        public string ActorPrincipal { get; set; }
        public string Descripcion { get; set; }


        public Video() { }

        public Video(string codigo, string titulo, string duracion,
            string copias, string precio, string anio, string director,
            string formato, string categoria, string actorPrincipal, string descripcion)
        {
            Codigo = codigo;
            Titulo = titulo;
            Duracion = duracion;
            Copias = copias;
            Precio = precio;
            Anio = anio;
            Director = director;
            Formato = formato;
            Categoria = categoria;
            ActorPrincipal = actorPrincipal;
            Descripcion = descripcion;
        }


        public static int Agregar(Video pVideo)
        {

            int retorno = 0;


            MySqlCommand registroCliente = new MySqlCommand(string.Format("Insert into Videos (" +
                "idVideo, Titulo, Descripcion, Duracion, Copias, " +
                "Categoria, Año, ActorPrincipal, Director, Precio, Formato) " +
                "values ('{0}','{1}','{2}', '{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
           pVideo.Codigo, pVideo.Titulo, pVideo.Descripcion, pVideo.Duracion, pVideo.Copias,
           pVideo.Categoria, pVideo.Anio, pVideo.ActorPrincipal, pVideo.Director, pVideo.Precio, pVideo.Formato),
          ConectarServidor.conexion());




            retorno = registroCliente.ExecuteNonQuery();

            return retorno;
        }
    }
}

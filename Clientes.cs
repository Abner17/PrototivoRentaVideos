using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RentaVideos
{
    class Clientes
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Fecha_Nac { get; set; }
        public string Direccion { get; set; }
        public string Nit { get; set; }
        public string Dpi { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string descripcionEmail { get; set; }
        public string descripcionTelefono { get; set; }
        public string Telefono { get; set; }
        public string FechaRegistro { get; set; }

        public Clientes() { }

        public Clientes(string Nit, string Dpi, string Sexo, string Nombre,
            string Apellido, string Fecha_Nac, string Direccion, string Email,
            string Telefono, string descripcionEmail, string descripcionTelefono,
            string FechaRegistro)

        {

            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Fecha_Nac = Fecha_Nac;
            this.Direccion = Direccion;
            this.Nit = Nit;
            this.Dpi = Dpi;
            this.Sexo = Sexo;
            this.Email = Email;
            this.Telefono = Telefono;
            this.descripcionEmail = descripcionEmail;
            this.descripcionTelefono = descripcionTelefono;
            this.FechaRegistro = FechaRegistro;
        }

        public static int Agregar(Clientes pCliente)
        {

            int retorno = 0;


            MySqlCommand registroCliente = new MySqlCommand(string.Format("Insert into Cliente (NIT, Nombre_Cliente, Apellido_Cliente, DPI, Direccion,Sexo, Fecha_Nacimiento) values ('{0}','{1}','{2}', '{3}','{4}','{5}','{6}')",
           pCliente.Nit, pCliente.Nombre, pCliente.Apellido, pCliente.Dpi, pCliente.Direccion, pCliente.Sexo, pCliente.Fecha_Nac), ConectarServidor.conexion());

            MySqlCommand registroTelefonoCliente = new MySqlCommand(string.Format("INSERT INTO `Telefono_Cliente` (`Telefono`, `Descripcion`, `Cliente_NIT`) VALUES  ('{0}','{1}','{2}')",
           pCliente.Telefono, pCliente.descripcionTelefono, pCliente.Nit), ConectarServidor.conexion());

            MySqlCommand registroMembresia = new MySqlCommand(string.Format("INSERT INTO `Membresia` (`Fecha_Registro`,`Cliente_NIT`) VALUES  ('{0}','{1}')",
            pCliente.FechaRegistro, pCliente.Nit), ConectarServidor.conexion());



            retorno = registroCliente.ExecuteNonQuery();
            retorno = registroTelefonoCliente.ExecuteNonQuery();
            retorno = registroMembresia.ExecuteNonQuery();
            return retorno;
        }
    }
}

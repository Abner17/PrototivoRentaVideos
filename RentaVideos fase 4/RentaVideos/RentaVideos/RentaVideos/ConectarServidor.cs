using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RentaVideos
{
    class ConectarServidor
    {

        public static MySqlConnection conexion()
        {
            MySqlConnection conectar = new MySqlConnection("Server=sql10.freemysqlhosting.net; Database=sql10206827; Uid=sql10206827; Pwd=VfjM6Vrz1S; Port=3306; SslMode=none;");
            try
            {
                conectar.Open();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return conectar;
        }
        public static MySqlConnection cerrarConexion()
        {
            MySqlConnection conectar = new MySqlConnection("Server=sql10.freemysqlhosting.net; Database=sql10206827; Uid=sql10206827; Pwd=VfjM6Vrz1S; Port=3306; SslMode=none;");
            try
            {
                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return conectar;
        }
    }
}

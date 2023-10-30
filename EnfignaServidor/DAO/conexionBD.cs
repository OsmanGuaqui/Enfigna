using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EnfignaServidor.DAO
{
    internal class conexionBD
    {
        MySqlConnection bdConexion = new MySqlConnection();


        static string servidor = "localhost";
        static string puerto = "3306";
        static string userId = "root";
        static string password = "admin";
        static string baseDatos = "ejemplo";

        string cadenaDeConexion = "server=" + servidor + ";" + "port=" + puerto + ";" +
            "user id=" + userId + ";" + "password=" + password + ";" + "database=" + baseDatos + ";";

        public MySqlConnection establecerConexion(){

            try {
                bdConexion.ConnectionString = cadenaDeConexion;
                bdConexion.Open();
                // MessageBox.Show("Weon malo feo ya esta la bd");
            }
            catch(MySqlException ex) {

                MessageBox.Show("Weon malo kliao hiciste la conexion mal:" + ex.ToString());
            }

            return bdConexion;
        }

        public void cerrarConexion() {
            bdConexion.Close();
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnfignaServidor.DAO
{
    internal class jugadorDAO
    {

     
        public void CrearCuenta(TextBox usuario, TextBox password,  int halo) {

            try
            {
                conexionBD conexion = new conexionBD();

                string crearCuentaQuery = "insert into usuario (usuario,password,halo)" +
                    "VALUES ('"+usuario.Text +"','" +password.Text +"','"+halo+"');";

                MySqlCommand comando = new MySqlCommand(crearCuentaQuery, conexion.establecerConexion());
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read()) { 
                }
                conexion.cerrarConexion();

            }
            catch (Exception ex) {
                MessageBox.Show("kliao Feo malo, error:" + ex.ToString());
            }
        }

        public void mostrarUsuarios(DataGridView tablausuarios)
        {

            try
            {
                conexionBD conexion = new conexionBD();

                string MostrarQuery = "select * From usuario ";

                tablausuarios.DataSource = null;
                MySqlDataAdapter adaptador = new MySqlDataAdapter(MostrarQuery, conexion.establecerConexion());
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                tablausuarios.DataSource= dt;

                conexion.cerrarConexion();


            }
            catch (Exception ex)
            {
                MessageBox.Show("kliao Feo malo no se muestran los usuarios , error:" + ex.ToString());
            }
        }



    }
}

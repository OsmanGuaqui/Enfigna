using EnfignaServidor.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnfignaServidor.DAO
{
    internal class cartaDAO
    {
        public Carta cartasObtenidas = new Carta();

        public List<Carta> recuperarCartas() { 
            
            List<Carta> cartasRecuperadas = new List<Carta> ();

            conexionBD conexion = new conexionBD();

            jugadorDAO player = new jugadorDAO();



            string recuperarCartasQuery = "SELECT idCarta FROM Carta Where idUsuario = '" 
                + player.recuperarIDUsuario() + "'";

            try { 
                MySqlCommand comandoRecuperarCartas = new MySqlCommand (recuperarCartasQuery, conexion.establecerConexion());
                MySqlDataReader lector = comandoRecuperarCartas.ExecuteReader();

                while (lector.Read()) {
                    int idcarta = lector.GetInt32("idCarta");
                    int a = 0;

                    Carta carta = new Carta
                    {
                        id = idcarta,
                        ataque = a,
                        vida = a,
                    };

                    cartasRecuperadas.Add(carta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("la verda no funciona tu recuperacion de cartas, error.  " + ex);

            }

            return cartasRecuperadas;
        }
    }
}

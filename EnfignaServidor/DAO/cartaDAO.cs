using EnfignaServidor.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnfignaServidor.DAO
{
    internal class cartaDAO
    {
        public Carta cartasObtenidas = new Modelo.Carta();


        public List<Carta> recuperarCartas() { 
            
            List<Carta> cartasRecuperadas = new List<Carta> ();

            conexionBD conexion = new conexionBD();


            return cartasRecuperadas;

        
        }


    }
}

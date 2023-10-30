using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnfignaServidor.Vistas
{
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
            DAO.jugadorDAO mostrar = new DAO.jugadorDAO();

            mostrar.mostrarUsuarios(dgvUsuarios);
        }

        private void buttonCrearCuenta_Click(object sender, EventArgs e)
        {
            DAO.jugadorDAO insertaJugador = new DAO.jugadorDAO();
            int halo = 1500;

            insertaJugador.CrearCuenta(inputUsuario, inputPassword, halo);


        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

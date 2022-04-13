using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinario_2022
{
    public partial class VentanaLogin : Form
    {
        Conexion miConexion = new Conexion();
        DataTable miInfoUsuario = new DataTable();
        String nombre = "";
        String apellido = "";
        String pass = "";
        int idActual = 1;
        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void nombreUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void login_Click(object sender, EventArgs e)
        {
            nombre = textoNombreUsuario.Text;
            apellido = textoApellidoUsuario.Text;
            pass = password.Text;
            miInfoUsuario = miConexion.getUsuarioYPass(idActual);
            while (miInfoUsuario.Rows[0]["Nombre"].ToString() != nombre || miInfoUsuario.Rows[0]["Apellido"].ToString() != apellido || miInfoUsuario.Rows[0]["password"].ToString() != pass)
            {
                idActual++;
                miInfoUsuario = miConexion.getUsuarioYPass(idActual);
            }
            VentanaPrincipal princ = new VentanaPrincipal(miInfoUsuario);
            princ.Show();
        }

    }
}

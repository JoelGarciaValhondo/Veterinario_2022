using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace Veterinario_2022
{
    public partial class VentanaPrincipal : Form
    {
        Conexion miConexion = new Conexion();
        public VentanaPrincipal()
        {
            InitializeComponent();
            
        }

       

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void insertaUsuario_Click(object sender, EventArgs e)
        {
            //HASH DE LA PASS AL INTRODUCIRLA POR PRIMERA VEZ EN LA BBDD.
            String textoPassword = textBoxPass.Text;
            String myHash = BCrypt.Net.BCrypt.HashPassword(textoPassword, BCrypt.Net.BCrypt.GenerateSalt());
            miConexion.insertaUsuario(textBoxDNI.Text, textBoxNombre.Text, textBoxApellido.Text, myHash, textBoxEmail.Text);
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}

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
        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void nombreUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void login_Click(object sender, EventArgs e)
        {
            //SI ESTO ES VERDADERO Y COINCIDE, QUE TE OCULTE EL LOGIN Y TE ABRA LA VENTANA PRINCIPAL Y, SI NO, MSG ERROR
            if(miConexion.getUsuarioYPass(textoNombreUsuario.Text, textoApellidoUsuario.Text, textoPassword.Text))
            {
                this.Hide();
                VentanaPrincipal princ = new VentanaPrincipal();
                princ.Show();
            }
            else
            {
                MessageBox.Show("usuario/contraseña incorrectos");

            }  
        }

    }
}

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
            
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            miConexion.insertaMascota(tipoMascota.Text, nombreMascota.Text, colorMascota.Text);
        }

        private void botonBuscarUsuario_Click(object sender, EventArgs e)
        {
            miConexion.buscaUsuario(textBoxNombreUsuario.Text);
            Resultados v = new Resultados("1" + textBoxNombreUsuario.Text);
            v.Show();
        }

        private void botonBuscarPorNombre_Click(object sender, EventArgs e)
        {
            miConexion.buscaMascotaPorNombre(textBoxNombreMascota.Text);
            ResultadosAnimales v = new ResultadosAnimales("2" + textBoxNombreMascota.Text);
            v.Show();
        }

        private void botonBuscarPorAnimal_Click(object sender, EventArgs e)
        {
            miConexion.buscaMascotaPorAnimal(textBoxAnimalMascota.Text);
            ResultadosAnimales v = new ResultadosAnimales("3" + textBoxAnimalMascota.Text);
            v.Show();
        }

        private void botonBuscarPorColor_Click(object sender, EventArgs e)
        {
            miConexion.buscaMascotaPorColor(textBoxColorMascota.Text);
            ResultadosAnimales v = new ResultadosAnimales("4" + textBoxColorMascota.Text);
            v.Show();
        }

        private void insertaUsuario_Click_1(object sender, EventArgs e)
        {
            //HASH DE LA PASS AL INTRODUCIRLA POR PRIMERA VEZ EN LA BBDD.
            String textoPassword = textBoxPass.Text;
            String myHash = BCrypt.Net.BCrypt.HashPassword(textoPassword, BCrypt.Net.BCrypt.GenerateSalt());
            miConexion.insertaUsuario(textBoxDNI.Text, textBoxNombre.Text, textBoxApellido.Text, myHash, textBoxEmail.Text);
        }
    }
}

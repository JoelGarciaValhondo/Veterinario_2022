﻿using System;
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
            miInfoUsuario = miConexion.getUsuarioYPass(nombre, apellido, pass);
            VentanaPrincipal princ = new VentanaPrincipal(miInfoUsuario);
            princ.Show();
        }
    }
}

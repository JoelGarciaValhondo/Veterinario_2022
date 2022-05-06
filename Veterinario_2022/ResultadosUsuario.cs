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
    public partial class Resultados : Form
    {
        Conexion miConexion = new Conexion();
        DataTable info = new DataTable();
        public Resultados(String texto)
        {
            InitializeComponent();
            if (texto.Substring(0,1) == "1")
            {
                texto = texto.Trim(new Char[] { ' ', '1', '.' });
                info = miConexion.buscaUsuario(texto);
                for (int i=0; i < info.Rows.Count; i++)
                {
                    resultado.Text = resultado.Text + info.Rows[i]["DNI"].ToString() + "   " + info.Rows[i]["Nombre"].ToString() + "   " + info.Rows[i]["Apellido"].ToString() + "   " + info.Rows[i]["email"].ToString() + "\n";

                }
            }
            
        }

        private void Resultados_Load(object sender, EventArgs e)
        {

        }

        private void resultado_Click(object sender, EventArgs e)
        {

        }
    }
}

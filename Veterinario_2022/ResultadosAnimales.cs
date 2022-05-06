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
    public partial class ResultadosAnimales : Form
    {
        Conexion miConexion = new Conexion();
        DataTable info = new DataTable();
        public ResultadosAnimales(String texto)
        {
            InitializeComponent();
            if (texto.Substring(0,1) == "2")
            {
                texto = texto.Trim(new Char[] { ' ', '2', '.' });
                info = miConexion.buscaMascotaPorNombre(texto);
                for (int i = 0; i < info.Rows.Count; i++)
                {
                    resultadoAnimales.Text = resultadoAnimales.Text + info.Rows[i]["Nombre"].ToString() + "   " + info.Rows[i]["Animal"].ToString() + "   " + info.Rows[i]["Color"].ToString() + "\n";

                }
            }
            if (texto.Substring(0,1) == "3")
            {
                texto = texto.Trim(new Char[] { ' ', '3', '.' });
                info = miConexion.buscaMascotaPorAnimal(texto);
                for (int i = 0; i < info.Rows.Count; i++)
                {
                    resultadoAnimales.Text = resultadoAnimales.Text + info.Rows[i]["Nombre"].ToString() + "   " + info.Rows[i]["Animal"].ToString() + "   " + info.Rows[i]["Color"].ToString() + "\n";

                }
            }
            if (texto.Substring(0,1) == "4")
            {
                texto = texto.Trim(new Char[] { ' ', '4', '.' });
                info = miConexion.buscaMascotaPorColor(texto);
                for (int i = 0; i < info.Rows.Count; i++)
                {
                    resultadoAnimales.Text = resultadoAnimales.Text + info.Rows[i]["Nombre"].ToString() + "   " + info.Rows[i]["Animal"].ToString() + "   " + info.Rows[i]["Color"].ToString() + "\n";

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


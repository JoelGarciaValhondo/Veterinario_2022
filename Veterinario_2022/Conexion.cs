using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Veterinario_2022
{
    class Conexion
    {
        public MySqlConnection conexion;
        public Conexion()
        {
            conexion = new MySqlConnection("Server = 127.0.0.1; DataBase = usuariosveterinario; Uid = root; Pwd =; Port = 3306;");
        }

        public Boolean getUsuarioYPass(String nombre, String apellido, String password)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM info_usuario WHERE Nombre = @nombre AND Apellido = @apellido AND password = @pass", conexion);
                //USAR PARAMETRIZACION CON CAJAS DE TEXTO O CAJAS DE BUSQUEDA. 
                consulta.Parameters.AddWithValue("@nombre", nombre);
                consulta.Parameters.AddWithValue("@apellido", apellido);
                consulta.Parameters.AddWithValue("@pass", password);
                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    return true;
                }
                conexion.Close();
                return false;
            }
            catch(MySqlException e)
            {
                return false;
            }
        }
    }
}

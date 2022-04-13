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

        public DataTable getUsuarioYPass(int id)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM info_usuario WHERE id='" + id + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable info_usuarios = new DataTable();
                info_usuarios.Load(resultado);
                conexion.Close();
                return info_usuarios; 
            }
            catch(MySqlException e)
            {
                throw e;
            }
        }
    }
}

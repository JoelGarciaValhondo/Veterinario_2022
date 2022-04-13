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

        //LOS DATOS PARA LOGIN E INSERTAR SON DISTINTOS A LOS DE JORGE YA QUE LA BBDD NO ES IGUAL.

        public Boolean getUsuarioYPass(String nombre, String apellido, String pass)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM info_usuario WHERE Nombre = @nombre AND Apellido = @apellido", conexion);
                //USAR PARAMETRIZACION CON CAJAS DE TEXTO O CAJAS DE BUSQUEDA. 
                consulta.Parameters.AddWithValue("@nombre", nombre);
                consulta.Parameters.AddWithValue("@apellido", apellido);
                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    String passwordConHash = resultado.GetString("password");
                    if (BCrypt.Net.BCrypt.Verify(pass, passwordConHash))
                    {
                        return true;
                    }
                    return false;
                }
                conexion.Close();
                return false;
            }
            catch(MySqlException e)
            {
                return false;
            }
        }

        public String insertaUsuario(String DNI, String nombre, String apellido, String password, String email)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO info_usuario (id, DNI, Nombre, Apellido, password, email) VALUES (NULL, @DNI, @Nombre, @Apellido, @password, @email)", conexion);
                consulta.Parameters.AddWithValue("@DNI", DNI);
                consulta.Parameters.AddWithValue("@Nombre", nombre);
                consulta.Parameters.AddWithValue("@Apellido", apellido);
                consulta.Parameters.AddWithValue("@password", password);
                consulta.Parameters.AddWithValue("@email", email);

                consulta.ExecuteNonQuery();

                conexion.Close();
                return "ok";
            }
            catch(MySqlException e)
            {
                return "error";
            }
        }
    }
}

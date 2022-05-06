using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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
                MySqlCommand consulta = new MySqlCommand ("INSERT INTO info_usuario (id, DNI, Nombre, Apellido, password, email) VALUES (NULL, @DNI, @Nombre, @Apellido, @password, @email)", conexion);
                consulta.Parameters.AddWithValue("@DNI", DNI);
                consulta.Parameters.AddWithValue("@Nombre", nombre);
                consulta.Parameters.AddWithValue("@Apellido", apellido);
                consulta.Parameters.AddWithValue("@password", password);
                consulta.Parameters.AddWithValue("@email", email);

                consulta.ExecuteNonQuery();

                conexion.Close();
                MessageBox.Show("Usuario Añadido");
                return "ok";
            }
            catch(MySqlException e)
            {
                 MessageBox.Show("error");
                return "error";
            }
        }

        public String insertaMascota(String animal, String nombre, String color)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO mascotas (Animal, Nombre, Color) VALUES (@Animal, @Nombre, @Color)", conexion);
                consulta.Parameters.AddWithValue("@Animal", animal);
                consulta.Parameters.AddWithValue("@Nombre", nombre);
                consulta.Parameters.AddWithValue("@Color", color);

                consulta.ExecuteNonQuery();

                conexion.Close();
                return "ok";
            }
            catch (MySqlException e)
            {
                return "error";
            }
        }

        public DataTable buscaUsuario(String nombre)
        {
            conexion.Open();
            MySqlCommand consulta = new MySqlCommand("SELECT DNI, Nombre, Apellido, email FROM info_usuario WHERE Nombre = @nombre", conexion);
            consulta.Parameters.AddWithValue("@nombre", nombre);
            MySqlDataReader resultado = consulta.ExecuteReader();
            DataTable usuario = new DataTable();
            usuario.Load(resultado);
            conexion.Close();
            return usuario;
        }

        public DataTable buscaMascotaPorNombre(String nombre)
        {
            conexion.Open();
            MySqlCommand consulta = new MySqlCommand("SELECT Animal, Nombre, Color FROM mascotas WHERE Nombre = @nombre", conexion);
            consulta.Parameters.AddWithValue("@nombre", nombre);
            MySqlDataReader resultado = consulta.ExecuteReader();
            DataTable mascotas = new DataTable();
            mascotas.Load(resultado);
            conexion.Close();
            return mascotas;
        }

        public DataTable buscaMascotaPorAnimal(String animal)
        {
            conexion.Open();
            MySqlCommand consulta = new MySqlCommand("SELECT Animal, Nombre, Color FROM mascotas WHERE Animal = @animal", conexion);
            consulta.Parameters.AddWithValue("@animal", animal);
            MySqlDataReader resultado = consulta.ExecuteReader();
            DataTable mascotas = new DataTable();
            mascotas.Load(resultado);
            conexion.Close();
            return mascotas;
        }

        public DataTable buscaMascotaPorColor(String color)
        {
            conexion.Open();
            MySqlCommand consulta = new MySqlCommand("SELECT Animal, Nombre, Color FROM mascotas WHERE Color = @color", conexion);
            consulta.Parameters.AddWithValue("@color", color);
            MySqlDataReader resultado = consulta.ExecuteReader();
            DataTable mascotas = new DataTable();
            mascotas.Load(resultado);
            conexion.Close();
            return mascotas;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laboratoriofinal2.Data;
using Laboratoriofinal2.Data.Models;
using MySql.Data.MySqlClient;

namespace Laboratoriofinal2.Data
{
    internal class ConexionPro

    {
        string connectionString = "server=localhost;database=db_universidad;user=root;password=123Pk2..";
        MySqlConnection connection;

        //Prueba conecta
        public bool ProbarConexion()
        {

            //Explicar

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public DataTable Imprimir()
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM catalogo_consolas";

                //Explicar

                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {

                    //Explicar

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {

                        //Explicar

                        adapter.Fill(tabla);
                    }
                }
            }

            return tabla;
        }

        //constructor
        public ConexionPro()
        {
            connection = new MySqlConnection(connectionString);
        }

        public void InsertarConsolas(ConsolasPros Consolita)
        {
            try
            {
                string query = "INSERT INTO catalogo_consolas (nombre_consola, compania, anio_lanzamiento, generacion) VALUES (@nombre,@compania,@fecha_lanzar,@generacion)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nombre", Consolita.Nombre);
                cmd.Parameters.AddWithValue("@compania", Consolita.Compania);
                cmd.Parameters.AddWithValue("@fecha_lanzar", Consolita.Fecha_lanzamiento);
                cmd.Parameters.AddWithValue("@generacion", Consolita.Generacion);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void Actualizar(ConsolasPros Consolita)
        {
            try
            {
                string query = "UPTADATE catalogo_consolas Set nombre = @nombre, compania = @compania, fecha_lanzar = @fecha_lanzar, generacion = @generacion where id_consola";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id_consola", Consolita.id_consola);
                cmd.Parameters.AddWithValue("@nombre", Consolita.Nombre);
                cmd.Parameters.AddWithValue("@compania", Consolita.Compania);
                cmd.Parameters.AddWithValue("@fecha_lanzar", Consolita.Fecha_lanzamiento);
                cmd.Parameters.AddWithValue("@generacion", Consolita.Generacion);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
      
        }
        public void BorrarConsola(int idConsola)
        {
            try
            {
                string query = "DELETE FROM catalogo_consolas WHERE id_consola = @id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", idConsola);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar el registro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public DataTable BuscarConsolasPorCompania(string compania)
        {
            DataTable dtConsolas = new DataTable();
            try
            {
                string query = "SELECT * FROM catalogo_consolas WHERE compania = @compania";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@compania", compania);
                connection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dtConsolas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar las consolas: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtConsolas;
        }
    }

}
    




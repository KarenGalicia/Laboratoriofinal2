using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using Laboratoriofinal2.Data;
using Laboratoriofinal2.Data.Models;
using MySql.Data.MySqlClient;
using Connection = DocumentFormat.OpenXml.Office2010.Excel.Connection;

namespace Laboratoriofinal2
{
    public partial class Form1 : Form
    {

        private string[] compania = {
            "Atari",
            "Coleco",
            "Mattel",
            "Microsoft",
            "Nintendo",
            "Ouya Inc.",
            "Sega",
            "Sony"
        };

        public Form1()
        {
            InitializeComponent();
        }
        private ConexionPro consolas = new ConexionPro();

        private void ButtonPrueba_Click(object sender, EventArgs e)
        {
            if (consolas.ProbarConexion())
            {
                MessageBox.Show("Si se pudo 🧐🧐");
            }
            else
            {
                MessageBox.Show("Nel Pastel 🦁🦁");
            }
        }

        private void Buttoncargar_Click(object sender, EventArgs e)
        {


            {

                {
                    dataGridViewTabla_contenido.DataSource = consolas.Imprimir();
                }
            }
        }

        private void Buttoninsertar_Click(object sender, EventArgs e)
        {

        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {

        }

        private void Buttonborrar_Click(object sender, EventArgs e)
        {

            try
            {
                // Capturar el ID de la consola a borrar desde el TextBox
                int idConsola = int.Parse(textBoxId.Text);

                // Llamar al método BorrarConsola para borrar la consola
                BorrarConsola(idConsola);

                MessageBox.Show("Consola borrada exitosamente.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar la consola: " + ex.Message);
            }
        }

        private void BorrarConsola(int idConsola)
        {
            throw new NotImplementedException();
        }

        private void ButtonBuscarCompañia_Click(object sender, EventArgs e)
        {
            
                DataTable dtConsolas = new DataTable();
                try
                {
                    // Capturar el nombre de la compañía del TextBox
                    string compania = textBoxbuscarcompañia.Text;

                    // Consulta SQL para buscar consolas por compañía
                    string query = "SELECT * FROM catalogo_consolas WHERE compania = @compania";
                    MySqlCommand cmd = new MySqlCommand(query, Connection);
                    cmd.Parameters.AddWithValue("@compania", compania);

                    // Abrir la conexión
                    connection.Open();

                    // Ejecutar la consulta y llenar el DataTable
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dtConsolas);

                    // Mostrar los resultados en el DataGridView
                    dataGridViewResultados.DataSource = dtConsolas;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar las consolas: " + ex.Message);
                }
                finally
                {
                // Asegurarse de cerrar la conexión
                connection.Close();
                }
            }
        }
    }



    
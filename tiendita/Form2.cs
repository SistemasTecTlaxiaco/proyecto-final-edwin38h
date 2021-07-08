using Admin2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Administrador1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        static string conectar = "datasource=127.0.0.1;port=3307;username=root;password=;database=tienda;";
        MySqlConnection databaseConnection = new MySqlConnection(conectar);

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = actualizarDatos("select nombre_producto, cantidad, precio from producto");
        }

        public DataTable actualizarDatos(String llenar)
        {
            databaseConnection.Open();
            DataTable dt = new DataTable();
            try
            {

                MySqlCommand cmd = new MySqlCommand(llenar, databaseConnection);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                databaseConnection.Close();
                return dt;
            }
            catch (Exception ex)
            {
               
                databaseConnection.Close();
                return dt;
            }
        }

       

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();    


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                textBox6.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = actualizarDatos("update producto set `cantidad` = `cantidad` + " + textBox7.Text  +" where producto.Nombre_producto like "+ "\"" + textBox6.Text + "\"");
            dataGridView1.DataSource = actualizarDatos("select nombre_producto, cantidad, precio from producto");
        }

        private void registro_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = actualizarDatos("select * from venta_del_dia");
        
    }
    }
    }


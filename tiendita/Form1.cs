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

namespace Admin2
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        static string conectar = "datasource=127.0.0.1;port=3307;username=root;password=;database=tienda;";
        MySqlConnection databaseConnection = new MySqlConnection(conectar);
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = actualizarDatos("select idventa, nombre_producto, cantidad, precio from venta");
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario2 = new Administrador1.Form2();
            formulario2.ShowDialog();
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
                MessageBox.Show(ex.Message);
                databaseConnection.Close();
                return dt;
            }
        }
        //buscar
        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = actualizarDatos("SELECT Nombre_producto as producto, precio  FROM producto where Nombre_producto like"+ "\""+buscador.Text+"\"");
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                buscador.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            catch
            {

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //AGREGAR AL CARRITO
        private void Agregador_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = actualizarDatos("insert into venta(nombre_producto, cantidad, precio) SELECT nombre_producto, cantidad, precio from producto where producto.Nombre_producto like" + "\""+buscador.Text+ "\"; update venta set `cantidad` = 1 where Nombre_producto like" + "\"" + buscador.Text + "\"");
            dataGridView1.DataSource = actualizarDatos("update producto set `cantidad` = `cantidad`-1 where producto.Nombre_producto like " + "\"" + buscador.Text + "\"");
            dataGridView1.DataSource = actualizarDatos("select idventa, nombre_producto, cantidad, precio from venta");
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(recivido.Text == null)
            {

            }
            else
            {

                dataGridView1.DataSource = actualizarDatos("insert into venta_del_dia (`total de ventas`) SELECT SUM(venta.precio) from venta; TRUNCATE table venta");


                MessageBox.Show("La venta fue exitosa");

            }

        }

        private void recivido_TextChanged(object sender, EventArgs e)
        {
        }

        private void recivido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

           
        }

        private void visualizar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = actualizarDatos("SELECT SUM(venta.precio) as total, " + recivido.Text + "- SUM(venta.precio) as `total a dar cambio` from venta");
        }

        //eliminar del carrito
        private void Eliminador_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = actualizarDatos("delete FROM venta where idventa = "+ idd.Text);
            dataGridView1.DataSource = actualizarDatos("select idventa, nombre_producto, cantidad, precio from venta");
            dataGridView1.DataSource = actualizarDatos("update producto set `cantidad` = `cantidad`+1 where producto.Nombre_producto like " + "\"" + buscador.Text + "\"");
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = actualizarDatos("select idventa, nombre_producto, cantidad, precio from venta");
        }

        private void idd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            
        }
    }
}

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
namespace RentaVideos
{
    
    public partial class rmDevoluciones : Form
 
    {
        
    string user = "";
        public class Devoluciones 
        {
            public DateTime fechaActual { get; set; }
            public  Devoluciones() { }
            public Devoluciones(DateTime FechaDev) { this.fechaActual = FechaDev; }

           
        }
        
        public rmDevoluciones()
        {
            InitializeComponent();
        }
        public rmDevoluciones(string user)
        {
            InitializeComponent();
            this.user = user;
        }
       
    private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal menu = new menuPrincipal(user);
            menu.Show();
        }

        private void rmDevoluciones_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            int i = 0;
            int suma = 0;
            for (i =1; i< dataGridView1.RowCount;i++)
            {
                suma = suma + int.Parse(dataGridView1.Rows[4].Cells[1].Value.ToString());
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {

        }

        private void button47_Click(object sender, EventArgs e)
        {
           int devolver ;

            int codigo;
            string nombre;
            DateTime FecIn;
            DateTime FecDev;

            MySqlCommand InfDetRent = new MySqlCommand(string.Format("pd_BuscarVideoDevolucion"), ConectarServidor.conexion());
            InfDetRent.CommandType = CommandType.StoredProcedure;

            InfDetRent.Parameters.AddWithValue("@NMem", textBox29.Text);
            MySqlDataReader reader = InfDetRent.ExecuteReader();



            codigo = int.Parse(reader.GetString(1));
            codigo = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            nombre = reader.GetString(2);
            nombre =  dataGridView1.CurrentRow.Cells[1].Value.ToString();
            FecIn = Convert.ToDateTime(reader.GetString(3));
            FecIn = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            FecDev = Convert.ToDateTime(reader.GetString(4));
            FecDev = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value.ToString());

           devolver = InfDetRent.ExecuteNonQuery();
            
            /*if (dateTimePicker1 > FecDev)
            {
                MessageBox.Show("El Cliente esta atrasado en la devolución");
                
            }*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

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
        public int diferencia = 0;
        public string codigo ="";
       

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
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("Select idMembresia from Membresia"), ConectarServidor.conexion());
                MySqlDataAdapter da = new MySqlDataAdapter(sql);
                DataSet ds = new DataSet();

                da.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    comMembresias.Items.Add(ds.Tables[0].Rows[i][0] );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
            const int columna = 6;
            int suma = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                suma += (int)row.Cells[columna].Value;
            }
            /*int i = 0;
            int suma = 0;
            for (i =1; i< dataGridView1.RowCount;i++)
            {
                suma = suma + int.Parse(dataGridView1.Rows[0].Cells[6].Value.ToString());
            }*/
        }

        private void button56_Click(object sender, EventArgs e)
        {

        }

        private void button47_Click(object sender, EventArgs e)
        {
            
            int devolver;
            DateTime fec1 ;
            DateTime fec2;
            TimeSpan calculo;
            string box = comMembresias.SelectedItem.ToString();
           /*box = box.Substring(0, box.IndexOf(" "));*/

            MySqlCommand InfDetRent = new MySqlCommand(string.Format("pd_BuscarVideoDevolucion"), ConectarServidor.conexion());
            InfDetRent.CommandType = CommandType.StoredProcedure;

            InfDetRent.Parameters.AddWithValue("@NMem", int.Parse(box));
            MySqlDataReader reader = InfDetRent.ExecuteReader();

            
            if (reader.Read()== true)
            {
                
               DataGridViewRow casillas = new DataGridViewRow();
                casillas.CreateCells(dataGridView1);
               casillas.Cells[0].Value = reader.GetString(0);
                casillas.Cells[1].Value = reader.GetString(1);
               casillas.Cells[2].Value = reader.GetString(2);
                casillas.Cells[3].Value = reader.GetString(3);
                casillas.Cells[4].Value= reader.GetDateTime(4);
                dataGridView1.Rows.Add(casillas);
                MySqlCommand sql1 = new MySqlCommand(String.Format("SELECT NOW()"), ConectarServidor.conexion());
                MySqlDataReader dr1 = sql1.ExecuteReader();
                if (dr1.Read() == true)
                {
                    fec1 = dr1.GetDateTime(0);
                    textBox1.Text = Convert.ToString(fec1);
                    fec2 = Convert.ToDateTime(casillas.Cells[4].Value = reader.GetDateTime(4));
                    calculo = fec1 - fec2;
                    diferencia = calculo.Days;
                    casillas.Cells[6].Value = "Q"+"."+diferencia * 10 ;
                    
                }


               


            }
            reader.Close();
            

            devolver = InfDetRent.ExecuteNonQuery();
            
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand RDev = new MySqlCommand(string.Format(""));

            
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

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

namespace SessionGLEB
{
    public partial class Admi : Form
    {
        public Admi( string Name, string Surname)
        {
            InitializeComponent();


            label1.Text = Name;
            label2.Text = Surname;
        }

        DB db = new DB();
        DataTable dt = new DataTable();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
 

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `product`", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Add MainF1 = new Add();
            MainF1.Show();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gitflow_project
{
    public partial class Form1 : Form
    {
        entidad ent = entidad.GetInstance();
        database db = new database();
        public Form1()
        {
            InitializeComponent();
        }
        
        void llenarTabla()
        {
            DataTable dt = db.llenarTabla();
            dataGridView1.DataSource = dt;
            ent.db = db;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            llenarTabla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 ventana = new Form3();    
            ventana.ShowDialog();
        }
    }
}

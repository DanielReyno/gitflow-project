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
        database db = new database();
        public Form1()
        {
            InitializeComponent();
        }
        
        void llenarTabla()
        {
            DataTable dt = db.llenarTabla();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            llenarTabla();
        }
    }
}

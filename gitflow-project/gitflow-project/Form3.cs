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
    public partial class Form3 : Form
    {
        entidad ent = entidad.GetInstance();
        database db = new database();
        public Form3()
        {
            InitializeComponent();
        }

        Form3(database test)
        {
            //db = test;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ent.ruta = textBox1.Text;
            ent.destino = textBox2.Text;
            ent.hora_partida = textBox3.Text;
            ent.hora_llegada = textBox4.Text;
            ent.precio = int.Parse(textBox5.Text);

            db.insertarDatos();
            ent.db.llenarTabla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

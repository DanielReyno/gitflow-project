using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace gitflow_project
{
    internal class database
    {
        String servidor = "Server=tcp:mydbsr.database.windows.net,1433;Initial Catalog=transAzure;Persist Security Info=False;User ID=empuser;Password=EmployeeUser*2023;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        
        entidad ent = entidad.GetInstance();
        public database() 
        { 
            
        }
        public DataTable llenarTabla()
        {
            SqlConnection conexion = new SqlConnection(servidor);
            SqlCommand comando = new SqlCommand("SELECT * FROM dbo.servicios", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;

        }
        public void insertarDatos()
        {
            String Query = "INSERT INTO dbo.servicios(id,ruta,destino,hora_partida,hora_llegada,costo) VALUES('"+null+"','" + ent.ruta + "','" + ent.destino + "','" + ent.hora_partida + "','" + ent.hora_llegada + "','"+ent.precio+"')";
            SqlConnection conexion = new SqlConnection(servidor);
            SqlCommand comando = new SqlCommand(Query, conexion);

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}

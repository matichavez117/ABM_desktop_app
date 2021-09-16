using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Datos
    {
        OleDbConnection conexion;
        OleDbCommand comando;
        OleDbDataReader lector;
        string cadenaConexion;

        public string CadenaConexion { get => cadenaConexion; set => cadenaConexion = value; }
        public OleDbDataReader pLector { get => lector; set => lector = value; }

        public Datos()
        {
            conexion = new OleDbConnection();
            comando = new OleDbCommand();
            CadenaConexion = @"Provider=SQLNCLI11;Data Source=localhost\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=TECNICATURAS_UTN_FRC";
        }

        public Datos (string cadenaConexion)
        {
            conexion = new OleDbConnection();
            comando = new OleDbCommand();
            this.cadenaConexion = cadenaConexion;
        }
           
        public void conectar()
        {
            conexion.ConnectionString = @"Provider=SQLNCLI11;Data Source=localhost\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=TECNICATURAS_UTN_FRC";
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        public DataTable ConsultarTabla(string nombreTabla)
        {
            conectar();
            comando.CommandText = "SELECT * FROM " + nombreTabla;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }

        public void desconectar()
        {
            conexion.Close();
        }


        public void leerTabla (string nombreTabla)
        {
            conectar();
            comando.CommandText = "SELECT * FROM " + nombreTabla;
            pLector = comando.ExecuteReader();
        }

        public void actualizar(string consultaSQL)
        {
            conectar();
            comando.CommandText = consultaSQL;
            comando.ExecuteNonQuery();
            desconectar();
        }

        public DataTable Consultar (string consultaSQL)
        {
            DataTable tabla = new DataTable();
            conectar();
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());
            this.desconectar();
            return tabla;
        }
    }
}

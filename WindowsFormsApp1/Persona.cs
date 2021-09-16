using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    class Persona
    {
        Datos oDatos = new Datos();
        int tipoDoc;
        int nroDoc;
        string apellido;
        string nombre;
        string direccion;
        int barrio;
        int genero;
        Int64 telefono;
        string email;
        DateTime fechaNac;

        public Persona()
        {
            tipoDoc = 0;
            nroDoc = 0;
            apellido = "";
            nombre = "";
            direccion = "";
            barrio = 0;
            genero = 0;
            telefono = 0;
            email = "";
            fechaNac = DateTime.Today;
        }

        public int pTipoDoc { get => tipoDoc; set => tipoDoc = value; }
        public int pNroDoc { get => nroDoc; set => nroDoc = value; }
        public string pApellido { get => apellido; set => apellido = value; }
        public string pNombre { get => nombre; set => nombre = value; }
        public string pDireccion { get => direccion; set => direccion = value; }
        public int pBarrio { get => barrio; set => barrio = value; }
        public int pGenero { get => genero; set => genero = value; }
        public Int64 pTelefono { get => telefono; set => telefono = value; }
        public string pEmail { get => email; set => email = value; }
        public DateTime pFechaNac { get => fechaNac; set => fechaNac = value; }

        public string ToStringPersona()
        {
            return apellido + " " + nombre + " - " + nroDoc;
        }


        public DataTable recuperarConsulta1 ()
        {
            string consultaSQL = "";
            return oDatos.Consultar(consultaSQL);
        }

        public DataTable recuperarConsulta2()
        {
            string consultaSQL = "";
            return oDatos.Consultar(consultaSQL);
        }

        public DataTable recuperarConsulta3()
        {
            string consultaSQL = ""; 
            return oDatos.Consultar(consultaSQL);
        }

        public DataTable recuperarConsulta4()
        {
            string consultaSQL = ""; 
            return oDatos.Consultar(consultaSQL);
        }

        public DataTable recuperarConsulta5()
        {
            string consultaSQL = "SELECT * from new_consulta5";
            return oDatos.Consultar(consultaSQL);
        }

        public DataTable recuperarConsulta6()
        {
            string consultaSQL = "select * from new_consulta6";
            return oDatos.Consultar(consultaSQL);
        }

        public DataTable recuperarConsulta7()
        {
            string consultaSQL = "select* from new_consulta7";
            return oDatos.Consultar(consultaSQL);
        }

        public DataTable recuperarConsulta8()
        {
            string consultaSQL = "";
            return oDatos.Consultar(consultaSQL);
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using WindowsFormsApp1;
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;

namespace WindowsFormsApp1
{
    public partial class FormConsultas : Form
    {
        Datos cDatos = new Datos();
        public FormConsultas()
        {
            InitializeComponent();
        }

        private void FormConsultas_Load(object sender, EventArgs e)
        {

        }

        private void btnConsulta5_Click(object sender, EventArgs e)
        {
            Persona oPersona = new Persona();
                dgConsultas.DataSource = oPersona.recuperarConsulta5();
                lblDetalle.Text = "Se quiere saber que materia se cursa por cuatrimestre para la administracion de aulas.";           
        }

        private void btnConsulta6_Click(object sender, EventArgs e)
        {
            Persona oPersona = new Persona();
            dgConsultas.DataSource = oPersona.recuperarConsulta6();
            lblDetalle.Text = "Lista los Docentes por Carrera y por Materias";
        }

        private void btnFiltrar5_Click(object sender, EventArgs e)
        {
            if (txtCodigoCuatrimestre.Text != String.Empty)
            {
                    string consultaSQL = "SELECT * from new_consulta5 WHERE CUATRIMESTRE LIKE '" + txtCodigoCuatrimestre.Text + "%'";
                    dgConsultas.DataSource = cDatos.Consultar(consultaSQL);
                    txtCodigoCuatrimestre.Clear();
            }

            if (rbtanio.Checked)
            {
                string consultaSQL = "SELECT * from new_consulta5 ORDER BY ANIO";
                dgConsultas.DataSource = cDatos.Consultar(consultaSQL);
            }

            if (rbtCuatrimestre.Checked)
            {
                string consultaSQL = "SELECT * from new_consulta5 ORDER BY CUATRIMESTRE";
                dgConsultas.DataSource = cDatos.Consultar(consultaSQL);
            }

        }

        private void txtCodigoCuatrimestre_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoCuatrimestre.Text != String.Empty)
            {
                rbtanio.Enabled = false;
                rbtanio.Checked = false;
                rbtCuatrimestre.Enabled = false;
                rbtCuatrimestre.Checked = false;
                
            }
            else
            {                
                rbtanio.Enabled = true;
                rbtCuatrimestre.Enabled = true;
            }
        }

        private void btnFiltrar6_Click(object sender, EventArgs e)
        {
            if (txtNombreCarrera.Text!=String.Empty)
            {
                string consultaSQL = "SELECT * from new_consulta6 WHERE TECNICATURA LIKE '" + txtNombreCarrera.Text + "%'";
                dgConsultas.DataSource = cDatos.Consultar(consultaSQL);
                txtNombreCarrera.Clear();
            }

            if (txtNombreMateria.Text != String.Empty)
            {
                string consultaSQL = "SELECT * from new_consulta6 WHERE MATERIA LIKE '" + txtNombreMateria.Text + "%'";
                dgConsultas.DataSource = cDatos.Consultar(consultaSQL);
                txtNombreMateria.Clear();
            }
        }

        private void txtNombreCarrera_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreCarrera.Text != string.Empty)
                txtNombreMateria.Enabled = false;
            else
                txtNombreMateria.Enabled = true;
        }

        private void txtNombreMateria_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreMateria.Text != string.Empty)
                txtNombreCarrera.Enabled = false;
            else
                txtNombreCarrera.Enabled = true;
        }

        private void btnConsulta7_Click(object sender, EventArgs e)
        {
            Persona oPersona = new Persona();
            dgConsultas.DataSource = oPersona.recuperarConsulta7();
            lblDetalle.Text = "Se quiere saber la cantidad de alumnos que rindieron alguna vez cada materia por fecha";
        }

        private void btnFiltrar7_Click(object sender, EventArgs e)
        {
            if(txtMateriaE.Text!=String.Empty)
            {
                string consultaSQL = "select * from new_consulta7 where MATERIA LIKE '" + txtMateriaE.Text + "%'";
                dgConsultas.DataSource = cDatos.Consultar(consultaSQL);
                txtNombreMateria.Clear();
            }

            if (rbtFecha.Checked)
            {                              
                string consultaSQL = "select * from new_consulta7 ORDER BY FECHA";
                dgConsultas.DataSource = cDatos.Consultar(consultaSQL);
                rbtFecha.Checked = false;
            }

            if(rbtTipoExamen.Checked)
            {
                string consultaSQL = "select * from new_consulta7 ORDER BY TIPO_EXAMEN";
                dgConsultas.DataSource = cDatos.Consultar(consultaSQL);
                rbtTipoExamen.Checked = false;
            }    

        }

        private void txtMateriaE_TextChanged(object sender, EventArgs e)
        {
            if (txtMateriaE.Text != String.Empty)
            {
                rbtTipoExamen.Enabled = false;
                rbtTipoExamen.Checked = false;
                rbtFecha.Enabled = false;
                rbtFecha.Checked = false;
            }

            else
            {
                rbtTipoExamen.Enabled = true;
                rbtFecha.Enabled = true;
            }

        }


    }
}

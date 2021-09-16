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


namespace WindowsFormsApp1
{
    public partial class FormReporteDP : Form
    {
        Datos oDatos = new Datos();
        public FormReporteDP()
        {
            InitializeComponent();
        }

        private void FormReporteDP_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDatosPersonales.DATOS_PERSONALES' Puede moverla o quitarla según sea necesario.
            //this.DATOS_PERSONALESTableAdapter.Fill(this.dsDatosPersonales.DATOS_PERSONALES);

            //this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
        }

        private void btnImprimirTodo_Click(object sender, EventArgs e)
        {
            string consultaSQL = "SELECT * FROM DATOS_PERSONALES";
            if (rbtApellidoF.Checked)
                consultaSQL += " ORDER BY APELLIDO";
            if (rbtNroDocF.Checked)
                consultaSQL += " ORDER BY NUM_DOC";
            DATOS_PERSONALESBindingSource.DataSource = oDatos.Consultar(consultaSQL);
            reportViewer1.RefreshReport();
        }

        private void btnImprimirFiltro_Click(object sender, EventArgs e)
        {
            string consultaSQL = "SELECT * FROM DATOS_PERSONALES WHERE NOMBRE LIKE '"+txtNombreF.Text+"%'";
            if (rbtApellidoF.Checked)
                consultaSQL += " ORDER BY APELLIDO";
            if (rbtNroDocF.Checked)
                consultaSQL += " ORDER BY NUM_DOC";
            DATOS_PERSONALESBindingSource.DataSource = oDatos.Consultar(consultaSQL);
            reportViewer1.RefreshReport();
        }
    }
    
}

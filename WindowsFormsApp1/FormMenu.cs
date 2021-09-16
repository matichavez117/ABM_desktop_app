using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmUDM : Form
    {
        int c;
        public frmUDM()
        {
            InitializeComponent();
            ReporteTSMI.Enabled = false;
            archivoTSMI.Enabled = false;
            ConsultasTSMI.Enabled = false;
            c = 0;
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void frmUDM_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCuenta.Text == "Admin" && txtConstrasenia.Text == "Admin")
            {
                archivoTSMI.Enabled = true;
                ReporteTSMI.Enabled = true;
                ConsultasTSMI.Enabled = true;
                txtCuenta.Enabled = false;
                txtConstrasenia.Enabled = false;
                btnCerrarSesion.Visible = true;
                btnIngresar.Visible = false;
            }
            else
            {
                MessageBox.Show("La cuenta ingresada no es válida", "ADVERTENCIA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                c++;
            }

            if (c==3)
            {
                MessageBox.Show("Se ha superado el máximo de intentos permitidos","ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);                          
                txtCuenta.Enabled = false;
                txtConstrasenia.Enabled = false;
                btnIngresar.Enabled = false;
            }
        }

        private void archivoTSMI_Click(object sender, EventArgs e)
        {
            
        }

        private void frmUDM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir de UDM?",
        "SALIENDO",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPersona fp = new FormPersona();
            fp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            archivoTSMI.Enabled = false;
            ReporteTSMI.Enabled = false;
            ConsultasTSMI.Enabled = false;
            txtCuenta.Clear();
            txtConstrasenia.Clear();
            txtConstrasenia.Enabled = true;
            txtCuenta.Enabled = true;
            btnCerrarSesion.Visible = false;
            btnIngresar.Visible = true;
        }

        private void consultarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormConsultas fc = new FormConsultas();
            fc.ShowDialog();
        }

        private void datosPersonalesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormReporteDP rpdp = new FormReporteDP();
            rpdp.ShowDialog();
            
        }
    }
}

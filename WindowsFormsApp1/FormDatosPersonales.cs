using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class FormPersona : System.Windows.Forms.Form
    {
        Datos oDatos = new Datos();
        const int tam = 1000;
        bool nuevo;
        Persona[] aPersona = new Persona[tam];
        int c;

        public FormPersona()
        {
            InitializeComponent();
            c = 0;
            for (int i = 0; i < tam; i++)
            {
                aPersona[i] = null;
            }
            nuevo = false;
        }

        private void FormPersona_Load(object sender, EventArgs e)
        {
            CargarCombo(cboBarrio, "BARRIOS", "NOMBRE_BARRIO", "COD_BARRIO");
            CargarCombo(cboGenero, "GENEROS", "DESCRIPCION", "ID_GENERO");
            CargarCombo(cboTipoDoc, "TIPOS_DOC", "DESCRIPCION", "ID_TIPO_DOC");
            cargarLista("DATOS_PERSONALES");
        }

        private void CargarCombo(ComboBox combo, string nombreTabla, string campoDisplay, string campoID) //METODO PARA CARGAR COMBO
        {
            DataTable tabla = new DataTable();
            tabla = oDatos.ConsultarTabla(nombreTabla);
            combo.DataSource = tabla;
            combo.DisplayMember = campoDisplay;
            combo.ValueMember = campoID;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cargarLista(string nombreTabla)
        {
            oDatos.leerTabla(nombreTabla);
            while (oDatos.pLector.Read())
            {
                Persona p = new Persona();

                if (!oDatos.pLector.IsDBNull(1))
                    p.pTipoDoc = oDatos.pLector.GetInt32(1);
                if (!oDatos.pLector.IsDBNull(2))
                    p.pNroDoc = oDatos.pLector.GetInt32(2);
                if (!oDatos.pLector.IsDBNull(3))
                    p.pApellido = oDatos.pLector.GetString(3);
                if (!oDatos.pLector.IsDBNull(4))
                    p.pNombre = oDatos.pLector.GetString(4);
                if (!oDatos.pLector.IsDBNull(5))
                    p.pDireccion = oDatos.pLector.GetString(5);
                if (!oDatos.pLector.IsDBNull(6))
                    p.pBarrio = oDatos.pLector.GetInt32(6);
                if (!oDatos.pLector.IsDBNull(7))
                    p.pGenero = oDatos.pLector.GetInt32(7);
                if (!oDatos.pLector.IsDBNull(8))
                    p.pTelefono = oDatos.pLector.GetInt64(8);
                if (!oDatos.pLector.IsDBNull(9))
                    p.pEmail = oDatos.pLector.GetString(9);
                if (!oDatos.pLector.IsDBNull(10))
                    p.pFechaNac = oDatos.pLector.GetDateTime(10);

                aPersona[c] = p;

                c++;
            }
            oDatos.pLector.Close();
            oDatos.desconectar();
            for (int i = 0; i < c; i++)
            {
                listPersonas.Items.Add(aPersona[i].ToStringPersona());

            }
            listPersonas.SelectedIndex = 0;
        }

        private void FormPersona_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private bool validar()
        {
            if (cboTipoDoc.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un tipo de documento");
                cboTipoDoc.Focus();
                return false;
            }
            if (txtNroDoc.Text == "")
            {
                MessageBox.Show("Debe ingresar un numero de documento");
                txtNroDoc.Focus();
                return false;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar el apellido");
                txtApellido.Focus();
                return false;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre");
                txtNombre.Focus();
                return false;
            }
            if (txtDireccion.Text == "")
            {
                MessageBox.Show("Debe ingresar una direccion");
                txtDireccion.Focus();
                return false;
            }
            if (cboBarrio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un barrio");
                cboBarrio.Focus();
                return false;
            }
            if (cboGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un genero");
                cboGenero.Focus();
                return false;
            }
            if (txtTelefono.Text == "")
            {
                MessageBox.Show("Debe ingresar un telefono");
                txtTelefono.Focus();
                return false;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Debe ingresar un email");
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private bool existe(int pk)
        {
            for (int i = 0; i < c; i++)
            {
                if (aPersona[i].pNroDoc == pk)
                    return true;
            }
            return false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCampos(listPersonas.SelectedIndex);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            string consultaSQL = "";
            if (validar())
            {
                
                if (nuevo)
                {

                    Persona p = new Persona();                    
                    p.pTipoDoc = cboTipoDoc.SelectedIndex + 1;
                    p.pNroDoc = Convert.ToInt32(txtNroDoc.Text);
                    p.pApellido = txtApellido.Text;
                    p.pNombre = txtNombre.Text;
                    p.pDireccion = txtDireccion.Text;
                    p.pBarrio = cboBarrio.SelectedIndex + 1;
                    p.pGenero = cboGenero.SelectedIndex + 1;
                    p.pTelefono = Convert.ToInt64(txtTelefono.Text);
                    p.pEmail = txtEmail.Text;
                    p.pFechaNac = dtpFechaNac.Value;

                        if (!existe(p.pNroDoc))
                    {
                        consultaSQL = "INSERT INTO DATOS_PERSONALES (ID_TIPO_DOC, NUM_DOC, APELLIDO, NOMBRE, DIRECCION, COD_BARRIO, ID_GENERO, TELEFONO, [E-MAIL], FEC_NAC) " +
                                       "VALUES (" + p.pTipoDoc + "," +
                                                    p.pNroDoc + ",'" +
                                                    p.pApellido + "','" +
                                                    p.pNombre + "','" +
                                                    p.pDireccion + "'," +
                                                    p.pBarrio + "," +
                                                    p.pGenero + "," +
                                                    p.pTelefono + ",'" +
                                                    p.pEmail + "','" +
                                                    p.pFechaNac.ToString("MM/dd/yyyy") + "')";



                        oDatos.actualizar(consultaSQL);

                    }

                }
                else
                {
                    int i = listPersonas.SelectedIndex;
                    aPersona[i].pTipoDoc = cboTipoDoc.SelectedIndex + 1;
                    aPersona[i].pNroDoc = Convert.ToInt32(txtNroDoc.Text);
                    aPersona[i].pApellido = txtApellido.Text;
                    aPersona[i].pNombre = txtNombre.Text;
                    aPersona[i].pDireccion = txtDireccion.Text;
                    aPersona[i].pBarrio = cboBarrio.SelectedIndex + 1;
                    aPersona[i].pGenero = cboGenero.SelectedIndex + 1;
                    aPersona[i].pTelefono = Convert.ToInt64(txtTelefono.Text);
                    aPersona[i].pEmail = txtEmail.Text;
                    aPersona[i].pFechaNac = dtpFechaNac.Value;

                    consultaSQL = "UPDATE DATOS_PERSONALES SET ID_TIPO_DOC=" + aPersona[i].pTipoDoc + ","
                                              + "NUM_DOC=" + aPersona[i].pNroDoc + ","
                                              + "APELLIDO ='" + aPersona[i].pApellido + "',"
                                              + "NOMBRE = '" + aPersona[i].pNombre + "',"
                                              + "DIRECCION= '" + aPersona[i].pDireccion + "',"
                                              + "COD_BARRIO=" + aPersona[i].pBarrio + ","
                                              + "ID_GENERO=" + aPersona[i].pGenero + ","
                                              + "TELEFONO=" + aPersona[i].pTelefono + ","
                                              + "[E-MAIL]='" + aPersona[i].pEmail + "',"
                                              + "FEC_NAC='" + aPersona[i].pFechaNac.ToString("MM/dd/yyyy")
                                              + "' WHERE NUM_DOC =" + aPersona[i].pNroDoc;

                    oDatos.actualizar(consultaSQL);

                }
                cargarLista("DATOS_PERSONALES");
            }
            nuevo = false;
        }

        private void cargarCampos(int posicion)
        {
            cboTipoDoc.SelectedValue = aPersona[posicion].pTipoDoc;
            txtNroDoc.Text = aPersona[posicion].pNroDoc.ToString();
            txtApellido.Text = aPersona[posicion].pApellido;
            txtNombre.Text = aPersona[posicion].pNombre;
            txtDireccion.Text = aPersona[posicion].pDireccion;
            cboBarrio.SelectedValue = aPersona[posicion].pBarrio;
            cboGenero.SelectedValue = aPersona[posicion].pGenero;
            txtTelefono.Text = aPersona[posicion].pTelefono.ToString();
            txtEmail.Text = aPersona[posicion].pEmail;
            dtpFechaNac.Value = aPersona[posicion].pFechaNac;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea borrar este producto?",
                    "BORRANDO",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string consultaSQL = "DELETE FROM DATOS_PERSONALES WHERE NUM_DOC=" + aPersona[listPersonas.SelectedIndex].pNroDoc;

                oDatos.actualizar(consultaSQL);
                cargarLista("DATOS_PERSONALES");
                limpiar();
            }
        }

        private void limpiar()
        {
            cboTipoDoc.SelectedIndex = -1;
            txtNroDoc.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            cboBarrio.SelectedIndex = -1;
            cboGenero.SelectedIndex = -1;
            txtTelefono.Clear();
            txtEmail.Clear();
            dtpFechaNac.ResetText();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            nuevo = true;
            limpiar();
            cboTipoDoc.Focus();
        }

        private void txtNroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar>=32 && e.KeyChar<=47) ||(e.KeyChar>=58 && e.KeyChar<=255))
            {
                MessageBox.Show("Debe ingresar solo números", "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Debe ingresar solo números", "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar>=32 && e.KeyChar<=64) || (e.KeyChar>=91 && e.KeyChar<=96) || (e.KeyChar>=123 && e.KeyChar<=255))
            {
                
                MessageBox.Show("Debe ingresar solo letras", "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                e.Handled = true;
                return; ;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Debe ingresar solo letras", "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

    }
}

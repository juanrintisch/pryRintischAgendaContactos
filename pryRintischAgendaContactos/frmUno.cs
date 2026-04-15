using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRintischAgendaContactos
{
   
    public partial class frmUno : Form
    {
        string varNombre = "";
        string varApellido = "";
        int varNumero = 0;
        string varCorreo = "";
        string varCategoria = "";


        public frmUno()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre");
                txtNombre.Focus();
            }

            else if (txtApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar un apellido");
                txtApellido.Focus();
            }

            else if (mskNumero.Text == "(351)   -")
            {
                MessageBox.Show("Debe ingresar un numero de telefono");
                mskNumero.Focus();
            }

            else if (txtCorreo.Text == "")
            {
                MessageBox.Show("Debe ingresar un correo electronico");
                txtCorreo.Focus();
            }

            else if (cmbCategoria.Text == "")
            {
                MessageBox.Show("Debe seleccionar una categoria");
                cmbCategoria.Focus();

            }
            else if (txtNombre.Text != "" && txtApellido.Text != "" && mskNumero.Text != "(351)   -" && txtCorreo.Text != "" && cmbCategoria.Text != "")
            {
                dtaDatos.Rows.Add(txtNombre.Text, txtApellido.Text, mskNumero.Text, txtCorreo.Text, cmbCategoria.Text);
                txtNombre.Clear();
                txtApellido.Clear();
                mskNumero.Clear();
                txtCorreo.Clear();
                cmbCategoria.SelectedIndex = -1;
                txtNombre.Focus();
                MessageBox.Show("Contacto agregado correctamente");
            }
            

        }
                              
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dtaDatos.Rows.RemoveAt(dtaDatos.CurrentRow.Index);
            MessageBox.Show("Contacto eliminado correctamente");
        }

        private void brnEditar_Click(object sender, EventArgs e)
        {
           if (txtNombre.Text != "" && txtApellido.Text != "" && mskNumero.Text != "(351)   -" && txtCorreo.Text != "" && cmbCategoria.Text != "")
           {
                dtaDatos.CurrentRow.Cells[0].Value = txtNombre.Text;
                dtaDatos.CurrentRow.Cells[1].Value = txtApellido.Text;
                dtaDatos.CurrentRow.Cells[2].Value = mskNumero.Text;
                dtaDatos.CurrentRow.Cells[3].Value = txtCorreo.Text;
                dtaDatos.CurrentRow.Cells[4].Value = cmbCategoria.Text;
                MessageBox.Show("Contacto editado correctamente");
                txtNombre.Clear();
                txtApellido.Clear();
                mskNumero.Clear();
                txtCorreo.Clear();
                cmbCategoria.SelectedIndex = -1;
                txtNombre.Focus();
            }           
        }

        private void dtaDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

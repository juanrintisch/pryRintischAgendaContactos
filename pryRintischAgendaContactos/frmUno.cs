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
                MessageBox.Show("Debe Ingresar un Nombre", "Upss!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
            }

            else if (txtApellido.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Apellido", "Upss!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
            }

            else if (mskNumero.Text == "(351)   -")
            {
                MessageBox.Show("Debe Ingresar un Numero de Telefono", "Upss!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNumero.Focus();
            }

            else if (txtCorreo.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Correo Electronico", "Upss!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
            }

            else if (cmbCategoria.Text == "")
            {
                MessageBox.Show("Debe Seleccionar una Categoria", "Upss!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Contacto Agregado Correctamente", "Contactos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            brnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }
                              
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           var Resultado = MessageBox.Show("¿Desea Eliminar el Contacto?", "Contactos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
           if (Resultado == DialogResult.Yes)
           {
               dtaDatos.Rows.RemoveAt(dtaDatos.CurrentRow.Index);
               MessageBox.Show("Contacto Eliminado Correctamente", "Contactos", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
            else
            {
                MessageBox.Show("No se Elimino el Contacto", "Contactos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void brnEditar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = dtaDatos.CurrentRow.Cells[0].Value.ToString();
            txtApellido.Text = dtaDatos.CurrentRow.Cells[1].Value.ToString();
            mskNumero.Text = dtaDatos.CurrentRow.Cells[2].Value.ToString();
            txtCorreo.Text = dtaDatos.CurrentRow.Cells[3].Value.ToString();
            cmbCategoria.Text = dtaDatos.CurrentRow.Cells[4].Value.ToString();
            btnConfirmarEdicion.Enabled = true;
            txtNombre.Focus();
        }

        private void dtaDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void grpBotones_Enter(object sender, EventArgs e)
        {

        }

        private void btnConfirmarEdicion_Click(object sender, EventArgs e)
        {           
           var Resultado = MessageBox.Show("¿Guardar cambios?", "Contactos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
           if (Resultado == DialogResult.Yes)
           {
               dtaDatos.CurrentRow.Cells[0].Value = txtNombre.Text;
               dtaDatos.CurrentRow.Cells[1].Value = txtApellido.Text;
               dtaDatos.CurrentRow.Cells[2].Value = mskNumero.Text;
               dtaDatos.CurrentRow.Cells[3].Value = txtCorreo.Text;
               dtaDatos.CurrentRow.Cells[4].Value = cmbCategoria.Text;
               MessageBox.Show("Contacto Editado Correctamente", "Contactos", MessageBoxButtons.OK, MessageBoxIcon.Information);
               txtNombre.Clear();
               txtApellido.Clear();
               mskNumero.Clear();
               txtCorreo.Clear();
               cmbCategoria.SelectedIndex = -1;
               txtNombre.Focus();
           }
            else
            {
                MessageBox.Show("No se Realizaron cambios", "Contactos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void grpTabla_Enter(object sender, EventArgs e)
        {

        }

        private void frmUno_Load(object sender, EventArgs e)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }
        //metodo de limpiar
        private void Limpiar() {

            TxtIdCliente.Text = string.Empty;
            TxtNombre.Text = string.Empty;
            TxtTelefono.Text = string.Empty;
            TxtDireccion.Text = string.Empty;
            TxtNombre.Focus();

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}

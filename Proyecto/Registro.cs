using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtRContraseña.Text == txtConfirmar.Text)
            {
                if(UsuarioDAL.CrearCuentas(txtRUsuario.Text, txtConfirmar.Text) > 0)
                {
                    //MessageBox.Show("Cuenta creada");
                    this.Hide();
                    Autenticacion lo = new Autenticacion();
                    lo.Show();
                }
                else
                {
                    MessageBox.Show("Cuenta no creada");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

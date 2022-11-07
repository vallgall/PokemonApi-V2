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
    public partial class Autenticacion : Form
    {
        public Autenticacion()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(UsuarioDAL.Autenticar(txtIUsuario.Text, txtIContraseña.Text) > 0)
            {
                this.Hide();
                PPokemon pp = new PPokemon();
                pp.Show();
                //MessageBox.Show("Ingreso con exito");
            }
            else
            {
                MessageBox.Show(" No ingreso con exito, datos incorrectos");
            }
        }

        private void btnICancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro re = new Registro();
            re.Show();
        }

        private void btnBIngresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autenticacion lo = new Autenticacion();
            lo.Show();
        }
    }
}

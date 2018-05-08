using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuringMachine
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnPalindromos_Click(object sender, EventArgs e)
        {
            frmPalindromos formPalindromos = new frmPalindromos();
            formPalindromos.Show();
            this.Hide();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            frmMultiplicacion formMultiplicacion = new frmMultiplicacion();
            formMultiplicacion.Show();
            this.Hide();
        }

        private void btnCopia_Click(object sender, EventArgs e)
        {
            frmCopiaPatron formCopiaPatron = new frmCopiaPatron();
            formCopiaPatron.Show();
            this.Hide();
        }
    }
}

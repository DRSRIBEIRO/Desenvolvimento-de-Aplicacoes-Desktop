using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrandoGastoRestaurante
{
    public partial class frmGastoEmRestaurante : Form
    {
        public frmGastoEmRestaurante()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //O N em ToString formata uma string para um valor numérico.
            txtTotalDaConta.Text = (Convert.ToDouble(txtDespesa.Text) * 1.10).ToString("N");
        }
    }
}

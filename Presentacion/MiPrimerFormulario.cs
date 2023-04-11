using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class MiPrimerFormulario : Form
    {
        public MiPrimerFormulario()
        {
            InitializeComponent();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_code.Text = "";
            txt_desc.Text = "";
            txt_code.Enabled = true;
            txt_desc.Enabled=true;
            //txt_code.Select();
            txt_code.Focus();

        }
    }
}

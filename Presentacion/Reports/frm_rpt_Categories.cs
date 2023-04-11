using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Reports
{
    public partial class frm_rpt_Categories : Form
    {
        public frm_rpt_Categories()
        {
            InitializeComponent();
        }

        private void frm_rpt_Categories_Load(object sender, EventArgs e)
        {
            this.uSP_List_CATableAdapter.Fill(this.dS_Reports.USP_List_CA, cText:txt_p1.Text) ;
            this.reportViewer1.RefreshReport();
        }
    }
}

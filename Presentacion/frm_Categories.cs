using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;
using System.Runtime.Remoting.Messaging;

namespace Presentacion
{
    public partial class frm_Categories : Form
    {
        public frm_Categories()
        {
            InitializeComponent();
            
        }

        #region "Mis variables"

        int save_status = 0;
        int ncode = 0; //save code for a selected row


        #endregion



        #region "Mis metodos"
        private void format_ca()
        {
            dgv_principal.Columns[0].Width = 80;
            dgv_principal.Columns[0].HeaderText = "CODIGO";
            dgv_principal.Columns[1].Width = 250;
            dgv_principal.Columns[1].HeaderText = "CATEGORIA";
        }


        private void list_ca(String cText)
        {
            dgv_principal.DataSource = N_Categories.List_ca(cText);
            this.format_ca();
        }

        private void frm_categories_load(object sender, EventArgs e )
        {
            this.list_ca("%");
        }


        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.list_ca(txt_search.Text.Trim());

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_description_ca.Text))
            {
                MessageBox.Show("No se tiene informacion para ser guardada", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                string response = "";
                E_Categories oCa = new E_Categories();
                oCa.code_ca = ncode;
                oCa.description_ca = txt_description_ca.Text.Trim();
                response = N_Categories.save_ca(save_status, oCa);
                if (response.Equals("OK"))
                {
                    this.list_ca("%");
                    txt_description_ca.Text = "";
                    this.lenabled(false);
                    save_status = 0;
                    ncode = 0;

                    MessageBox.Show("Datos guardados correctamente", "Aviso del sistema", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(response, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            

        }

        private void lenabled(bool enabled)
        {
            txt_description_ca.Enabled = enabled;
            btn_cancel.Enabled = enabled;
            btn_save.Enabled = enabled;

            btn_new.Enabled = !enabled;
            btn_update.Enabled = !enabled;
            btn_delete.Enabled = !enabled;
            btn_report.Enabled = !enabled;
            btn_goout.Enabled = !enabled;

            txt_search.Enabled = !enabled;
            btn_search.Enabled = !enabled;
            dgv_principal.Enabled = !enabled;

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            save_status = 1;
            this.lenabled(true);
            txt_description_ca.Text = "";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.lenabled(false);
            txt_description_ca.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            save_status = 2;
            this.lenabled(true);

        }

        private void dgv_principal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ncode = Convert.ToInt32(dgv_principal.CurrentRow.Cells["code_ca"].Value);
            txt_description_ca.Text = Convert.ToString(dgv_principal.CurrentRow.Cells["description_ca"].Value);
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            Reports.frm_rpt_Categories oRpt1 = new Reports.frm_rpt_Categories();
            oRpt1.txt_p1.Text = txt_search.Text;
            oRpt1.ShowDialog();
        }

        private void btn_goout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

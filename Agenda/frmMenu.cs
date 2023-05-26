using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            lbl_versao.Text = cl_geral.versao;
        }

        private void cmd_sair_Click(object sender, EventArgs e)
        {
            // sair do app
            if (MessageBox.Show("Dejesa sair da Agenda ?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Application.Exit();
        }

        private void cmd_inserir_Click(object sender, EventArgs e)
        {
            // ABRE O FORM DE EDIÇÃO

            frmInserirEditar formulario = new frmInserirEditar();

            formulario.ShowDialog();
        }
    }
}

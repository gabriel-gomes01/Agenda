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
            //Mostra a versão do programa
            lbl_versao.Text = cl_geral.versao;

            //Carrega os contatos do programas
            cl_geral.ConstroiListaContato();
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

        private void cmd_pesquisar_Click(object sender, EventArgs e)
        {
            frm_Texto f = new frm_Texto();
            f.ShowDialog();

            if (f.cancelado) return;

            //abre o quadro de resultado de pesquisa
            frm_resultado ff = new frm_resultado(f.texto);
            ff.ShowDialog();

        }
    }
}

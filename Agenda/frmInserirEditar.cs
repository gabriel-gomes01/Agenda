using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frmInserirEditar : Form
    {
        public frmInserirEditar()
        {
            InitializeComponent();
            ControiLista();
        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInserirEditar_Load(object sender, EventArgs e)
        {

        }

        private void ControiLista()
        {
            //adiciona a lista de contatos
            lista_contatos.Items.Clear();

            foreach (cl_contato contato in cl_geral.LISTA_CONTATOS)
            {
                lista_contatos.Items.Add(contato.nome + " (" + contato.numero + " )");
            }

            label_numero_registros.Text = "Registros: " + lista_contatos.Items.Count;

        }
    }
}

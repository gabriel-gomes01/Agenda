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
            ConstroiLista();
        }

        //======================================================================

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //======================================================================

        private void frmInserirEditar_Load(object sender, EventArgs e)
        {

        }

        //======================================================================

        private void ConstroiLista()
        {
            //adiciona a lista de contatos
            lista_contatos.Items.Clear();

            foreach (cl_contato contato in cl_geral.LISTA_CONTATOS)
            {
                lista_contatos.Items.Add(contato.nome + " (" + contato.numero + " )");
            }

            label_numero_registros.Text = "Registros: " + lista_contatos.Items.Count;

        }

        //======================================================================

        private void cmd_gravar_Click(object sender, EventArgs e)
        {
            //insere novo elemento na lista

            //verirfica os campos
            if (text_nome.Text == "" || text_numero.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            foreach (cl_contato contato in cl_geral.LISTA_CONTATOS)
                if (contato.nome == text_nome.Text && contato.numero == text_numero.Text)
                {
                    MessageBox.Show("Contato já existe");
                    return;
                }
            //gravar novo
            cl_geral.GravarNovoRegistro(text_nome.Text, text_numero.Text);

            //mostra lista
            ConstroiLista();

            //novo registro
            text_nome.Text = "";
            text_numero.Text = "";
            text_numero.Focus();
        }
    }
}

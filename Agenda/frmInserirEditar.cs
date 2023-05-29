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
        int indice;

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

            //Bloqueia os botoes Apagar e editar
            cmd_apagar.Enabled = false;
            cmd_editar.Enabled = false;

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

        //======================================================================

        private void lista_contatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //seleciona um contato

            //verifica se o indice é -1
            if (lista_contatos.SelectedIndex == -1) return;

            indice = lista_contatos.SelectedIndex;
            cmd_apagar.Enabled = true;
            cmd_editar.Enabled = true;
        }

        //======================================================================

        private void cmd_apagar_Click(object sender, EventArgs e)
        {
            //remove da lista
            cl_geral.LISTA_CONTATOS.RemoveAt(indice);

            cl_geral.GravarFicheiro();

            ConstroiLista();
        }

    }
}

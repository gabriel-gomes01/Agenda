using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frm_resultado : Form
    {
        string _texto;

        public frm_resultado(string texto)
        {
            InitializeComponent();

            //define o texto de pesquisa
            _texto = texto.ToUpper();
        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_resultado_Load(object sender, EventArgs e)
        {
            ExecutaPesquisa();
        }

        private void ExecutaPesquisa()
        {
            List<cl_contato> lista_resultados = new List<cl_contato>();

            foreach (cl_contato contato in cl_geral.LISTA_CONTATOS)
            {
                if (contato.nome.ToUpper().Contains(_texto) ||
                    contato.numero.ToUpper().Contains(_texto))
                {
                    lista_resultados.Add(contato);
                }
            }

            //Apresenta o resultado na lista
            lista_final.Items.Clear();
            foreach (cl_contato contato in lista_resultados)
            {
                lista_final.Items.Add(contato.nome + "(" + contato.numero + ")");
            }
            label_numero_registros.Text = "Registros: " + lista_final.Items.Count;
        }

        private void cmd_nova_pesquisa_Click(object sender, EventArgs e)
        {
            //pedir novo texto
            frm_Texto f = new frm_Texto();
            f.ShowDialog();

            if (f.cancelado) return;

            _texto = f.texto.ToUpper();

            ExecutaPesquisa();
        }
    }
}

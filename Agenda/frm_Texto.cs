using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frm_Texto : Form
    {
        public bool cancelado { get; set; }
        public string texto { get; set; }

        public frm_Texto()
        {
            InitializeComponent();
        }

        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            cancelado = true;
            this.Close();
        }

        private void cmd_pesquisar_Click(object sender, EventArgs e)
        {
            texto = text_texto.Text;
            cancelado = false;
            this.Close();
        }
    }
}

namespace Agenda
{
    partial class frmInserirEditar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmd_fechar = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            text_nome = new System.Windows.Forms.TextBox();
            text_numero = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            cmd_gravar = new System.Windows.Forms.Button();
            lista_contatos = new System.Windows.Forms.ListBox();
            label3 = new System.Windows.Forms.Label();
            label_numero_registros = new System.Windows.Forms.Label();
            cmd_apagar = new System.Windows.Forms.Button();
            cmd_editar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // cmd_fechar
            // 
            cmd_fechar.Location = new System.Drawing.Point(348, 397);
            cmd_fechar.Name = "cmd_fechar";
            cmd_fechar.Size = new System.Drawing.Size(102, 42);
            cmd_fechar.TabIndex = 5;
            cmd_fechar.Text = "Fechar";
            cmd_fechar.UseVisualStyleBackColor = true;
            cmd_fechar.Click += cmd_fechar_Click;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(12, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 23);
            label1.TabIndex = 9;
            label1.Text = "Nome";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_nome
            // 
            text_nome.Location = new System.Drawing.Point(82, 12);
            text_nome.MaxLength = 50;
            text_nome.Name = "text_nome";
            text_nome.Size = new System.Drawing.Size(368, 23);
            text_nome.TabIndex = 0;
            // 
            // text_numero
            // 
            text_numero.Location = new System.Drawing.Point(82, 50);
            text_numero.MaxLength = 20;
            text_numero.Name = "text_numero";
            text_numero.Size = new System.Drawing.Size(153, 23);
            text_numero.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(12, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 23);
            label2.TabIndex = 10;
            label2.Text = "Numero";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmd_gravar
            // 
            cmd_gravar.Location = new System.Drawing.Point(174, 101);
            cmd_gravar.Name = "cmd_gravar";
            cmd_gravar.Size = new System.Drawing.Size(139, 53);
            cmd_gravar.TabIndex = 2;
            cmd_gravar.Text = "Gravar";
            cmd_gravar.UseVisualStyleBackColor = true;
            cmd_gravar.Click += cmd_gravar_Click;
            // 
            // lista_contatos
            // 
            lista_contatos.FormattingEnabled = true;
            lista_contatos.ItemHeight = 15;
            lista_contatos.Location = new System.Drawing.Point(12, 192);
            lista_contatos.Name = "lista_contatos";
            lista_contatos.Size = new System.Drawing.Size(438, 199);
            lista_contatos.TabIndex = 7;
            lista_contatos.SelectedIndexChanged += lista_contatos_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(12, 166);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(223, 23);
            label3.TabIndex = 6;
            label3.Text = "Contatos Salvos";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_numero_registros
            // 
            label_numero_registros.Location = new System.Drawing.Point(12, 394);
            label_numero_registros.Name = "label_numero_registros";
            label_numero_registros.Size = new System.Drawing.Size(128, 23);
            label_numero_registros.TabIndex = 8;
            label_numero_registros.Text = "Registros: 0";
            label_numero_registros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmd_apagar
            // 
            cmd_apagar.Location = new System.Drawing.Point(246, 397);
            cmd_apagar.Name = "cmd_apagar";
            cmd_apagar.Size = new System.Drawing.Size(96, 42);
            cmd_apagar.TabIndex = 4;
            cmd_apagar.Text = "Apagar";
            cmd_apagar.UseVisualStyleBackColor = true;
            cmd_apagar.Click += cmd_apagar_Click;
            // 
            // cmd_editar
            // 
            cmd_editar.Location = new System.Drawing.Point(146, 397);
            cmd_editar.Name = "cmd_editar";
            cmd_editar.Size = new System.Drawing.Size(94, 42);
            cmd_editar.TabIndex = 3;
            cmd_editar.Text = "Editar";
            cmd_editar.UseVisualStyleBackColor = true;
            cmd_editar.Click += cmd_editar_Click;
            // 
            // frmInserirEditar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(462, 451);
            ControlBox = false;
            Controls.Add(cmd_editar);
            Controls.Add(cmd_apagar);
            Controls.Add(label_numero_registros);
            Controls.Add(label3);
            Controls.Add(lista_contatos);
            Controls.Add(cmd_gravar);
            Controls.Add(text_numero);
            Controls.Add(label2);
            Controls.Add(text_nome);
            Controls.Add(label1);
            Controls.Add(cmd_fechar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInserirEditar";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "AGENDA - INSERIR/EDITAR";
            Load += frmInserirEditar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.TextBox text_numero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmd_gravar;
        private System.Windows.Forms.ListBox lista_contatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_numero_registros;
        private System.Windows.Forms.Button cmd_apagar;
        private System.Windows.Forms.Button cmd_editar;
    }
}
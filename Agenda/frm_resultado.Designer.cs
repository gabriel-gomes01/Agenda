namespace Agenda
{
    partial class frm_resultado
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
            cmd_nova_pesquisa = new System.Windows.Forms.Button();
            cmd_fechar = new System.Windows.Forms.Button();
            lista_final = new System.Windows.Forms.ListBox();
            label_numero_registros = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // cmd_nova_pesquisa
            // 
            cmd_nova_pesquisa.Location = new System.Drawing.Point(368, 175);
            cmd_nova_pesquisa.Name = "cmd_nova_pesquisa";
            cmd_nova_pesquisa.Size = new System.Drawing.Size(143, 42);
            cmd_nova_pesquisa.TabIndex = 0;
            cmd_nova_pesquisa.Text = "Nova Pesquisa...";
            cmd_nova_pesquisa.UseVisualStyleBackColor = true;
            cmd_nova_pesquisa.Click += cmd_nova_pesquisa_Click;
            // 
            // cmd_fechar
            // 
            cmd_fechar.Location = new System.Drawing.Point(219, 175);
            cmd_fechar.Name = "cmd_fechar";
            cmd_fechar.Size = new System.Drawing.Size(143, 42);
            cmd_fechar.TabIndex = 1;
            cmd_fechar.Text = "Fechar";
            cmd_fechar.UseVisualStyleBackColor = true;
            cmd_fechar.Click += cmd_fechar_Click;
            // 
            // lista_final
            // 
            lista_final.FormattingEnabled = true;
            lista_final.ItemHeight = 15;
            lista_final.Location = new System.Drawing.Point(0, 0);
            lista_final.Name = "lista_final";
            lista_final.Size = new System.Drawing.Size(511, 169);
            lista_final.TabIndex = 2;
            // 
            // label_numero_registros
            // 
            label_numero_registros.Location = new System.Drawing.Point(12, 175);
            label_numero_registros.Name = "label_numero_registros";
            label_numero_registros.Size = new System.Drawing.Size(201, 23);
            label_numero_registros.TabIndex = 9;
            label_numero_registros.Text = "Registros: 0";
            label_numero_registros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frm_resultado
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(523, 224);
            ControlBox = false;
            Controls.Add(label_numero_registros);
            Controls.Add(lista_final);
            Controls.Add(cmd_fechar);
            Controls.Add(cmd_nova_pesquisa);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_resultado";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "RESULTADOS";
            Load += frm_resultado_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button cmd_nova_pesquisa;
        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.ListBox lista_final;
        private System.Windows.Forms.Label label_numero_registros;
    }
}
namespace Agenda
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            cmd_inserir = new System.Windows.Forms.Button();
            cmd_pesquisar = new System.Windows.Forms.Button();
            cmd_sair = new System.Windows.Forms.Button();
            lbl_versao = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(127, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(133, 34);
            label1.TabIndex = 0;
            label1.Text = "AGENDA";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmd_inserir
            // 
            cmd_inserir.Location = new System.Drawing.Point(107, 65);
            cmd_inserir.Name = "cmd_inserir";
            cmd_inserir.Size = new System.Drawing.Size(170, 70);
            cmd_inserir.TabIndex = 1;
            cmd_inserir.Text = "Inserir / Editar";
            cmd_inserir.UseVisualStyleBackColor = true;
            cmd_inserir.Click += cmd_inserir_Click;
            // 
            // cmd_pesquisar
            // 
            cmd_pesquisar.Location = new System.Drawing.Point(107, 152);
            cmd_pesquisar.Name = "cmd_pesquisar";
            cmd_pesquisar.Size = new System.Drawing.Size(170, 70);
            cmd_pesquisar.TabIndex = 2;
            cmd_pesquisar.Text = "Pesquisar";
            cmd_pesquisar.UseVisualStyleBackColor = true;
            // 
            // cmd_sair
            // 
            cmd_sair.Location = new System.Drawing.Point(107, 245);
            cmd_sair.Name = "cmd_sair";
            cmd_sair.Size = new System.Drawing.Size(170, 70);
            cmd_sair.TabIndex = 3;
            cmd_sair.Text = "Sair";
            cmd_sair.UseVisualStyleBackColor = true;
            cmd_sair.Click += cmd_sair_Click;
            // 
            // lbl_versao
            // 
            lbl_versao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_versao.Location = new System.Drawing.Point(12, 324);
            lbl_versao.Name = "lbl_versao";
            lbl_versao.Size = new System.Drawing.Size(360, 23);
            lbl_versao.TabIndex = 4;
            lbl_versao.Text = "Versão do Programa";
            lbl_versao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(384, 356);
            Controls.Add(lbl_versao);
            Controls.Add(cmd_sair);
            Controls.Add(cmd_pesquisar);
            Controls.Add(cmd_inserir);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMenu";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "AGENDA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_inserir;
        private System.Windows.Forms.Button cmd_pesquisar;
        private System.Windows.Forms.Button cmd_sair;
        private System.Windows.Forms.Label lbl_versao;
    }
}

namespace Agenda
{
    partial class frm_Texto
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
            text_texto = new System.Windows.Forms.TextBox();
            cmd_pesquisar = new System.Windows.Forms.Button();
            cmd_cancelar = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // text_texto
            // 
            text_texto.Location = new System.Drawing.Point(12, 37);
            text_texto.MaxLength = 30;
            text_texto.Name = "text_texto";
            text_texto.Size = new System.Drawing.Size(262, 23);
            text_texto.TabIndex = 0;
            // 
            // cmd_pesquisar
            // 
            cmd_pesquisar.Location = new System.Drawing.Point(169, 66);
            cmd_pesquisar.Name = "cmd_pesquisar";
            cmd_pesquisar.Size = new System.Drawing.Size(104, 35);
            cmd_pesquisar.TabIndex = 1;
            cmd_pesquisar.Text = "Pesquisar";
            cmd_pesquisar.UseVisualStyleBackColor = true;
            cmd_pesquisar.Click += cmd_pesquisar_Click;
            // 
            // cmd_cancelar
            // 
            cmd_cancelar.Location = new System.Drawing.Point(12, 66);
            cmd_cancelar.Name = "cmd_cancelar";
            cmd_cancelar.Size = new System.Drawing.Size(104, 35);
            cmd_cancelar.TabIndex = 2;
            cmd_cancelar.Text = "Cancelar";
            cmd_cancelar.UseVisualStyleBackColor = true;
            cmd_cancelar.Click += cmd_cancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "Pesquisa:";
            // 
            // frm_Texto
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(285, 113);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(cmd_cancelar);
            Controls.Add(cmd_pesquisar);
            Controls.Add(text_texto);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_Texto";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frm_Texto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox text_texto;
        private System.Windows.Forms.Button cmd_pesquisar;
        private System.Windows.Forms.Button cmd_cancelar;
        private System.Windows.Forms.Label label1;
    }
}
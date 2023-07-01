namespace ListaExercicios3
{
    partial class FormMenu
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
            this.buttonFatorial = new System.Windows.Forms.Button();
            this.buttonMultiplos = new System.Windows.Forms.Button();
            this.buttonConversao = new System.Windows.Forms.Button();
            this.buttonVotacao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonFatorial
            // 
            this.buttonFatorial.Location = new System.Drawing.Point(42, 87);
            this.buttonFatorial.Name = "buttonFatorial";
            this.buttonFatorial.Size = new System.Drawing.Size(75, 23);
            this.buttonFatorial.TabIndex = 0;
            this.buttonFatorial.Text = "Fatorial";
            this.buttonFatorial.UseVisualStyleBackColor = true;
            this.buttonFatorial.Click += new System.EventHandler(this.buttonFatorial_Click);
            // 
            // buttonMultiplos
            // 
            this.buttonMultiplos.Location = new System.Drawing.Point(42, 155);
            this.buttonMultiplos.Name = "buttonMultiplos";
            this.buttonMultiplos.Size = new System.Drawing.Size(75, 23);
            this.buttonMultiplos.TabIndex = 1;
            this.buttonMultiplos.Text = "Multiplos";
            this.buttonMultiplos.UseVisualStyleBackColor = true;
            this.buttonMultiplos.Click += new System.EventHandler(this.buttonMultiplos_Click);
            // 
            // buttonConversao
            // 
            this.buttonConversao.Location = new System.Drawing.Point(42, 233);
            this.buttonConversao.Name = "buttonConversao";
            this.buttonConversao.Size = new System.Drawing.Size(75, 23);
            this.buttonConversao.TabIndex = 2;
            this.buttonConversao.Text = "Conversão";
            this.buttonConversao.UseVisualStyleBackColor = true;
            this.buttonConversao.Click += new System.EventHandler(this.buttonConversao_Click);
            // 
            // buttonVotacao
            // 
            this.buttonVotacao.Location = new System.Drawing.Point(42, 308);
            this.buttonVotacao.Name = "buttonVotacao";
            this.buttonVotacao.Size = new System.Drawing.Size(75, 23);
            this.buttonVotacao.TabIndex = 3;
            this.buttonVotacao.Text = "Votação";
            this.buttonVotacao.UseVisualStyleBackColor = true;
            this.buttonVotacao.Click += new System.EventHandler(this.buttonVotacao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(139, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "MENU DE OPÇÕES";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonVotacao);
            this.Controls.Add(this.buttonConversao);
            this.Controls.Add(this.buttonMultiplos);
            this.Controls.Add(this.buttonFatorial);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonFatorial;
        private Button buttonMultiplos;
        private Button buttonConversao;
        private Button buttonVotacao;
        private Label label1;
    }
}
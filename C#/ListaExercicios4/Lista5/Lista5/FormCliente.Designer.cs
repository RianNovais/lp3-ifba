namespace Lista5
{
    partial class FormCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btCadastroCliente = new System.Windows.Forms.Button();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.textBoxIdadeCliente = new System.Windows.Forms.TextBox();
            this.textBoxTelefoneCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(247, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(247, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Idade:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(247, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefone:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // btCadastroCliente
            // 
            this.btCadastroCliente.Location = new System.Drawing.Point(309, 418);
            this.btCadastroCliente.Name = "btCadastroCliente";
            this.btCadastroCliente.Size = new System.Drawing.Size(86, 32);
            this.btCadastroCliente.TabIndex = 1;
            this.btCadastroCliente.Text = "Cadastrar";
            this.btCadastroCliente.UseVisualStyleBackColor = true;
            this.btCadastroCliente.Click += new System.EventHandler(this.btCadastroCliente_Click);
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Location = new System.Drawing.Point(309, 175);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(100, 23);
            this.textBoxNomeCliente.TabIndex = 2;
            // 
            // textBoxIdadeCliente
            // 
            this.textBoxIdadeCliente.Location = new System.Drawing.Point(309, 216);
            this.textBoxIdadeCliente.Name = "textBoxIdadeCliente";
            this.textBoxIdadeCliente.Size = new System.Drawing.Size(100, 23);
            this.textBoxIdadeCliente.TabIndex = 2;
            // 
            // textBoxTelefoneCliente
            // 
            this.textBoxTelefoneCliente.Location = new System.Drawing.Point(309, 259);
            this.textBoxTelefoneCliente.Name = "textBoxTelefoneCliente";
            this.textBoxTelefoneCliente.Size = new System.Drawing.Size(100, 23);
            this.textBoxTelefoneCliente.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(247, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cadastro de Clientes";
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 481);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTelefoneCliente);
            this.Controls.Add(this.textBoxIdadeCliente);
            this.Controls.Add(this.textBoxNomeCliente);
            this.Controls.Add(this.btCadastroCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btCadastroCliente;
        private TextBox textBoxNomeCliente;
        private TextBox textBoxIdadeCliente;
        private TextBox textBoxTelefoneCliente;
        private Label label4;
    }
}
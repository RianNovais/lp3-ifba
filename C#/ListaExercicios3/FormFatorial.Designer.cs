namespace ListaExercicios3
{
    partial class FormFatorial
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
            this.LabelNumero = new System.Windows.Forms.Label();
            this.BoxNFat = new System.Windows.Forms.TextBox();
            this.bCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelNumero
            // 
            this.LabelNumero.AutoSize = true;
            this.LabelNumero.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelNumero.Location = new System.Drawing.Point(29, 93);
            this.LabelNumero.Name = "LabelNumero";
            this.LabelNumero.Size = new System.Drawing.Size(308, 17);
            this.LabelNumero.TabIndex = 0;
            this.LabelNumero.Text = "Digite um valor para ser calculado seu fatorial:";
            // 
            // BoxNFat
            // 
            this.BoxNFat.Location = new System.Drawing.Point(138, 131);
            this.BoxNFat.Name = "BoxNFat";
            this.BoxNFat.Size = new System.Drawing.Size(71, 23);
            this.BoxNFat.TabIndex = 1;
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(29, 131);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(75, 23);
            this.bCalcular.TabIndex = 2;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // FormFatorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.BoxNFat);
            this.Controls.Add(this.LabelNumero);
            this.MaximizeBox = false;
            this.Name = "FormFatorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelNumero;
        private TextBox BoxNFat;
        private Button bCalcular;
    }
}
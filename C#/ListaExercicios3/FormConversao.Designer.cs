namespace ListaExercicios3
{
    partial class FormConversao
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
            this.btMostrarGraus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(133, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor de Graus Fahrenheit para Celsius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(133, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Graus 50 a 65F em Celsius";
            // 
            // btMostrarGraus
            // 
            this.btMostrarGraus.Location = new System.Drawing.Point(267, 381);
            this.btMostrarGraus.Name = "btMostrarGraus";
            this.btMostrarGraus.Size = new System.Drawing.Size(75, 23);
            this.btMostrarGraus.TabIndex = 2;
            this.btMostrarGraus.Text = "Mostrar";
            this.btMostrarGraus.UseVisualStyleBackColor = true;
            this.btMostrarGraus.Click += new System.EventHandler(this.btMostrarGraus_Click);
            // 
            // FormConversao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 484);
            this.Controls.Add(this.btMostrarGraus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormConversao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btMostrarGraus;
    }
}
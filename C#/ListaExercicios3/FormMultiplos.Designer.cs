namespace ListaExercicios3
{
    partial class formMultiplos
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
            this.buttonMostrarMultiplos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "informar todos os múltiplos de 17 ou de 31";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "no intervalo de 500 a 1000";
            // 
            // buttonMostrarMultiplos
            // 
            this.buttonMostrarMultiplos.Location = new System.Drawing.Point(184, 184);
            this.buttonMostrarMultiplos.Name = "buttonMostrarMultiplos";
            this.buttonMostrarMultiplos.Size = new System.Drawing.Size(75, 23);
            this.buttonMostrarMultiplos.TabIndex = 2;
            this.buttonMostrarMultiplos.Text = "Mostrar";
            this.buttonMostrarMultiplos.UseVisualStyleBackColor = true;
            this.buttonMostrarMultiplos.Click += new System.EventHandler(this.buttonMostrarMultiplos_Click);
            // 
            // formMultiplos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 459);
            this.Controls.Add(this.buttonMostrarMultiplos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formMultiplos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiplos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonMostrarMultiplos;
    }
}
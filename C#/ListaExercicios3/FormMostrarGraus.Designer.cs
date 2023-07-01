namespace ListaExercicios3
{
    partial class FormMostrarGraus
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
            this.textBoxGraus = new System.Windows.Forms.TextBox();
            this.textBoxGrausC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxGraus
            // 
            this.textBoxGraus.Location = new System.Drawing.Point(94, 63);
            this.textBoxGraus.Multiline = true;
            this.textBoxGraus.Name = "textBoxGraus";
            this.textBoxGraus.Size = new System.Drawing.Size(43, 260);
            this.textBoxGraus.TabIndex = 0;
            // 
            // textBoxGrausC
            // 
            this.textBoxGrausC.Location = new System.Drawing.Point(156, 63);
            this.textBoxGrausC.Multiline = true;
            this.textBoxGrausC.Name = "textBoxGrausC";
            this.textBoxGrausC.Size = new System.Drawing.Size(76, 260);
            this.textBoxGrausC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fahrenheit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Celsius";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormMostrarGraus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGrausC);
            this.Controls.Add(this.textBoxGraus);
            this.Name = "FormMostrarGraus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConversorDeGraus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxGraus;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBoxGrausC;
    }
}
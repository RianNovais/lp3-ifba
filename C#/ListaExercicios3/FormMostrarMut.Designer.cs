namespace ListaExercicios3
{
    partial class FormMostrarMut
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
            this.textBoxMut1 = new System.Windows.Forms.TextBox();
            this.textBoxMut2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxMut1
            // 
            this.textBoxMut1.Location = new System.Drawing.Point(163, 37);
            this.textBoxMut1.Multiline = true;
            this.textBoxMut1.Name = "textBoxMut1";
            this.textBoxMut1.Size = new System.Drawing.Size(212, 162);
            this.textBoxMut1.TabIndex = 0;
            // 
            // textBoxMut2
            // 
            this.textBoxMut2.Location = new System.Drawing.Point(163, 256);
            this.textBoxMut2.Multiline = true;
            this.textBoxMut2.Name = "textBoxMut2";
            this.textBoxMut2.Size = new System.Drawing.Size(212, 162);
            this.textBoxMut2.TabIndex = 1;
            // 
            // FormMostrarMut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 529);
            this.Controls.Add(this.textBoxMut2);
            this.Controls.Add(this.textBoxMut1);
            this.Name = "FormMostrarMut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiplos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxMut1;
        private TextBox textBoxMut2;
    }
}
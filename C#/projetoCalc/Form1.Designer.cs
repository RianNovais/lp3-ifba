//RIAN MUNIZ 4TIB

namespace projetoCalc
{
    partial class Form1
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
            this.btSoma = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.btMult = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.labelRes = new System.Windows.Forms.Label();
            this.labelN1 = new System.Windows.Forms.Label();
            this.labelN2 = new System.Windows.Forms.Label();
            this.textN1 = new System.Windows.Forms.TextBox();
            this.textN2 = new System.Windows.Forms.TextBox();
            this.btApagar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSoma
            // 
            this.btSoma.Location = new System.Drawing.Point(443, 105);
            this.btSoma.Name = "btSoma";
            this.btSoma.Size = new System.Drawing.Size(94, 71);
            this.btSoma.TabIndex = 0;
            this.btSoma.Text = "Soma";
            this.btSoma.UseVisualStyleBackColor = true;
            this.btSoma.Click += new System.EventHandler(this.btSoma_Click);
            // 
            // btSub
            // 
            this.btSub.Location = new System.Drawing.Point(443, 197);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(94, 71);
            this.btSub.TabIndex = 1;
            this.btSub.Text = "Subtração";
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // btMult
            // 
            this.btMult.Location = new System.Drawing.Point(443, 288);
            this.btMult.Name = "btMult";
            this.btMult.Size = new System.Drawing.Size(94, 71);
            this.btMult.TabIndex = 2;
            this.btMult.Text = "Multiplicação";
            this.btMult.UseVisualStyleBackColor = true;
            this.btMult.Click += new System.EventHandler(this.BtMult_Click);
            // 
            // btDiv
            // 
            this.btDiv.Location = new System.Drawing.Point(443, 380);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(94, 71);
            this.btDiv.TabIndex = 3;
            this.btDiv.Text = "Divisão";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // labelRes
            // 
            this.labelRes.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRes.Location = new System.Drawing.Point(47, 412);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(89, 60);
            this.labelRes.TabIndex = 5;
            // 
            // labelN1
            // 
            this.labelN1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelN1.Location = new System.Drawing.Point(47, 84);
            this.labelN1.Name = "labelN1";
            this.labelN1.Size = new System.Drawing.Size(122, 44);
            this.labelN1.TabIndex = 6;
            this.labelN1.Text = "Numero 1";
            this.labelN1.Click += new System.EventHandler(this.labelN1_Click);
            // 
            // labelN2
            // 
            this.labelN2.AutoSize = true;
            this.labelN2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelN2.Location = new System.Drawing.Point(47, 151);
            this.labelN2.Name = "labelN2";
            this.labelN2.Size = new System.Drawing.Size(81, 21);
            this.labelN2.TabIndex = 7;
            this.labelN2.Text = "Numero 2";
            // 
            // textN1
            // 
            this.textN1.Location = new System.Drawing.Point(143, 84);
            this.textN1.Name = "textN1";
            this.textN1.Size = new System.Drawing.Size(140, 23);
            this.textN1.TabIndex = 8;
            // 
            // textN2
            // 
            this.textN2.Location = new System.Drawing.Point(143, 149);
            this.textN2.Name = "textN2";
            this.textN2.Size = new System.Drawing.Size(140, 23);
            this.textN2.TabIndex = 9;
            // 
            // btApagar
            // 
            this.btApagar.Location = new System.Drawing.Point(204, 463);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(79, 56);
            this.btApagar.TabIndex = 10;
            this.btApagar.Text = "Apagar";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(305, 463);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(79, 56);
            this.btSair.TabIndex = 11;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(549, 542);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btApagar);
            this.Controls.Add(this.textN2);
            this.Controls.Add(this.textN1);
            this.Controls.Add(this.labelN2);
            this.Controls.Add(this.labelN1);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btMult);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.btSoma);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btSoma;
        private Button btSub;
        private Button btMult;
        private Button btDiv;
        private Label labelRes;
        private Label labelN1;
        private Label labelN2;
        private TextBox textN1;
        private TextBox textN2;
        private Button btApagar;
        private Button btSair;
    }
}
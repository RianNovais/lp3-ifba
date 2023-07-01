namespace ListaExercicios3
{
    partial class FormVotacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVotacao));
            this.btJair = new System.Windows.Forms.Button();
            this.btLula = new System.Windows.Forms.Button();
            this.btCiro = new System.Windows.Forms.Button();
            this.btSimone = new System.Windows.Forms.Button();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.btBranco = new System.Windows.Forms.Button();
            this.btNulo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btJair
            // 
            this.btJair.Image = ((System.Drawing.Image)(resources.GetObject("btJair.Image")));
            this.btJair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btJair.Location = new System.Drawing.Point(12, 117);
            this.btJair.Name = "btJair";
            this.btJair.Size = new System.Drawing.Size(80, 67);
            this.btJair.TabIndex = 0;
            this.btJair.UseVisualStyleBackColor = true;
            this.btJair.Click += new System.EventHandler(this.btJair_Click);
            // 
            // btLula
            // 
            this.btLula.Image = ((System.Drawing.Image)(resources.GetObject("btLula.Image")));
            this.btLula.Location = new System.Drawing.Point(119, 117);
            this.btLula.Name = "btLula";
            this.btLula.Size = new System.Drawing.Size(84, 67);
            this.btLula.TabIndex = 1;
            this.btLula.UseVisualStyleBackColor = true;
            this.btLula.Click += new System.EventHandler(this.btLula_Click);
            // 
            // btCiro
            // 
            this.btCiro.Image = global::ListaExercicios3.Properties.Resources.Ciro_Gomes__cropped_;
            this.btCiro.Location = new System.Drawing.Point(237, 117);
            this.btCiro.Name = "btCiro";
            this.btCiro.Size = new System.Drawing.Size(85, 67);
            this.btCiro.TabIndex = 2;
            this.btCiro.UseVisualStyleBackColor = true;
            this.btCiro.Click += new System.EventHandler(this.btCiro_Click);
            // 
            // btSimone
            // 
            this.btSimone.Image = global::ListaExercicios3.Properties.Resources._1EFA1CF4_52CB_4974_8F18_15A60C7B37D6_769x492;
            this.btSimone.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSimone.Location = new System.Drawing.Point(363, 117);
            this.btSimone.Name = "btSimone";
            this.btSimone.Size = new System.Drawing.Size(90, 67);
            this.btSimone.TabIndex = 3;
            this.btSimone.UseVisualStyleBackColor = true;
            this.btSimone.Click += new System.EventHandler(this.btSimone_Click);
            // 
            // btFinalizar
            // 
            this.btFinalizar.Location = new System.Drawing.Point(234, 392);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(129, 46);
            this.btFinalizar.TabIndex = 4;
            this.btFinalizar.Text = "Finalizar";
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // btBranco
            // 
            this.btBranco.Location = new System.Drawing.Point(12, 221);
            this.btBranco.Name = "btBranco";
            this.btBranco.Size = new System.Drawing.Size(75, 75);
            this.btBranco.TabIndex = 5;
            this.btBranco.Text = "Branco";
            this.btBranco.UseVisualStyleBackColor = true;
            this.btBranco.Click += new System.EventHandler(this.btBranco_Click);
            // 
            // btNulo
            // 
            this.btNulo.Location = new System.Drawing.Point(12, 322);
            this.btNulo.Name = "btNulo";
            this.btNulo.Size = new System.Drawing.Size(75, 70);
            this.btNulo.TabIndex = 6;
            this.btNulo.Text = "Nulo";
            this.btNulo.UseVisualStyleBackColor = true;
            this.btNulo.Click += new System.EventHandler(this.btNulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(270, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "VOTAÇÃO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Clique na opção em que deseja votar.";
            // 
            // FormVotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btNulo);
            this.Controls.Add(this.btBranco);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.btSimone);
            this.Controls.Add(this.btCiro);
            this.Controls.Add(this.btLula);
            this.Controls.Add(this.btJair);
            this.Name = "FormVotacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Votação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btJair;
        private Button btLula;
        private Button btCiro;
        private Button btSimone;
        private Button btFinalizar;
        private Button btBranco;
        private Button btNulo;
        private Label label1;
        private Label label2;
    }
}
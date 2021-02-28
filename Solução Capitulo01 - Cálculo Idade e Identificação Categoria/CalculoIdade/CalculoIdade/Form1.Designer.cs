namespace CalculoIdade
{
    partial class frmMatrículaAluno
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblAnoNascimento = new System.Windows.Forms.Label();
            this.lblAnoUltimoAniversario = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnIdentificarCategoria = new System.Windows.Forms.Button();
            this.lblDescricaoCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(29, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "&Nome:";
            // 
            // lblAnoNascimento
            // 
            this.lblAnoNascimento.AutoSize = true;
            this.lblAnoNascimento.Location = new System.Drawing.Point(29, 48);
            this.lblAnoNascimento.Name = "lblAnoNascimento";
            this.lblAnoNascimento.Size = new System.Drawing.Size(88, 13);
            this.lblAnoNascimento.TabIndex = 1;
            this.lblAnoNascimento.Text = "&Ano Nascimento:";
            // 
            // lblAnoUltimoAniversario
            // 
            this.lblAnoUltimoAniversario.AutoSize = true;
            this.lblAnoUltimoAniversario.Location = new System.Drawing.Point(202, 47);
            this.lblAnoUltimoAniversario.Name = "lblAnoUltimoAniversario";
            this.lblAnoUltimoAniversario.Size = new System.Drawing.Size(116, 13);
            this.lblAnoUltimoAniversario.TabIndex = 2;
            this.lblAnoUltimoAniversario.Text = "An&o Último Aniversário:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(156, 74);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoria:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(81, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(320, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(78, 20);
            this.textBox3.TabIndex = 6;
            // 
            // btnIdentificarCategoria
            // 
            this.btnIdentificarCategoria.Location = new System.Drawing.Point(29, 69);
            this.btnIdentificarCategoria.Name = "btnIdentificarCategoria";
            this.btnIdentificarCategoria.Size = new System.Drawing.Size(121, 23);
            this.btnIdentificarCategoria.TabIndex = 8;
            this.btnIdentificarCategoria.Text = "Identificar Categoria";
            this.btnIdentificarCategoria.UseVisualStyleBackColor = true;
            // 
            // lblDescricaoCategoria
            // 
            this.lblDescricaoCategoria.BackColor = System.Drawing.Color.Yellow;
            this.lblDescricaoCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescricaoCategoria.Location = new System.Drawing.Point(214, 69);
            this.lblDescricaoCategoria.Name = "lblDescricaoCategoria";
            this.lblDescricaoCategoria.Size = new System.Drawing.Size(184, 23);
            this.lblDescricaoCategoria.TabIndex = 10;
            this.lblDescricaoCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDescricaoCategoria.UseMnemonic = false;
            // 
            // frmMatrículaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 104);
            this.Controls.Add(this.lblDescricaoCategoria);
            this.Controls.Add(this.btnIdentificarCategoria);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblAnoUltimoAniversario);
            this.Controls.Add(this.lblAnoNascimento);
            this.Controls.Add(this.lblNome);
            this.Name = "frmMatrículaAluno";
            this.Text = "Matrícula de Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblAnoNascimento;
        private System.Windows.Forms.Label lblAnoUltimoAniversario;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnIdentificarCategoria;
        private System.Windows.Forms.Label lblDescricaoCategoria;
    }
}


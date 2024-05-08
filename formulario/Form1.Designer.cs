namespace formulario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nome = new System.Windows.Forms.Label();
            this.Sobrenome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxNomes = new System.Windows.Forms.ComboBox();
            this.lblSelecionado = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(40, 60);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(70, 25);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome:";
            this.Nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // Sobrenome
            // 
            this.Sobrenome.AutoSize = true;
            this.Sobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sobrenome.Location = new System.Drawing.Point(40, 113);
            this.Sobrenome.Name = "Sobrenome";
            this.Sobrenome.Size = new System.Drawing.Size(120, 25);
            this.Sobrenome.TabIndex = 1;
            this.Sobrenome.Text = "Sobrenome:";
            this.Sobrenome.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(116, 65);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(166, 118);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(100, 20);
            this.txtSobrenome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome completo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(200, 186);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.ReadOnly = true;
            this.txtNomeCompleto.Size = new System.Drawing.Size(100, 20);
            this.txtNomeCompleto.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Concatenar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxNomes
            // 
            this.comboBoxNomes.FormattingEnabled = true;
            this.comboBoxNomes.Location = new System.Drawing.Point(523, 60);
            this.comboBoxNomes.Name = "comboBoxNomes";
            this.comboBoxNomes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNomes.TabIndex = 7;
            this.comboBoxNomes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblSelecionado
            // 
            this.lblSelecionado.AutoSize = true;
            this.lblSelecionado.Location = new System.Drawing.Point(520, 113);
            this.lblSelecionado.Name = "lblSelecionado";
            this.lblSelecionado.Size = new System.Drawing.Size(56, 13);
            this.lblSelecionado.TabIndex = 8;
            this.lblSelecionado.Text = "<<vazio>>";
            this.lblSelecionado.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(500, 226);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(144, 199);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblSelecionado);
            this.Controls.Add(this.comboBoxNomes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.Sobrenome);
            this.Controls.Add(this.Nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Sobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxNomes;
        private System.Windows.Forms.Label lblSelecionado;
        private System.Windows.Forms.ListBox listBox1;
    }
}


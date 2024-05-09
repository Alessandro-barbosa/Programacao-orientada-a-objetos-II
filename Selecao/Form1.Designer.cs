namespace Selecao
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
            this.btn1 = new System.Windows.Forms.Button();
            this.txtNomeP = new System.Windows.Forms.TextBox();
            this.comboBoxNomeP = new System.Windows.Forms.ComboBox();
            this.lbxTodosEstados = new System.Windows.Forms.ListBox();
            this.btnCopiarTodos = new System.Windows.Forms.Button();
            this.lbxEstadosSelecionados = new System.Windows.Forms.ListBox();
            this.btnSelecionados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(279, 48);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Adicionar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtNomeP
            // 
            this.txtNomeP.Location = new System.Drawing.Point(92, 51);
            this.txtNomeP.Name = "txtNomeP";
            this.txtNomeP.Size = new System.Drawing.Size(140, 20);
            this.txtNomeP.TabIndex = 1;
            this.txtNomeP.TextChanged += new System.EventHandler(this.txtNomeP_TextChanged);
            // 
            // comboBoxNomeP
            // 
            this.comboBoxNomeP.FormattingEnabled = true;
            this.comboBoxNomeP.Location = new System.Drawing.Point(92, 122);
            this.comboBoxNomeP.Name = "comboBoxNomeP";
            this.comboBoxNomeP.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNomeP.TabIndex = 2;
            this.comboBoxNomeP.SelectedIndexChanged += new System.EventHandler(this.comboBoxNomeP_SelectedIndexChanged);
            // 
            // lbxTodosEstados
            // 
            this.lbxTodosEstados.FormattingEnabled = true;
            this.lbxTodosEstados.Location = new System.Drawing.Point(92, 210);
            this.lbxTodosEstados.Name = "lbxTodosEstados";
            this.lbxTodosEstados.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxTodosEstados.Size = new System.Drawing.Size(120, 95);
            this.lbxTodosEstados.TabIndex = 4;
            // 
            // btnCopiarTodos
            // 
            this.btnCopiarTodos.Location = new System.Drawing.Point(241, 210);
            this.btnCopiarTodos.Name = "btnCopiarTodos";
            this.btnCopiarTodos.Size = new System.Drawing.Size(75, 23);
            this.btnCopiarTodos.TabIndex = 5;
            this.btnCopiarTodos.Text = "CopiarTodos";
            this.btnCopiarTodos.UseVisualStyleBackColor = true;
            this.btnCopiarTodos.Click += new System.EventHandler(this.btnCopiarTodos_Click);
            // 
            // lbxEstadosSelecionados
            // 
            this.lbxEstadosSelecionados.FormattingEnabled = true;
            this.lbxEstadosSelecionados.Location = new System.Drawing.Point(464, 210);
            this.lbxEstadosSelecionados.Name = "lbxEstadosSelecionados";
            this.lbxEstadosSelecionados.Size = new System.Drawing.Size(120, 95);
            this.lbxEstadosSelecionados.TabIndex = 6;
            // 
            // btnSelecionados
            // 
            this.btnSelecionados.Location = new System.Drawing.Point(611, 210);
            this.btnSelecionados.Name = "btnSelecionados";
            this.btnSelecionados.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionados.TabIndex = 7;
            this.btnSelecionados.Text = "Selecionados";
            this.btnSelecionados.UseVisualStyleBackColor = true;
            this.btnSelecionados.Click += new System.EventHandler(this.btnSelecionados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Estado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lista de Estados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lista box de estados";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelecionados);
            this.Controls.Add(this.lbxEstadosSelecionados);
            this.Controls.Add(this.btnCopiarTodos);
            this.Controls.Add(this.lbxTodosEstados);
            this.Controls.Add(this.comboBoxNomeP);
            this.Controls.Add(this.txtNomeP);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtNomeP;
        private System.Windows.Forms.ComboBox comboBoxNomeP;
        private System.Windows.Forms.ListBox lbxTodosEstados;
        private System.Windows.Forms.Button btnCopiarTodos;
        private System.Windows.Forms.ListBox lbxEstadosSelecionados;
        private System.Windows.Forms.Button btnSelecionados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


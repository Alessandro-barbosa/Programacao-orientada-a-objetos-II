namespace AgendaTelefonica
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.checkBoxTermos = new System.Windows.Forms.CheckBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.btnAeitarTermos = new System.Windows.Forms.Button();
            this.listaNomeTelefone = new System.Windows.Forms.ListBox();
            this.showtxtNome = new System.Windows.Forms.TextBox();
            this.showTxtTipo = new System.Windows.Forms.TextBox();
            this.showTxtTelefone = new System.Windows.Forms.TextBox();
            this.comboBoxTipos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(42, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(94, 31);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(42, 57);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(128, 31);
            this.lblTelefone.TabIndex = 1;
            this.lblTelefone.Text = "Telefone:";
            this.lblTelefone.Click += new System.EventHandler(this.lblTelefone_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(42, 96);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(75, 31);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo:";
            // 
            // checkBoxTermos
            // 
            this.checkBoxTermos.AutoSize = true;
            this.checkBoxTermos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTermos.Location = new System.Drawing.Point(176, 135);
            this.checkBoxTermos.Name = "checkBoxTermos";
            this.checkBoxTermos.Size = new System.Drawing.Size(162, 26);
            this.checkBoxTermos.TabIndex = 3;
            this.checkBoxTermos.Text = "Aceito os termos";
            this.checkBoxTermos.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(139, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(248, 26);
            this.txtNome.TabIndex = 4;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(176, 64);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(211, 26);
            this.txtTelefone.TabIndex = 5;
            // 
            // btnAeitarTermos
            // 
            this.btnAeitarTermos.AutoSize = true;
            this.btnAeitarTermos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAeitarTermos.Location = new System.Drawing.Point(212, 167);
            this.btnAeitarTermos.Name = "btnAeitarTermos";
            this.btnAeitarTermos.Size = new System.Drawing.Size(85, 30);
            this.btnAeitarTermos.TabIndex = 7;
            this.btnAeitarTermos.Text = "Adicionar";
            this.btnAeitarTermos.UseVisualStyleBackColor = true;
            this.btnAeitarTermos.Click += new System.EventHandler(this.btnAeitarTermos_Click);
            // 
            // listaNomeTelefone
            // 
            this.listaNomeTelefone.FormattingEnabled = true;
            this.listaNomeTelefone.Location = new System.Drawing.Point(48, 225);
            this.listaNomeTelefone.Name = "listaNomeTelefone";
            this.listaNomeTelefone.Size = new System.Drawing.Size(204, 147);
            this.listaNomeTelefone.TabIndex = 8;
            this.listaNomeTelefone.SelectedIndexChanged += new System.EventHandler(this.listaNomeTelefone_SelectedIndexChanged);
            // 
            // showtxtNome
            // 
            this.showtxtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtxtNome.Location = new System.Drawing.Point(357, 225);
            this.showtxtNome.Name = "showtxtNome";
            this.showtxtNome.ReadOnly = true;
            this.showtxtNome.Size = new System.Drawing.Size(282, 27);
            this.showtxtNome.TabIndex = 9;
            this.showtxtNome.Visible = false;
            // 
            // showTxtTipo
            // 
            this.showTxtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTxtTipo.Location = new System.Drawing.Point(357, 315);
            this.showTxtTipo.Name = "showTxtTipo";
            this.showTxtTipo.ReadOnly = true;
            this.showTxtTipo.Size = new System.Drawing.Size(282, 27);
            this.showTxtTipo.TabIndex = 10;
            this.showTxtTipo.Visible = false;
            // 
            // showTxtTelefone
            // 
            this.showTxtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTxtTelefone.Location = new System.Drawing.Point(357, 272);
            this.showTxtTelefone.Name = "showTxtTelefone";
            this.showTxtTelefone.ReadOnly = true;
            this.showTxtTelefone.Size = new System.Drawing.Size(282, 27);
            this.showTxtTelefone.TabIndex = 11;
            this.showTxtTelefone.Visible = false;
            // 
            // comboBoxTipos
            // 
            this.comboBoxTipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipos.FormattingEnabled = true;
            this.comboBoxTipos.Items.AddRange(new object[] {
            "Zap",
            "Esqueci"});
            this.comboBoxTipos.Location = new System.Drawing.Point(139, 105);
            this.comboBoxTipos.Name = "comboBoxTipos";
            this.comboBoxTipos.Size = new System.Drawing.Size(248, 24);
            this.comboBoxTipos.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 445);
            this.Controls.Add(this.comboBoxTipos);
            this.Controls.Add(this.showTxtTelefone);
            this.Controls.Add(this.showTxtTipo);
            this.Controls.Add(this.showtxtNome);
            this.Controls.Add(this.listaNomeTelefone);
            this.Controls.Add(this.btnAeitarTermos);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.checkBoxTermos);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.CheckBox checkBoxTermos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button btnAeitarTermos;
        private System.Windows.Forms.ListBox listaNomeTelefone;
        private System.Windows.Forms.TextBox showtxtNome;
        private System.Windows.Forms.TextBox showTxtTipo;
        private System.Windows.Forms.TextBox showTxtTelefone;
        private System.Windows.Forms.ComboBox comboBoxTipos;
    }
}


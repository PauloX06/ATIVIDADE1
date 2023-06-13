namespace Atividade_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_nome = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.lb_cpf = new System.Windows.Forms.Label();
            this.lb_idade = new System.Windows.Forms.Label();
            this.lb_sexo = new System.Windows.Forms.Label();
            this.lb_peso = new System.Windows.Forms.Label();
            this.lb_altura = new System.Windows.Forms.Label();
            this.mask_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_peso = new System.Windows.Forms.NumericUpDown();
            this.num_altura = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.num_idade = new System.Windows.Forms.NumericUpDown();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.lb_cpf2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_peso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_altura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_idade)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_nome.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(53, 202);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(49, 21);
            this.lb_nome.TabIndex = 0;
            this.lb_nome.Text = "Nome";
            // 
            // tx_nome
            // 
            this.tx_nome.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_nome.Location = new System.Drawing.Point(115, 202);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(100, 24);
            this.tx_nome.TabIndex = 1;
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_cpf.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cpf.Location = new System.Drawing.Point(53, 241);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(33, 21);
            this.lb_cpf.TabIndex = 2;
            this.lb_cpf.Text = "Cpf";
            // 
            // lb_idade
            // 
            this.lb_idade.AutoSize = true;
            this.lb_idade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_idade.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idade.Location = new System.Drawing.Point(53, 281);
            this.lb_idade.Name = "lb_idade";
            this.lb_idade.Size = new System.Drawing.Size(47, 21);
            this.lb_idade.TabIndex = 4;
            this.lb_idade.Text = "Idade";
            // 
            // lb_sexo
            // 
            this.lb_sexo.AutoSize = true;
            this.lb_sexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_sexo.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sexo.Location = new System.Drawing.Point(53, 322);
            this.lb_sexo.Name = "lb_sexo";
            this.lb_sexo.Size = new System.Drawing.Size(42, 21);
            this.lb_sexo.TabIndex = 6;
            this.lb_sexo.Text = "Sexo";
            // 
            // lb_peso
            // 
            this.lb_peso.AutoSize = true;
            this.lb_peso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_peso.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_peso.Location = new System.Drawing.Point(54, 363);
            this.lb_peso.Name = "lb_peso";
            this.lb_peso.Size = new System.Drawing.Size(41, 21);
            this.lb_peso.TabIndex = 8;
            this.lb_peso.Text = "Peso";
            // 
            // lb_altura
            // 
            this.lb_altura.AutoSize = true;
            this.lb_altura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_altura.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_altura.Location = new System.Drawing.Point(54, 401);
            this.lb_altura.Name = "lb_altura";
            this.lb_altura.Size = new System.Drawing.Size(52, 21);
            this.lb_altura.TabIndex = 10;
            this.lb_altura.Text = "Altura";
            // 
            // mask_cpf
            // 
            this.mask_cpf.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_cpf.Location = new System.Drawing.Point(115, 241);
            this.mask_cpf.Mask = "000,000,000-00";
            this.mask_cpf.Name = "mask_cpf";
            this.mask_cpf.Size = new System.Drawing.Size(100, 24);
            this.mask_cpf.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Sitka Small", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 48);
            this.label1.TabIndex = 14;
            this.label1.Text = "IMC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Indice de Massa Corporal";
            // 
            // num_peso
            // 
            this.num_peso.DecimalPlaces = 2;
            this.num_peso.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_peso.Location = new System.Drawing.Point(115, 360);
            this.num_peso.Name = "num_peso";
            this.num_peso.Size = new System.Drawing.Size(100, 24);
            this.num_peso.TabIndex = 16;
            this.num_peso.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // num_altura
            // 
            this.num_altura.DecimalPlaces = 2;
            this.num_altura.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_altura.Location = new System.Drawing.Point(115, 398);
            this.num_altura.Name = "num_altura";
            this.num_altura.Size = new System.Drawing.Size(100, 24);
            this.num_altura.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(648, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(549, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 35);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbSexo
            // 
            this.cmbSexo.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino ",
            "Feminino"});
            this.cmbSexo.Location = new System.Drawing.Point(115, 321);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(100, 27);
            this.cmbSexo.TabIndex = 20;
            // 
            // num_idade
            // 
            this.num_idade.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_idade.Location = new System.Drawing.Point(115, 283);
            this.num_idade.Name = "num_idade";
            this.num_idade.Size = new System.Drawing.Size(100, 24);
            this.num_idade.TabIndex = 21;
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_resultado.Location = new System.Drawing.Point(247, 332);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(77, 16);
            this.lb_resultado.TabIndex = 22;
            this.lb_resultado.Text = "lb_resultado";
            // 
            // lb_cpf2
            // 
            this.lb_cpf2.AutoSize = true;
            this.lb_cpf2.Location = new System.Drawing.Point(247, 252);
            this.lb_cpf2.Name = "lb_cpf2";
            this.lb_cpf2.Size = new System.Drawing.Size(42, 13);
            this.lb_cpf2.TabIndex = 23;
            this.lb_cpf2.Text = "lb_cpf2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_cpf2);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.num_idade);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.num_altura);
            this.Controls.Add(this.num_peso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mask_cpf);
            this.Controls.Add(this.lb_altura);
            this.Controls.Add(this.lb_peso);
            this.Controls.Add(this.lb_sexo);
            this.Controls.Add(this.lb_idade);
            this.Controls.Add(this.lb_cpf);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.lb_nome);
            this.Name = "Form1";
            this.Text = "Calcular IMC";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_peso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_altura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_idade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.Label lb_cpf;
        private System.Windows.Forms.Label lb_idade;
        private System.Windows.Forms.Label lb_sexo;
        private System.Windows.Forms.Label lb_peso;
        private System.Windows.Forms.Label lb_altura;
        private System.Windows.Forms.MaskedTextBox mask_cpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_peso;
        private System.Windows.Forms.NumericUpDown num_altura;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.NumericUpDown num_idade;
        private System.Windows.Forms.Label lb_resultado;
        private System.Windows.Forms.Label lb_cpf2;
    }
}


namespace CalculadoraSimples
{
    partial class ButtonCalculadora
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
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.buttonIgual = new System.Windows.Forms.Button();
            this.buttonMultiplicacao = new System.Windows.Forms.Button();
            this.buttonDivisao = new System.Windows.Forms.Button();
            this.buttonMais = new System.Windows.Forms.Button();
            this.buttonMenos = new System.Windows.Forms.Button();
            this.buttonOito = new System.Windows.Forms.Button();
            this.buttonNove = new System.Windows.Forms.Button();
            this.buttonSete = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonQuatro = new System.Windows.Forms.Button();
            this.buttonCinco = new System.Windows.Forms.Button();
            this.buttonSeis = new System.Windows.Forms.Button();
            this.buttonUm = new System.Windows.Forms.Button();
            this.buttonDois = new System.Windows.Forms.Button();
            this.buttonTres = new System.Windows.Forms.Button();
            this.buttonVirgula = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonParenteses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBoxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisplay.Location = new System.Drawing.Point(12, 12);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(278, 44);
            this.textBoxDisplay.TabIndex = 0;
            this.textBoxDisplay.TextChanged += new System.EventHandler(this.textBoxDisplay_TextChanged);
            // 
            // buttonIgual
            // 
            this.buttonIgual.BackColor = System.Drawing.Color.Turquoise;
            this.buttonIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIgual.Location = new System.Drawing.Point(225, 242);
            this.buttonIgual.Name = "buttonIgual";
            this.buttonIgual.Size = new System.Drawing.Size(65, 114);
            this.buttonIgual.TabIndex = 1;
            this.buttonIgual.Text = "=";
            this.buttonIgual.UseVisualStyleBackColor = false;
            this.buttonIgual.Click += new System.EventHandler(this.buttonIgual_Click);
            // 
            // buttonMultiplicacao
            // 
            this.buttonMultiplicacao.BackColor = System.Drawing.Color.Turquoise;
            this.buttonMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplicacao.Location = new System.Drawing.Point(225, 182);
            this.buttonMultiplicacao.Name = "buttonMultiplicacao";
            this.buttonMultiplicacao.Size = new System.Drawing.Size(65, 54);
            this.buttonMultiplicacao.TabIndex = 2;
            this.buttonMultiplicacao.Text = "*";
            this.buttonMultiplicacao.UseVisualStyleBackColor = false;
            this.buttonMultiplicacao.Click += new System.EventHandler(this.buttonMultiplicacao_Click);
            // 
            // buttonDivisao
            // 
            this.buttonDivisao.BackColor = System.Drawing.Color.Turquoise;
            this.buttonDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivisao.Location = new System.Drawing.Point(225, 122);
            this.buttonDivisao.Name = "buttonDivisao";
            this.buttonDivisao.Size = new System.Drawing.Size(65, 54);
            this.buttonDivisao.TabIndex = 3;
            this.buttonDivisao.Text = "/";
            this.buttonDivisao.UseVisualStyleBackColor = false;
            this.buttonDivisao.Click += new System.EventHandler(this.buttonDivisao_Click);
            // 
            // buttonMais
            // 
            this.buttonMais.BackColor = System.Drawing.Color.Turquoise;
            this.buttonMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMais.Location = new System.Drawing.Point(225, 62);
            this.buttonMais.Name = "buttonMais";
            this.buttonMais.Size = new System.Drawing.Size(65, 54);
            this.buttonMais.TabIndex = 4;
            this.buttonMais.Text = "+";
            this.buttonMais.UseVisualStyleBackColor = false;
            this.buttonMais.Click += new System.EventHandler(this.buttonMais_Click);
            // 
            // buttonMenos
            // 
            this.buttonMenos.BackColor = System.Drawing.Color.Turquoise;
            this.buttonMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenos.Location = new System.Drawing.Point(154, 62);
            this.buttonMenos.Name = "buttonMenos";
            this.buttonMenos.Size = new System.Drawing.Size(65, 54);
            this.buttonMenos.TabIndex = 5;
            this.buttonMenos.Text = "-";
            this.buttonMenos.UseVisualStyleBackColor = false;
            this.buttonMenos.Click += new System.EventHandler(this.buttonMenos_Click);
            // 
            // buttonOito
            // 
            this.buttonOito.BackColor = System.Drawing.Color.Turquoise;
            this.buttonOito.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOito.Location = new System.Drawing.Point(83, 122);
            this.buttonOito.Name = "buttonOito";
            this.buttonOito.Size = new System.Drawing.Size(65, 54);
            this.buttonOito.TabIndex = 7;
            this.buttonOito.Text = "8";
            this.buttonOito.UseVisualStyleBackColor = false;
            this.buttonOito.Click += new System.EventHandler(this.buttonNum_click);
            // 
            // buttonNove
            // 
            this.buttonNove.BackColor = System.Drawing.Color.Turquoise;
            this.buttonNove.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNove.Location = new System.Drawing.Point(154, 122);
            this.buttonNove.Name = "buttonNove";
            this.buttonNove.Size = new System.Drawing.Size(65, 54);
            this.buttonNove.TabIndex = 8;
            this.buttonNove.Text = "9";
            this.buttonNove.UseVisualStyleBackColor = false;
            this.buttonNove.Click += new System.EventHandler(this.buttonNum_click);
            // 
            // buttonSete
            // 
            this.buttonSete.BackColor = System.Drawing.Color.Turquoise;
            this.buttonSete.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSete.Location = new System.Drawing.Point(12, 122);
            this.buttonSete.Name = "buttonSete";
            this.buttonSete.Size = new System.Drawing.Size(65, 54);
            this.buttonSete.TabIndex = 9;
            this.buttonSete.Text = "7";
            this.buttonSete.UseVisualStyleBackColor = false;
            this.buttonSete.Click += new System.EventHandler(this.buttonNum_click);
            // 
            // buttonZero
            // 
            this.buttonZero.BackColor = System.Drawing.Color.Turquoise;
            this.buttonZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZero.Location = new System.Drawing.Point(83, 302);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(65, 54);
            this.buttonZero.TabIndex = 10;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = false;
            this.buttonZero.Click += new System.EventHandler(this.buttonNum_click);
            // 
            // buttonQuatro
            // 
            this.buttonQuatro.BackColor = System.Drawing.Color.Turquoise;
            this.buttonQuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuatro.Location = new System.Drawing.Point(12, 182);
            this.buttonQuatro.Name = "buttonQuatro";
            this.buttonQuatro.Size = new System.Drawing.Size(65, 54);
            this.buttonQuatro.TabIndex = 11;
            this.buttonQuatro.Text = "4";
            this.buttonQuatro.UseVisualStyleBackColor = false;
            this.buttonQuatro.Click += new System.EventHandler(this.buttonNum_click);
            // 
            // buttonCinco
            // 
            this.buttonCinco.BackColor = System.Drawing.Color.Turquoise;
            this.buttonCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCinco.Location = new System.Drawing.Point(83, 182);
            this.buttonCinco.Name = "buttonCinco";
            this.buttonCinco.Size = new System.Drawing.Size(65, 54);
            this.buttonCinco.TabIndex = 12;
            this.buttonCinco.Text = "5";
            this.buttonCinco.UseVisualStyleBackColor = false;
            this.buttonCinco.Click += new System.EventHandler(this.buttonNum_click);
            // 
            // buttonSeis
            // 
            this.buttonSeis.BackColor = System.Drawing.Color.Turquoise;
            this.buttonSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeis.Location = new System.Drawing.Point(154, 182);
            this.buttonSeis.Name = "buttonSeis";
            this.buttonSeis.Size = new System.Drawing.Size(65, 54);
            this.buttonSeis.TabIndex = 13;
            this.buttonSeis.Text = "6";
            this.buttonSeis.UseVisualStyleBackColor = false;
            this.buttonSeis.Click += new System.EventHandler(this.buttonNum_click);
            // 
            // buttonUm
            // 
            this.buttonUm.BackColor = System.Drawing.Color.Turquoise;
            this.buttonUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUm.Location = new System.Drawing.Point(12, 242);
            this.buttonUm.Name = "buttonUm";
            this.buttonUm.Size = new System.Drawing.Size(65, 54);
            this.buttonUm.TabIndex = 14;
            this.buttonUm.Text = "1";
            this.buttonUm.UseVisualStyleBackColor = false;
            this.buttonUm.Click += new System.EventHandler(this.buttonNum_click);
            // 
            // buttonDois
            // 
            this.buttonDois.BackColor = System.Drawing.Color.Turquoise;
            this.buttonDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDois.Location = new System.Drawing.Point(83, 242);
            this.buttonDois.Name = "buttonDois";
            this.buttonDois.Size = new System.Drawing.Size(65, 54);
            this.buttonDois.TabIndex = 15;
            this.buttonDois.Text = "2";
            this.buttonDois.UseVisualStyleBackColor = false;
            this.buttonDois.Click += new System.EventHandler(this.buttonNum_click);
            // 
            // buttonTres
            // 
            this.buttonTres.BackColor = System.Drawing.Color.Turquoise;
            this.buttonTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTres.Location = new System.Drawing.Point(154, 242);
            this.buttonTres.Name = "buttonTres";
            this.buttonTres.Size = new System.Drawing.Size(65, 54);
            this.buttonTres.TabIndex = 16;
            this.buttonTres.Text = "3";
            this.buttonTres.UseVisualStyleBackColor = false;
            this.buttonTres.Click += new System.EventHandler(this.buttonNum_click);
            // 
            // buttonVirgula
            // 
            this.buttonVirgula.BackColor = System.Drawing.Color.Turquoise;
            this.buttonVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVirgula.Location = new System.Drawing.Point(154, 302);
            this.buttonVirgula.Name = "buttonVirgula";
            this.buttonVirgula.Size = new System.Drawing.Size(65, 54);
            this.buttonVirgula.TabIndex = 17;
            this.buttonVirgula.Text = ",";
            this.buttonVirgula.UseVisualStyleBackColor = false;
            this.buttonVirgula.Click += new System.EventHandler(this.buttonVirgula_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Turquoise;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(12, 302);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(65, 54);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Del";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.Color.Turquoise;
            this.buttonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCE.Location = new System.Drawing.Point(12, 62);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(65, 54);
            this.buttonCE.TabIndex = 19;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.Color.Turquoise;
            this.buttonCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopy.Location = new System.Drawing.Point(116, 62);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(32, 54);
            this.buttonCopy.TabIndex = 20;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonParenteses
            // 
            this.buttonParenteses.BackColor = System.Drawing.Color.Turquoise;
            this.buttonParenteses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParenteses.Location = new System.Drawing.Point(83, 63);
            this.buttonParenteses.Name = "buttonParenteses";
            this.buttonParenteses.Size = new System.Drawing.Size(32, 54);
            this.buttonParenteses.TabIndex = 21;
            this.buttonParenteses.Text = "()";
            this.buttonParenteses.UseVisualStyleBackColor = false;
            this.buttonParenteses.Click += new System.EventHandler(this.buttonParenteses_Click);
            // 
            // ButtonCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(299, 366);
            this.Controls.Add(this.buttonParenteses);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonVirgula);
            this.Controls.Add(this.buttonTres);
            this.Controls.Add(this.buttonDois);
            this.Controls.Add(this.buttonUm);
            this.Controls.Add(this.buttonSeis);
            this.Controls.Add(this.buttonCinco);
            this.Controls.Add(this.buttonQuatro);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonSete);
            this.Controls.Add(this.buttonNove);
            this.Controls.Add(this.buttonOito);
            this.Controls.Add(this.buttonMenos);
            this.Controls.Add(this.buttonMais);
            this.Controls.Add(this.buttonDivisao);
            this.Controls.Add(this.buttonMultiplicacao);
            this.Controls.Add(this.buttonIgual);
            this.Controls.Add(this.textBoxDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ButtonCalculadora";
            this.Text = "Calculadora Rapha";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Button buttonIgual;
        private System.Windows.Forms.Button buttonMultiplicacao;
        private System.Windows.Forms.Button buttonDivisao;
        private System.Windows.Forms.Button buttonMais;
        private System.Windows.Forms.Button buttonMenos;
        private System.Windows.Forms.Button buttonOito;
        private System.Windows.Forms.Button buttonNove;
        private System.Windows.Forms.Button buttonSete;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonQuatro;
        private System.Windows.Forms.Button buttonCinco;
        private System.Windows.Forms.Button buttonSeis;
        private System.Windows.Forms.Button buttonUm;
        private System.Windows.Forms.Button buttonDois;
        private System.Windows.Forms.Button buttonTres;
        private System.Windows.Forms.Button buttonVirgula;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonParenteses;
    }
}


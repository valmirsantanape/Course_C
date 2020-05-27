namespace SiglePage
{
    partial class FormPricipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEspessuraCaneta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbEspessuraCaneta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCor);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personalizar";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SpringGreen;
            this.button4.Location = new System.Drawing.Point(308, 49);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 27);
            this.button4.TabIndex = 6;
            this.button4.Text = "Salvar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SpringGreen;
            this.button3.Location = new System.Drawing.Point(221, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 27);
            this.button3.TabIndex = 5;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SpringGreen;
            this.button2.Location = new System.Drawing.Point(127, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Borracha";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Espessura Caneta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbEspessuraCaneta
            // 
            this.cbEspessuraCaneta.FormattingEnabled = true;
            this.cbEspessuraCaneta.Location = new System.Drawing.Point(395, 15);
            this.cbEspessuraCaneta.Name = "cbEspessuraCaneta";
            this.cbEspessuraCaneta.Size = new System.Drawing.Size(121, 28);
            this.cbEspessuraCaneta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cor da Caneta";
            // 
            // btnCor
            // 
            this.btnCor.BackColor = System.Drawing.Color.SpringGreen;
            this.btnCor.Location = new System.Drawing.Point(108, 15);
            this.btnCor.Name = "btnCor";
            this.btnCor.Size = new System.Drawing.Size(136, 28);
            this.btnCor.TabIndex = 0;
            this.btnCor.Text = "Botao Cor Caneta";
            this.btnCor.UseVisualStyleBackColor = false;
            this.btnCor.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(8, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 337);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // FormPricipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPricipal";
            this.ShowIcon = false;
            this.Text = "Sigle Page";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEspessuraCaneta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCor;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}


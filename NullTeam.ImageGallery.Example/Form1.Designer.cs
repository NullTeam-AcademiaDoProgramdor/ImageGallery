
namespace NullTeam.ImageGallery.Example
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numericLimiteImagens = new System.Windows.Forms.NumericUpDown();
            this.btnSetLimiteImagens = new System.Windows.Forms.Button();
            this.checkAdicao = new System.Windows.Forms.CheckBox();
            this.checkRemocao = new System.Windows.Forms.CheckBox();
            this.imageGallery1 = new NullTeam.ImageGallery.Lib.ImageGallery();
            this.label1 = new System.Windows.Forms.Label();
            this.checkContador = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericLimiteImagens)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericLimiteImagens
            // 
            this.numericLimiteImagens.Location = new System.Drawing.Point(153, 245);
            this.numericLimiteImagens.Name = "numericLimiteImagens";
            this.numericLimiteImagens.Size = new System.Drawing.Size(99, 20);
            this.numericLimiteImagens.TabIndex = 1;
            // 
            // btnSetLimiteImagens
            // 
            this.btnSetLimiteImagens.Location = new System.Drawing.Point(12, 242);
            this.btnSetLimiteImagens.Name = "btnSetLimiteImagens";
            this.btnSetLimiteImagens.Size = new System.Drawing.Size(135, 23);
            this.btnSetLimiteImagens.TabIndex = 2;
            this.btnSetLimiteImagens.Text = "Setar limite de imagens";
            this.btnSetLimiteImagens.UseVisualStyleBackColor = true;
            this.btnSetLimiteImagens.Click += new System.EventHandler(this.btnSetLimiteImagens_Click);
            // 
            // checkAdicao
            // 
            this.checkAdicao.AutoSize = true;
            this.checkAdicao.Checked = true;
            this.checkAdicao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAdicao.Location = new System.Drawing.Point(12, 271);
            this.checkAdicao.Name = "checkAdicao";
            this.checkAdicao.Size = new System.Drawing.Size(152, 17);
            this.checkAdicao.TabIndex = 3;
            this.checkAdicao.Text = "Permitir adição de imagens";
            this.checkAdicao.UseVisualStyleBackColor = true;
            this.checkAdicao.CheckedChanged += new System.EventHandler(this.checkAdicao_CheckedChanged);
            // 
            // checkRemocao
            // 
            this.checkRemocao.AutoSize = true;
            this.checkRemocao.Checked = true;
            this.checkRemocao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkRemocao.Location = new System.Drawing.Point(12, 294);
            this.checkRemocao.Name = "checkRemocao";
            this.checkRemocao.Size = new System.Drawing.Size(161, 17);
            this.checkRemocao.TabIndex = 4;
            this.checkRemocao.Text = "Permitir remoção de imagens";
            this.checkRemocao.UseVisualStyleBackColor = true;
            this.checkRemocao.CheckedChanged += new System.EventHandler(this.checkRemocao_CheckedChanged);
            // 
            // imageGallery1
            // 
            this.imageGallery1.Images = ((System.Collections.Generic.List<System.Drawing.Image>)(resources.GetObject("imageGallery1.Images")));
            this.imageGallery1.LimiteImagens = ((uint)(0u));
            this.imageGallery1.Location = new System.Drawing.Point(6, 19);
            this.imageGallery1.MostrarContador = true;
            this.imageGallery1.Name = "imageGallery1";
            this.imageGallery1.PermitirAdicao = true;
            this.imageGallery1.PermitirRemocao = true;
            this.imageGallery1.Size = new System.Drawing.Size(325, 199);
            this.imageGallery1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "(0 para sem limite)";
            // 
            // checkContador
            // 
            this.checkContador.AutoSize = true;
            this.checkContador.Checked = true;
            this.checkContador.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkContador.Location = new System.Drawing.Point(13, 318);
            this.checkContador.Name = "checkContador";
            this.checkContador.Size = new System.Drawing.Size(106, 17);
            this.checkContador.TabIndex = 6;
            this.checkContador.Text = "Mostrar contador";
            this.checkContador.UseVisualStyleBackColor = true;
            this.checkContador.CheckedChanged += new System.EventHandler(this.checkContador_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imageGallery1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 224);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Galeria de imagens";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 342);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkContador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkRemocao);
            this.Controls.Add(this.checkAdicao);
            this.Controls.Add(this.btnSetLimiteImagens);
            this.Controls.Add(this.numericLimiteImagens);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericLimiteImagens)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lib.ImageGallery imageGallery1;
        private System.Windows.Forms.NumericUpDown numericLimiteImagens;
        private System.Windows.Forms.Button btnSetLimiteImagens;
        private System.Windows.Forms.CheckBox checkAdicao;
        private System.Windows.Forms.CheckBox checkRemocao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkContador;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


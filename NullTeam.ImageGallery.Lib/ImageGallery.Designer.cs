namespace NullTeam.ImageGallery.Lib
{
    partial class ImageGallery
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnAnteriorImage = new System.Windows.Forms.Button();
            this.btnProximaImage = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tooltipBtnsControle = new System.Windows.Forms.ToolTip(this.components);
            this.labelContador = new System.Windows.Forms.Label();
            this.ButtonsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonsTableLayoutPanel
            // 
            this.ButtonsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsTableLayoutPanel.ColumnCount = 4;
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsTableLayoutPanel.Controls.Add(this.btnAnteriorImage, 0, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.btnProximaImage, 3, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.btnRemover, 1, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.btnAdicionar, 2, 0);
            this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(0, 183);
            this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            this.ButtonsTableLayoutPanel.RowCount = 1;
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(223, 27);
            this.ButtonsTableLayoutPanel.TabIndex = 1;
            // 
            // btnAnteriorImage
            // 
            this.btnAnteriorImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnteriorImage.Image = global::NullTeam.ImageGallery.Lib.Properties.Resources.outline_arrow_left_black_24dp;
            this.btnAnteriorImage.Location = new System.Drawing.Point(3, 3);
            this.btnAnteriorImage.Name = "btnAnteriorImage";
            this.btnAnteriorImage.Size = new System.Drawing.Size(49, 21);
            this.btnAnteriorImage.TabIndex = 0;
            this.tooltipBtnsControle.SetToolTip(this.btnAnteriorImage, "Ir para a imagem anterior");
            this.btnAnteriorImage.UseVisualStyleBackColor = true;
            this.btnAnteriorImage.Click += new System.EventHandler(this.btnAnteriorImage_Click);
            // 
            // btnProximaImage
            // 
            this.btnProximaImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProximaImage.Image = global::NullTeam.ImageGallery.Lib.Properties.Resources.outline_arrow_right_black_24dp;
            this.btnProximaImage.Location = new System.Drawing.Point(168, 3);
            this.btnProximaImage.Name = "btnProximaImage";
            this.btnProximaImage.Size = new System.Drawing.Size(52, 21);
            this.btnProximaImage.TabIndex = 1;
            this.tooltipBtnsControle.SetToolTip(this.btnProximaImage, "Ir para a proxima imagem");
            this.btnProximaImage.UseVisualStyleBackColor = true;
            this.btnProximaImage.Click += new System.EventHandler(this.btnProximaImage_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemover.Image = global::NullTeam.ImageGallery.Lib.Properties.Resources.outline_remove_black_24dp;
            this.btnRemover.Location = new System.Drawing.Point(58, 3);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(49, 21);
            this.btnRemover.TabIndex = 2;
            this.tooltipBtnsControle.SetToolTip(this.btnRemover, "Remover a imagem atual");
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdicionar.Image = global::NullTeam.ImageGallery.Lib.Properties.Resources.outline_add_black_24dp;
            this.btnAdicionar.Location = new System.Drawing.Point(113, 3);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(49, 21);
            this.btnAdicionar.TabIndex = 3;
            this.tooltipBtnsControle.SetToolTip(this.btnAdicionar, "Adicionar uma nova imagem");
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(0, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(223, 160);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // tooltipBtnsControle
            // 
            this.tooltipBtnsControle.ShowAlways = true;
            // 
            // labelContador
            // 
            this.labelContador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelContador.Location = new System.Drawing.Point(3, 165);
            this.labelContador.Name = "labelContador";
            this.labelContador.Size = new System.Drawing.Size(217, 18);
            this.labelContador.TabIndex = 2;
            this.labelContador.Text = "0/0";
            this.labelContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImageGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelContador);
            this.Controls.Add(this.ButtonsTableLayoutPanel);
            this.Controls.Add(this.pictureBox);
            this.Name = "ImageGallery";
            this.Size = new System.Drawing.Size(223, 212);
            this.ButtonsTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayoutPanel;
        private System.Windows.Forms.Button btnAnteriorImage;
        private System.Windows.Forms.Button btnProximaImage;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ToolTip tooltipBtnsControle;
        private System.Windows.Forms.Label labelContador;
    }
}

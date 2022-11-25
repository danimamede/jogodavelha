
namespace JogoDaVelha
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnTwoPlayers = new System.Windows.Forms.Button();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnOnePlayer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(238, 111);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(272, 44);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Jogo da Velha";
            // 
            // btnTwoPlayers
            // 
            this.btnTwoPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwoPlayers.Location = new System.Drawing.Point(243, 357);
            this.btnTwoPlayers.Name = "btnTwoPlayers";
            this.btnTwoPlayers.Size = new System.Drawing.Size(150, 45);
            this.btnTwoPlayers.TabIndex = 2;
            this.btnTwoPlayers.Text = "2 Jogadores";
            this.btnTwoPlayers.UseVisualStyleBackColor = true;
            this.btnTwoPlayers.Click += new System.EventHandler(this.BtnTwoPlayers_Click);
            // 
            // PicLogo
            // 
            this.PicLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicLogo.Image = ((System.Drawing.Image)(resources.GetObject("PicLogo.Image")));
            this.PicLogo.Location = new System.Drawing.Point(129, 91);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(115, 120);
            this.PicLogo.TabIndex = 1;
            this.PicLogo.TabStop = false;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(268, 166);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(204, 24);
            this.lblSubtitle.TabIndex = 4;
            this.lblSubtitle.Text = "Treinamento Prime It";
            // 
            // btnOnePlayer
            // 
            this.btnOnePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnePlayer.Location = new System.Drawing.Point(243, 299);
            this.btnOnePlayer.Name = "btnOnePlayer";
            this.btnOnePlayer.Size = new System.Drawing.Size(150, 45);
            this.btnOnePlayer.TabIndex = 5;
            this.btnOnePlayer.Text = " 1 Jogador";
            this.btnOnePlayer.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(639, 476);
            this.Controls.Add(this.btnOnePlayer);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnTwoPlayers);
            this.Controls.Add(this.PicLogo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Velha - MENU";
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnTwoPlayers;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnOnePlayer;
    }
}


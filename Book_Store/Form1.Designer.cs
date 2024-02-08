namespace Book_Store
{
    partial class Anasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.btngiris = new System.Windows.Forms.Button();
            this.lblkullanici = new System.Windows.Forms.Label();
            this.txtkullanici = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.btnkayit = new System.Windows.Forms.Button();
            this.picresimanasayfa = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsonuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picresimanasayfa)).BeginInit();
            this.SuspendLayout();
            // 
            // btngiris
            // 
            this.btngiris.Location = new System.Drawing.Point(236, 295);
            this.btngiris.Name = "btngiris";
            this.btngiris.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btngiris.Size = new System.Drawing.Size(110, 25);
            this.btngiris.TabIndex = 0;
            this.btngiris.Text = "Giriş Yap";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // lblkullanici
            // 
            this.lblkullanici.AutoSize = true;
            this.lblkullanici.Location = new System.Drawing.Point(33, 122);
            this.lblkullanici.Name = "lblkullanici";
            this.lblkullanici.Size = new System.Drawing.Size(79, 18);
            this.lblkullanici.TabIndex = 1;
            this.lblkullanici.Text = "Kullanıcı";
            // 
            // txtkullanici
            // 
            this.txtkullanici.Location = new System.Drawing.Point(129, 119);
            this.txtkullanici.Name = "txtkullanici";
            this.txtkullanici.Size = new System.Drawing.Size(100, 25);
            this.txtkullanici.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şifre";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(129, 160);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(100, 25);
            this.txtsifre.TabIndex = 2;
            // 
            // btnkayit
            // 
            this.btnkayit.Location = new System.Drawing.Point(61, 295);
            this.btnkayit.Name = "btnkayit";
            this.btnkayit.Size = new System.Drawing.Size(89, 25);
            this.btnkayit.TabIndex = 3;
            this.btnkayit.Text = "Kayıt ol";
            this.btnkayit.UseVisualStyleBackColor = true;
            this.btnkayit.Click += new System.EventHandler(this.btnkayit_Click);
            // 
            // picresimanasayfa
            // 
            this.picresimanasayfa.Image = ((System.Drawing.Image)(resources.GetObject("picresimanasayfa.Image")));
            this.picresimanasayfa.Location = new System.Drawing.Point(280, 82);
            this.picresimanasayfa.Name = "picresimanasayfa";
            this.picresimanasayfa.Size = new System.Drawing.Size(186, 160);
            this.picresimanasayfa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picresimanasayfa.TabIndex = 4;
            this.picresimanasayfa.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(102, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kitabın Adresi www.kitapcin.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hala üye değilmisiniz? Hemen üye ol ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(171, 258);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(0, 18);
            this.lblsonuc.TabIndex = 7;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 374);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picresimanasayfa);
            this.Controls.Add(this.btnkayit);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtkullanici);
            this.Controls.Add(this.lblkullanici);
            this.Controls.Add(this.btngiris);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            ((System.ComponentModel.ISupportInitialize)(this.picresimanasayfa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Label lblkullanici;
        private System.Windows.Forms.TextBox txtkullanici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button btnkayit;
        private System.Windows.Forms.PictureBox picresimanasayfa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsonuc;
    }
}


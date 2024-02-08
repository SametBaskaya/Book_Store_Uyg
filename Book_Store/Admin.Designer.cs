namespace Book_Store
{
    partial class Admin
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
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtkitapadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkitapyazari = new System.Windows.Forms.TextBox();
            this.txttoplam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsatilan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.btngoruntule = new System.Windows.Forms.Button();
            this.txttur = new System.Windows.Forms.Label();
            this.cmbxtur = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbegen = new System.Windows.Forms.TextBox();
            this.menugo = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnkayittemizle = new System.Windows.Forms.Button();
            this.datalist = new System.Windows.Forms.DataGridView();
            this.menugo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalist)).BeginInit();
            this.SuspendLayout();
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(1104, 289);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(99, 30);
            this.btnekle.TabIndex = 1;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(1104, 341);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(99, 30);
            this.btnsil.TabIndex = 1;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click_1);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(1104, 398);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(99, 30);
            this.btnguncelle.TabIndex = 1;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click_1);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(50, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı";
            // 
            // txtkitapadi
            // 
            this.txtkitapadi.Location = new System.Drawing.Point(159, 56);
            this.txtkitapadi.Name = "txtkitapadi";
            this.txtkitapadi.Size = new System.Drawing.Size(100, 29);
            this.txtkitapadi.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Yazarı";
            // 
            // txtkitapyazari
            // 
            this.txtkitapyazari.Location = new System.Drawing.Point(159, 100);
            this.txtkitapyazari.Name = "txtkitapyazari";
            this.txtkitapyazari.Size = new System.Drawing.Size(100, 29);
            this.txtkitapyazari.TabIndex = 3;
            // 
            // txttoplam
            // 
            this.txttoplam.Location = new System.Drawing.Point(709, 103);
            this.txttoplam.Name = "txttoplam";
            this.txttoplam.Size = new System.Drawing.Size(121, 29);
            this.txttoplam.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Stok Durumu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Satılan Adet";
            // 
            // txtsatilan
            // 
            this.txtsatilan.Location = new System.Drawing.Point(709, 56);
            this.txtsatilan.Name = "txtsatilan";
            this.txtsatilan.Size = new System.Drawing.Size(121, 29);
            this.txtsatilan.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(572, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Toplam Miktar";
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(426, 104);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(121, 29);
            this.txtstok.TabIndex = 3;
            // 
            // btngoruntule
            // 
            this.btngoruntule.Location = new System.Drawing.Point(1104, 237);
            this.btngoruntule.Name = "btngoruntule";
            this.btngoruntule.Size = new System.Drawing.Size(99, 35);
            this.btngoruntule.TabIndex = 4;
            this.btngoruntule.Text = "Görüntüle";
            this.btngoruntule.UseVisualStyleBackColor = true;
            this.btngoruntule.Click += new System.EventHandler(this.btngoruntule_Click_1);
            // 
            // txttur
            // 
            this.txttur.AutoSize = true;
            this.txttur.Location = new System.Drawing.Point(310, 63);
            this.txttur.Name = "txttur";
            this.txttur.Size = new System.Drawing.Size(95, 22);
            this.txttur.TabIndex = 5;
            this.txttur.Text = "Kitap Türü";
            // 
            // cmbxtur
            // 
            this.cmbxtur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxtur.FormattingEnabled = true;
            this.cmbxtur.Items.AddRange(new object[] {
            "Seçiniz",
            "Kişisel Gelişim",
            "Macera",
            "Tarih",
            "Aksiyon",
            "Psikoloji"});
            this.cmbxtur.Location = new System.Drawing.Point(426, 63);
            this.cmbxtur.Name = "cmbxtur";
            this.cmbxtur.Size = new System.Drawing.Size(121, 30);
            this.cmbxtur.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(865, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Beğeni sayisi";
            // 
            // txtbegen
            // 
            this.txtbegen.Location = new System.Drawing.Point(1009, 77);
            this.txtbegen.Name = "txtbegen";
            this.txtbegen.Size = new System.Drawing.Size(121, 29);
            this.txtbegen.TabIndex = 3;
            // 
            // menugo
            // 
            this.menugo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem});
            this.menugo.Location = new System.Drawing.Point(0, 0);
            this.menugo.Name = "menugo";
            this.menugo.Size = new System.Drawing.Size(1245, 24);
            this.menugo.TabIndex = 9;
            this.menugo.Text = "menuSemtrip1";
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.anasayfaToolStripMenuItem.Text = "Anasayfa";
            this.anasayfaToolStripMenuItem.Click += new System.EventHandler(this.anasayfaToolStripMenuItem_Click);
            // 
            // btnkayittemizle
            // 
            this.btnkayittemizle.Location = new System.Drawing.Point(1081, 445);
            this.btnkayittemizle.Name = "btnkayittemizle";
            this.btnkayittemizle.Size = new System.Drawing.Size(160, 40);
            this.btnkayittemizle.TabIndex = 10;
            this.btnkayittemizle.Text = "Kayıtları Temizle";
            this.btnkayittemizle.UseVisualStyleBackColor = true;
            this.btnkayittemizle.Click += new System.EventHandler(this.btnkayittemizle_Click);
            // 
            // datalist
            // 
            this.datalist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalist.Location = new System.Drawing.Point(40, 211);
            this.datalist.Name = "datalist";
            this.datalist.Size = new System.Drawing.Size(1022, 287);
            this.datalist.TabIndex = 11;
            this.datalist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datalist_CellClick);
            this.datalist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datalist_CellDoubleClick);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1245, 541);
            this.Controls.Add(this.datalist);
            this.Controls.Add(this.btnkayittemizle);
            this.Controls.Add(this.cmbxtur);
            this.Controls.Add(this.txttur);
            this.Controls.Add(this.btngoruntule);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbegen);
            this.Controls.Add(this.txtsatilan);
            this.Controls.Add(this.txtkitapyazari);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txttoplam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtkitapadi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.menugo);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menugo;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.menugo.ResumeLayout(false);
            this.menugo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkitapadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkitapyazari;
        private System.Windows.Forms.TextBox txttoplam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsatilan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.Button btngoruntule;
        private System.Windows.Forms.Label txttur;
        private System.Windows.Forms.ComboBox cmbxtur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbegen;
        private System.Windows.Forms.MenuStrip menugo;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.Button btnkayittemizle;
        private System.Windows.Forms.DataGridView datalist;
    }
}
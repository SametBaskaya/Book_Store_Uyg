namespace Book_Store
{
    partial class Kullanici
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
            this.menusayfa = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblkullanici = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grouparama = new System.Windows.Forms.GroupBox();
            this.listkitap = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnsorgula = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtaranan = new System.Windows.Forms.TextBox();
            this.grparama = new System.Windows.Forms.GroupBox();
            this.radiotop5 = new System.Windows.Forms.RadioButton();
            this.radiencokbegenilen = new System.Windows.Forms.RadioButton();
            this.radioencoksatan = new System.Windows.Forms.RadioButton();
            this.alfabetiksira = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbkategori = new System.Windows.Forms.ComboBox();
            this.btnsorgulatum = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblgelenkullanici = new System.Windows.Forms.Label();
            this.menusayfa.SuspendLayout();
            this.grouparama.SuspendLayout();
            this.grparama.SuspendLayout();
            this.SuspendLayout();
            // 
            // menusayfa
            // 
            this.menusayfa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.yenToolStripMenuItem});
            this.menusayfa.Location = new System.Drawing.Point(0, 0);
            this.menusayfa.Name = "menusayfa";
            this.menusayfa.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menusayfa.Size = new System.Drawing.Size(1139, 27);
            this.menusayfa.TabIndex = 0;
            this.menusayfa.Text = "menuStrip1";
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(67, 19);
            this.anasayfaToolStripMenuItem.Text = "Anasayfa";
            this.anasayfaToolStripMenuItem.Click += new System.EventHandler(this.anasayfaToolStripMenuItem_Click);
            // 
            // yenToolStripMenuItem
            // 
            this.yenToolStripMenuItem.Name = "yenToolStripMenuItem";
            this.yenToolStripMenuItem.Size = new System.Drawing.Size(69, 19);
            this.yenToolStripMenuItem.Text = "Yeni kayıt";
            this.yenToolStripMenuItem.Click += new System.EventHandler(this.yenToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hoşgeldin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblkullanici
            // 
            this.lblkullanici.AutoSize = true;
            this.lblkullanici.Location = new System.Drawing.Point(130, 170);
            this.lblkullanici.Name = "lblkullanici";
            this.lblkullanici.Size = new System.Drawing.Size(49, 23);
            this.lblkullanici.TabIndex = 2;
            this.lblkullanici.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Burdan istediğin sorgulamaları yapabilirsin";
            // 
            // grouparama
            // 
            this.grouparama.BackColor = System.Drawing.Color.Transparent;
            this.grouparama.Controls.Add(this.listkitap);
            this.grouparama.Location = new System.Drawing.Point(12, 219);
            this.grouparama.Name = "grouparama";
            this.grouparama.Size = new System.Drawing.Size(914, 339);
            this.grouparama.TabIndex = 5;
            this.grouparama.TabStop = false;
            this.grouparama.Text = "Arama Sonucu";
            // 
            // listkitap
            // 
            this.listkitap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listkitap.HideSelection = false;
            this.listkitap.Location = new System.Drawing.Point(22, 45);
            this.listkitap.Name = "listkitap";
            this.listkitap.Size = new System.Drawing.Size(871, 277);
            this.listkitap.TabIndex = 0;
            this.listkitap.UseCompatibleStateImageBehavior = false;
            this.listkitap.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kitap Adı";
            this.columnHeader1.Width = 154;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kitap Yazari";
            this.columnHeader2.Width = 139;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kitap Türü";
            this.columnHeader3.Width = 121;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Stok Miktarı";
            this.columnHeader4.Width = 135;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Satılan Miktar";
            this.columnHeader5.Width = 111;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Toplam Adet";
            this.columnHeader6.Width = 103;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Beğeni Sayısı";
            this.columnHeader7.Width = 103;
            // 
            // btnsorgula
            // 
            this.btnsorgula.Location = new System.Drawing.Point(982, 402);
            this.btnsorgula.Name = "btnsorgula";
            this.btnsorgula.Size = new System.Drawing.Size(98, 31);
            this.btnsorgula.TabIndex = 6;
            this.btnsorgula.Text = "Sorgula";
            this.btnsorgula.UseVisualStyleBackColor = true;
            this.btnsorgula.Click += new System.EventHandler(this.btnsorgula_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(932, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Arama";
            // 
            // txtaranan
            // 
            this.txtaranan.Location = new System.Drawing.Point(994, 286);
            this.txtaranan.Name = "txtaranan";
            this.txtaranan.Size = new System.Drawing.Size(121, 30);
            this.txtaranan.TabIndex = 8;
            // 
            // grparama
            // 
            this.grparama.Controls.Add(this.radiotop5);
            this.grparama.Controls.Add(this.radiencokbegenilen);
            this.grparama.Controls.Add(this.radioencoksatan);
            this.grparama.Controls.Add(this.alfabetiksira);
            this.grparama.Location = new System.Drawing.Point(751, 36);
            this.grparama.Name = "grparama";
            this.grparama.Size = new System.Drawing.Size(329, 134);
            this.grparama.TabIndex = 9;
            this.grparama.TabStop = false;
            this.grparama.Text = "Arama Ölçütleri";
            // 
            // radiotop5
            // 
            this.radiotop5.AutoSize = true;
            this.radiotop5.Location = new System.Drawing.Point(150, 29);
            this.radiotop5.Name = "radiotop5";
            this.radiotop5.Size = new System.Drawing.Size(61, 27);
            this.radiotop5.TabIndex = 1;
            this.radiotop5.TabStop = true;
            this.radiotop5.Text = "Top 5";
            this.radiotop5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radiotop5.UseVisualStyleBackColor = true;
            // 
            // radiencokbegenilen
            // 
            this.radiencokbegenilen.AutoSize = true;
            this.radiencokbegenilen.Location = new System.Drawing.Point(150, 71);
            this.radiencokbegenilen.Name = "radiencokbegenilen";
            this.radiencokbegenilen.Size = new System.Drawing.Size(134, 27);
            this.radiencokbegenilen.TabIndex = 0;
            this.radiencokbegenilen.TabStop = true;
            this.radiencokbegenilen.Text = "En çok beğenilen";
            this.radiencokbegenilen.UseVisualStyleBackColor = true;
            // 
            // radioencoksatan
            // 
            this.radioencoksatan.AutoSize = true;
            this.radioencoksatan.Location = new System.Drawing.Point(16, 71);
            this.radioencoksatan.Name = "radioencoksatan";
            this.radioencoksatan.Size = new System.Drawing.Size(135, 27);
            this.radioencoksatan.TabIndex = 0;
            this.radioencoksatan.TabStop = true;
            this.radioencoksatan.Text = "En çok satılanlar";
            this.radioencoksatan.UseVisualStyleBackColor = true;
            this.radioencoksatan.CheckedChanged += new System.EventHandler(this.radiomaksimum_CheckedChanged);
            // 
            // alfabetiksira
            // 
            this.alfabetiksira.AutoSize = true;
            this.alfabetiksira.Location = new System.Drawing.Point(16, 29);
            this.alfabetiksira.Name = "alfabetiksira";
            this.alfabetiksira.Size = new System.Drawing.Size(50, 27);
            this.alfabetiksira.TabIndex = 0;
            this.alfabetiksira.TabStop = true;
            this.alfabetiksira.Text = "A-Z";
            this.alfabetiksira.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(932, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kategori";
            // 
            // cmbkategori
            // 
            this.cmbkategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbkategori.FormattingEnabled = true;
            this.cmbkategori.Items.AddRange(new object[] {
            "Seçiniz",
            "Kişisel Gelişim",
            "Aksiyon",
            "Macera",
            "Psikoloji",
            "Tarih"});
            this.cmbkategori.Location = new System.Drawing.Point(994, 341);
            this.cmbkategori.Name = "cmbkategori";
            this.cmbkategori.Size = new System.Drawing.Size(121, 31);
            this.cmbkategori.TabIndex = 11;
            // 
            // btnsorgulatum
            // 
            this.btnsorgulatum.Location = new System.Drawing.Point(351, 594);
            this.btnsorgulatum.Name = "btnsorgulatum";
            this.btnsorgulatum.Size = new System.Drawing.Size(212, 40);
            this.btnsorgulatum.TabIndex = 12;
            this.btnsorgulatum.Text = "Tüm Kayıtları Sorgula";
            this.btnsorgulatum.UseVisualStyleBackColor = true;
            this.btnsorgulatum.Click += new System.EventHandler(this.btnsorgulatum_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(887, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            // 
            // lblgelenkullanici
            // 
            this.lblgelenkullanici.AutoSize = true;
            this.lblgelenkullanici.Location = new System.Drawing.Point(121, 62);
            this.lblgelenkullanici.Name = "lblgelenkullanici";
            this.lblgelenkullanici.Size = new System.Drawing.Size(48, 23);
            this.lblgelenkullanici.TabIndex = 17;
            this.lblgelenkullanici.Text = "label7";
            // 
            // Kullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1139, 749);
            this.Controls.Add(this.lblgelenkullanici);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnsorgulatum);
            this.Controls.Add(this.cmbkategori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grparama);
            this.Controls.Add(this.txtaranan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsorgula);
            this.Controls.Add(this.grouparama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblkullanici);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menusayfa);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menusayfa;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Kullanici";
            this.Text = "Kullanici";
            this.Load += new System.EventHandler(this.Kullanici_Load);
            this.menusayfa.ResumeLayout(false);
            this.menusayfa.PerformLayout();
            this.grouparama.ResumeLayout(false);
            this.grparama.ResumeLayout(false);
            this.grparama.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menusayfa;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yenToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblkullanici;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grouparama;
        private System.Windows.Forms.Button btnsorgula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtaranan;
        private System.Windows.Forms.GroupBox grparama;
        private System.Windows.Forms.RadioButton radiotop5;
        private System.Windows.Forms.RadioButton radiencokbegenilen;
        private System.Windows.Forms.RadioButton radioencoksatan;
        private System.Windows.Forms.RadioButton alfabetiksira;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbkategori;
        private System.Windows.Forms.Button btnsorgulatum;
        private System.Windows.Forms.ListView listkitap;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblgelenkullanici;
    }
}
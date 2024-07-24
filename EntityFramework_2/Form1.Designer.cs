
namespace EntityFramework_2
{
	partial class Form1
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
			this.txtIsim = new System.Windows.Forms.TextBox();
			this.txtFiyat = new System.Windows.Forms.TextBox();
			this.cmbKategoriler = new System.Windows.Forms.ComboBox();
			this.btnEkle = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.lstUrunler = new System.Windows.Forms.ListBox();
			this.btnKategoriReset = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtIsim
			// 
			this.txtIsim.Location = new System.Drawing.Point(116, 56);
			this.txtIsim.Name = "txtIsim";
			this.txtIsim.Size = new System.Drawing.Size(100, 22);
			this.txtIsim.TabIndex = 0;
			// 
			// txtFiyat
			// 
			this.txtFiyat.Location = new System.Drawing.Point(116, 105);
			this.txtFiyat.Name = "txtFiyat";
			this.txtFiyat.Size = new System.Drawing.Size(100, 22);
			this.txtFiyat.TabIndex = 1;
			// 
			// cmbKategoriler
			// 
			this.cmbKategoriler.FormattingEnabled = true;
			this.cmbKategoriler.Location = new System.Drawing.Point(116, 154);
			this.cmbKategoriler.Name = "cmbKategoriler";
			this.cmbKategoriler.Size = new System.Drawing.Size(121, 24);
			this.cmbKategoriler.TabIndex = 2;
			// 
			// btnEkle
			// 
			this.btnEkle.Location = new System.Drawing.Point(116, 209);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(100, 31);
			this.btnEkle.TabIndex = 3;
			this.btnEkle.Text = "Ekle";
			this.btnEkle.UseVisualStyleBackColor = true;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// btnSil
			// 
			this.btnSil.Location = new System.Drawing.Point(116, 259);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(100, 31);
			this.btnSil.TabIndex = 4;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Location = new System.Drawing.Point(116, 317);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(100, 31);
			this.btnGuncelle.TabIndex = 5;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// lstUrunler
			// 
			this.lstUrunler.FormattingEnabled = true;
			this.lstUrunler.ItemHeight = 16;
			this.lstUrunler.Location = new System.Drawing.Point(350, 56);
			this.lstUrunler.Name = "lstUrunler";
			this.lstUrunler.Size = new System.Drawing.Size(438, 292);
			this.lstUrunler.TabIndex = 6;
			this.lstUrunler.Click += new System.EventHandler(this.lstUrunler_Click);
			// 
			// btnKategoriReset
			// 
			this.btnKategoriReset.Location = new System.Drawing.Point(252, 154);
			this.btnKategoriReset.Name = "btnKategoriReset";
			this.btnKategoriReset.Size = new System.Drawing.Size(92, 34);
			this.btnKategoriReset.TabIndex = 7;
			this.btnKategoriReset.Text = "Resetle";
			this.btnKategoriReset.UseVisualStyleBackColor = true;
			this.btnKategoriReset.Click += new System.EventHandler(this.btnKategoriReset_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(61, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 17);
			this.label1.TabIndex = 8;
			this.label1.Text = "İsim";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(55, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 17);
			this.label2.TabIndex = 9;
			this.label2.Text = "Fiyat";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 157);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 17);
			this.label3.TabIndex = 10;
			this.label3.Text = "Kategori";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnKategoriReset);
			this.Controls.Add(this.lstUrunler);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.btnSil);
			this.Controls.Add(this.btnEkle);
			this.Controls.Add(this.cmbKategoriler);
			this.Controls.Add(this.txtFiyat);
			this.Controls.Add(this.txtIsim);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtIsim;
		private System.Windows.Forms.TextBox txtFiyat;
		private System.Windows.Forms.ComboBox cmbKategoriler;
		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.ListBox lstUrunler;
		private System.Windows.Forms.Button btnKategoriReset;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}


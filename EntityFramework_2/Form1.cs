using EntityFramework_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework_2
{
	public partial class Form1 : Form
	{
		NorthwindEntities _db;
		public Form1()
		{
			InitializeComponent();
			_db = new NorthwindEntities();
		}
		public void KategoriveUrunleriListele() {
			lstUrunler.DataSource = _db.Products.ToList();
			lstUrunler.DisplayMember = "ProductName";
			
			cmbKategoriler.DataSource = _db.Categories.ToList();
			cmbKategoriler.DisplayMember = "CategoryName";
			
			cmbKategoriler.ValueMember = "CategoryID";//ValueMember arka tarafta saklanan kullanıcıya gözükmeyen deger.
													  //Arka tarafta CategoryID ait veriler bulunmakta.
			cmbKategoriler.SelectedIndex = lstUrunler.SelectedIndex = -1;

			txtFiyat.Text = txtIsim.Text = string.Empty;//string.Empty, boş bir string ("") değerini temsil eden bir sabittir
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			KategoriveUrunleriListele();
			
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			try
			{
				Product p = new Product()
				{

					ProductName = txtIsim.Text,
					UnitPrice = Convert.ToDecimal(txtFiyat.Text)
				};
				if (cmbKategoriler.SelectedIndex > -1)
				{
					p.CategoryID = Convert.ToInt32(cmbKategoriler.SelectedValue);//Combobox ın arkasında sakladığı ValueMember ına erişmiş olduk.
				}

				_db.Products.Add(p);
				_db.SaveChanges();
				KategoriveUrunleriListele();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

			}
		}

		private void btnKategoriReset_Click(object sender, EventArgs e)
		{
			cmbKategoriler.SelectedIndex = -1;
		}


		Product _secilen;

		private void lstUrunler_Click(object sender, EventArgs e)
		{
			if (lstUrunler.SelectedIndex > -1) {

				_secilen = lstUrunler.SelectedItem  as Product;
				txtFiyat.Text = _secilen.UnitPrice.ToString();
				txtIsim.Text = _secilen.ProductName;
				cmbKategoriler.SelectedValue = _secilen.CategoryID != null ? _secilen.CategoryID : -1;
			}
		}
		public void KaydetveListele() {

			_db.SaveChanges();
			_secilen = null;
			KategoriveUrunleriListele();
		}
		public void SecileniResetle()
		{
			_secilen = null;

		}
		public void GuncelleveSilIslemleriGerceklestir() {

			KaydetveListele();
			SecileniResetle();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (_secilen != null)
			{
				_db.Products.Remove(_secilen);
				GuncelleveSilIslemleriGerceklestir();


			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			try
			{
				if (_secilen != null)
				{

					_secilen.ProductName = txtIsim.Text;
					_secilen.UnitPrice = Convert.ToDecimal(txtFiyat.Text);
					KategoriBelirle(_secilen);
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
			
		}
		public void KategoriBelirle(Product item) {

			item.CategoryID = cmbKategoriler.SelectedItem != null ? Convert.ToInt32(cmbKategoriler.SelectedValue): default(int?);
		
		}
	}
}

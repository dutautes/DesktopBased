using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopBased
{
    public partial class KasirOtomatis : Form
    {
        List<int> harga = new  List<int>();
        public KasirOtomatis()
        {
            InitializeComponent();
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            string barang = txtBarang.Text;
            int hrg = int.Parse(txtHarga.Text);

            harga.Add(hrg);
            lstBelanja.Items.Add($"{barang} - Rp{hrg}");

            txtBarang.Clear();
            txtHarga.Clear();
            txtBarang.Focus();
        }

        private void Hitung_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach (int h in harga) total += h;

            lblTotal.Text = $"Total: Rp{total}";
        }
    }
}

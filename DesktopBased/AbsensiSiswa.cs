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
    public partial class AbsensiSiswa : Form
    {
        public AbsensiSiswa()
        {
            InitializeComponent();
            cmbStatus.Items.Add("Hadir");
            cmbStatus.Items.Add("Izin");
            cmbStatus.Items.Add("Sakit");
            cmbStatus.Items.Add("Alfa");
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            string nama = lstAbsen.Text;
            string combo = cmbStatus.SelectedItem.ToString();

            lstAbsensi.Items.Add("Nama : " + nama + " | Keterangan : " + combo);

            lstAbsen.Text = "";
            cmbStatus.SelectedItem = null;
            lstAbsen.Focus();

        }
    }
}

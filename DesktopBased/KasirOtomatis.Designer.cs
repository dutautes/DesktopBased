namespace DesktopBased
{
    partial class KasirOtomatis
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
            this.txtBarang = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Hitung = new MaterialSkin.Controls.MaterialFlatButton();
            this.lstBelanja = new System.Windows.Forms.ListBox();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.txtHarga = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnTambah = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // txtBarang
            // 
            this.txtBarang.Depth = 0;
            this.txtBarang.Hint = "";
            this.txtBarang.Location = new System.Drawing.Point(399, 92);
            this.txtBarang.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBarang.Name = "txtBarang";
            this.txtBarang.PasswordChar = '\0';
            this.txtBarang.SelectedText = "";
            this.txtBarang.SelectionLength = 0;
            this.txtBarang.SelectionStart = 0;
            this.txtBarang.Size = new System.Drawing.Size(75, 23);
            this.txtBarang.TabIndex = 0;
            this.txtBarang.UseSystemPasswordChar = false;
            // 
            // Hitung
            // 
            this.Hitung.AutoSize = true;
            this.Hitung.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Hitung.Depth = 0;
            this.Hitung.Location = new System.Drawing.Point(319, 186);
            this.Hitung.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Hitung.MouseState = MaterialSkin.MouseState.HOVER;
            this.Hitung.Name = "Hitung";
            this.Hitung.Primary = false;
            this.Hitung.Size = new System.Drawing.Size(62, 36);
            this.Hitung.TabIndex = 1;
            this.Hitung.Text = "Hitung";
            this.Hitung.UseVisualStyleBackColor = true;
            this.Hitung.Click += new System.EventHandler(this.Hitung_Click);
            // 
            // lstBelanja
            // 
            this.lstBelanja.FormattingEnabled = true;
            this.lstBelanja.Location = new System.Drawing.Point(218, 289);
            this.lstBelanja.Name = "lstBelanja";
            this.lstBelanja.Size = new System.Drawing.Size(120, 95);
            this.lstBelanja.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(416, 289);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 19);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total";
            // 
            // txtHarga
            // 
            this.txtHarga.Depth = 0;
            this.txtHarga.Hint = "";
            this.txtHarga.Location = new System.Drawing.Point(399, 143);
            this.txtHarga.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.PasswordChar = '\0';
            this.txtHarga.SelectedText = "";
            this.txtHarga.SelectionLength = 0;
            this.txtHarga.SelectionStart = 0;
            this.txtHarga.Size = new System.Drawing.Size(75, 23);
            this.txtHarga.TabIndex = 4;
            this.txtHarga.UseSystemPasswordChar = false;
            // 
            // BtnTambah
            // 
            this.BtnTambah.AutoSize = true;
            this.BtnTambah.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnTambah.Depth = 0;
            this.BtnTambah.Location = new System.Drawing.Point(405, 186);
            this.BtnTambah.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnTambah.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnTambah.Name = "BtnTambah";
            this.BtnTambah.Primary = false;
            this.BtnTambah.Size = new System.Drawing.Size(69, 36);
            this.BtnTambah.TabIndex = 5;
            this.BtnTambah.Text = "Tambah";
            this.BtnTambah.UseVisualStyleBackColor = true;
            this.BtnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(315, 96);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(63, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Barang :";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(321, 147);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(57, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Harga :";
            // 
            // KasirOtomatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.BtnTambah);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lstBelanja);
            this.Controls.Add(this.Hitung);
            this.Controls.Add(this.txtBarang);
            this.Name = "KasirOtomatis";
            this.Text = "KasirOtomatis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtBarang;
        private MaterialSkin.Controls.MaterialFlatButton Hitung;
        private System.Windows.Forms.ListBox lstBelanja;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtHarga;
        private MaterialSkin.Controls.MaterialFlatButton BtnTambah;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}
namespace DesktopBased
{
    partial class AbsensiSiswa
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
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lstAbsensi = new System.Windows.Forms.ListBox();
            this.BtnTambah = new MaterialSkin.Controls.MaterialFlatButton();
            this.lstAbsen = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Hadir",
            "Tidak Hadir"});
            this.cmbStatus.Location = new System.Drawing.Point(499, 104);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(160, 24);
            this.cmbStatus.TabIndex = 1;
            this.cmbStatus.Text = "Kehadiran";
            // 
            // lstAbsensi
            // 
            this.lstAbsensi.FormattingEnabled = true;
            this.lstAbsensi.ItemHeight = 16;
            this.lstAbsensi.Location = new System.Drawing.Point(315, 309);
            this.lstAbsensi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstAbsensi.Name = "lstAbsensi";
            this.lstAbsensi.Size = new System.Drawing.Size(363, 116);
            this.lstAbsensi.TabIndex = 3;
            // 
            // BtnTambah
            // 
            this.BtnTambah.AutoSize = true;
            this.BtnTambah.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnTambah.Depth = 0;
            this.BtnTambah.Location = new System.Drawing.Point(499, 135);
            this.BtnTambah.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnTambah.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnTambah.Name = "BtnTambah";
            this.BtnTambah.Primary = false;
            this.BtnTambah.Size = new System.Drawing.Size(62, 36);
            this.BtnTambah.TabIndex = 4;
            this.BtnTambah.Text = "Submit";
            this.BtnTambah.UseVisualStyleBackColor = true;
            this.BtnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // lstAbsen
            // 
            this.lstAbsen.Depth = 0;
            this.lstAbsen.Hint = "";
            this.lstAbsen.Location = new System.Drawing.Point(499, 74);
            this.lstAbsen.MouseState = MaterialSkin.MouseState.HOVER;
            this.lstAbsen.Name = "lstAbsen";
            this.lstAbsen.PasswordChar = '\0';
            this.lstAbsen.SelectedText = "";
            this.lstAbsen.SelectionLength = 0;
            this.lstAbsen.SelectionStart = 0;
            this.lstAbsen.Size = new System.Drawing.Size(160, 23);
            this.lstAbsen.TabIndex = 5;
            this.lstAbsen.Text = "isi nama anda";
            this.lstAbsen.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(409, 74);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(57, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Nama :";
            // 
            // AbsensiSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lstAbsen);
            this.Controls.Add(this.BtnTambah);
            this.Controls.Add(this.lstAbsensi);
            this.Controls.Add(this.cmbStatus);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AbsensiSiswa";
            this.Text = "AbsensiSiswa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ListBox lstAbsensi;
        private MaterialSkin.Controls.MaterialFlatButton BtnTambah;
        private MaterialSkin.Controls.MaterialSingleLineTextField lstAbsen;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
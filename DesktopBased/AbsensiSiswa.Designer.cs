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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Hadir",
            "Tidak Hadir"});
            this.cmbStatus.Location = new System.Drawing.Point(373, 93);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 1;
            this.cmbStatus.Text = "Kehadiran";
            // 
            // lstAbsensi
            // 
            this.lstAbsensi.FormattingEnabled = true;
            this.lstAbsensi.Location = new System.Drawing.Point(250, 212);
            this.lstAbsensi.Name = "lstAbsensi";
            this.lstAbsensi.Size = new System.Drawing.Size(273, 95);
            this.lstAbsensi.TabIndex = 3;
            // 
            // BtnTambah
            // 
            this.BtnTambah.AutoSize = true;
            this.BtnTambah.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnTambah.Depth = 0;
            this.BtnTambah.Location = new System.Drawing.Point(373, 132);
            this.BtnTambah.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            this.lstAbsen.Location = new System.Drawing.Point(374, 56);
            this.lstAbsen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstAbsen.MouseState = MaterialSkin.MouseState.HOVER;
            this.lstAbsen.Name = "lstAbsen";
            this.lstAbsen.PasswordChar = '\0';
            this.lstAbsen.SelectedText = "";
            this.lstAbsen.SelectionLength = 0;
            this.lstAbsen.SelectionStart = 0;
            this.lstAbsen.Size = new System.Drawing.Size(120, 23);
            this.lstAbsen.TabIndex = 5;
            this.lstAbsen.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(297, 60);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(57, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Nama :";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(262, 93);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(92, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Keterangan :";
            // 
            // AbsensiSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lstAbsen);
            this.Controls.Add(this.BtnTambah);
            this.Controls.Add(this.lstAbsensi);
            this.Controls.Add(this.cmbStatus);
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
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}
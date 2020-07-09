namespace Stok_Takip_Sistemi
{
    partial class FrmGiris
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
            this.lbl_parola = new DevExpress.XtraEditors.LabelControl();
            this.lbl_kullanici_adi = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_parola = new DevExpress.XtraEditors.TextEdit();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_parola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_parola
            // 
            this.lbl_parola.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parola.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_parola.Appearance.Options.UseFont = true;
            this.lbl_parola.Appearance.Options.UseForeColor = true;
            this.lbl_parola.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_parola.Location = new System.Drawing.Point(61, 116);
            this.lbl_parola.Name = "lbl_parola";
            this.lbl_parola.Size = new System.Drawing.Size(114, 22);
            this.lbl_parola.TabIndex = 13;
            this.lbl_parola.Text = "Parola";
            // 
            // lbl_kullanici_adi
            // 
            this.lbl_kullanici_adi.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kullanici_adi.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_kullanici_adi.Appearance.Options.UseFont = true;
            this.lbl_kullanici_adi.Appearance.Options.UseForeColor = true;
            this.lbl_kullanici_adi.Location = new System.Drawing.Point(61, 42);
            this.lbl_kullanici_adi.Name = "lbl_kullanici_adi";
            this.lbl_kullanici_adi.Size = new System.Drawing.Size(115, 22);
            this.lbl_kullanici_adi.TabIndex = 10;
            this.lbl_kullanici_adi.Text = "Kullanıcı Adı";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_parola);
            this.panel1.Controls.Add(this.lbl_parola);
            this.panel1.Controls.Add(this.txtKullaniciAdi);
            this.panel1.Controls.Add(this.lbl_kullanici_adi);
            this.panel1.Location = new System.Drawing.Point(181, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 288);
            this.panel1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(61, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 61);
            this.button1.TabIndex = 14;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_parola
            // 
            this.txt_parola.EditValue = "";
            this.txt_parola.Location = new System.Drawing.Point(61, 144);
            this.txt_parola.Name = "txt_parola";
            this.txt_parola.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txt_parola.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_parola.Properties.Appearance.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.txt_parola.Properties.Appearance.Options.UseBackColor = true;
            this.txt_parola.Properties.Appearance.Options.UseFont = true;
            this.txt_parola.Properties.Appearance.Options.UseForeColor = true;
            this.txt_parola.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txt_parola.Properties.PasswordChar = '*';
            this.txt_parola.Size = new System.Drawing.Size(242, 28);
            this.txt_parola.TabIndex = 11;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.EditValue = "";
            this.txtKullaniciAdi.Location = new System.Drawing.Point(61, 71);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Properties.Appearance.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.txtKullaniciAdi.Properties.Appearance.Options.UseBackColor = true;
            this.txtKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.txtKullaniciAdi.Properties.Appearance.Options.UseForeColor = true;
            this.txtKullaniciAdi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(242, 28);
            this.txtKullaniciAdi.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(258, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 75);
            this.label1.TabIndex = 16;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(268, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Stock Management System";
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(731, 444);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGiris";
            this.Text = "GirisYap";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_parola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lbl_parola;
        private DevExpress.XtraEditors.LabelControl lbl_kullanici_adi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txt_parola;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
    }
}
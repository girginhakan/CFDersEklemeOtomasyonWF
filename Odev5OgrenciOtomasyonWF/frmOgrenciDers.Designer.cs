namespace Odev5OgrenciOtomasyonWF
{
    partial class frmOgrenciDers
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtDersId = new TextBox();
            txtDersAdi = new TextBox();
            txtDersKodu = new TextBox();
            txtHarfNotu = new TextBox();
            txtKredi = new TextBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            dgvDersListe = new DataGridView();
            btnGenelOrtalama = new Button();
            btnIstatistikler = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDersListe).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 76);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 0;
            label1.Text = "Ders ID : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 126);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 1;
            label2.Text = "Ders Adı : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 177);
            label3.Name = "label3";
            label3.Size = new Size(98, 23);
            label3.TabIndex = 2;
            label3.Text = "Ders Kodu :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 227);
            label4.Name = "label4";
            label4.Size = new Size(95, 23);
            label4.TabIndex = 3;
            label4.Text = "Harf Notu :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 278);
            label5.Name = "label5";
            label5.Size = new Size(69, 23);
            label5.TabIndex = 4;
            label5.Text = "Kredisi :";
            // 
            // txtDersId
            // 
            txtDersId.Enabled = false;
            txtDersId.Location = new Point(136, 73);
            txtDersId.Name = "txtDersId";
            txtDersId.Size = new Size(169, 30);
            txtDersId.TabIndex = 5;
            // 
            // txtDersAdi
            // 
            txtDersAdi.Location = new Point(136, 123);
            txtDersAdi.Name = "txtDersAdi";
            txtDersAdi.Size = new Size(169, 30);
            txtDersAdi.TabIndex = 6;
            // 
            // txtDersKodu
            // 
            txtDersKodu.Location = new Point(136, 174);
            txtDersKodu.Name = "txtDersKodu";
            txtDersKodu.Size = new Size(169, 30);
            txtDersKodu.TabIndex = 7;
            // 
            // txtHarfNotu
            // 
            txtHarfNotu.Location = new Point(136, 224);
            txtHarfNotu.Name = "txtHarfNotu";
            txtHarfNotu.Size = new Size(169, 30);
            txtHarfNotu.TabIndex = 8;
            // 
            // txtKredi
            // 
            txtKredi.Location = new Point(136, 275);
            txtKredi.Name = "txtKredi";
            txtKredi.Size = new Size(169, 30);
            txtKredi.TabIndex = 9;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(37, 345);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(117, 41);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(188, 345);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(117, 41);
            btnGuncelle.TabIndex = 11;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(37, 404);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(268, 41);
            btnSil.TabIndex = 12;
            btnSil.Text = "Kaldır";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dgvDersListe
            // 
            dgvDersListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDersListe.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDersListe.Location = new Point(352, 34);
            dgvDersListe.Name = "dgvDersListe";
            dgvDersListe.RowHeadersWidth = 51;
            dgvDersListe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDersListe.Size = new Size(667, 352);
            dgvDersListe.TabIndex = 13;
            dgvDersListe.CellClick += dgvDersListe_CellClick;
            // 
            // btnGenelOrtalama
            // 
            btnGenelOrtalama.Location = new Point(352, 405);
            btnGenelOrtalama.Name = "btnGenelOrtalama";
            btnGenelOrtalama.Size = new Size(286, 40);
            btnGenelOrtalama.TabIndex = 14;
            btnGenelOrtalama.Text = "Genel Ortalama";
            btnGenelOrtalama.UseVisualStyleBackColor = true;
            btnGenelOrtalama.Click += btnGenelOrtalama_Click;
            // 
            // btnIstatistikler
            // 
            btnIstatistikler.Location = new Point(710, 404);
            btnIstatistikler.Name = "btnIstatistikler";
            btnIstatistikler.Size = new Size(309, 40);
            btnIstatistikler.TabIndex = 15;
            btnIstatistikler.Text = "İstatistikleri Göster";
            btnIstatistikler.UseVisualStyleBackColor = true;
            btnIstatistikler.Click += btnIstatistikler_Click;
            // 
            // frmOgrenciDers
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 471);
            Controls.Add(btnIstatistikler);
            Controls.Add(btnGenelOrtalama);
            Controls.Add(dgvDersListe);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtKredi);
            Controls.Add(txtHarfNotu);
            Controls.Add(txtDersKodu);
            Controls.Add(txtDersAdi);
            Controls.Add(txtDersId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmOgrenciDers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmOgrenciDers";
            ((System.ComponentModel.ISupportInitialize)dgvDersListe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtDersId;
        private TextBox txtDersAdi;
        private TextBox txtDersKodu;
        private TextBox txtHarfNotu;
        private TextBox txtKredi;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dgvDersListe;
        private Button btnGenelOrtalama;
        private Button btnIstatistikler;
    }
}

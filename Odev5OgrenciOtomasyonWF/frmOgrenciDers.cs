using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Odev5OgrenciOtomasyonWF
{
    public partial class frmOgrenciDers : Form
    {
        OgrenciOtomasyonContext db = new OgrenciOtomasyonContext();
        Ders secilenDers;
        DialogResult dialog = new DialogResult();
        public frmOgrenciDers()
        {
            InitializeComponent();
            DersleriListele();
        }

        public void DersleriListele()
        {
            dgvDersListe.DataSource = db.Dersler.ToList();
        }

        public float HarfNotuDonusumu(string ders)
        {
            if (ders == "A")
                return 4.0f;
            if (ders == "B")
                return 3.5f;
            if (ders == "C")
                return 2.0f;
            if (ders == "D")
                return 1.0f;
            if (ders == "F")
                return 0.0f;
            return 0.0f;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtDersAdi.Text != string.Empty && txtDersKodu.Text != string.Empty && txtHarfNotu.Text != string.Empty && txtKredi.Text != null)
            {
                Ders ders = new Ders();
                ders.DersAdi = txtDersAdi.Text;
                ders.DersKodu = txtDersKodu.Text;
                ders.HarfNotu = txtHarfNotu.Text;
                ders.DersKredisi = int.Parse(txtKredi.Text);

                db.Dersler.Add(ders);
                db.SaveChanges();
                DersleriListele();
            }

        }

        private void dgvDersListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenDers = (Ders)dgvDersListe.SelectedRows[0].DataBoundItem;
            txtDersId.Text = secilenDers.Id.ToString();
            txtDersAdi.Text = secilenDers.DersAdi;
            txtDersKodu.Text = secilenDers.DersKodu;
            txtHarfNotu.Text = secilenDers.HarfNotu;
            txtKredi.Text = secilenDers.DersKredisi.ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenDers != null)
            {
                secilenDers.DersAdi = txtDersAdi.Text;
                secilenDers.DersKodu = txtDersKodu.Text;
                secilenDers.HarfNotu = txtHarfNotu.Text;
                secilenDers.DersKredisi = int.Parse(txtKredi.Text);
                db.Dersler.Update(secilenDers);
                db.SaveChanges();
                MessageBox.Show("Seçili olan kişi başarıyla güncellenmiştir.");
                DersleriListele();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            dialog = MessageBox.Show(" Seçilen dersi silmek istediğinizden emin misiniz?", "Sil", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes && secilenDers != null)
            {
                db.Dersler.Remove(secilenDers);
                db.SaveChanges();
                MessageBox.Show("İlgili ders başarıyla silinmiştir");
                DersleriListele();
            }
            else
            {
                MessageBox.Show("Lütfen silme işlemi yapmak için ders seçiniz");
            }
        }

        private void btnGenelOrtalama_Click(object sender, EventArgs e)
        {
            float ortalama = 0;
            foreach (var not in db.Dersler)
            {
                ortalama = (HarfNotuDonusumu(not.HarfNotu) * not.DersKredisi) / db.Dersler.Count();
            }

            MessageBox.Show("Derslerin Genel ortalaması : " + ortalama.ToString());
        }

        private void btnIstatistikler_Click(object sender, EventArgs e)
        {
            MessageBox.Show(db.Dersler.Count().ToString()+ "dersten: \n"+)
        }
    }
}

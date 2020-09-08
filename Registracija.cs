using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Registracija : Form
    {
        private Korisnik korisnik;
        public bool Edit { get; set; }

        KonekcijaNaBazu KonekcijaNaBazu = DLWMS.DB;

        public Registracija()
        {
            InitializeComponent();
            korisnik = new Korisnik();
            UcitajSpolove();
        }

        public Registracija(Korisnik korisnik) : this()
        {
            this.korisnik = korisnik;
            UcitajPodatkeOKorisniku();
            Edit = true;

        }

        private void UcitajPodatkeOKorisniku()
        {
            try
            {
                txtIme.Text = korisnik.Ime;
                txtPrezime.Text = korisnik.Prezime;
                txtKorisnickoIme.Text = korisnik.KorisnickoIme;
                txtLozinka.Text = korisnik.Lozinka;
                pbSlikaKorisnika.Image =ImageHelper.FromByteToImage( korisnik.Slika);
                cmbSpol.SelectedValue = korisnik.Spol.Id;
                cbAdmin.Checked = korisnik.Admin;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Greska -> {ex.Message}");
            }
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {

                
                korisnik.Ime = txtIme.Text;
                korisnik.Prezime = txtPrezime.Text;
                korisnik.KorisnickoIme = txtKorisnickoIme.Text;
                korisnik.Lozinka = txtLozinka.Text;
                korisnik.Slika = ImageHelper.FromImageToByte(pbSlikaKorisnika.Image);
                korisnik.Spol = cmbSpol.SelectedItem as Spolovi;
                korisnik.Admin = cbAdmin.Checked;

                if (!Edit)
                {
                    //korisnik.Id = DBInMemory.RegistrovaniKorisnici.Count + 1;
                    //DBInMemory.RegistrovaniKorisnici.Add(korisnik);
                    KonekcijaNaBazu.Korisnici.Add(korisnik);
                    KonekcijaNaBazu.SaveChanges();
                    MessageBox.Show($"Registracija je uspjesna");
                }
                else
                {
                    KonekcijaNaBazu.Entry(korisnik).State = EntityState.Modified;
                    KonekcijaNaBazu.SaveChanges();
                    MessageBox.Show($"Editovanje je uspjesno");
                }
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidirajUnos()
        {
            return Validator.ObaveznoPolje(txtIme,err, Validator.porukaObaveznaVrijednost) && Validator.ObaveznoPolje(txtPrezime,err, Validator.porukaObaveznaVrijednost) && Validator.ObaveznoPolje(cmbSpol, err, Validator.porukaObaveznaVrijednost);
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            txtKorisnickoIme.Text = $"{txtIme.Text.ToLower()}.{txtPrezime.Text.ToLower()}";
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            txtKorisnickoIme.Text = $"{txtIme.Text.ToLower()}.{txtPrezime.Text.ToLower()}";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            char prazan = new char();
            if (txtLozinka.PasswordChar == prazan)
                txtLozinka.PasswordChar = '*';
            else
                txtLozinka.PasswordChar = prazan;
        }

        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdUcitajSliku.ShowDialog() == DialogResult.OK)
                {
                    string putanjaDoSlike = ofdUcitajSliku.FileName;
                    Image slika = Image.FromFile(putanjaDoSlike);
                    pbSlikaKorisnika.Image = slika;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"greska -> {ex}");
            }
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            Text = cmbSpol.SelectedIndex.ToString();
        }

        private void Registracija_Load(object sender, EventArgs e)
        {
           
        }

        private void UcitajSpolove()
        {
            try
            {
                cmbSpol.DataSource = KonekcijaNaBazu.Spolovi.ToList();
                cmbSpol.DisplayMember = "Naziv";
                cmbSpol.ValueMember = "Id";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

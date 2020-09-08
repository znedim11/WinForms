using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class KorisniciAdmin : Form
    {
        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;
        public KorisniciAdmin()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }

        private void KorisniciAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            Registracija registracija = new Registracija();
            if(registracija.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void dgvKorisnici_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void LoadData (List<Korisnik> korisnici = null)
        {
            try
            {
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = korisnici ?? konekcijaNaBazu.Korisnici.ToList();//DBInMemory.RegistrovaniKorisnici;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "" + ex.InnerException.Message);
            }
        }

        private void txtPretraga_ver1_TextChanged(object sender, EventArgs e)
        {
            string filter = txtPretraga.Text.ToLower();
            List<Korisnik> rezultat = new List<Korisnik>();
            foreach (var korisnik in DBInMemory.RegistrovaniKorisnici)
            {
                if (korisnik.Ime.ToLower().Contains(filter) || korisnik.Prezime.ToLower().Contains(filter))
                    rezultat.Add(korisnik);
            }
            LoadData(rezultat);
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            string filter = txtPretraga.Text.ToLower();
            List<Korisnik> rezultat =
                DBInMemory.RegistrovaniKorisnici.Where
                (korisnik => korisnik.Ime.ToLower().Contains(filter) || korisnik.Prezime.ToLower().Contains(filter)).ToList();
            
            LoadData(rezultat);
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Korisnik korisnik = dgvKorisnici.SelectedRows[0].DataBoundItem as Korisnik;
            Form forma = null;
            if (korisnik != null)
            {
                if (e.ColumnIndex == 5)
                {
                    forma = new KorisniciPolozeniPredmeti(korisnik);                   
                }
                else if(e.ColumnIndex==6){
                    forma = new Izvjestaj(korisnik);
                }
                else
                {
                    forma = new Registracija(korisnik);
                }
                forma.ShowDialog();
                LoadData();
            }
        }
    }
}

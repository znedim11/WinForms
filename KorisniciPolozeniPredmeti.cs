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
    public partial class KorisniciPolozeniPredmeti : Form
    {
        private Korisnik korisnik;
        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;

        public KorisniciPolozeniPredmeti()
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
        }

        public KorisniciPolozeniPredmeti(Korisnik korisnik):this()
        {
            this.korisnik = korisnik;
        }

        private void KorisniciPolozeniPredmeti_Load(object sender, EventArgs e)
        {
            UcitajPredmete();
            UcitajPolozenePredmete();
            
        }

        private void UcitajPredmete()
        {
            try
            {
                cmbPredmeti.DataSource = konekcijaNaBazu.Predmeti.ToList();// DBInMemory.NPP2018;
                cmbPredmeti.DisplayMember = "Naziv";
                cmbPredmeti.ValueMember = "Id";
            }
            catch (Exception ex)
            {

                MboxHelper.PrikaziGresku(ex);
            }
            
        }

        private void UcitajPolozenePredmete()
        {
            try
            {
                dgvPolozeniPredmeti.DataSource = null;
                dgvPolozeniPredmeti.DataSource = korisnik.Uspjeh;
            }
            catch ( Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }

        private void btnDodajPolozeni_Click(object sender, EventArgs e)
        {
            try
            {
                Predmeti odabraniPredmet = cmbPredmeti.SelectedItem as Predmeti;
                ProvjeriDaLiPredmetPostoji(odabraniPredmet);
                KorisniciPredmeti polozeniPredmet = new KorisniciPredmeti();
                //polozeniPredmet.Id = korisnik.Polozeni.Count + 1;
                polozeniPredmet.Predmet = cmbPredmeti.SelectedItem as Predmeti;
                polozeniPredmet.Ocjena = int.Parse(txtOcjena.Text);
                polozeniPredmet.Datum = dtpDatumPologanja.Value.ToString("dd.MM.yyyy");
                korisnik.Uspjeh.Add(polozeniPredmet);
                konekcijaNaBazu.SaveChanges();
                UcitajPolozenePredmete();


                //PolozeniPredmeti polozeniPredmet = new PolozeniPredmeti();
                //polozeniPredmet.Id = korisnik.Polozeni.Count + 1;
                //polozeniPredmet.Predmet = cmbPredmeti.SelectedItem as Predmet;
                //polozeniPredmet.Ocjena = int.Parse(txtOcjena.Text);
                //polozeniPredmet.DatumPolaganja = dtpDatumPologanja.Value;
                //korisnik.Polozeni.Add(polozeniPredmet);
                //UcitajPolozenePredmete();

            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
            ;
        }

        private void ProvjeriDaLiPredmetPostoji(Predmeti odabraniPredmet)
        {
            if (korisnik.Uspjeh.Where(x => x.Predmet.Id == odabraniPredmet.Id).Count() > 0)
                throw new Exception($"Predmet {odabraniPredmet} je vec evidentiran korisniku {korisnik}");
        }

        private void dgvPolozeniPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

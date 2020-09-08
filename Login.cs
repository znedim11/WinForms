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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
             
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtKorisnickoIme.Text;
            string lozinka = txtLozinka.Text;
            bool pronadjen = false;

            if (ValidirajUnos())
            {

                foreach (var korisnik in DBInMemory.RegistrovaniKorisnici)
                {
                    if (korisnickoIme == korisnik.KorisnickoIme && lozinka == korisnik.Lozinka)
                    {
                        MessageBox.Show($"Dobro dosli {korisnik}");
                        pronadjen = true;
                    }
                }
                if (!pronadjen)
                    MessageBox.Show($"Uneseni podaci nisu validini");
            }
        }

        private bool ValidirajUnos()
        {
            return Validator.ObaveznoPolje(txtKorisnickoIme, errorProvider1, Validator.porukaObaveznaVrijednost) && Validator.ObaveznoPolje(txtLozinka, errorProvider1, Validator.porukaObaveznaVrijednost);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.ShowDialog();
        }
    }
}

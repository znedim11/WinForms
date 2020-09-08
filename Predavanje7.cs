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
    public partial class Predavanje7 : Form
    {
        public Predavanje7()
        {
            InitializeComponent();
        }

        private void Predavanje7_Load(object sender, EventArgs e)
        {
            //VarDynamic();
            //AnonimniTipoviTuple();
            //DodatneMetode();
            LINQ();
        }

        private void LINQ()
        {
            
        }

        private void DodatneMetode()
        {
            string ime = "denis";
            //ime.FITEnkripcija();
        }

        private void AnonimniTipoviTuple()
        {
            var student = new { Indeks = 150051, Ime = "denis" };
            //student.Ime = "Music";

            var predmet = (Godina:1,Naziv:"Programiranje II",6);
            //predmet.Item3
            //predmet.Godina
        }

        private void VarDynamic()
        {
            var broj = 10;
            var ime = "denis";
            var korisnici2019 = new List<Korisnik>();
            var polozeni2019 = new Dictionary<AjademsaGodina, PolozeniPredmeti>();

            dynamic broj2 = 30;
            broj2 = "Music";
            //broj2.NepostojecaMetoda();
            dynamic ime2 = "denis";
        }

        int[] ocjene = new int[] { 6, 9, 8, 6, 7, 8, 8, 10 };
        private void txtFilter_ver1_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtFilter.Text))
            {
                int filter = int.Parse(txtFilter.Text);
                var dobreOcjene =
                    from o in ocjene
                    where o > filter
                    select o;

                cbDobreOcjene.DataSource = dobreOcjene.ToList();
            }
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtFilter.Text))
            {
                int filter = int.Parse(txtFilter.Text);
                var dobreOcjene =
                    ocjene.Where(ocjena =>ocjena>filter);

                cbDobreOcjene.DataSource = dobreOcjene.ToList();
            }
        }
    }

    //static class KlasaDodatnihMetoda
    //{
    //    public static string FITEnkripcija(this string sadrzaj)
    //    {
    //        string znakovi = "abcdefghijklmnoprstuvz0123456789";
    //        string zamjena = "1bcad9ef8g6h3ij2klm5nvprstuz89*q";
    //        string kriptovaniSadrzaj = "";
    //        for (int i = 0; i < sadrzaj.Length; i++)
    //        {
    //            kriptovaniSadrzaj += zamjena[znakovi.IndexOf(sadrzaj[i])];
    //            return kriptovaniSadrzaj;
    //        }
    //    }
    //}

    class AjademsaGodina { }

    //class PolozeniPredmeti { }
}

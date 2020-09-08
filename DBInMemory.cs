using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    class DBInMemory
    {
        public static List<Korisnik> RegistrovaniKorisnici { get; set; } 
        public static List<string> Spolovi { get; set; }
        public static List<Predmet> NPP2018 { get; set; }
        static DBInMemory()
        {
            RegistrovaniKorisnici = new List<Korisnik>();
            Spolovi = new List<string>();
            NPP2018 = new List<Predmet>();
            DodajSpolove();
            DodajPodrazumjevaneKorisnike();
            UcitajPredmeteNPP2018();
        }

        private static void UcitajPredmeteNPP2018()
        {
            for (int i = 1; i < 20; i++)
            {
                NPP2018.Add(new Predmet() { Id = i,Naziv=$"Predmet {i} "});
            }
        }

        private static void DodajSpolove()
        {
            Spolovi.Add("Muski");
            Spolovi.Add("Zenski");
            Spolovi.Add("******");
        }

        private static void DodajPodrazumjevaneKorisnike()
        {
            Korisnik k1 = new Korisnik() { Id = 1, Ime = "Denis", Prezime = "Music", KorisnickoIme = "denis", Lozinka = "denis" };
            Korisnik k2 = new Korisnik() { Id = 2, Ime = "Jasmin", Prezime = "Azemovic", KorisnickoIme = "jasmin", Lozinka = "jasmin" };
            RegistrovaniKorisnici.Add(k1);
            RegistrovaniKorisnici.Add(k2);
        }
    }
}

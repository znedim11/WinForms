using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace WinForms
{
    public partial class Izvjestaj : Form
    {
        private Korisnik korisnik;

        public Izvjestaj()
        {
            InitializeComponent();
        }

        public Izvjestaj(Korisnik korisnik) : this()
        {
            this.korisnik = korisnik;
        }

        private void Izvjestaj_Load(object sender, EventArgs e)
        {
            if (korisnik != null)
            {
                ReportParameterCollection rpc = new ReportParameterCollection();
                rpc.Add(new ReportParameter("ImePrezime", $"{korisnik.Ime} {korisnik.Prezime}"));
                rpc.Add(new ReportParameter("Indeks",korisnik.KorisnickoIme));

                DSDLWMS.tblPolozeniDataTable tbl = new DSDLWMS.tblPolozeniDataTable();
                int i = 1;

                
                foreach (var polozeni in korisnik.Uspjeh)
                {
                    DSDLWMS.tblPolozeniRow red = tbl.NewtblPolozeniRow();
                    red.Rb = i++.ToString();
                    red.Naziv = polozeni.Predmet.Naziv;
                    red.Ocjena = polozeni.Ocjena;
                    red.Datum = polozeni.Datum;
                    tbl.Rows.Add(red);

                }

                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DLWMS";
                rds.Value = tbl;



                reportViewer1.LocalReport.SetParameters(rpc);
                reportViewer1.LocalReport.DataSources.Add(rds);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}

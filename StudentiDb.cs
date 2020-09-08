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
    public partial class StudentiDb : Form
    {
        KonekcijaNaBazu konekcijaNaBazu = new KonekcijaNaBazu();
        public StudentiDb()
        {
            InitializeComponent();
        }

        private void StudentiDb_Load(object sender, EventArgs e)
        {
            UcitajSveStudente();
        }

        private void btnDodajStudenta_Click(object sender, EventArgs e)
        {
            try
            {
                Studenti studenti = new Studenti() { ImePrezime = txtImePrezime.Text };
                konekcijaNaBazu.Studenti.Add(studenti);
                konekcijaNaBazu.SaveChanges();
                UcitajSveStudente();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "" + ex.InnerException?.Message);
            }
        }

        private void UcitajSveStudente()
        {
            try
            {
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = konekcijaNaBazu.Studenti.ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "" + ex.InnerException?.Message);
            }
        }
    }
}

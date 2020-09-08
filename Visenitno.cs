using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.P11
{
    public partial class Visenitno : Form
    {
        public Visenitno()
        {
            InitializeComponent();
        }
        string zaIspis;

        async void NekaMetoda()
        {
            await Task.Run(() =>
            {
                ProvjeriPrivilegije();
            });
            ProvjeriBazu();

        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {

            txtIspis.Text = zaIspis = "";

            NekaMetoda();

            var konekcija = Task.Run(() =>
            {
                ProvjeriKonekciju();

            });

            var cekanje = konekcija.GetAwaiter();//AWAIT
            cekanje.OnCompleted(() => {
                ProvjeriBazu();
            });

            Task.Run(() =>
            {
                ProvjeriBazu();
            });


            //txtIspis.Text = zaIspis;
        }

        private void ProvjeriPrivilegije()
        {
            Thread.Sleep(1000);
            Action action = () => txtIspis.Text += "Privilegije OK..." + Environment.NewLine;
            BeginInvoke(action);
        }

        private void ProvjeriBazu()
        {
            Thread.Sleep(2000);
            Action action = () => txtIspis.Text += "Baza OK..." + Environment.NewLine;
            BeginInvoke(action);
        }

        private void ProvjeriKonekciju()
        {
            Thread.Sleep(3000);
            Action action = () => txtIspis.Text += "Koenkcija OK..." + Environment.NewLine;
            BeginInvoke(action);

        }
    }
}


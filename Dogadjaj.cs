using System;
using System.Collections;
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
    class Student
    {
        int[] ocjene = new int[] { 6, 9, 8, 10 };
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < ocjene.Length; i++)
            {
                yield return ocjene[i];
            }
        }
    }

    public partial class Dogadjaj : Form
    {
        delegate void Notifikacija(string poruka);
        event Notifikacija SMSNotifikacija;

        delegate void NotifikacijaNadleznih(string broj, string poruka);
        event NotifikacijaNadleznih ZabranjenUnos;
        public Dogadjaj()
        {
            InitializeComponent();
            ZabranjenUnos += PosaljiNotifikacijuNadleznim;
           
        }

        void PosaljiNotifikacijuNadleznim(string brojTelefona, string poruka)
        {
            MessageBox.Show($"Nadlezni -> {brojTelefona} : {poruka}");
        }
        private void btnSMSSalji_Click(object sender, EventArgs e)
        {
            Student IB150061 = new Student();
            foreach(var ocjene in IB150061)
            {
                MessageBox.Show($"Ocjena-> {ocjene}");
            }


            foreach(var slovo in "denis")
            {
                MessageBox.Show($"Slovo -> {slovo}");
            }
            var enumerator = "denis".GetEnumerator();
            while (enumerator.MoveNext())
            {
                MessageBox.Show($"Slovo -> {enumerator.Current}");
            }
        }

        void BHTelecom(string poruka)
        {
            MessageBox.Show($"BHTelecom -> {poruka}");
        }
        void Eronet(string poruka)
        {
            MessageBox.Show($"Eronet -> {poruka}");
        }

        

        private void cbBHTelecom_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBHTelecom.Checked)
                SMSNotifikacija += BHTelecom;
            else
                SMSNotifikacija -= BHTelecom;
        }

        private void cbEronet_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEronet.Checked)
                SMSNotifikacija += Eronet;
            else
                SMSNotifikacija -= Eronet;
        }

        private void txtPoruka_TextChanged(object sender, EventArgs e)
        {
            if (txtPoruka.Text.Contains("ubiti"))
                ZabranjenUnos("061222333", $"Koristenje zabranjene rijeci {txtPoruka.Text}");
        }

        private void Dogadjaj_Load(object sender, EventArgs e)
        {
            MessageBox.Show(MathUtil.Calc(kvadriraj, 1,2,5,6).ToString());
            MessageBox.Show(MathUtil.Calc(kubiraj, 1, 2, 5, 6).ToString());
        }
        int kvadriraj(int broj) { return broj * broj; }
        int kubiraj(int broj) { return broj * broj * broj; }
    }
    delegate int Operacija(int broj);
    class MathUtil
    {
        public static int Calc(Operacija operacija, params int [] brojevi)
        {
            int suma = 0;
            for (int i = 0; i < brojevi.Length; i++)
            {
                suma += operacija(brojevi[i]);
            }
            return suma;
        }

    }
}

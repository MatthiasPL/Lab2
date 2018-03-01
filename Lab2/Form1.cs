using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        string uzytkownik;
        public Form1()
        {
            InitializeComponent();
        }

        #region MojeMetody
        //Obsługa błędów- niewypełnione pole
        private bool CzyPoleWypelnione(TextBox poleTekstowe)
        {
            if (poleTekstowe.Text == "")
            {
                errorProviderPolTekstowych.SetError(poleTekstowe,"Pole zostało niewypełnione");
                return false;
            }
            errorProviderPolTekstowych.SetError(poleTekstowe, "");
            return true;
        }

        private void CzyscFormularz()
        {
            textBoxImie.Clear();
            textBoxNazwisko.Clear();
        }

        private bool DodajUzytkownikaDoListy(string uzytkownik)
        {
            if (listBox1.Items.Contains(uzytkownik))
            {
                //zaimplementować 
                return false;
            }
            else
            {
                listBox1.Items.Add(uzytkownik);
                CzyscFormularz();
                textBoxImie.Focus();
                return true;
            }
        }
        #endregion

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            //Nie trzeba &&, lepiej to zrobić &
            if (CzyPoleWypelnione(textBoxImie) & CzyPoleWypelnione(textBoxNazwisko))
            {
                uzytkownik = textBoxImie.Text + " " + textBoxNazwisko.Text + " " + numericUpDownWiek.Value;
                DodajUzytkownikaDoListy(uzytkownik);
                uzytkownik = "";
                
            }
        }
    }
}

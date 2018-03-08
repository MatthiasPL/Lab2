using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private void UsunUzytkownikaZListy()
        {
            string zaznaczenie = listBox1.SelectedItem.ToString();
            if (zaznaczenie != "")
                listBox1.Items.Remove(zaznaczenie);
            
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

        private void buttonUsun_Click(object sender, MouseEventArgs e)
        {
            UsunUzytkownikaZListy();
        }

        private void textBoxImie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar)&&!char.IsLetter('-')&&e.KeyChar!=127){
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                textBoxNazwisko.Focus();
            }
        }

        private void textBoxNazwisko_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                numericUpDownWiek.Focus();
            }
        }

        private void numericUpDownWiek_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonDodaj_Click(sender, e);
            }
        }

    }
}

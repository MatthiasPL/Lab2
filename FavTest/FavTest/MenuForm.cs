using FavTest.Models;
using FavTest.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FavTest
{
    public partial class MenuForm : Form, IMenuForm
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        #region Interface
        int prevPytanie;
        public string TextOdpowiedz
        {
            get
            {
                return textOdpowiedz.Text;
            }

            set
            {
                textOdpowiedz.Text = value;
            }
        }

        public string TextPytanie
        {
            get
            {
                return textPytanie.Text;
            }

            set
            {
                textPytanie.Text = value;
            }
        }
        public string[] ListaPytan
        {
            get
            {
                return ListaPytan;
            }
            set
            {
                if (value != null)
                {
                    listPytania.Items.Clear();
                    listPytania.Items.AddRange(value);
                }
            }
        }

        public int IdCurrentPytanie
        {
            get
            {
                return listPytania.SelectedIndex;
            }
            set
            {
                listPytania.SelectedIndex = value;
            }

        }
        public string[] ListaOdpowiedzi
        {
            get
            {
                return ListaOdpowiedzi;
            }
            set
            {
                if (value != null)
                {
                    checkedListOdpowiedzi.Items.Clear();
                    checkedListOdpowiedzi.Items.AddRange(value);
                }
            }
        }
        public int IdCurrentOdpowiedz
        {
            get
            {
                return checkedListOdpowiedzi.SelectedIndex;
            }
            set
            {
                IdCurrentPytanie = value;
            }
        }
        public int IdPreviousPytanie
        {
            get
            {
                return prevPytanie;
            }

            set
            {
                prevPytanie = value;
            }
        }

        public Answer NewAnswer { get; set; }

        public Question NewQuestion{get; set; }
        public Test test { get; set; }

        public event Action<object, EventArgs> VEventOnLoad;
        public event Action<object, EventArgs> VEventOnSelect;
        public event Action<object, EventArgs> VEventOnSave;
        public event Action<object, EventArgs> VEventOnEdit;
        public event Action<object, EventArgs> VEventOnDelete;
        public event Action<object, EventArgs> VEventOnNewAnswer;
        public event Action<object, EventArgs> VEventOnAnswerDelete;
        public event Action<object, EventArgs> VEventOnLostQuestionFocus;
        public event Action<object, EventArgs> CzyNaPewno;
        #endregion

        #region Functions
        public void OdswiezListe()
        {
            listPytania.Items.Clear();
        }
        public void DodajOdpowiedz(string odp, bool isValid)
        {
            checkedListOdpowiedzi.Items.Add(odp, isValid);
        }
        public void UsunOdpowiedzi()
        {
            checkedListOdpowiedzi.Items.Clear();
            textPytanie.Clear();
            textOdpowiedz.Clear();
        }
        public List<string> ZwrocOdpowiedzi()
        {
            List<string> odpowiedzi = new List<string>();
            foreach(var item in checkedListOdpowiedzi.Items)
            {
                odpowiedzi.Add(item.ToString());
            }
            return odpowiedzi;
        }
        public List<int> ZwrocListeIdPoprawnychOdpowiedzi()
        {
            List<int> listaPoprawnosci = new List<int>();
            foreach(int indexChecked in checkedListOdpowiedzi.CheckedIndices)
            {
                listaPoprawnosci.Add(indexChecked);
                //Console.WriteLine(indexChecked);
            }
            return listaPoprawnosci;
        }
        public void ZaladujOdpowiedzi()
        {
            checkedListOdpowiedzi.Items.Clear();
            foreach(var item in test.Questions[IdCurrentPytanie].Answers)
            {
                DodajOdpowiedz(item.AnswerText, item.IsValid);
            }
        }
        public void SetQuestionFocus()
        {
            listPytania.Focus();
            listPytania.SelectedIndex = IdPreviousPytanie;
            //listPytania.
        }
        #endregion

        private void MenuForm_Load(object sender, EventArgs e)
        {
            if (VEventOnLoad != null)
            {
                VEventOnLoad(sender, e);
            }
        }

        private void listPytania_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (VEventOnLoad != null)
            {
                VEventOnSelect(sender, e);
                CzyNaPewno(sender, e);
            }
        }

        private void buttonZapiszTest_Click(object sender, EventArgs e)
        {
            if (VEventOnSave != null)
            {
                VEventOnSave(sender, e);
            }
        }

        private void buttonEdytujPytanie_Click(object sender, EventArgs e)
        {
            if (VEventOnEdit != null)
            {
                VEventOnEdit(sender, e);
            }
        }

        private void buttonUsunPytanie_Click(object sender, EventArgs e)
        {
            if (VEventOnDelete != null)
            {
                VEventOnDelete(sender, e);
            }
        }

        private void buttonDodajOdpowiedz_Click(object sender, EventArgs e)
        {
            if (VEventOnNewAnswer != null)
            {
                VEventOnNewAnswer(sender, e);
            }
        }
        private void buttonUsunOdpowiedz_Click(object sender, EventArgs e)
        {
            if (VEventOnAnswerDelete != null)
            {
                VEventOnAnswerDelete(sender, e);
            }
        }

        private void listPytania_Leave(object sender, EventArgs e)
        {
            if (VEventOnLostQuestionFocus != null)
            {
                VEventOnLostQuestionFocus(sender, e);
            }
        }
    }
}

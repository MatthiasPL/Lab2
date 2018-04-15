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
        public string TextOdpowiedz
        {
            get
            {
                return textOdpowiedz.ToString();
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
                return textPytanie.ToString();
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

        public Answer NewAnswer { get; set; }

        public Question NewQuestion{get; set; }
        public Test test { get; set; }

        public event Action<object, EventArgs> VEventOnLoad;
        public event Action<object, EventArgs> VEventOnSelect;
        #endregion

        #region Functions
        public void DodajOdpowiedz(string odp, bool isValid)
        {
            checkedListOdpowiedzi.Items.Add(odp, isValid);
        }
        public void UsunOdpowiedzi()
        {
            checkedListOdpowiedzi.Items.Clear();
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
            }
        }
    }
}

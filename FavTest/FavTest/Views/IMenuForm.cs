﻿using FavTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavTest.Views
{
    interface IMenuForm
    {
        event Action<object, EventArgs> VEventOnLoad;
        event Action<object, EventArgs> VEventOnSelect;
        event Action<object, EventArgs> VEventOnSave;
        event Action<object, EventArgs> VEventOnEdit;
        event Action<object, EventArgs> VEventOnDelete;
        event Action<object, EventArgs> VEventOnNewAnswer;
        string TextPytanie { get; set; }
        string TextOdpowiedz { get; set; }
        string[] ListaPytan { get; set; }
        int IdCurrentPytanie { get; set; }
        string[] ListaOdpowiedzi { get;  set; }
        void DodajOdpowiedz(string odp, bool isValid);
        void UsunOdpowiedzi();
        void OdswiezListe();
        List<string> ZwrocOdpowiedzi();
        List<int> ZwrocListeIdPoprawnychOdpowiedzi();
        Answer NewAnswer { get; set; }
        Question NewQuestion { get; set; }
        Test test { get; set; }
    }
}

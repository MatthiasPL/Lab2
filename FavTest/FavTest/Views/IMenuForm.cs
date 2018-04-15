using FavTest.Models;
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
        string TextPytanie { get; set; }
        string TextOdpowiedz { get; set; }
        string[] ListaPytan { get; set; }
        int IdCurrentPytanie { get; set; }
        string[] ListaOdpowiedzi { get; set; }
        void DodajOdpowiedz(string odp, bool isValid);
        void UsunOdpowiedzi();
        Answer NewAnswer { get; set; }
        Question NewQuestion { get; set; }
        Test test { get; set; }
    }
}

﻿using FavTest.Models;
using FavTest.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FavTest.Presenters
{
    public class MenuFormPresenter
    {
        IMenuForm menuform;
        Model model;
        public MenuFormPresenter(Model model, MenuForm menuform)
        {
            this.model = model;
            this.menuform = menuform;

            menuform.VEventOnLoad += View_VEventOnLoad;
            menuform.VEventOnSelect += View_VEventOnSelect;
            menuform.VEventOnSave += View_VEventOnSave;
            menuform.VEventOnEdit += View_VEventOnEdit;
            menuform.VEventOnDelete += View_VEventOnDelete;
        }

        private void View_VEventOnLoad(object arg1, EventArgs arg2)
        {
            if(File.Exists("file.xml")){
                menuform.test = model.LoadTest("file.xml");
                menuform.ListaPytan = model.LoadQuestions(menuform.test);
            }
            else
            {
                File.Create("file.xml");
            }
        }
        private void View_VEventOnSelect(object arg1, EventArgs arg2)
        {
            menuform.UsunOdpowiedzi();
            menuform.TextPytanie = menuform.test.Questions[menuform.IdCurrentPytanie].QuestionText;
            List<string> odpowiedzi=new List<string>();
            List<int> poprawne = new List<int>();
            int i = 0;
            foreach(Answer answer in menuform.test.Questions[menuform.IdCurrentPytanie].Answers)
            {
                odpowiedzi.Add(answer.AnswerText);
                if (answer.IsValid)
                {
                    poprawne.Add(i);
                }
                i++;
                menuform.DodajOdpowiedz(answer.AnswerText, answer.IsValid);
            }
        }
        private void View_VEventOnSave(object arg1, EventArgs arg2)
        {
            Test test = menuform.test;
            XmlSerializer serializer = new XmlSerializer(typeof(Test));
            serializer.Serialize(File.Create("file.xml"), test);
            MessageBox.Show("Pomyślnie zapisano.");
            //Console.WriteLine("Powodzenie");
        }
        private void View_VEventOnEdit(object arg1, EventArgs arg2)
        {
            if (menuform.IdCurrentPytanie>=1)
            {
                menuform.test.Questions[menuform.IdCurrentPytanie].QuestionText = menuform.TextPytanie;
                List<string> odpowiedzi = menuform.ZwrocOdpowiedzi();
                for (int i = 0; i < odpowiedzi.Count; i++)
                {
                    Console.WriteLine(odpowiedzi[i]);
                }
                List<Answer> answers = new List<Answer>();
                List<int> poprawneId = menuform.ZwrocListeIdPoprawnychOdpowiedzi();

                for (int i = 0; i < odpowiedzi.Count; i++)
                {
                    Answer answer = new Answer();
                    answer.AnswerText = odpowiedzi[i];
                    if (poprawneId.Contains(i))
                    {
                        answer.IsValid = true;
                    }
                    else
                    {
                        answer.IsValid = false;
                    }
                    answers.Add(answer);
                }
                menuform.test.Questions[menuform.IdCurrentPytanie].Answers = answers;
            }
        }
        private void View_VEventOnDelete(object arg1, EventArgs arg2)
        {
            menuform.test.Questions.Remove(menuform.test.Questions.ElementAt(menuform.IdCurrentPytanie));
            menuform.OdswiezListe();
            menuform.UsunOdpowiedzi();
            menuform.ListaPytan = model.LoadQuestions(menuform.test);
        }
        private void View_VEventOnNewAnswer(object arg1, EventArgs arg2)
        {
            Answer answer = model.CreateNewAnswer(menuform.TextOdpowiedz, false);
            menuform.test.Questions[menuform.IdCurrentPytanie].Answers.Add(answer);
            //menuform.OdswiezListe();
            //menuform.UsunOdpowiedzi();
            menuform.DodajOdpowiedz(answer.AnswerText, false);
            menuform.ListaPytan = model.LoadQuestions(menuform.test);
        }
    }
}

//To-Do:
//Funkcje tj.: usun pytanie, ladowanie pytan, ladowanie zawartosci

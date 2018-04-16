using FavTest.Models;
using FavTest.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string path = "file.xml";
            if(File.Exists(path)){
                Test test = null;

                XmlSerializer serializer = new XmlSerializer(typeof(Test));

                StreamReader reader = new StreamReader(path);
                test = (Test)serializer.Deserialize(reader);
                reader.Close();

                List<string> lista = new List<string>();

                foreach (Question question in test.Questions)
                {
                    lista.Add(question.QuestionText);
                }
                menuform.ListaPytan = lista.ToArray();
                menuform.test = test;
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
            Console.WriteLine("Powodzenie");
        }
        private void View_VEventOnEdit(object arg1, EventArgs arg2)
        {
            menuform.test.Questions[menuform.IdCurrentPytanie].QuestionText = menuform.TextPytanie;
            List<string> odpowiedzi = menuform.ZwrocOdpowiedzi();
            for(int i = 0; i < odpowiedzi.Count; i++)
            {
                Console.WriteLine(odpowiedzi[i]);
            }
            List<Answer> answers = new List<Answer>();
            List<int> poprawneId = menuform.ZwrocListeIdPoprawnychOdpowiedzi();
            
            for(int i=0; i<odpowiedzi.Count; i++)
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
        private void View_VEventOnDelete(object arg1, EventArgs arg2)
        {
            menuform.test.Questions.Remove(menuform.test.Questions.ElementAt(menuform.IdCurrentPytanie));
            menuform.OdswiezListe();
            menuform.UsunOdpowiedzi();
            List<string> lista = new List<string>();
            foreach (Question question in menuform.test.Questions)
            {
                lista.Add(question.QuestionText);
            }
            menuform.ListaPytan = lista.ToArray();
        }
    }
}

//To-Do:
//Funkcje tj.: usun pytanie, ladowanie pytan, ladowanie zawartosci

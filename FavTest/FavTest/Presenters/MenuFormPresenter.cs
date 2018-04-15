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
                    Console.WriteLine(i);
                }
                i++;
                menuform.DodajOdpowiedz(answer.AnswerText, answer.IsValid);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FavTest.Models
{
    public class Model
    {
        public Model() { }

        public Answer CreateNewAnswer(string textanswer, bool isvalid)
        {
            return new Answer(textanswer, isvalid);
        }
        public Question CreateNewQuestion(string textquestion, List<Answer> answers)
        {
            return new Question(textquestion, answers);
        }
        public Test LoadTest(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Test));
            Test test = null;
            StreamReader reader = new StreamReader(path);

            test = (Test)serializer.Deserialize(reader);
            reader.Close();

            return test;
        }
        public string[] LoadQuestions(Test test)
        {
            List<string> lista = new List<string>();

            foreach (Question question in test.Questions)
            {
                lista.Add(question.QuestionText);
            }

            return lista.ToArray();
        }
    }
}

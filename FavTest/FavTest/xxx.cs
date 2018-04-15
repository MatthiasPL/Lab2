using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using FavTest.Models;

namespace FavTest
{
    public class xxx
    {
        public xxx() {

            /*Test test = null;
            string path = "file.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(Test));

            StreamReader reader = new StreamReader(path);
            test = (Test)serializer.Deserialize(reader);
            reader.Close();

            Console.WriteLine(test.Questions[0].QuestionText);
            */

            /*Test test = new Test();

            List<Question> questions = new List<Question>();

                for (int i = 0; i < 10; i++)
                {
                    Question question = new Question();
                    question.QuestionText = "Pytanie " + (i+1);
                    question.Answers = new List<Answer>
                    {
                        new Answer
                        {
                            AnswerText="Odp1",
                            IsValid = false
                        },
                        new Answer
                        {
                            AnswerText="Odp2",
                            IsValid=true
                        }
                    };
                    questions.Add(question);
                    test.Questions = questions;
                }

                XmlSerializer serializer = new XmlSerializer(typeof(Test));
                serializer.Serialize(File.Create("file.xml"), test);
                */
        }
    }
}


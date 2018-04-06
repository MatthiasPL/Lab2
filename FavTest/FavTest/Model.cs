using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FavTest
{
    public class Model
    {
        public Model()
        {
            Question question = new Question();
            question.questionText = "Pytanie 1";
            question.answers = new List<Answer>
            {
                new Answer
                {
                    answertext="Odp1",
                    isValid = false
                },
                new Answer
                {
                    answertext="Odp2",
                    isValid=true
                }
            };

            XmlSerializer serializer = new XmlSerializer(typeof(Question));
            serializer.Serialize(File.Create("file.xml"), question);
        }
    }
}


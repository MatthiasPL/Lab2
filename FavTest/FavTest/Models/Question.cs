using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FavTest
{
    public class Question
    {
        //public Question(string questiontext, List<Answer> answers)
        //{
        //    QuestionText = questiontext;
        //    Answers = answers;
        //}
        public Question() { }
        public string QuestionText { get; set; }
        [XmlArray("Answers")]
        [XmlArrayItem("Answer")]
        public List<Answer> Answers { get; set; }
    }
}

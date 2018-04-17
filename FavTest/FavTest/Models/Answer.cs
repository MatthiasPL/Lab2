using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FavTest
{
    public class Answer
    {
        //public Answer(string answertext, bool isvalid)
        //{
        //    AnswerText = answertext;
        //    IsValid = isvalid;
        //}
        public Answer() {}
        public Answer(string answertext, bool isvalid)
        {
            this.AnswerText = answertext;
            this.IsValid = isvalid;
        }
        [XmlAttribute("AnswerText")]
        public string AnswerText { get; set; }
        [XmlAttribute("IsValid")]
        public bool IsValid { get; set; }
    }
}

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
        public string questionText { get; set; }
        [XmlArray]
        [XmlArrayItem(typeof(Answer))]
        public List<Answer> answers { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FavTest.Models
{
    public class Test
    {
        public Test() { }
        //public Test(List<Question> questions)
        //{
        //    Questions = questions;
        //}
        //[XmlArray]
        //[XmlArrayItem(typeof(Question))]
        [XmlArray("Questions")]
        [XmlArrayItem("Question")]
        public List<Question> Questions { get; set; }

    }
}

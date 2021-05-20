using System;
using System.Xml.Serialization;

namespace Object_2.Business_layer
{
    [Serializable]
    public class User
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlElement]
        public double Weight { get; set; }
        [XmlElement]
        public double Height { get; set; }
        [XmlElement]
        public int Age { get; set; }
        [XmlElement]
        public Activity DailyActivity { get; set; }

        public User() { }
    }
}

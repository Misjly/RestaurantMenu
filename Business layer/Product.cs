using System;
using System.Globalization;
using System.Xml.Serialization;

namespace Object_2.Business_layer
{
    [Serializable]
    public class Product
    {
        private NumberFormatInfo _setPrecision = new NumberFormatInfo { NumberDecimalDigits = 2, NumberDecimalSeparator = "," };

        [XmlElement("Name", Type = typeof(string))]
        public string Name { get; set; }

        [XmlElement("Gramms", Type = typeof(int))]
        public int Gramms { get; set; }

        [XmlElement("Protein", Type = typeof(string))]
        public string StringProtein
        {
            get
            {
                return Protein.ToString("F", _setPrecision);
            }
            set
            {
                Protein = double.Parse(value, _setPrecision);
            }
        }

        [XmlIgnore]
        public double Protein { get; set; }

        [XmlElement("Fats", Type = typeof(string))]
        public string StringFats
        {
            get
            {
                return Fats.ToString("F", _setPrecision);
            }
            set
            {
                Fats = double.Parse(value, _setPrecision);
            }
        }

        [XmlIgnore]
        public double Fats { get; set; }

        [XmlElement("Carbs", Type = typeof(string))]
        public string StringCarbs
        {
            get
            {
                return Carbs.ToString("F", _setPrecision);
            }
            set
            {
                Carbs = double.Parse(value, _setPrecision);
            }
        }

        [XmlIgnore]
        public double Carbs { get; set; }

        [XmlElement("Calories", Type = typeof(string))]
        public string StringCalories
        {
            get
            {
                return Calories.ToString("F", _setPrecision);
            }
            set
            {
                Calories = double.Parse(value, _setPrecision);
            }
        }

        [XmlIgnore]
        public double Calories { get; set; }

        public Product() { }
    }
}

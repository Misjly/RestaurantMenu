using System;
using System.Xml.Serialization;

namespace Object_2.Business_layer
{
    [Serializable]
    public class Menu
    {
        [XmlElement("Breakfast")]
        public Category Breakfast { get; set; }
        [XmlElement("Lunch")]
        public Category Lunch { get; set; }
        [XmlElement("Dinner")]
        public Category Dinner { get; set; }
        public Menu()
        {
            Breakfast = new Category();
            Breakfast.Name = "Breakfast";
            Lunch = new Category();
            Lunch.Name = "Lunch";
            Dinner = new Category();
            Dinner.Name = "Dinner";
        }
    }
}

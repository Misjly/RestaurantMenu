using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Object_2.Business_layer
{
    [Serializable]
    public class Category
    {
        [XmlAttribute("name")]
        public string Name { get; set; }
        
        [XmlAttribute("description")]
        public string Description { get; set; }

        [XmlElement("Product", Type = typeof(Product))]
        public List<Product> Products { get; set; } = new List<Product>();
        public Category() { }
    }
}

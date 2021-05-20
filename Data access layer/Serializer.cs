using Object_2.Business_layer;
using System.Configuration;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Object_2.Data_access_layer
{
    public class Serializer<T> where T : class
    {
        public Serializer() { }

        public void Serialize(T items)
        {
            using (var fs = new FileStream(ConfigurationManager.AppSettings[typeof(T).Name], FileMode.Create))
            {
                using (var sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    XmlSerializer formatter = new XmlSerializer(typeof(T));
                    formatter.Serialize(sw, items);
                }
            }
        }

        public T Deserialize()
        {
            using (var fs = new FileStream(ConfigurationManager.AppSettings[typeof(T).Name], FileMode.OpenOrCreate))
            {
                using (var sr = new StreamReader(fs, Encoding.UTF8))
                {
                    XmlSerializer formatter = new XmlSerializer(typeof(T));
                    return (T)formatter.Deserialize(sr);
                }
            }
        }
    }
}

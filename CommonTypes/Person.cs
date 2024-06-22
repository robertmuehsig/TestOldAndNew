using System;
using System.IO;
using System.Xml.Serialization;

namespace CommonTypes
{
    public class Person
    {
        public required string Name { get; set; }

        public static Person DeserializeFromXml(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            using (StringReader reader = new StringReader(xml))
            {
                return (Person)serializer.Deserialize(reader);
            }
        }
    }
}

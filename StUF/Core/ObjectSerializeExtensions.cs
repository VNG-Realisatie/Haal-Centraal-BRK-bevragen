using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace Core
{
    public static class ObjectSerializeExtensions
    {
        public static string SerializeToXml(this object instance)
        {
            if (instance == null) return string.Empty;

            using (var memoryStream = new MemoryStream())
            using (var streamReader = new StreamReader(memoryStream))
            {
                new DataContractSerializer(instance.GetType()).WriteObject(memoryStream, instance);

                //new XmlSerializer(instance.GetType()).Serialize(memoryStream, instance);

                memoryStream.Position = 0;

                return streamReader.ReadToEnd();
            }
        }

        public static T DeserializeFromXml<T>(this string xml)
        {
            using (var stringReader = new StringReader(xml))
            using (var xmlTextReader = new XmlTextReader(stringReader))
            {
                return (T)new XmlSerializer(typeof(T)).Deserialize(xmlTextReader);
            }
        }
    }
}

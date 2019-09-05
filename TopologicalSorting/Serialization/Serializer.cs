using System.IO;
using System.Xml.Serialization;

namespace Serialization
{
    public class Serializer
    {
        public static T DeserializeFromXml<T>(string Path) where T : new()
        {
            T Result = default(T);
            using (var iReader = new StreamReader(Path))
            {
                var DeSerializer = new XmlSerializer(typeof(T));
                Result = (T)DeSerializer.Deserialize(iReader);
            }
            return Result;
        }

        public static void SerializeToXml<T>(string Path, T iObj)
        {
            using (var iWriter = new StreamWriter(Path))
            {
                var Serializer = new XmlSerializer(typeof(T));
                Serializer.Serialize(iWriter, iObj);
            }
        }
    }
}

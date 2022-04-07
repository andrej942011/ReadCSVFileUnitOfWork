using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReadCSVFileADO.Common
{
    public class XMLConfig
    {
        String fileName;

        public XMLConfig(string fileName)
        {
            this.fileName = fileName + ".xml";
        }

        public T ReadFile<T>()
        {
            using(FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                TextReader textReader = new StreamReader(fs);

                var res = (T)serializer.Deserialize(textReader);
                return res;
            }
        }

        public void WriteFile<T>(T type)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            using (FileStream fs = new FileStream(fileName, FileMode.Create)) //FileMode.OpenOrCreate
            {
                xmlSerializer.Serialize(fs, type);
            }
        }
    }
}

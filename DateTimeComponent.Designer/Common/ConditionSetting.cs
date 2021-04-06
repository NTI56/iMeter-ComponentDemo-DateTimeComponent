using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace DateTimeComponent.Common
{
    [Serializable]
    public class ConditionSetting
    {
        public bool[] Allow; //Length = 60



        public static ConditionSetting FromXml(XmlDocument setting)
        {
            using (XmlReader reader = new XmlNodeReader(setting))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ConditionSetting));
                return (ConditionSetting)xmlSerializer.Deserialize(reader);
            }
        }
        public static XmlDocument GetDefault()
        {
            var tmp = new ConditionSetting() { Allow = new bool[60] };
            return tmp.ToXml();
        }

        public XmlDocument ToXml()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ConditionSetting));
            XmlDocument document = new XmlDocument();
            XPathNavigator nav = document.CreateNavigator();
            using (XmlWriter writer = nav.AppendChild())
            {
                xmlSerializer.Serialize(writer, this);
                writer.Flush();
            }
            return document;
        }
    }
}

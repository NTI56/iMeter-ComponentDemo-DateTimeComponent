using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace DateTimeComponent.Common
{
	[Serializable]
	public class ProcessorAddTimeSetting
	{
		public int Seconds { get; set; }

		public static ProcessorAddTimeSetting FromXml(XmlDocument setting)
		{
			using (XmlReader reader = new XmlNodeReader(setting))
			{
				XmlSerializer xmlSerializer = new XmlSerializer(typeof(ProcessorAddTimeSetting));
				return (ProcessorAddTimeSetting)xmlSerializer.Deserialize(reader);
			}
		}

		public static XmlDocument GetDefault()
		{
			var tmp = new ProcessorAddTimeSetting() { Seconds = 5 };
			return tmp.ToXml();
		}

		public XmlDocument ToXml()
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(ProcessorAddTimeSetting));
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

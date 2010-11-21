using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Serialization;

namespace TunngleSharp
{
    public class TunngleWebClient
    {
        private static string xmlApi = "http://www.tunngle.net/api/export.xml";
        public DateTime LastQuery { get; private set; }
        public Export Export { get; private set; }
        private TimeSpan RefreshTime = TimeSpan.FromMinutes(5);

        public TunngleWebClient()
        {
        }

        public void Refresh()
        {
            if ((DateTime.Now - LastQuery) > RefreshTime)
            {
                HttpWebRequest req = HttpWebRequest.Create(xmlApi) as HttpWebRequest;
                XmlSerializer ser = new XmlSerializer(typeof(Export));
                Export = ser.Deserialize(req.GetResponse().GetResponseStream()) as Export;
                LastQuery = DateTime.Now;
            }
        }
    }
}

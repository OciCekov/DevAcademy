namespace ParseJsonInDotNet
{
    using System;
    using System.Net;
    using System.Xml.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Execution
    {
        private const string XmlUrlPath = @"http://forums.academy.telerik.com/feed/qa.rss ";
        private const string XmlFilePath = @"../../rss.xml";

        private static void Main()
        {
            var rssFeed = new WebClient();
            rssFeed.DownloadFile(XmlUrlPath, XmlFilePath);

            var rssAsXml = XElement.Load(XmlFilePath);

            var rssAsJson = JsonConvert.SerializeXNode(rssAsXml, Formatting.Indented);

            var rssAsObject = JObject.Parse(rssAsJson);

            foreach (var title in rssAsObject["rss"]["channel"]["item"])
            {
                //  Console.WriteLine(title["title"]);
            }

            var itemsJson = rssAsObject["rss"]["channel"]["item"].ToString();
            var items = JsonConvert.DeserializeObject<Item[]>(itemsJson);

            foreach (var item in items)
            {
                Console.WriteLine(item.Title);
            }
        }

    }

   
}
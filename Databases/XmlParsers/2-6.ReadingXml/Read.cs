namespace ExtractArtists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    public class ExtractArtists
    {
        private static void Main()
        {
            string xmlPath = @"..\..\..\MusicAlbumsCatalogue.xml";

            XmlDocument catalogDoc = new XmlDocument();
            catalogDoc.Load(xmlPath);

            PrintAuthorsAndNumberOfAlbums(catalogDoc);

            PrintAuhorsAndNumberOfAlbumsXPath(catalogDoc);

            RemoveAlbumsWithPriceHigherThan(20, catalogDoc);

            PrintsAllSongsTitles(xmlPath);

            PrintsAllSongTitlesLINQ(xmlPath);
        }

        private static void PrintsAllSongTitlesLINQ(string xmlPath)
        {
            XDocument catalogDocX = XDocument.Load(xmlPath);
            var songTitles = catalogDocX.Descendants("title").Select(t => t.Value);

            foreach (var songtitle in songTitles)
            {
                Console.WriteLine("Song -> " + songtitle);
            }
        }

        private static void PrintsAllSongsTitles(string xmlPath)
        {
            using (XmlReader reader = XmlReader.Create(xmlPath))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "title"))
                    {
                        Console.WriteLine("Song -> " + reader.ReadElementString());
                    }
                }
            }
            Console.WriteLine();
        }

        private static void RemoveAlbumsWithPriceHigherThan(decimal priceMax, XmlDocument catalogDoc)
        {
            var nodesToRemove = new List<XmlNode>();
            foreach (XmlNode node in catalogDoc.DocumentElement)
            {
                decimal price = decimal.Parse(node["price"].InnerText);
                if (price > priceMax)
                {
                    nodesToRemove.Add(node);
                }
            }

            foreach (var node in nodesToRemove)
            {
                catalogDoc.DocumentElement.RemoveChild(node);
            }

            Console.WriteLine("Modified XML document.");
            Console.WriteLine();
            catalogDoc.Save(@"..\..\..\catalogDeletedAlbums.xml");
        }

        private static void PrintAuhorsAndNumberOfAlbumsXPath(XmlDocument catalogDoc)
        {
            string xPathQuery = "catalog/album/artist";

            XmlNodeList artistNames = catalogDoc.SelectNodes(xPathQuery);
            var result = artistNames.OfType<XmlElement>()
                .GroupBy(e => e.InnerText)
                .ToDictionary(gr => gr.Key, gr => gr.Count());

            PrintDictionaryArtistsAndNumberOfAlbums(result);
            Console.WriteLine();
        }

        private static void PrintAuthorsAndNumberOfAlbums(XmlDocument catalogDoc)
        {
            XmlNode rootNode = catalogDoc.DocumentElement;
            var artistsNumberAlbums = new Dictionary<string, int>();

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                string artist = node["artist"].InnerText;
                if (!artistsNumberAlbums.ContainsKey(artist))
                {
                    artistsNumberAlbums[artist] = 0;
                }
                artistsNumberAlbums[artist]++;
            }

            PrintDictionaryArtistsAndNumberOfAlbums(artistsNumberAlbums);
            Console.WriteLine();
        }

        private static void PrintDictionaryArtistsAndNumberOfAlbums(
            IEnumerable<KeyValuePair<string, int>> artistsNumberAlbums)
        {
            foreach (var artist in artistsNumberAlbums)
            {
                Console.WriteLine("{0} -> {1} {2}", artist.Key, artist.Value, artist.Value == 1 ? "album" : "albums");
            }
        }
    }
}
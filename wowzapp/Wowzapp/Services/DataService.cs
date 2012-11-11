using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Windows.Data.Json;
using Windows.Networking;
using Windows.Storage;
using App2.DataModel;

namespace App2.Services
{
    class DataService
    {

        public void GetRedditSectionItems(string url, Action<RedditSection, Exception> callback)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(url);
                RedditSection redditSection =
                (
                    from stats in xmlDoc.Descendants("channel")
                    select new RedditSection
                    {
                        Title = stats.Element("title").Value,
                        Link = stats.Element("link").Value,
                        Description = stats.Element("link").Value,
                        //SecImage = (from player in xmlDoc.Descendants("image")
                        //            select new SectionImage
                        //            {

                        //            }),
                        Items = (from item in xmlDoc.Descendants("item")
                                   select new Item
                                   {
                                       Title = item.Element("title").Value,
                                       Link = item.Element("link").Value,
                                       GUID = item.Element("guid").Value,
                                       PubDate = item.Element("pubDate").Value,
                                       Description = item.Element("description").Value,
                                       MediaTitle = item.Element("media:title").Value,
                                       MediaImage = item.Element("media:image").Value,
                                   }).ToList<Item>()
                    }
                ).First();

                callback(redditSection, null);
            }
            catch (Exception e)
            {
                callback(null, e);
            }
        }

    }
}

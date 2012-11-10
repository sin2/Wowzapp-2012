using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.DataModel
{
    public class RedditSection
    {
        public string RSS;
        public string Title;
        public string Link;
        public string Description;
        public SectionImage SecImage;
        public List<Item> Items;

    }
    public class SectionImage
    {
        public string URL;
        public string Title;
        public string Link;
    }

    public class Item
    {
        public string Title;
        public string Link;
        public string GUID;
        public string PubDate;
        public string Description;
        public string MediaTitle;
        public string MediaImage;
    }
}

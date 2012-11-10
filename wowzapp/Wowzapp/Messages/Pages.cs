using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wowzapp.Messages
{
    public static class Pages
    {
        public static Type HOME_PAGE
        {
            get 
            {
                return typeof(Wowzapp.Views.HomePage.HomePage);
            }
        }
    }
}

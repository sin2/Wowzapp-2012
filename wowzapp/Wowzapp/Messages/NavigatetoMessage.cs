using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wowzapp.Messages
{
    class NavigatetoMessage
    {
        public Type PageType { get; set; }
        public object Parameter { get; set; }

        public void NavigateToMessage(Type pageType, object parameter)
        {
            PageType = pageType;
            Parameter = parameter;
        }
    }
}

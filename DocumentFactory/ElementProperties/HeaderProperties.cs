using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.ElementProperties
{
    public class HeaderProperties : IElementProperties
    {
        public string level { get; set; }
        public string title { get; set; }

    }
}

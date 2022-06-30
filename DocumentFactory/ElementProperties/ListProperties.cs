using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.ElementProperties
{
    public class ListProperties : IElementProperties
    {
        public string listType { get; set; }
        public List<string> items { get; set; }

    }
}

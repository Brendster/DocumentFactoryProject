using DocumentFactory.ElementProperties;
using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Html
{
    internal class HtmlList : IElement
    {
        ListProperties props;

        public HtmlList(ListProperties props)
        {
            this.props = props;
        }

        public override string ToString()
        {
            string output = "";

            switch (props.listType)
            {
                case "Unordered":
                    foreach(string items in props.items)
                    {
                        output += $"<li>{items}</li>";
                    }
                    return $"<ul>{output}</ul>";
                default:
                    foreach (string items in props.items)
                    {
                        output += $"<li>{items}</li>";
                    }
                    return $"<ol>{output}</ol>";
            }
        }
    }
}

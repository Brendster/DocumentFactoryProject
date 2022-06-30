using DocumentFactory.ElementProperties;
using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Markdown
{
    internal class MarkdownList : IElement
    {
        ListProperties props;

        public MarkdownList(ListProperties props)
        {
            this.props = props;
        }

        public override string ToString()
        {
            string output = "";

            switch (props.listType)
            {
                case "Unordered":
                    foreach (string items in props.items)
                    {
                        output += $"- {items}\n";
                    }
                    return $"{output}";
                default:
                    int index = 1;
                    foreach (string items in props.items)
                    {
                        output += $"{index}. {items}\n";
                        ++index;
                    }
                    return $"{output}";
            }
        }
    }
}

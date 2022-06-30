using DocumentFactory.ElementProperties;
using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Markdown
{
    internal class MarkdownHeader : IElement
    {
        HeaderProperties props;

        public MarkdownHeader(HeaderProperties props)
        {
            this.props = props;
        }

        public override string ToString()
        {
            switch (props.level)
            {
                case "1":
                    return $"# { props.title }";
                case "2":
                    return $"## { props.title }";
                case "3":
                    return $"### { props.title }";
                case "4":
                    return $"#### { props.title }";
            }
            return null;
        }
    }
}

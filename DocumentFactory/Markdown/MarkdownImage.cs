using DocumentFactory.ElementProperties;
using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Markdown
{
    internal class MarkdownImage : IElement
    {
        ImageProperties props;

        public MarkdownImage(ImageProperties props)
        {
            this.props = props;
        }

        public override string ToString()
        {
            return $"![{props.altText}]({props.url} \"{ props.title}\" )";
        }
    }
}

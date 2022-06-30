using DocumentFactory.ElementProperties;
using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Html
{
    internal class HtmlImage : IElement
    {
        ImageProperties props;

        public HtmlImage(ImageProperties props)
        {
            this.props = props;
        }

        public override string ToString()
        {
            return $"<img src='{props.url}' alt='{props.altText}' title='{props.title}'/>";
        }
    }
}

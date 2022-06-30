using DocumentFactory.ElementProperties;
using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Html
{
    internal class HtmlHeader : IElement
    {
        HeaderProperties props;

        public HtmlHeader(HeaderProperties props)
        {
            this.props = props;
        }

        public override string ToString()
        {
            switch (props.level)
            {
                case "1":
                    return $"<h1> { props.title } </h1>";
                case "2":
                    return $"<h2> { props.title } </h2>";
                case "3":
                    return $"<h3> { props.title } </h3>";
                case "4":
                    return $"<h4> { props.title } </h4>";
            }
            return "test";
        }

    }
}

using DocumentFactory.ElementProperties;
using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//File: HtmlDocumentFactory.cs
//Name: Brenden Abbott 
//Course: INFO3137
//Date: 2022-06-12

namespace DocumentFactory.Html
{
    public class HtmlDocumentFactory : IDocumentFactory
    {
        protected static HtmlDocumentFactory instance;

        public static HtmlDocumentFactory Instance()
        {
            if (instance == null)
            {
                instance = new HtmlDocumentFactory();
            }
            return instance;
        }

        protected HtmlDocumentFactory()
        {

        }

        public IDocument CreateDocument(string fileName)
        {
            return new HtmlDocument(fileName);
        }

        public IElement CreateElement(string elementType, string props)
        {
            switch(elementType)
            {
                case "Image":
                    return CreateImage(props);
                case "Header":
                    return CreateHeader(props);
                case "List":
                    return CreateList(props);
                case "Table":
                    return CreateTable(props);

            }


            return null;
        }

        protected IElement CreateImage(string props)
        {
            var properties = props.Split(';');
            var imgProps = new ImageProperties
            {
                url = properties[0],
                altText = properties[1],
                title = properties[2],
            };

            return new HtmlImage(imgProps);
        }

        protected IElement CreateHeader(string props)
        {
            var properties = props.Split(';');
            var headerProps = new HeaderProperties
            {
                level = properties[0],
                title = properties[1],
            };

            return new HtmlHeader(headerProps);
        }

        protected IElement CreateList(string props)
        {
            var properties = props.Split(';');
            List<string> itemHelp = new List<string>();
            
            for (int i = 1; i < properties.Length; i++)
            {
                itemHelp.Add(properties[i]);
            }

            var listProps = new ListProperties
            {
                listType = properties[0],
                items = itemHelp,
            };

            return new HtmlList(listProps);
        }

        protected IElement CreateTable(string props)
        {
            var properties = props.Split(';');
            List<string> rowHelp = new List<string>();

            for (int i = 0; i < properties.Length; i++)
            {
                rowHelp.Add(properties[i]);
            }

            var tableProps = new TableProperties
            {
                rows = rowHelp,
            };

            return new HtmlTable(tableProps);
        }
    }
}

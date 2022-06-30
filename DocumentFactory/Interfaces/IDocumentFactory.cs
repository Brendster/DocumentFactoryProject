using System;
using System.Collections.Generic;
using System.Text;

//File: IDocumentFactory.cs
//Name: Brenden Abbott 
//Course: INFO3137
//Date: 2022-06-12

namespace DocumentFactory.Interfaces
{
    public interface IDocumentFactory
    {
        IDocument CreateDocument(string fileName);
        IElement CreateElement(string elementType, string props);
    }
}

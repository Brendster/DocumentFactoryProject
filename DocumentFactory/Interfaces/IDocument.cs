//File: IDocument.cs
//Name: Brenden Abbott 
//Course: INFO3137
//Date: 2022-06-12

namespace DocumentFactory.Interfaces
{
    public interface IDocument
    {
        void AddElement(IElement element);
        void RunDocument();

    }
}
using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Markdown
{
    public class MarkdownDocument : IDocument
    {
        List<IElement> elements = new List<IElement>();
        string filename;

        public MarkdownDocument(string filename)
        {
            this.filename = filename;
        }

        public void AddElement(IElement element)
        {
            elements.Add(element);
        }
        public void RunDocument()
        {
            string output = "";


            foreach (var element in elements)
            {
                output += element.ToString() + "\n";
            }

            File.WriteAllText(filename, output);

            System.Diagnostics.Process.Start("chrome.exe", System.IO.Path.GetFullPath(filename));

        }

    }
}

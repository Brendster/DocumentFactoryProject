using DocumentFactory.Html;
using DocumentFactory.Interfaces;
using DocumentFactory.Markdown;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//File: Program.cs
//Name: Brenden Abbott 
//Course: INFO3137
//Date: 2022-06-12

namespace Director
{
    class Program
    {
        static IDocument document;
        static IDocumentFactory documentFactory = null;
        static void CreateDocument(string[] commands)
        {
            
            switch(commands[0])
            {
                case "Markdown":
                    documentFactory = MarkdownDocumentFactory.Instance();
                    break;
                case "Html":
                    documentFactory = HtmlDocumentFactory.Instance();
                    break;

            }

            document = documentFactory.CreateDocument(commands[1]);
        }

        static void Main(string[] args)
        {
            string[] commands;
            var list = File.ReadAllText("CreateDocumentScript.txt");
            commands = list.Split('#');

            foreach (var command in commands)
            {
                var strippedCommand = Regex.Replace(command, @"\t|\n|\r", "");
                var commandList = strippedCommand.Split(':');
                switch (commandList[0])
                {
                    case "Document":
                        //Your document creation code goes here
                        CreateDocument(commandList[1].Split(';'));
                        break;
                    case "Element":
                        // Your element creation code goes here
                        document.AddElement(documentFactory.CreateElement(commandList[1], commandList[2]));
                        break;
                    case "Run":
                        // Your document running code goes here
                        document.RunDocument();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

using DocumentFactory.ElementProperties;
using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Markdown
{
    internal class MarkdownTable : IElement
    {
        TableProperties props;

        public MarkdownTable(TableProperties props)
        {
            this.props = props;
        }

        public override string ToString()
        {

            string output = "";

            for (int i = 0; i < props.rows.Count; i++)
            {
                var rowData = props.rows[i].Split('$');

                switch (rowData[0])
                {
                    case "Head":
                        for (int j = 1; j < rowData.Length; j++)
                        {
                            output += $"| { rowData[j]} ";
                        }
                        output += "|";
                        output += "\n| --- | --- | --- ";
                        break;
                    case "Row":
                        for (int j = 1; j < rowData.Length; j++)
                        {
                            output += $"| { rowData[j]} ";
                        }
                        break;
                }
                output += "|\n";
            }
            return output;
        }
    }
}

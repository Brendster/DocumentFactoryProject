using DocumentFactory.ElementProperties;
using DocumentFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Html
{
    internal class HtmlTable : IElement
    {
        TableProperties props;

        public HtmlTable(TableProperties props)
        {
            this.props = props;
        }

        public override string ToString()
        {
            
            string output = "<table>";

            for (int i = 0; i < props.rows.Count; i++)
            {
                output += "<tr>";
                var rowData = props.rows[i].Split('$');

                switch (rowData[0])
                {
                    case "Head":
                        for (int j = 1; j < rowData.Length; j++)
                        {
                            output += $"<th> { rowData[j]} </th>";
                        }
                        break;
                    case "Row":
                        for (int j = 1; j < rowData.Length; j++)
                        {
                            output += $"<td> { rowData[j]} </td>";
                        }
                        break;
                }

                output += "</tr>";

            }
            return output + "</table";
        }
    }
}

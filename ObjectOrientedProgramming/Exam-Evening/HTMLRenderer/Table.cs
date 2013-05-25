using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderer
{
    class HTMLTable : HTMLElement, ITable
    {
        public int Rows { get; private set; }
        public int Cols { get; private set; }
        private IElement[,] tableElements;

        public HTMLTable(int rows, int cols)
            : base("table")
        {
            if (rows <= 0)
            {
                throw new ArgumentOutOfRangeException("rows", 0, "Positive number required.");
            }
            if (cols <= 0)
            {
                throw new ArgumentOutOfRangeException("cols", 0, "Positive number required.");
            }
            this.Rows = rows;
            this.Cols = cols;
            this.tableElements = new IElement[rows, cols];
        }

        public override string TextContent
        {
            get
            {
                return null;
            }
            set
            {
                throw new InvalidOperationException("Tables cannot have text content");
            }
        }

        public virtual IElement this[int row, int col]
        {
            get
            {
                return this.tableElements[row, col];
            }

            set
            {
                this.tableElements[row, col] = value;
            }
        }

        public override void Render(StringBuilder output)
        {
            output.Append("<table>");
            for (int row = 0; row < this.Rows; row++)
            {
                output.Append("<tr>");
                for (int col = 0; col < this.Cols; col++)
                {
                    output.Append("<td>");
                    this.tableElements[row, col].Render(output);
                    output.Append("</td>");
                }
                output.Append("</tr>");
            }
            output.Append("</table>");
        }
    }
}

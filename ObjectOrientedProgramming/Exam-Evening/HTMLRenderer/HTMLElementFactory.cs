using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLRenderer
{
    public class HTMLElementFactory : IElementFactory
    {
		public IElement CreateElement(string name)
		{
			return new HTMLElement(name);
		}

		public IElement CreateElement(string name, string textContent)
		{
			return new HTMLElement(name, textContent);
		}

		public ITable CreateTable(int rows, int cols)
		{
 			return new HTMLTable(rows, cols);
		}
	}
}

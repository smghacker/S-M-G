using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderer
{
    class HTMLElement : IElement
    {
        public virtual string Name { get; private set; }
        public virtual string TextContent { get; set; }
        private IList<IElement> childElements;

        public HTMLElement(string name)
        {
            this.Name = name;
            this.childElements = new List<IElement>();
        }

        public HTMLElement(string name, string content)
            : this(name)
        {
            this.TextContent = content;
        }

        public virtual IEnumerable<IElement> ChildElements
        {
            get
            {
                return this.childElements;
            }
        }

        public virtual void AddElement(IElement element)
        {
            this.childElements.Add(element);
        }

        public virtual void Render(StringBuilder output)
        {
            if (this.Name != null)
            {
                output.Append("<");
                output.Append(this.Name);
                output.Append(">");
            }
            if (this.TextContent != null)
            {
                output.Append(HTMLEncode(this.TextContent));
            }
            foreach (var childElement in this.childElements)
            {
                childElement.Render(output);
            }
            if (this.Name != null)
            {
                output.Append("</");
                output.Append(this.Name);
                output.Append(">");
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            this.Render(result);
            return result.ToString();
        }

        protected string HTMLEncode(string text)
        {
            StringBuilder result = new StringBuilder();
            foreach (var ch in text)
            {
                if (ch == '<')
                {
                    result.Append("&lt;");
                }
                else if (ch == '>')
                {
                    result.Append("&gt;");
                }
                else if (ch == '&')
                {
                    result.Append("&amp;");
                }
                else
                {
                    result.Append(ch);
                }
            }
            return result.ToString();
        }
    }
}

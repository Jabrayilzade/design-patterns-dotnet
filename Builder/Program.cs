using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using static System.Console;

namespace Builder
{
    public class HtmlElement
    {
        public string Name;
        public string Text;
        public List<HtmlElement> Elements = new List<HtmlElement>();
        private const int IndentSize = 2;

        public HtmlElement()
        {
        }

        public HtmlElement(string name, string text)
        {
            Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            Text = text ?? throw new ArgumentNullException(paramName: nameof(text));
        }

        private string ToStringImpl(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', IndentSize * indent);

            sb.AppendLine($"{i}<{Name}>");

            if (!string.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new string(' ', IndentSize * (indent + 1)));
                sb.AppendLine(Text);
            }

            foreach (var el in Elements)
            {
                sb.Append(el.ToStringImpl(indent + 1));
            }

            return sb.AppendLine($"{i}</{Name}>").ToString();
        }

        public override string ToString()
        {
            return ToStringImpl(0);
        }
    }

    public class HtmlBuilder
    {
        private HtmlElement _root = new HtmlElement();
        private readonly string _rootName;

        public HtmlBuilder(string rootName)
        {
            this._rootName = rootName;
            _root.Name = rootName;
        }

        public HtmlBuilder AddChild(string name, string text)
        {
            var e = new HtmlElement(name, text);
            _root.Elements.Add(e);
            return this;
        }

        public override string ToString()
        {
            return _root.ToString();
        }

        public void Clear()
        {
            _root = new HtmlElement { Name = _rootName };
        }
    }

    internal static class Program
    {
        private static void Main(string[] args)
        {
            var builder = new HtmlBuilder("ul");

            builder.AddChild("li", "hello")
                .AddChild("li", "hello")
                .AddChild("li", "hello");

            WriteLine(builder.ToString());
        }
    }
}
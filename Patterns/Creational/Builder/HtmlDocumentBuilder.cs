namespace Builder
{
    public class HtmlDocumentBuilder   : IHtmlDocumentBuilder
    {
        private HtmlDocument _document;

        public HtmlDocumentBuilder()
        {
            _document = new HtmlDocument();
        }


        public HtmlDocumentBuilder SetTitle(string title)
        {
            _document.Title = title;

            return this;
        }

        public HtmlDocumentBuilder SetHead(string head)
        {
            _document.Head = head;

            return this;
        }

        public HtmlDocumentBuilder SetBody(string body)
        {
            _document.Body = body;

            return this;
        }

        public HtmlDocumentBuilder SetFooter(string footer)
        {
            _document.Footer = footer;

            return this;
        }

        public HtmlDocument Build()
        {
            return _document;
        }
    }

    public interface IHtmlDocumentBuilder
    {
        HtmlDocumentBuilder SetTitle(string title);

        HtmlDocumentBuilder SetHead(string head);

        HtmlDocumentBuilder SetBody(string body);

        HtmlDocumentBuilder SetFooter(string footer);

        HtmlDocument Build();
    }
}                                           
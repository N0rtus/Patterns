namespace Builder
{
    public class HtmlDocument
    {
     
        public string Title { get; set; }

        public string Head { get; set; }

        public string Body { get; set; }            

        public string Footer { get; set; }

        public override string ToString()
        {
            return $" {Title} \n {Head} \n {Body} \n {Footer}";
        }
    }
}
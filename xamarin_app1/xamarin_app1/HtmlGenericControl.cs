namespace xamarin_app1
{
    internal class HtmlGenericControl
    {
        private string v;

        public HtmlGenericControl(string v)
        {
            this.v = v;
        }

        public string InnerHtml { get; set; }
    }
}
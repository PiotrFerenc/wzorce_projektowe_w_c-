namespace Prototyp
{
    public class SheetOfPaper : IPage
    {
        public SheetOfPaper(string content)
        {
            Content = content;
        }

        public IPage Clone() => new SheetOfPaper(Content);
        

        public string Content { get; set; }
    }
}
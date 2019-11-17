using Telegram.Bot.Types;

namespace PrChloe_.Models.Components
{
    public class Article
    {
        public int ArticleId { get; set; }
        public Audio Content { get; set; }
        public string Discription { get; set; }
        public int ThumbUps { get; set; }
    }
}
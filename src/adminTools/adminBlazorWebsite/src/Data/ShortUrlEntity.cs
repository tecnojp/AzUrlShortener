using System.Linq;

namespace  adminBlazorWebsite.Data
{
    public class ShortUrlEntity
    {
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }

        public string Url { get; set; }

        public int Clicks { get; set; }

        public ShortUrlEntity(){}

        public static ShortUrlEntity GetEntity(string longUrl, string endUrl){
            return new ShortUrlEntity
            {
                PartitionKey = endUrl.First().ToString(),
                RowKey = endUrl,
                Url = longUrl
            };
        }
    }


}

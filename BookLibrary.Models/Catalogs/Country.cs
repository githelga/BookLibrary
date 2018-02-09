using BookLibrary.Models.Common;

namespace BookLibrary.Models.Catalogs
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }
        public string IsoCodeA2 { get; set; }
        public string IsoCodeA3 { get; set; }
    }
}

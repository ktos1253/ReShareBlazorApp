namespace ReShareBlazorApp.Web.Models
{
    public class ListingModel
    {
        public ListingType Type { get; set; } = ListingType.Odsprzedam;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public decimal? Price { get; set; }
        public bool AcceptTerms { get; set; }
    }

    public enum ListingType
    {
        Odsprzedam,
        Oddam,
        Wypozycze,
        WolneMiejsce,
        Szukam
    }
}

namespace AppOverview.Models
{
    public class AppModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public FaqItem[] FaqItems { get; set; }
        public string PortalUrl { get; set; }
        public string MoreInfoUrl { get; set; }
        public string FaqUrl { get; set; }
        public string ImageUrl { get; set; }
        public string BackgroundUrl { get; set; }
        public string IconUrl { get; set; }
        public string NewsUrl { get; set; }
        public string KbUrl { get; set; }
    }
}

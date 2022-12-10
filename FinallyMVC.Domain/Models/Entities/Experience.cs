namespace FinallyMVC.Domain.Models.Entities
{
    public class Experience : Background
    {
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        
        public string Title { get; set; }
        
        public string CompanyName { get; set; }
        
        public string Location { get; set; }
    
        public string Details { get; set; }
        public string ImagePath { get; set; }
        public string ImageUrl { get; set; }
    }
}

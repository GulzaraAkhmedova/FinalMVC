using FinallyMVC.Domain.AppCode.Infrastructure;

namespace FinallyMVC.Domain.Models.Entities
{
    public class Contact : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string ImageURL { get; set; }
        public string Phone { get; set; }
        public string Body { get; set; }
    }
}

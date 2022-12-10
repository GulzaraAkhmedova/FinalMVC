using FinallyMVC.Domain.AppCode.Infrastructure;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinallyMVC.Domain.Models.Entities
{
    public class Portfolio : BaseEntity
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public string ImagePath { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        

    }
}

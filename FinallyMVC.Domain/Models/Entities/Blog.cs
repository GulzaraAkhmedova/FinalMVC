using FinallyMVC.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Models.Entities
{
    public class Blog : BaseEntity
    {   
        public string Title { get; set; }
        public string Body { get; set; }
        public string ImagePath { get; set; }
        [NotMapped]
        public string Image { get; set; }
        public string Slug { get; set; }
        public virtual ICollection<BlogPostComment> Comments { get; set; }
        public DateTime? PublishDate { get; set; }
        public int Size { get; set; }
        public string ImageUrl { get; internal set; }
    }
}

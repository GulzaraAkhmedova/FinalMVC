using FinallyMVC.Domain.AppCode.Infrastructure;
using FinallyMVC.Domain.Models.Entities.Membership;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinallyMVC.Domain.Models.Entities
{
    public class BlogPostComment : BaseEntity
    {
        public int? CreatedByUserId { get; set; }
        [ForeignKey("CreatedByUserId")]
        public virtual FinallymvcUser CreatedByUser { get; set; }
        public string Text { get; set; }
        public int BlogPostId { get; set; }
        public virtual Blog Blog { get; set; }
        public int? ParentId { get; set; }
        public virtual BlogPostComment Parent { get; set; }
        public virtual ICollection<BlogPostComment> Comments { get; set; }
        public bool Approved { get; set; }
    }
}

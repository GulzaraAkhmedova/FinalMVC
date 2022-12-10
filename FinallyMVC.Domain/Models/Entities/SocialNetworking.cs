using FinallyMVC.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Models.Entities
{
    public class SocialNetworking : BaseEntity
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
        public string FacebookLink { get; set; }
        public string TwitterLink { get; set; }
        public string LinkedinLink { get; set; }
        public string GitHubLink { get; set; }
        public string YoutubeLink { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}

using FinallyMVC.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyMVC.Domain.Models.Entities
{
    public class Background : BaseEntity
    {
        public string Date { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public string Place { get; set; }
        public string Body { get; set; }
        public string Profession { get; set; }
        public string Degree { get; set; }
        public int YearObtention { get; set; }
        public string Details { get; set; }
        public string ImagePath { get; set; }
    }
}

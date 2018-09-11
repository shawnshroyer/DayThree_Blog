using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DayThree_Blog.Models
{
    public class Comment
    {
        public int Id { get; set; } //PK
        public int BlogPostId { get; set; } //FK
        public string AuthorId { get; set; } //FK
        public string Body { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Updated { get; set; }
        public string UpdateReason { get; set; }

        public virtual ApplicationUser Author { get; set; }
        public virtual BlogPost BlogPost { get; set; }


        //public string MediaUrl { get; set; }
        //public bool Published { get; set; }

        public Comment()
        {

        }
    }
}
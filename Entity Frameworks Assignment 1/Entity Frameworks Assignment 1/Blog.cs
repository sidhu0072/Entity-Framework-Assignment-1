using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Frameworks_Assignment_1
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public bool IsPublic { get; set; }
        public int BlogTypeId { get; set; }

        // Navigation property
        public BlogType BlogType { get; set; }
        public ICollection<Post> Posts { get; set; }
    }

}

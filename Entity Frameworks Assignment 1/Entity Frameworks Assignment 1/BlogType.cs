using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Frameworks_Assignment_1
{
    public class BlogType
    {
        public int BlogTypeId { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation property
        public ICollection<Blog> Blogs { get; set; }
    }
}

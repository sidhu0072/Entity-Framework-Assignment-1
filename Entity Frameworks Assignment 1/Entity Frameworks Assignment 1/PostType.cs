using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Frameworks_Assignment_1
{
    public class PostType
    {
        public int PostTypeId { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation property
        public ICollection<Post> Posts { get; set; }
    }
}

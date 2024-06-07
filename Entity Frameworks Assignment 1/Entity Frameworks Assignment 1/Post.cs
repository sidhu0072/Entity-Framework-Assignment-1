﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Frameworks_Assignment_1
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        public int PostTypeId { get; set; }
        public int UserId { get; set; }

        // Navigation properties
        public Blog Blog { get; set; }
        public PostType PostType { get; set; }
        public User User { get; set; }
    }


}

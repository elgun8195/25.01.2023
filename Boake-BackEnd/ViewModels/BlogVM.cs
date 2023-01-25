using Boake_BackEnd.Models;
using System.Collections.Generic;

namespace Boake_BackEnd.ViewModels
{
    public class BlogVM
    {
        public List<Blog> Blogs { get; set; }
        public List<Blog> BlogsForTag { get; set; }
        public Blog Blog { get; set; }

    }
}

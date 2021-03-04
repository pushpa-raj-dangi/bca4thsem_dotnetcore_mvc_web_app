using NewsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsWebApp.ViewModels
{
    public class PostByCategory
    {
        public IEnumerable<Post> Posts { get; set; }
    }
}

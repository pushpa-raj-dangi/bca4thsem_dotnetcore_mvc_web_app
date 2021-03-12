
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace NewsWebApp.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="Post Title")]
        public string Name { get; set; }
        public string Slug { get; set; }
        [AllowHtml]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
        public string Picture { get; set; }
        public AppUser AppUser { get; set; }

        public PostStatus PostStatus { get; set; }
        [Required]
        public IEnumerable<Category> Categories { get; set; }

        [Required]
        public IEnumerable<Tag> Tags { get; set; }
        public virtual ICollection<PostTag> PostTags { get; set; }
        public virtual ICollection<PostCategory> PostCategories { get; set; }

        [Display(Name="Created Date")]
        public DateTime CreatedDate { get; set; }


        public Post()
        {
            PostTags = new Collection<PostTag>();
            PostCategories = new Collection<PostCategory>();
            CreatedDate = DateTime.UtcNow;

        }

    }
}

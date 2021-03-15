using NewsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewsWebApp.ViewModels
{
    public class PostDetailViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Post Title")]
        [Required]
        public string Name { get; set; }
        public string Slug { get; set; }
        
        public string Content { get; set; }
        public PostStatus PostStatus { get; set; }

        public IEnumerable<Category> Categories { get; set; }
        public List<int> SelectedCategory { get; set; }
        public List<int> SelectedTag { get; set; }

        public AppUser AppUser { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
        
        public virtual ICollection<PostTag> PostTags { get; set; }
        public virtual ICollection<PostCategory> PostCategories { get; set; }

        public ICollection<Post> Posts { get; set; }
        public Post Post { get; set; }
        public string UserId { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public string Comment { get; set; }
        public PostDetailViewModel()
        {
            Comments = new Collection<Comment>();
            PostTags = new Collection<PostTag>();
            PostCategories = new Collection<PostCategory>();
        }
    }
}

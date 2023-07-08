using BlogMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogMVC.Infrastructure.Repositories
{
    public class PostRepository
    {
        private readonly Context _context;

        public PostRepository(Context context)
        {
            _context = context;
        }

        public void DeletePost(int postId)
        {
            var post = _context.Posts.Find(postId);
            if (post != null)
            {
                _context.Posts.Remove(post);
                _context.SaveChanges();
            }
        }

        public int AddPost(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
            return post.Id;
        }

        public Post GetPostById(int postId)
        {
            var post = _context.Posts.FirstOrDefault(p => p.Id == postId);
            return post;
        }
        public IQueryable<Post> GetPostsByCategoryId(int categoryId)
        {
            var posts = _context.Posts.Where(p => p.CategoryId == categoryId);
            return posts;
        }

        public IQueryable<Tag> GetAllTags()
        {
            var tags = _context.Tags;
            return tags;
        }

        public IQueryable<Category> GetAllCategories()

        {
            var categories = _context.Categories;
            return categories;
        }
    }
}

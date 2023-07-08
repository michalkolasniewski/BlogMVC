using BlogMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogMVC.Domain.Interface
{
    public interface IPostRepository
    {
        public void DeletePost(int postId);
        int AddPost(Post post);
        IQueryable<Post> GetPostsByCategoryId(int categoryId);
        Post GetItemById(int postId);
        IQueryable<Tag> GetAllTags();
        IQueryable<Category> GetAllCategories();
    }
}

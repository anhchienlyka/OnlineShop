using OnlineShop.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Mode.Models;
namespace OnlineShop.Data.Repositories
{
    public interface IPostCategoryRepository : IRepository<PostCategorie>
    {
    }

    public class PostCategoryRepository : RepositoryBase<PostCategorie>, IPostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}

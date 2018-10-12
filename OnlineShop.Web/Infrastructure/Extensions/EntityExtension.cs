using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineShop.Mode.Models;
using OnlineShop.Web.Models;
namespace OnlineShop.Web.Infrastructure.Extensions
{
    public static class EntityExtension
    {
        public static void UpdatePostCategory(this PostCategorie postCategory, PostCategoryViewModel postCategoryVm)
        {
            postCategory.ID = postCategoryVm.ID;
            postCategory.Name = postCategoryVm.Name;
            postCategory.Description = postCategoryVm.Description;
            postCategory.Alias = postCategoryVm.Alias;
            postCategory.PrentID = postCategoryVm.PrentID;
            postCategory.DisplayOrder = postCategoryVm.DisplayOrder;
            postCategory.Image = postCategoryVm.Image;
            postCategory.HomeFlag = postCategoryVm.HomeFlag;

            postCategory.CreateDate = postCategoryVm.CreatedDate;
            postCategory.CreateBy = postCategoryVm.CreatedBy;
            postCategory.UpdateDate = postCategoryVm.UpdatedDate;
            postCategory.UpdateBy = postCategoryVm.UpdatedBy;
            postCategory.MetaKeyword = postCategoryVm.MetaKeyword;
            postCategory.MetaDescription = postCategoryVm.MetaDescription;
            postCategory.Status = postCategoryVm.Status;

        }
        public static void UpdatePost(this Post post, PostViewModel postVm)
        {
            post.ID = postVm.ID;
            post.Name = postVm.Name;
            post.Description = postVm.Description;
            post.Alias = postVm.Alias;
            post.CategoryeID = postVm.CategoryeID;
            post.Content = postVm.Content;
            post.Image = postVm.Image;
            post.HomeFlag = postVm.HomeFlag;
            post.ViewCount = postVm.ViewCount;

            post.CreateDate = postVm.CreatedDate;
            post.CreateBy = postVm.CreatedBy;
            post.UpdateDate = postVm.UpdatedDate;
            post.UpdateBy = postVm.UpdatedBy;
            post.MetaKeyword = postVm.MetaKeyword;
            post.MetaDescription = postVm.MetaDescription;
            post.Status = postVm.Status;
        }
    }
}
using System;
using System.Collections.Generic;
using OnlineShop.Data.Infrastructure;
using OnlineShop.Data.Repositories;
using OnlineShop.Mode.Models;

namespace OnlineShop.Service
{
    public interface IPostCategoryService
    {
        PostCategorie Add(PostCategorie postCategory);

        void Update(PostCategorie postCategory);

        PostCategorie Delete(int id);

        IEnumerable<PostCategorie> GetAll();

        IEnumerable<PostCategorie> GetAllByParentId(int parentId);

        PostCategorie GetById(int id);

        void Save();
    }

    public class PostCategoryService : IPostCategoryService
    {
        private IPostCategoryRepository _postCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public PostCategoryService(IPostCategoryRepository postCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._postCategoryRepository = postCategoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public PostCategorie Add(PostCategorie postCategory)
        {
            return _postCategoryRepository.Add(postCategory);
        }

        public PostCategorie Delete(int id)
        {
            return _postCategoryRepository.Delete(id);
        }

        public IEnumerable<PostCategorie> GetAll()
        {
            return _postCategoryRepository.GetAll();
        }

        public IEnumerable<PostCategorie> GetAllByParentId(int parentId)
        {
            return _postCategoryRepository.GetMulti(x => x.Status && x.PrentID == parentId);
        }

        public PostCategorie GetById(int id)
        {
            return _postCategoryRepository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(PostCategorie postCategory)
        {
            _postCategoryRepository.Update(postCategory);
        }
    }
}

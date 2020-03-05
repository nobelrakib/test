﻿using System;
using System.Collections.Generic;
using System.Text;
using Ecommerce.Data;
using Ecommerce.Core.UnitOfWork;
using Ecommerce.Core.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Ecommerce.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private IStoreUnitOfWork _storeUnitOfWork;
        //public Order o = new Order(); 
        public CategoryService(IStoreUnitOfWork storeUnitOfWork)
        { 
            _storeUnitOfWork = storeUnitOfWork;
        }
        public void AddNewCategory(Category category)
        {
            if (category == null || string.IsNullOrWhiteSpace(category.Name))
                throw new InvalidOperationException("Category name is missing");

            _storeUnitOfWork.CategoryRepository.Add(category);
            _storeUnitOfWork.Save();
        }
        public IEnumerable<Category> GetCategories(
           int pageIndex,
           int pageSize,
           string searchText,
            int total,
            int totalFiltered)
        {

                return _storeUnitOfWork.CategoryRepository.Get(
                    out total,
                    out totalFiltered,
                    x => x.Name.Contains(searchText),
                    null,
                    "",
                    pageIndex,
                    pageSize,
                    true);   
        }
        public void DeleteCategory(int id)
        {
            _storeUnitOfWork.CategoryRepository.Remove(id);
            _storeUnitOfWork.Save();
        }

        public void EditCategory(Category category)
        {
            var oldCategory = _storeUnitOfWork.CategoryRepository.GetById(category.Id);
            oldCategory.Name = category.Name;
            _storeUnitOfWork.Save();
        }
        public Category GetCategory(int id)
        {
            return _storeUnitOfWork.CategoryRepository.GetById(id);
        }
        public List<Category> GetList() => _storeUnitOfWork.CategoryRepository.GetCategoryList();


    }
}
﻿using System;
using System.Collections.Generic;
using System.Text;
using FoodOrdering.Core.Entities;
using FoodOrdering.Core.UnitofWork;
namespace FoodOrdering.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private IFoodStoreUnitofWork _storeUnitOfWork;
        public CategoryService(IFoodStoreUnitofWork storeUnitOfWork)
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
            out int total,
            out int totalFiltered)
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
        public Category GetCategoryByName(string name)
        {
            return _storeUnitOfWork.CategoryRepository.SearchByCategoryName(name);
        }
    }
}

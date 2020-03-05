﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Core.Services;
using Ecommerce.Core.Entities;
using Autofac;
namespace Ecommerce.Web.Areas.Admin.Models
{
    public class CategoryUpdateModel : BaseModel
    {
       // private ICategoryService _categoryService;
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Category> CategoryList { get; set; }
        public IList<Product> ProductList { get; set; }

        private ICategoryService _categoryService;
        public string[] Ids { get; set; }

        public CategoryUpdateModel()
        {
            _categoryService = Startup.AutofacContainer.Resolve<ICategoryService>();
        }

        public CategoryUpdateModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public void AddNewCategory()
        {
            try
            {
                _categoryService.AddNewCategory(new Category
                {
                    Name = this.Name
                });

                Notification = new NotificationModel("Success!", "Category successfuly created", NotificationType.Success);
            }
            catch (InvalidOperationException iex)
            {
                Notification = new NotificationModel(
                    "Failed!",
                    "Failed to create category, please provide valid name",
                    NotificationType.Fail);
            }
            catch (Exception ex)
            {
                Notification = new NotificationModel(
                    "Failed!",
                    "Failed to create category, please try again",
                    NotificationType.Fail);
            }
        }

        public void EditCategory()
        {
            try
            {
                _categoryService.EditCategory(new Category
                {
                    Id = this.Id,
                    Name = this.Name
                });

                Notification = new NotificationModel("Success!", "Category successfuly updated", NotificationType.Success);
            }
            catch (InvalidOperationException iex)
            {
                Notification = new NotificationModel(
                    "Failed!",
                    "Failed to update category, please provide valid name",
                    NotificationType.Fail);
            }
            catch (Exception ex)
            {
                Notification = new NotificationModel(
                    "Failed!",
                    "Failed to update category, please try again",
                    NotificationType.Fail);
            }
        }

        public void Load(int id)
        {
            var category = _categoryService.GetCategory(id);
            if (category != null)
            {
                Id = category.Id;
                Name = category.Name;
            }
        }
        public void GetListOfCategory() =>CategoryList= _categoryService.GetList();
    }
}
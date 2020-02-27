﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using FoodOrdering.Core.Entities;
using FoodOrdering.Core.Services;
namespace FoodOrdering.Areas.Admin.Models
{
    public class CategoryUpdateModel : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<FoodItem> FoodList { get; set; }
        public string[] FoodItemIds { get; set; }

        private IFoodItemService _fooditemService;

        private ICategoryService _categoryService;

        public CategoryUpdateModel()
        {
            _categoryService = Startup.AutofacContainer.Resolve<ICategoryService>();
            _fooditemService = Startup.AutofacContainer.Resolve<IFoodItemService>();
        }

        public CategoryUpdateModel(ICategoryService categoryService, IFoodItemService fooditemService)
        {
            _categoryService = categoryService;
            _fooditemService = fooditemService;
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
        public void ListofFood() => FoodList = _fooditemService.GetFoodItemList();
    }
}

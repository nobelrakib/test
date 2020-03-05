﻿using System;
using System.Collections.Generic;
using System.Text;
using FoodOrdering.Data;
using FoodOrdering.Core.Entities;
namespace FoodOrdering.Core.Repositories
{
    public interface IPendingOrderRepository : IRepository<PendingOrder>
    {
        IList<PendingOrder> ListOfPendingOrder();
        IList<PendingOrder> ListOfPendingOrder(string userId);
    }
}
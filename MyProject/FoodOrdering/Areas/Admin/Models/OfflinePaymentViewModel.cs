﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodOrdering.Core.Entities;
using FoodOrdering.Core.Services;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using FoodOrdering.Models;
namespace FoodOrdering.Areas.Admin.Models
{
    public class OfflinePaymentViewModel
    {
        private IPaymentService _paymentService;
        public OfflinePaymentViewModel()
        {
            _paymentService = Startup.AutofacContainer.Resolve<IPaymentService>();
        }

        public OfflinePaymentViewModel(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public object GetPayments(DataTablesAjaxRequestModel tableModel)
        {
            int total = 0;
            int totalFiltered = 0;
            var records = _paymentService.GetOfflinePayments(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                out total,
                out totalFiltered);

            return new
            {
                recordsTotal = total,
                recordsFiltered = totalFiltered,
                data = (from record in records
                        select new string[]
                        {
                                record.Id.ToString(),
                                record.OrderId.ToString(),
                                //record.CardNumber
                        }
                    ).ToArray()

            };
        }
    }
}

﻿using BookStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repository.IRepository
{
    public interface IProductImageRepository : IRepository<ProductImage>
    {
        void Update(ProductImage obj);
    }
}

﻿using BlogWebAppCore2.Data.Abstract;
using BlogWebAppCore2.Entites.Concrete;
using BlogWebAppCore2.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebAppCore2.Data.Concrete.EntityFramework.Repositories
{
    public class CategoryRepository : EfEntityRepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context)
        {
        }
    }
}

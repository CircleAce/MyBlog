﻿using Acme.BookStore.Domain.Blog;
using Acme.BookStore.Domain.Blog.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Acme.BookStore.EntityFrameworkCore.Repositories.Blog
{
   public class PostRepository : EfCoreRepository<AcmeBlogDbContext, Post, int>, IPostRepository
    {
        public PostRepository(IDbContextProvider<AcmeBlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}

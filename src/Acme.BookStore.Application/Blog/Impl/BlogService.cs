﻿using Acme.Application.Caching.Blog;

using Acme.BookStore.Domain.Blog.Repositories;


namespace Acme.BookStore.Application.Blog.Impl
{
    public partial class BlogService : MeowvBlogApplicationServiceBase, IBlogService
    {
        private readonly IBlogCacheService _blogCacheService;
        private readonly IPostRepository _postRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ITagRepository _tagRepository;
        private readonly IPostTagRepository _postTagRepository;
        private readonly IFriendLinkRepository _friendLinksRepository;

        public BlogService(IBlogCacheService blogCacheService,
                           IPostRepository postRepository,
                           ICategoryRepository categoryRepository,
                           ITagRepository tagRepository,
                           IPostTagRepository postTagRepository,
                           IFriendLinkRepository friendLinksRepository)
        {
            _blogCacheService = blogCacheService;
            _postRepository = postRepository;
            _categoryRepository = categoryRepository;
            _tagRepository = tagRepository;
            _postTagRepository = postTagRepository;
            _friendLinksRepository = friendLinksRepository;
        }
    }
}

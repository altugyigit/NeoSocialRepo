﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using NeoSocial.Database.Models;

namespace NeoSocial.Database.Repository
{
    public interface IArticlePost : IRepository<ArticlePost>
    { }

    public class TurkeyCityRepository : Repository<ArticlePost>, IArticlePost
    {
        public TurkeyCityRepository(DbContext dbContext)
            : base(dbContext)
        { }
    }
}

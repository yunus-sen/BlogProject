﻿using BlogProject.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Entities.Concrete
{
    public class Comment : EntityBase, IEntity
    {
        public string Text { get; set; }
        public string Note { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
    }
}

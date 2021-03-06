﻿using Forum.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Data
{
    public class ForumData
    {
        public ForumData()
        {
            this.Users = DataMapper.LoadUsers();
            this.Categories = DataMapper.LoadCategories();
            this.Posts = DataMapper.LoadPost();
            this.Replies = DataMapper.LoadReply();
        }

        public List<Category> Categories { get; set; }
        public List<User> Users { get; set; }
        public List<Post> Posts { get; set; }
        public List<Reply> Replies { get; set; }

        public void SaveChanges()
        {
            DataMapper.SaveUsers(this.Users);
            DataMapper.SaveCategories(this.Categories);
            DataMapper.SavePost(this.Posts);
            DataMapper.SaveReply(this.Replies);
        }
    }
}

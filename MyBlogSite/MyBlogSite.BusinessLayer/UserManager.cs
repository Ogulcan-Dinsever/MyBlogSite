﻿using MyBlogSite.DataAccessLayer;
using MyBlogSite.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogSite.BusinessLayer
{
    public class UserManager
    {
        Repository<User> userRepository = new Repository<User>();

        public User GetUserById(int id)
        {
            return userRepository.GetById(id);
        }
    }
}

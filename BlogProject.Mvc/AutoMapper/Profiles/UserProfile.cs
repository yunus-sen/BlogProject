using AutoMapper;
using BlogProject.Entities.Concrete;
using BlogProject.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Mvc.AutoMapper.Profiles
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<UserAddDto, User>();
        }
    }
}

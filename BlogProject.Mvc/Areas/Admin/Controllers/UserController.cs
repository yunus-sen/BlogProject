﻿    using BlogProject.Entities.Concrete;
using BlogProject.Entities.Dtos;
using BlogProject.Shared.Utilities.Extentions;
using BlogProject.Shared.Utilities.Results.ComplexTypes;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IWebHostEnvironment _env;


        public UserController(UserManager<User> userManager, IWebHostEnvironment env)
        {
            _userManager = userManager;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            return View(new UserListDto
            {
                Users = users,
                ResultStatus = ResultStatus.Success
            });
        }

        [HttpGet]
        public IActionResult Add()
        {

            return PartialView("_UserAddPartial");
        }

        public async Task<string> ImageUpload(UserAddDto userAddDto)
        {
            string wwwRoot = _env.WebRootPath;
            string fileExtention = Path.GetExtension(userAddDto.Picture.FileName);
            DateTime dateTime = DateTime.Now;
            string fileName = $"{userAddDto.UserName}_{dateTime.FullDateAndTimeStringWithUnderscore()}{fileExtention}";
            var path = Path.Combine($"{wwwRoot}/img", fileName);
            await using(var stream =new FileStream(path, FileMode.Create))
            {
                await userAddDto.Picture.CopyToAsync(stream);
            }
            return fileName;
        }
    }
}

﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;

namespace Northwind.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController :ApiBaseController<IUserService, User, DtoUser>
    {
        private readonly IUserService userService;
        public UserController(IUserService userService) : base(userService)
        {
            this.userService = userService;
        }
    
    }
}

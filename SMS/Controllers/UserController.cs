using Microsoft.AspNetCore.Mvc;

using SMS.Controllers.Base;
using SMS.Models.ViewModels;
using SMS.Service.Services.Contracts;

namespace SMS.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserService _userService;
        public UserController(IUserService service)
        {
            _userService = service;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_userService.GetAllUsers());
        }

        [HttpPost]
        public IActionResult AddUser(UserModel userModels)
        {
            return Ok(_userService.AddUser(userModels));
        }


    }
}

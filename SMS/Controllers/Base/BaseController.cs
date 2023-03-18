using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SMS.Models.ViewModels;
using System.Security.Claims;

namespace SMS.Controllers.Base
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        public BaseController()
        {
        }

        internal UserModel GetUser()
        {
            ClaimsPrincipal user = User;
            var resp = (UserModel)JsonConvert.DeserializeObject(user.FindFirstValue(ClaimTypes.UserData), typeof(UserModel));
            return resp;
        }

    }
}

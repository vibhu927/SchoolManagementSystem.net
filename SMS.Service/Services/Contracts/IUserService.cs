using SMS.DataAccess.Repositories.Contracts;
using SMS.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Service.Services.Contracts
{
    public interface IUserService 
    {
        ServiceResult GetAllUsers();
        ServiceResult AddUser(UserModel users);
        ServiceResult GetUserById(int id);
        
    }
}

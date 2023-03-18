using SMS.DataAccess.Repositories.Contracts;
using SMS.Models.DataModels;
using SMS.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DataAccess.Repositories
{
    public class UserRepository : GenericRepository<User> , IUserRepository
    {
        private readonly SMSContext _context;
        public UserRepository(SMSContext context) : base(context)
        {
            _context = context;
        }
        public List<UserModel> GetUsers()
        {
            return (from user in _context.Users
                    select new UserModel
                    {
                        id = user.id,
                        userName = user.userName,
                        userType = user.userType
                    }).OrderBy(x => x.id).ToList();

        }
    }
}

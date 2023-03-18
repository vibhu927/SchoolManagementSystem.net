using AutoMapper;
using Microsoft.Extensions.Logging;
using SMS.DataAccess.Repositories.Contracts;
using SMS.Models.ViewModels;
using SMS.Service.Services.Contracts;
using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using SMS.Common.Utilities;
using SMS.Models.DataModels;

namespace SMS.Service.Services
{
    public class UserService : IUserService
    {
        public IUserRepository _userRepo;
        private ServiceResult _serviceResult;
       // private readonly IEncryptionManager _encryptionManager;
        private readonly IMapper _mapper;
        private readonly Guid _guid;
        ILogger<UserService> _logger;
        public UserService(IUserRepository repo, /* IEncryptionManager encryptionManager, */IMapper mapper, ILogger<UserService> logger)
        {
            _userRepo = repo;
            _serviceResult = new ServiceResult { Status = true, Message = Global.Success, StatusCode = Convert.ToInt32(HttpStatusCode.OK) };
           // _encryptionManager = encryptionManager;
            _mapper = mapper;
            _logger = logger;
            _guid = Guid.NewGuid();
        }
        public ServiceResult GetAllUsers()
        {
            _serviceResult.ResultData = _userRepo.GetUsers();
            return _serviceResult;
        }

        public ServiceResult GetUserById (int id)
        {
            var param = new DynamicParameters { RemoveUnused = true };
            param.Add("@id", id);
            var query = _userRepo.GetQueryList<UserModel>("GetUserById", param, CommandType.StoredProcedure).ToList();
            _serviceResult.ResultData = query;
            return _serviceResult;
        }

        public ServiceResult AddUser(UserModel users)
        {
           
            var user = _mapper.Map<User>(users);
            user.createdDate = DateTime.UtcNow;
            _userRepo.Add(user);
            _userRepo.Commit();
            users.id = user.id;

            _serviceResult.Message = Global.Success;
            _serviceResult.ResultData = users.id;

            _serviceResult.Status = true;
            _serviceResult.ResultData = Convert.ToInt32(HttpStatusCode.OK);
            return _serviceResult;
        }
    }
}

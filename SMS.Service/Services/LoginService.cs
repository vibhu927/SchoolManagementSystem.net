using AutoMapper;
using Microsoft.Extensions.Options;
using SMS.Common.Utilities;
using SMS.DataAccess.Repositories.Contracts;
using SMS.Models.DataModels;
using SMS.Models.ViewModels;
using SMS.Service.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Service.Services
{
    public class LoginService : ILoginService
    {
        private readonly ServiceResult _serviceResult;
        private readonly AppSettings _appSettings;
        private IUserRepository _userRepository;
        private readonly IMapper _mapper;


        public LoginService(IOptions<AppSettings> appSettings,
            IUserRepository userRepository,
            IMapper mapper
        )
        {
            _appSettings = appSettings.Value;
            _userRepository = userRepository;
            _mapper = mapper;
        }

           public ServiceResult Login(LoginModel model)
        {
            return _serviceResult;
        }
        //    {
        //        try
        //        {
        //            // UserModel

        //            var user = GetUser(model.username);
        //            if (user != null)
        //            {
        //                if (!_encryptionManager.VerifyHashedPassword(user.password, model.password))
        //                {
        //                    throw new InternalValidationException(Global.IncorrectPassword);
        //                }

        //            }
        //            else
        //                return null;
        //            user.refreshToken = Guid.NewGuid().ToString();
        //            _userRepository.Update(user);
        //            _userRepository.Commit();
        //            var userResponse = _mapper.Map<UserModel>(user);


        //            userResponse.token = GenerateToken(userResponse);
        //            userResponse.refreshToken = user.refreshToken;
        //            userResponse.expireIn = _appSettings.ExpiryTime;
        //            userResponse.password = string.Empty; // no need send pwd to user end

        //            return new ServiceResult
        //            {
        //                Message = Global.Success,
        //                ResultData = userResponse,
        //                Status = true,
        //                StatusCode = Convert.ToInt32(HttpStatusCode.OK)
        //            };
        //        }
        //        catch (Exception ex)
        //        {
        //            return new ServiceResult
        //            {
        //                Message = Global.Failed,
        //                ResultData = ex.Message,
        //                Status = true,
        //                StatusCode = Convert.ToInt32(HttpStatusCode.OK)
        //            };
        //        }

        //    }
        //    private User GetUser(string username)
        //    {
        //        username = username.ToLower();
        //        return _userRepository.FindBy(x => x.username.ToLower() == username).FirstOrDefault(); //username should be unique
        //    }
        
    }
}

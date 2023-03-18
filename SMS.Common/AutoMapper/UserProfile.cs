using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SMS.Models.DataModels;
using SMS.Models.ViewModels;

namespace SMS.Common.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {

            CreateMap<UserModel, User>().ReverseMap();

        }
    }
}
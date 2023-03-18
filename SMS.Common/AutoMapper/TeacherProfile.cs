using AutoMapper;
using SMS.Models.DataModels;
using SMS.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Common.AutoMapper
{
    public class TeacherProfile : Profile
    {
        public TeacherProfile ()
        {

            CreateMap<TeacherModel, Teacher>().ReverseMap();

        }
    }
}

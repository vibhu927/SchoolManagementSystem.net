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
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {

            CreateMap<StudentModel, Student>().ReverseMap();

        }
    }
}

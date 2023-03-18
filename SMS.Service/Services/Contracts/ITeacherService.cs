using SMS.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Service.Services.Contracts
{
    public interface ITeacherService
    {
        ServiceResult GetAllTeachers();
        ServiceResult GetTeacherById(int id);
    }
}

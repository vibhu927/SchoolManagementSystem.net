using SMS.Models.DataModels;
using SMS.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DataAccess.Repositories.Contracts
{
    public interface ITeacherRepository : IGenericRepository<Teacher>
    {
        List<TeacherModel> GetTeachers();
    }
}

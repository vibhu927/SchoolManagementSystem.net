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
    public class TeacherReporsitory : GenericRepository<Teacher>, ITeacherRepository
    {
        private readonly SMSContext _context;
        public TeacherReporsitory(SMSContext context) : base(context)
        {
            _context = context;
        }
        public List<TeacherModel> GetTeachers()
        {
            return (from teacher in _context.Teachers
                    select new TeacherModel
                    {
                        id = teacher.id,
                        dob = teacher.dob,
                        firstName = teacher.firstName,
                        lastName = teacher.lastName,
                    }).OrderBy(x => x.id).ToList();

        }
    }
}

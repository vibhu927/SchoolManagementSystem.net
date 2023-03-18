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
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        private readonly SMSContext _context;
        public StudentRepository(SMSContext context) : base(context)
        {
            _context = context;
        }
        public List<StudentModel> GetStudents()
        {
            return (from student in _context.Students
                    select new StudentModel
                    {
                        id = student.id,
                        dob = student.dob,
                        firstName = student.firstName,
                        lastName = student.lastName,
                    }).OrderBy(x => x.id).ToList();

        }
    }
}

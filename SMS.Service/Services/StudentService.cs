using AutoMapper;
using Dapper;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;
using SMS.Common.Utilities;
using SMS.DataAccess.Repositories.Contracts;
using SMS.Models.ViewModels;
using SMS.Service.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Service.Services
{
    public class StudentService : IStudentService
    {
        public IStudentRepository _studentRepo;
        private ServiceResult _serviceResult;
        private readonly IMapper _mapper;
        private readonly Guid _guid;
        ILogger<StudentService> _logger;
        public StudentService(IStudentRepository repo, IMapper mapper, ILogger<StudentService> logger)
        {
            _studentRepo = repo;
            _serviceResult = new ServiceResult { Status = true, Message = Global.Success, StatusCode = Convert.ToInt32(HttpStatusCode.OK) };
            _mapper = mapper;
            _logger = logger;
            _guid = Guid.NewGuid();
        }

        public ServiceResult GetAllStudents()
        {
            _serviceResult.ResultData = _studentRepo.GetStudents();
            return _serviceResult;
        }

        public ServiceResult GetStudentById(int id)
        {
            var param = new DynamicParameters { RemoveUnused = true };
            param.Add("@i", id);
            var query = _studentRepo.GetQueryList<StudentModel>("getRoleByRoleId", param, CommandType.StoredProcedure).ToList();
            _serviceResult.ResultData = query;
            return _serviceResult;
        }
    }

}

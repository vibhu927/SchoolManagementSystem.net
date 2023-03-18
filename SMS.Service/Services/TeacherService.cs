using AutoMapper;
using Dapper;
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
    public class TeacherService : ITeacherService
    {
        public ITeacherRepository _teacherRepo;
        private ServiceResult _serviceResult;
        private readonly IMapper _mapper;
        private readonly Guid _guid;
        ILogger<TeacherService> _logger;
        public TeacherService(ITeacherRepository repo, IMapper mapper, ILogger<TeacherService> logger)
        {
            _teacherRepo = repo;
            _serviceResult = new ServiceResult { Status = true, Message = Global.Success, StatusCode = Convert.ToInt32(HttpStatusCode.OK) };
            _mapper = mapper;
            _logger = logger;
            _guid = Guid.NewGuid();
        }

        public ServiceResult GetAllTeachers()
        {
            _serviceResult.ResultData = _teacherRepo.GetTeachers();
            return _serviceResult;
        }

        public ServiceResult GetTeacherById(int id)
        {
            var param = new DynamicParameters { RemoveUnused = true };
            param.Add("@i", id);
            var query = _teacherRepo.GetQueryList<TeacherModel>("getRoleByRoleId", param, CommandType.StoredProcedure).ToList();
            _serviceResult.ResultData = query;
            return _serviceResult;
        }
    }
}
